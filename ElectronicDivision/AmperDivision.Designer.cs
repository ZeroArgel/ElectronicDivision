namespace ElectronicDivision
{
    partial class AmperDivision
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
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbl_It1 = new System.Windows.Forms.Label();
            this.Lbl_R2Ohm = new System.Windows.Forms.Label();
            this.Lbl_R1Ohm = new System.Windows.Forms.Label();
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.Txt_It = new System.Windows.Forms.TextBox();
            this.Lbl_It = new System.Windows.Forms.Label();
            this.Txt_R1 = new System.Windows.Forms.TextBox();
            this.Lbl_R1 = new System.Windows.Forms.Label();
            this.Txt_R2 = new System.Windows.Forms.TextBox();
            this.Lbl_R2 = new System.Windows.Forms.Label();
            this.Lbl_Process = new System.Windows.Forms.Label();
            this.Txt_Process = new System.Windows.Forms.TextBox();
            this.Lbl_RR1 = new System.Windows.Forms.Label();
            this.Lbl_RR2 = new System.Windows.Forms.Label();
            this.Lbl_RIt = new System.Windows.Forms.Label();
            this.Lbl_RIt1 = new System.Windows.Forms.Label();
            this.Lbl_RIt2 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ElectronicDivision.Properties.Resources.Diagram__1_1;
            this.pictureBox2.Location = new System.Drawing.Point(578, 12);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(233, 211);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ElectronicDivision.Properties.Resources.Diagram1;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(233, 211);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbl_It1);
            this.groupBox1.Controls.Add(this.Lbl_R2Ohm);
            this.groupBox1.Controls.Add(this.Lbl_R1Ohm);
            this.groupBox1.Controls.Add(this.BtnClean);
            this.groupBox1.Controls.Add(this.BtnCalculate);
            this.groupBox1.Controls.Add(this.Txt_It);
            this.groupBox1.Controls.Add(this.Lbl_It);
            this.groupBox1.Controls.Add(this.Txt_R1);
            this.groupBox1.Controls.Add(this.Lbl_R1);
            this.groupBox1.Controls.Add(this.Txt_R2);
            this.groupBox1.Controls.Add(this.Lbl_R2);
            this.groupBox1.Location = new System.Drawing.Point(251, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 87);
            this.groupBox1.TabIndex = 4;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Get Vout";
            // 
            // Lbl_It1
            // 
            this.Lbl_It1.AutoSize = true;
            this.Lbl_It1.Location = new System.Drawing.Point(222, 23);
            this.Lbl_It1.Name = "Lbl_It1";
            this.Lbl_It1.Size = new System.Drawing.Size(14, 13);
            this.Lbl_It1.TabIndex = 0;
            this.Lbl_It1.Text = "A";
            // 
            // Lbl_R2Ohm
            // 
            this.Lbl_R2Ohm.AutoSize = true;
            this.Lbl_R2Ohm.Location = new System.Drawing.Point(108, 53);
            this.Lbl_R2Ohm.Name = "Lbl_R2Ohm";
            this.Lbl_R2Ohm.Size = new System.Drawing.Size(16, 13);
            this.Lbl_R2Ohm.TabIndex = 0;
            this.Lbl_R2Ohm.Text = "Ω";
            // 
            // Lbl_R1Ohm
            // 
            this.Lbl_R1Ohm.AutoSize = true;
            this.Lbl_R1Ohm.Location = new System.Drawing.Point(108, 22);
            this.Lbl_R1Ohm.Name = "Lbl_R1Ohm";
            this.Lbl_R1Ohm.Size = new System.Drawing.Size(16, 13);
            this.Lbl_R1Ohm.TabIndex = 0;
            this.Lbl_R1Ohm.Text = "Ω";
            // 
            // BtnClean
            // 
            this.BtnClean.Location = new System.Drawing.Point(240, 48);
            this.BtnClean.Name = "BtnClean";
            this.BtnClean.Size = new System.Drawing.Size(75, 23);
            this.BtnClean.TabIndex = 5;
            this.BtnClean.Text = "Clean";
            this.BtnClean.UseVisualStyleBackColor = true;
            this.BtnClean.Click += new System.EventHandler(this.BtnClean_Click);
            // 
            // BtnCalculate
            // 
            this.BtnCalculate.Location = new System.Drawing.Point(159, 48);
            this.BtnCalculate.Name = "BtnCalculate";
            this.BtnCalculate.Size = new System.Drawing.Size(75, 23);
            this.BtnCalculate.TabIndex = 4;
            this.BtnCalculate.Text = "Calculate";
            this.BtnCalculate.UseVisualStyleBackColor = true;
            this.BtnCalculate.Click += new System.EventHandler(this.BtnCalculate_Click);
            // 
            // Txt_It
            // 
            this.Txt_It.Location = new System.Drawing.Point(163, 19);
            this.Txt_It.Name = "Txt_It";
            this.Txt_It.Size = new System.Drawing.Size(53, 20);
            this.Txt_It.TabIndex = 3;
            // 
            // Lbl_It
            // 
            this.Lbl_It.AutoSize = true;
            this.Lbl_It.Location = new System.Drawing.Point(141, 22);
            this.Lbl_It.Name = "Lbl_It";
            this.Lbl_It.Size = new System.Drawing.Size(16, 13);
            this.Lbl_It.TabIndex = 0;
            this.Lbl_It.Text = "It:";
            // 
            // Txt_R1
            // 
            this.Txt_R1.Location = new System.Drawing.Point(45, 19);
            this.Txt_R1.Name = "Txt_R1";
            this.Txt_R1.Size = new System.Drawing.Size(57, 20);
            this.Txt_R1.TabIndex = 1;
            // 
            // Lbl_R1
            // 
            this.Lbl_R1.AutoSize = true;
            this.Lbl_R1.Location = new System.Drawing.Point(15, 22);
            this.Lbl_R1.Name = "Lbl_R1";
            this.Lbl_R1.Size = new System.Drawing.Size(24, 13);
            this.Lbl_R1.TabIndex = 0;
            this.Lbl_R1.Text = "R1:";
            // 
            // Txt_R2
            // 
            this.Txt_R2.Location = new System.Drawing.Point(45, 50);
            this.Txt_R2.Name = "Txt_R2";
            this.Txt_R2.Size = new System.Drawing.Size(57, 20);
            this.Txt_R2.TabIndex = 2;
            // 
            // Lbl_R2
            // 
            this.Lbl_R2.AutoSize = true;
            this.Lbl_R2.Location = new System.Drawing.Point(15, 53);
            this.Lbl_R2.Name = "Lbl_R2";
            this.Lbl_R2.Size = new System.Drawing.Size(24, 13);
            this.Lbl_R2.TabIndex = 0;
            this.Lbl_R2.Text = "R2:";
            // 
            // Lbl_Process
            // 
            this.Lbl_Process.AutoSize = true;
            this.Lbl_Process.Location = new System.Drawing.Point(251, 105);
            this.Lbl_Process.Name = "Lbl_Process";
            this.Lbl_Process.Size = new System.Drawing.Size(78, 13);
            this.Lbl_Process.TabIndex = 9;
            this.Lbl_Process.Text = "Show Process:";
            // 
            // Txt_Process
            // 
            this.Txt_Process.Location = new System.Drawing.Point(251, 121);
            this.Txt_Process.Multiline = true;
            this.Txt_Process.Name = "Txt_Process";
            this.Txt_Process.Size = new System.Drawing.Size(321, 102);
            this.Txt_Process.TabIndex = 10;
            // 
            // Lbl_RR1
            // 
            this.Lbl_RR1.AutoSize = true;
            this.Lbl_RR1.Location = new System.Drawing.Point(123, 86);
            this.Lbl_RR1.Name = "Lbl_RR1";
            this.Lbl_RR1.Size = new System.Drawing.Size(29, 13);
            this.Lbl_RR1.TabIndex = 0;
            this.Lbl_RR1.Text = "RR1";
            // 
            // Lbl_RR2
            // 
            this.Lbl_RR2.AutoSize = true;
            this.Lbl_RR2.Location = new System.Drawing.Point(186, 86);
            this.Lbl_RR2.Name = "Lbl_RR2";
            this.Lbl_RR2.Size = new System.Drawing.Size(29, 13);
            this.Lbl_RR2.TabIndex = 0;
            this.Lbl_RR2.Text = "RR2";
            // 
            // Lbl_RIt
            // 
            this.Lbl_RIt.AutoSize = true;
            this.Lbl_RIt.Location = new System.Drawing.Point(79, 22);
            this.Lbl_RIt.Name = "Lbl_RIt";
            this.Lbl_RIt.Size = new System.Drawing.Size(21, 13);
            this.Lbl_RIt.TabIndex = 0;
            this.Lbl_RIt.Text = "RIt";
            // 
            // Lbl_RIt1
            // 
            this.Lbl_RIt1.AutoSize = true;
            this.Lbl_RIt1.Location = new System.Drawing.Point(140, 187);
            this.Lbl_RIt1.Name = "Lbl_RIt1";
            this.Lbl_RIt1.Size = new System.Drawing.Size(27, 13);
            this.Lbl_RIt1.TabIndex = 0;
            this.Lbl_RIt1.Text = "RIt1";
            // 
            // Lbl_RIt2
            // 
            this.Lbl_RIt2.AutoSize = true;
            this.Lbl_RIt2.Location = new System.Drawing.Point(201, 204);
            this.Lbl_RIt2.Name = "Lbl_RIt2";
            this.Lbl_RIt2.Size = new System.Drawing.Size(27, 13);
            this.Lbl_RIt2.TabIndex = 0;
            this.Lbl_RIt2.Text = "RIt2";
            // 
            // AmperDivision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.ClientSize = new System.Drawing.Size(825, 238);
            this.Controls.Add(this.Lbl_RIt2);
            this.Controls.Add(this.Lbl_RIt1);
            this.Controls.Add(this.Lbl_RIt);
            this.Controls.Add(this.Lbl_RR2);
            this.Controls.Add(this.Lbl_RR1);
            this.Controls.Add(this.Lbl_Process);
            this.Controls.Add(this.Txt_Process);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.MaximumSize = new System.Drawing.Size(841, 277);
            this.MinimumSize = new System.Drawing.Size(841, 277);
            this.Name = "AmperDivision";
            this.Text = "AmperDivision";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.PictureBox pictureBox2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label Lbl_It1;
        private System.Windows.Forms.Label Lbl_R2Ohm;
        private System.Windows.Forms.Label Lbl_R1Ohm;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.TextBox Txt_It;
        private System.Windows.Forms.Label Lbl_It;
        private System.Windows.Forms.TextBox Txt_R1;
        private System.Windows.Forms.Label Lbl_R1;
        private System.Windows.Forms.TextBox Txt_R2;
        private System.Windows.Forms.Label Lbl_R2;
        private System.Windows.Forms.Label Lbl_Process;
        private System.Windows.Forms.TextBox Txt_Process;
        private System.Windows.Forms.Label Lbl_RR1;
        private System.Windows.Forms.Label Lbl_RR2;
        private System.Windows.Forms.Label Lbl_RIt;
        private System.Windows.Forms.Label Lbl_RIt1;
        private System.Windows.Forms.Label Lbl_RIt2;
    }
}