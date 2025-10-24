# How to populate TreeNavigator from a database (WinForms)
## Overview 
This example shows how to populate the Syncfusion TreeNavigator control in a Windows Forms application using data retrieved from a database. The TreeNavigator displays hierarchical data with root items for each column and child items for row values.

## 1. Initialize the Form and DataView
```csharp
private DataView dataBaseView;

public Form1()
{
    InitializeComponent();
    dataBaseView = GetOrderDetails();
}
```
The constructor initializes the form and retrieves data from the database using the `GetOrderDetials()` method, storing it in a `DataView`.

## 2. Populate TreeNavigator Items
```csharp
private void FillItems(TreeNavigator tree)
{
    foreach (DataColumn col in dataBaseView.Table.Columns)
        this.treeNavigator1.Items.Add(new TreeMenuItem() { Text = col.ColumnName });

    // Add DataView rows to TreeMenuItem
    foreach (DataRow x in dataBaseView.Table.Rows)
    {
        foreach (TreeMenuItem y in this.treeNavigator1.Items)
        {
            if (dataBaseView.Table.Columns.Contains(y.Text))
                y.Items.Add(new TreeMenuItem() { Text = x[dataBaseView.Table.Columns[y.Text]].ToString() });
        }
    }
}
```
- All **column names** from the DataView are added as root items in the TreeNavigator.
- For each row in the DataView, corresponding values are added as child items under their respective column names.

## 3. Retrieve Data from Database
```csharp
private static DataView GetOrderDetails()
{
    try
    {
        DataSet ds = new DataSet();
        using (SqlCeConnection con = new SqlCeConnection(@"DataSource=Data\Northwind.sdf"))
        {
            con.Open();
            SqlCeCommand cmd = new SqlCeCommand("SELECT Top(20) [Order ID], [Product ID], [ColumnName], [Unit Price], Quantity FROM [Order Details]", con);
            SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);
            da.Fill(ds);

            // Create DataView with filter and sort
            DataView dataView = new DataView(ds.Tables[0], "[Unit Price] >= 20", "[Order ID]", DataViewRowState.CurrentRows);
            return dataView;
        }
    }
    catch (Exception e)
    {
        MessageBox.Show("Exception in connection: " + e.Message);
        return null;
    }
}
```
- Connects to a **SQL Server Compact Edition** database.
- Retrieves the top 20 rows from the `Order Details` table.
- Creates a **DataView** with a filter (`Unit Price >= 20`) and sorts by `Order ID`.

## 4. Trigger Population on Button Click
```csharp
private void button1_Click(object sender, EventArgs e)
{
    this.treeNavigator1.Visible = true;
    FillItems(this.treeNavigator1);
}
```
When the button is clicked, the TreeNavigator becomes visible and is populated with data.

## Summary
This approach is useful for applications like **order management systems**, **product catalogs**, or any scenario requiring dynamic hierarchical navigation based on database content.
