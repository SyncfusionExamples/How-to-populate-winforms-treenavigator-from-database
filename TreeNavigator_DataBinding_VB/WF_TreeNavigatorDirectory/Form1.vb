Imports Microsoft.VisualBasic
Imports System
Imports System.Data
Imports System.Linq
Imports System.Windows.Forms
Imports Syncfusion.Windows.Forms.Tools
Imports System.Data.SqlServerCe

Namespace WF_TreeNavigatorDirectory
	Partial Public Class Form1
		Inherits Form
		Public Sub New()
			InitializeComponent()
			dataBaseView = GetOrderDetials()
		End Sub

		Private dataBaseView As DataView

		Private Sub button1_Click(ByVal sender As Object, ByVal e As EventArgs) Handles button1.Click
			Me.treeNavigator1.Visible = True
			FillItems(Me.treeNavigator1)
		End Sub
		Private Sub FillItems(ByVal tree As TreeNavigator)
		  For Each col As DataColumn In dataBaseView.Table.Columns
				Me.treeNavigator1.Items.Add(New TreeMenuItem() With {.Text = col.ColumnName})
		  Next col
			For Each x As DataRow In dataBaseView.Table.Rows
				For Each y As TreeMenuItem In Me.treeNavigator1.Items
					If dataBaseView.Table.Columns.Contains(y.Text) Then
						y.Items.Add(New TreeMenuItem() With {.Text = x(dataBaseView.Table.Columns(y.Text)).ToString()})
					End If

				Next y
			Next x
		End Sub

		Private Shared Function GetOrderDetials() As DataView
			Try
				Dim ds As New DataSet()
				Using con As New SqlCeConnection("DataSource=Data\Northwind.sdf")
					con.Open()
					Dim cmd As New SqlCeCommand("SELECT Top(20) [Order ID], [Product ID], [ColumnName], [Unit Price], Quantity" & ControlChars.CrLf & "                                                          FROM [Order Details] ", con)
					Dim da As New SqlCeDataAdapter(cmd)


					da.Fill(ds)

					'Creation of DataView
					Dim dataView As New DataView(ds.Tables(0), "[Unit Price] >= 20", "[Order ID]", DataViewRowState.CurrentRows)
					Return dataView
				End Using


			Catch e As Exception
				MessageBox.Show("Exception in connection: " & Constants.vbTab + e.Message)
				Return Nothing
			End Try
		End Function
	End Class
End Namespace
