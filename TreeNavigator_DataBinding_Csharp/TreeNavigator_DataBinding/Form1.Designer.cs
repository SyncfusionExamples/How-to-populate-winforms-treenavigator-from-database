namespace TreeNavigator_DataBinding
{
    partial class Form1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            Syncfusion.Windows.Forms.Tools.TreeNavigator.HeaderCollection headerCollection1 = new Syncfusion.Windows.Forms.Tools.TreeNavigator.HeaderCollection();
            this.treeNavigator1 = new Syncfusion.Windows.Forms.Tools.TreeNavigator();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeNavigator1
            // 
            this.treeNavigator1.Dock = System.Windows.Forms.DockStyle.Left;
            headerCollection1.Font = new System.Drawing.Font("Arial", 8F);
            headerCollection1.HeaderText = "TreeNavigator";
            this.treeNavigator1.Header = headerCollection1;
            this.treeNavigator1.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeNavigator1.Location = new System.Drawing.Point(0, 0);
            this.treeNavigator1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.treeNavigator1.MinimumSize = new System.Drawing.Size(100, 97);
            this.treeNavigator1.Name = "treeNavigator1";
            this.treeNavigator1.Size = new System.Drawing.Size(209, 306);
            this.treeNavigator1.TabIndex = 0;
            this.treeNavigator1.Text = "treeNavigator1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(315, 130);
            this.button1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(160, 30);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load TreeNavigator";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(566, 306);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeNavigator1);
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TreeNavigator_DataBinding";
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TreeNavigator treeNavigator1;
        private System.Windows.Forms.Button button1;
    }
}

