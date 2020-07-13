Imports Microsoft.VisualBasic
Imports System
Namespace WF_TreeNavigatorDirectory
	Partial Public Class Form1
		''' <summary>
		''' Required designer variable.
		''' </summary>
		Private components As System.ComponentModel.IContainer = Nothing

		''' <summary>
		''' Clean up any resources being used.
		''' </summary>
		''' <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
		Protected Overrides Sub Dispose(ByVal disposing As Boolean)
			If disposing AndAlso (components IsNot Nothing) Then
				components.Dispose()
			End If
			MyBase.Dispose(disposing)
		End Sub

		#Region "Windows Form Designer generated code"

		''' <summary>
		''' Required method for Designer support - do not modify
		''' the contents of this method with the code editor.
		''' </summary>
		Private Sub InitializeComponent()
			Dim headerCollection2 As New Syncfusion.Windows.Forms.Tools.TreeNavigator.HeaderCollection()
			Me.treeNavigator1 = New Syncfusion.Windows.Forms.Tools.TreeNavigator()
			Me.button1 = New System.Windows.Forms.Button()
			Me.SuspendLayout()
			' 
			' treeNavigator1
			' 
			Me.treeNavigator1.BackColor = System.Drawing.Color.White
			headerCollection2.Font = New System.Drawing.Font("Arial", 8F)
			Me.treeNavigator1.Header = headerCollection2
			Me.treeNavigator1.ItemBackColor = System.Drawing.SystemColors.Control
			Me.treeNavigator1.Location = New System.Drawing.Point(47, 35)
			Me.treeNavigator1.MinimumSize = New System.Drawing.Size(150, 150)
			Me.treeNavigator1.Name = "treeNavigator1"
			Me.treeNavigator1.ShowHeader = False
			Me.treeNavigator1.Size = New System.Drawing.Size(449, 377)
			Me.treeNavigator1.TabIndex = 0
			Me.treeNavigator1.Text = "treeNavigator1"
			' 
			' button1
			' 
			Me.button1.Location = New System.Drawing.Point(557, 200)
			Me.button1.Name = "button1"
			Me.button1.Size = New System.Drawing.Size(171, 40)
			Me.button1.TabIndex = 1
			Me.button1.Text = "Click to load"
			Me.button1.UseVisualStyleBackColor = True
'			Me.button1.Click += New System.EventHandler(Me.button1_Click)
			' 
			' Form1
			' 
			Me.AutoScaleDimensions = New System.Drawing.SizeF(8F, 16F)
			Me.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font
			Me.ClientSize = New System.Drawing.Size(871, 502)
			Me.Controls.Add(Me.button1)
			Me.Controls.Add(Me.treeNavigator1)
			Me.Name = "Form1"
			Me.Text = "Form1"
			Me.ResumeLayout(False)

		End Sub

		#End Region

		Private treeNavigator1 As Syncfusion.Windows.Forms.Tools.TreeNavigator
		Private WithEvents button1 As System.Windows.Forms.Button
	End Class
End Namespace

