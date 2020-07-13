using EnvDTE;
using Syncfusion.Windows.Forms.Tools;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlServerCe;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace TreeNavigator_DataBinding
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            dataBaseView = GetOrderDetials();
        }

        //Initialize the DataView
        private DataView dataBaseView;

        private void FillItems(TreeNavigator tree)
        {
            foreach (DataColumn col in dataBaseView.Table.Columns)
                this.treeNavigator1.Items.Add(new TreeMenuItem() { Text = col.ColumnName });
            //Add the DataView rows to TreeMenuItem
            foreach (DataRow x in dataBaseView.Table.Rows)
            {
                foreach (TreeMenuItem y in this.treeNavigator1.Items)
                {
                    if (dataBaseView.Table.Columns.Contains(y.Text))
                        y.Items.Add(new TreeMenuItem() { Text = x[dataBaseView.Table.Columns[y.Text]].ToString() });
                }
            }
        }

        private static DataView GetOrderDetials()
        {
            try
            {
                //Initialize the DataSet
                DataSet ds = new DataSet();
                using (SqlCeConnection con = new SqlCeConnection(@"DataSource=Data\Northwind.sdf"))
                {
                    con.Open();
                    SqlCeCommand cmd = new SqlCeCommand("SELECT Top(20) [Order ID], [Product ID], [ColumnName], [Unit Price], Quantity \r\nFROM [Order Details] ", con);
                    SqlCeDataAdapter da = new SqlCeDataAdapter(cmd);


                    da.Fill(ds);

                    // Creation of DataView
                    DataView dataView = new DataView(ds.Tables[0], "[Unit Price] >= 20", "[Order ID]", DataViewRowState.CurrentRows);
                    return dataView;
                }
            }

            catch (Exception e)
            {
                MessageBox.Show("Exception in connection: " +  e.Message);
                return null;
            }
        }


        private void button1_Click(object sender, EventArgs e)
        {
            this.treeNavigator1.Visible = true;
            FillItems(this.treeNavigator1);
        }
    }
}
