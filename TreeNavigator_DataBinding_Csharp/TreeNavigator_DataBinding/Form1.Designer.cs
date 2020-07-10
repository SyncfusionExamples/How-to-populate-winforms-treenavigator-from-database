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
            Syncfusion.Windows.Forms.Tools.TreeNavigator.HeaderCollection headerCollection2 = new Syncfusion.Windows.Forms.Tools.TreeNavigator.HeaderCollection();
            this.treeNavigator1 = new Syncfusion.Windows.Forms.Tools.TreeNavigator();
            this.button1 = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // treeNavigator1
            // 
            headerCollection2.Font = new System.Drawing.Font("Arial", 8F);
            headerCollection2.HeaderText = "TreeNavigator";
            this.treeNavigator1.Header = headerCollection2;
            this.treeNavigator1.ItemBackColor = System.Drawing.SystemColors.Control;
            this.treeNavigator1.Location = new System.Drawing.Point(67, 75);
            this.treeNavigator1.MinimumSize = new System.Drawing.Size(150, 150);
            this.treeNavigator1.Name = "treeNavigator1";
            this.treeNavigator1.Size = new System.Drawing.Size(313, 422);
            this.treeNavigator1.TabIndex = 0;
            this.treeNavigator1.Text = "treeNavigator1";
            // 
            // button1
            // 
            this.button1.Location = new System.Drawing.Point(551, 234);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(240, 46);
            this.button1.TabIndex = 1;
            this.button1.Text = "Load TreeNavigator";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(971, 599);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.treeNavigator1);
            this.Name = "Form1";
            this.Text = "TreeNavigator_DataBinding";
            this.ResumeLayout(false);

        }

        #endregion

        private Syncfusion.Windows.Forms.Tools.TreeNavigator treeNavigator1;
        private System.Windows.Forms.Button button1;
    }
}

