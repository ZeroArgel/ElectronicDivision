using System;
using System.Windows.Forms;

namespace ElectronicDivision {
    public partial class AmperDivision : Form {
        #region AmperDivision
        public AmperDivision() => InitializeComponent();
        #endregion
        #region BtnCalculate_Click
        private void BtnCalculate_Click(object sender, EventArgs e) {
            try {
                if (!IsValide(Txt_It.Text, Txt_R1.Text, Txt_R2.Text)) throw new Exception("Any field no is integer or is less that 1");
                Lbl_RIt.Text = Txt_It.Text + " A";
                Lbl_RR1.Text = Txt_R1.Text + " Ω";
                Lbl_RR2.Text = Txt_R2.Text + " Ω";
                Txt_Process.Text = ProcessIT(double.Parse(Txt_It.Text), int.Parse(Txt_R1.Text), int.Parse(Txt_R2.Text), true);
                Txt_Process.Text += Environment.NewLine;
                Txt_Process.Text += ProcessIT(double.Parse(Txt_It.Text), int.Parse(Txt_R1.Text), int.Parse(Txt_R2.Text), false);
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
        private bool IsValide(object _it, object _r1, object _r2) {
            if (!double.TryParse(_it.ToString(), out double _) || !int.TryParse(_r1.ToString(), out int _) || !int.TryParse(_r2.ToString(), out int _)) return false;
            if (double.Parse(_it.ToString()) <= 0.0 || int.Parse(_r1.ToString()) <= 0 || int.Parse(_r2.ToString()) <= 0) return false;
            return true;
        }
        #endregion
        #region ProcessIT
        private string ProcessIT(double _it, int _r1, int _r2, bool _type) {
            double r1r2 = _r1 + _r2;
            double rx_r1r2 = _r1 / r1r2;
            if (_type) rx_r1r2 = _r2 / r1r2;
            double res = rx_r1r2 * _it;
            var process = "(R2 / (R1 + R2)) * It" + Environment.NewLine;
            if (_type) {
                process += "(" + _r1 + "Ω / (" + _r1 + "Ω + " + _r2 + "Ω)) * " + _it + " A " + Environment.NewLine;
                process += "(" + _r1 + "Ω/ (" + r1r2 + "Ω)) * " + _it + " A " + Environment.NewLine;
            } else {
                process += "(" + _r2 + "Ω / (" + _r1 + "Ω + " + _r2 + "Ω)) * " + _it + " A " + Environment.NewLine;
                process += "(" + _r2 + "Ω/ (" + r1r2 + "Ω)) * " + _it + " A " + Environment.NewLine;
            }
            process += "(" + rx_r1r2 + ") * " + _it + " A " + Environment.NewLine;
            process += res + " A " + Environment.NewLine;
            Lbl_RIt1.Text = res.ToString("#.##") + " A";
            return process;
        }
        #endregion
        #region Clean
        private void Clean(bool _typeClean) {
            if (_typeClean) {
                Lbl_RIt.Text = "RIt";
                Lbl_RIt1.Text = "RIt1";
                Lbl_RIt2.Text = "RIt2";
                Lbl_RR1.Text = "RR1";
                Lbl_RR2.Text = "RR2";
                Txt_Process.Text = "";
            }
            Txt_It.Text = "";
            Txt_R1.Text = "";
            Txt_R2.Text = "";
            Txt_R1.Focus();
        }
        #endregion
    }
}