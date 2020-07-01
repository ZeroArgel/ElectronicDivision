using System;
using System.Windows.Forms;

namespace ElectronicDivision {
    public partial class VoltDivision : Form {
        #region TensorDivision
        public VoltDivision() {
            InitializeComponent();
        }
        #endregion
        #region BtnCalculate_Click
        private void BtnCalculate_Click(object sender, EventArgs e) {
            try {
                if (!IsValide(Txt_Vin.Text, Txt_R1.Text, Txt_R2.Text)) throw new Exception("Any field no is integer or is less that 1");
                Lbl_RVin.Text = Txt_Vin.Text + " V";
                Lbl_RR1.Text = Txt_R1.Text + " Ω";
                Lbl_RR2.Text = Txt_R2.Text + " Ω";
                Txt_Process.Text = Process(int.Parse(Txt_Vin.Text), int.Parse(Txt_R1.Text), int.Parse(Txt_R2.Text));
            } catch (Exception ex) { MessageBox.Show(ex.Message); } 
            finally {
                Clean(false);
            }
        }
        #endregion
        #region BtnClean_Click
        private void BtnClean_Click(object sender, EventArgs e) => Clean(true);
        #endregion
        #region IsValide
        private bool IsValide(object _vin, object _r1, object _r2) {
            if (!double.TryParse(_vin.ToString(), out double _) || !int.TryParse(_r1.ToString(), out int _) || !int.TryParse(_r2.ToString(), out int _)) return false;
            if (double.Parse(_vin.ToString()) <= 0.0 || int.Parse(_r1.ToString()) <= 0 || int.Parse(_r2.ToString()) <= 0) return false;
            return true;
        }
        #endregion
        #region Process
        private string Process(double _vin, int _r1, int _r2) {
            double r1r2 = _r1 + _r2;
            double r2_r1r2 = _r2 / r1r2;
            double res = r2_r1r2 * _vin;
            var process = "(R2 / (R1 + R2)) * Vin" + Environment.NewLine;
            process += "(" + _r2 + "Ω / (" + _r1 + "Ω + " + _r2 + "Ω)) * " + _vin + " V " + Environment.NewLine;
            process += "(" + _r2 + "Ω/ (" + r1r2 + "Ω)) * " + _vin + " V " + Environment.NewLine;
            process += "(" + r2_r1r2 + ") * " + _vin + " V " + Environment.NewLine;
            process += res + " V " + Environment.NewLine;
            Lbl_RVout.Text = res.ToString("#.##") + " V";
            return process;
        }
        #endregion
        #region Clean
        private void Clean(bool _typeClean) {
            if (_typeClean) {
                Lbl_RVin.Text = "RVin";
                Lbl_RVout.Text = "RVout";
                Lbl_RR1.Text = "RR1";
                Lbl_RR2.Text = "RR2";
                Txt_Process.Text = "";
            }
            Txt_Vin.Text = "";
            Txt_R1.Text = "";
            Txt_R2.Text = "";
            Txt_R1.Focus();
        }
        #endregion
    }
}