namespace ElectronicDivision
{
    partial class VoltDivision
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(VoltDivision));
            this.pictureBox2 = new System.Windows.Forms.PictureBox();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Lbl_R2 = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.Lbl_Vin1 = new System.Windows.Forms.Label();
            this.Lbl_R2Ohm = new System.Windows.Forms.Label();
            this.Lbl_R1Ohm = new System.Windows.Forms.Label();
            this.BtnClean = new System.Windows.Forms.Button();
            this.BtnCalculate = new System.Windows.Forms.Button();
            this.Txt_Vin = new System.Windows.Forms.TextBox();
            this.Lbl_Vin = new System.Windows.Forms.Label();
            this.Txt_R1 = new System.Windows.Forms.TextBox();
            this.Lbl_R1 = new System.Windows.Forms.Label();
            this.Txt_R2 = new System.Windows.Forms.TextBox();
            this.Lbl_RR1 = new System.Windows.Forms.Label();
            this.Lbl_RR2 = new System.Windows.Forms.Label();
            this.Lbl_RVout = new System.Windows.Forms.Label();
            this.Lbl_RVin = new System.Windows.Forms.Label();
            this.Txt_Process = new System.Windows.Forms.TextBox();
            this.Lbl_Process = new System.Windows.Forms.Label();
            this.Lbl_Formula = new System.Windows.Forms.Label();
            this.Lbl_Diagram = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox2)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // pictureBox2
            // 
            this.pictureBox2.Image = global::ElectronicDivision.Properties.Resources.Diagram__1_;
            this.pictureBox2.Location = new System.Drawing.Point(560, 77);
            this.pictureBox2.Name = "pictureBox2";
            this.pictureBox2.Size = new System.Drawing.Size(192, 87);
            this.pictureBox2.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox2.TabIndex = 1;
            this.pictureBox2.TabStop = false;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::ElectronicDivision.Properties.Resources.Diagram;
            this.pictureBox1.Location = new System.Drawing.Point(12, 12);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(215, 216);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
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
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.Lbl_Vin1);
            this.groupBox1.Controls.Add(this.Lbl_R2Ohm);
            this.groupBox1.Controls.Add(this.Lbl_R1Ohm);
            this.groupBox1.Controls.Add(this.BtnClean);
            this.groupBox1.Controls.Add(this.BtnCalculate);
            this.groupBox1.Controls.Add(this.Txt_Vin);
            this.groupBox1.Controls.Add(this.Lbl_Vin);
            this.groupBox1.Controls.Add(this.Txt_R1);
            this.groupBox1.Controls.Add(this.Lbl_R1);
            this.groupBox1.Controls.Add(this.Txt_R2);
            this.groupBox1.Controls.Add(this.Lbl_R2);
            this.groupBox1.Location = new System.Drawing.Point(233, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(321, 87);
            this.groupBox1.TabIndex = 3;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Get Vout";
            // 
            // Lbl_Vin1
            // 
            this.Lbl_Vin1.AutoSize = true;
            this.Lbl_Vin1.Location = new System.Drawing.Point(222, 23);
            this.Lbl_Vin1.Name = "Lbl_Vin1";
            this.Lbl_Vin1.Size = new System.Drawing.Size(14, 13);
            this.Lbl_Vin1.TabIndex = 0;
            this.Lbl_Vin1.Text = "V";
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
            // Txt_Vin
            // 
            this.Txt_Vin.Location = new System.Drawing.Point(163, 19);
            this.Txt_Vin.Name = "Txt_Vin";
            this.Txt_Vin.Size = new System.Drawing.Size(53, 20);
            this.Txt_Vin.TabIndex = 3;
            // 
            // Lbl_Vin
            // 
            this.Lbl_Vin.AutoSize = true;
            this.Lbl_Vin.Location = new System.Drawing.Point(132, 22);
            this.Lbl_Vin.Name = "Lbl_Vin";
            this.Lbl_Vin.Size = new System.Drawing.Size(25, 13);
            this.Lbl_Vin.TabIndex = 0;
            this.Lbl_Vin.Text = "Vin:";
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
            // Lbl_RR1
            // 
            this.Lbl_RR1.AutoSize = true;
            this.Lbl_RR1.Location = new System.Drawing.Point(115, 86);
            this.Lbl_RR1.Name = "Lbl_RR1";
            this.Lbl_RR1.Size = new System.Drawing.Size(29, 13);
            this.Lbl_RR1.TabIndex = 4;
            this.Lbl_RR1.Text = "RR1";
            // 
            // Lbl_RR2
            // 
            this.Lbl_RR2.AutoSize = true;
            this.Lbl_RR2.Location = new System.Drawing.Point(115, 151);
            this.Lbl_RR2.Name = "Lbl_RR2";
            this.Lbl_RR2.Size = new System.Drawing.Size(29, 13);
            this.Lbl_RR2.TabIndex = 5;
            this.Lbl_RR2.Text = "RR2";
            // 
            // Lbl_RVout
            // 
            this.Lbl_RVout.AutoSize = true;
            this.Lbl_RVout.Location = new System.Drawing.Point(162, 133);
            this.Lbl_RVout.Name = "Lbl_RVout";
            this.Lbl_RVout.Size = new System.Drawing.Size(37, 13);
            this.Lbl_RVout.TabIndex = 6;
            this.Lbl_RVout.Text = "RVout";
            // 
            // Lbl_RVin
            // 
            this.Lbl_RVin.AutoSize = true;
            this.Lbl_RVin.Location = new System.Drawing.Point(29, 70);
            this.Lbl_RVin.Name = "Lbl_RVin";
            this.Lbl_RVin.Size = new System.Drawing.Size(30, 13);
            this.Lbl_RVin.TabIndex = 7;
            this.Lbl_RVin.Text = "RVin";
            // 
            // Txt_Process
            // 
            this.Txt_Process.Location = new System.Drawing.Point(233, 126);
            this.Txt_Process.Multiline = true;
            this.Txt_Process.Name = "Txt_Process";
            this.Txt_Process.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.Txt_Process.Size = new System.Drawing.Size(321, 102);
            this.Txt_Process.TabIndex = 8;
            // 
            // Lbl_Process
            // 
            this.Lbl_Process.AutoSize = true;
            this.Lbl_Process.Location = new System.Drawing.Point(233, 110);
            this.Lbl_Process.Name = "Lbl_Process";
            this.Lbl_Process.Size = new System.Drawing.Size(78, 13);
            this.Lbl_Process.TabIndex = 0;
            this.Lbl_Process.Text = "Show Process:";
            // 
            // Lbl_Formula
            // 
            this.Lbl_Formula.AutoSize = true;
            this.Lbl_Formula.Location = new System.Drawing.Point(569, 86);
            this.Lbl_Formula.Name = "Lbl_Formula";
            this.Lbl_Formula.Size = new System.Drawing.Size(47, 13);
            this.Lbl_Formula.TabIndex = 0;
            this.Lbl_Formula.Text = "Formula:";
            // 
            // Lbl_Diagram
            // 
            this.Lbl_Diagram.AutoSize = true;
            this.Lbl_Diagram.Location = new System.Drawing.Point(29, 21);
            this.Lbl_Diagram.Name = "Lbl_Diagram";
            this.Lbl_Diagram.Size = new System.Drawing.Size(49, 13);
            this.Lbl_Diagram.TabIndex = 0;
            this.Lbl_Diagram.Text = "Diagram:";
            // 
            // VoltDivision
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(764, 241);
            this.Controls.Add(this.Lbl_Diagram);
            this.Controls.Add(this.Lbl_Formula);
            this.Controls.Add(this.Lbl_Process);
            this.Controls.Add(this.Txt_Process);
            this.Controls.Add(this.Lbl_RVin);
            this.Controls.Add(this.Lbl_RVout);
            this.Controls.Add(this.Lbl_RR2);
            this.Controls.Add(this.Lbl_RR1);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.pictureBox2);
            this.Controls.Add(this.pictureBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(780, 280);
            this.MinimizeBox = false;
            this.MinimumSize = new System.Drawing.Size(780, 280);
            this.Name = "VoltDivision";
            this.Text = "Volt Division";
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
        private System.Windows.Forms.Label Lbl_R2;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.TextBox Txt_R1;
        private System.Windows.Forms.Label Lbl_R1;
        private System.Windows.Forms.TextBox Txt_R2;
        private System.Windows.Forms.TextBox Txt_Vin;
        private System.Windows.Forms.Label Lbl_Vin;
        private System.Windows.Forms.Button BtnClean;
        private System.Windows.Forms.Button BtnCalculate;
        private System.Windows.Forms.Label Lbl_RR1;
        private System.Windows.Forms.Label Lbl_RR2;
        private System.Windows.Forms.Label Lbl_RVout;
        private System.Windows.Forms.Label Lbl_RVin;
        private System.Windows.Forms.TextBox Txt_Process;
        private System.Windows.Forms.Label Lbl_R2Ohm;
        private System.Windows.Forms.Label Lbl_R1Ohm;
        private System.Windows.Forms.Label Lbl_Vin1;
        private System.Windows.Forms.Label Lbl_Process;
        private System.Windows.Forms.Label Lbl_Formula;
        private System.Windows.Forms.Label Lbl_Diagram;
    }
}

