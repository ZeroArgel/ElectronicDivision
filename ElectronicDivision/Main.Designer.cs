namespace ElectronicDivision
{
    partial class Main
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
            this.menuStrip1 = new System.Windows.Forms.MenuStrip();
            this.voltDivisionToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.VoltDivision = new System.Windows.Forms.ToolStripMenuItem();
            this.AmperDivision = new System.Windows.Forms.ToolStripMenuItem();
            this.menuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // menuStrip1
            // 
            this.menuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.voltDivisionToolStripMenuItem});
            this.menuStrip1.Location = new System.Drawing.Point(0, 0);
            this.menuStrip1.Name = "menuStrip1";
            this.menuStrip1.Size = new System.Drawing.Size(328, 24);
            this.menuStrip1.TabIndex = 0;
            this.menuStrip1.Text = "menuStrip1";
            // 
            // voltDivisionToolStripMenuItem
            // 
            this.voltDivisionToolStripMenuItem.DropDownItems.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.VoltDivision,
            this.AmperDivision});
            this.voltDivisionToolStripMenuItem.Name = "voltDivisionToolStripMenuItem";
            this.voltDivisionToolStripMenuItem.Size = new System.Drawing.Size(71, 20);
            this.voltDivisionToolStripMenuItem.Text = "Electronic";
            // 
            // VoltDivision
            // 
            this.VoltDivision.Name = "VoltDivision";
            this.VoltDivision.Size = new System.Drawing.Size(152, 22);
            this.VoltDivision.Text = "VoltDivision";
            this.VoltDivision.Click += new System.EventHandler(this.VoltDivision_Click);
            // 
            // AmperDivision
            // 
            this.AmperDivision.Name = "AmperDivision";
            this.AmperDivision.Size = new System.Drawing.Size(152, 22);
            this.AmperDivision.Text = "AmperDivision";
            this.AmperDivision.Click += new System.EventHandler(this.AmperDivision_Click);
            // 
            // Main
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(328, 133);
            this.Controls.Add(this.menuStrip1);
            this.MainMenuStrip = this.menuStrip1;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(344, 172);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(344, 172);
            this.Name = "Main";
            this.Text = "Main";
            this.menuStrip1.ResumeLayout(false);
            this.menuStrip1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.MenuStrip menuStrip1;
        private System.Windows.Forms.ToolStripMenuItem voltDivisionToolStripMenuItem;
        private System.Windows.Forms.ToolStripMenuItem VoltDivision;
        private System.Windows.Forms.ToolStripMenuItem AmperDivision;
    }
}