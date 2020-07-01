using System;
using System.Windows.Forms;

namespace ElectronicDivision {
    public partial class Main : Form {
        #region Variables privates
        private VoltDivision VoltDivision_;
        private AmperDivision AmperDivision_;
        #endregion
        #region Constructor
        public Main() => InitializeComponent();
        #endregion
        #region VoltDivision_Click
        private void VoltDivision_Click(object sender, EventArgs e) {
            try {
                VoltDivision_ = new VoltDivision();
                VoltDivision_.ShowDialog();
            } finally {
                VoltDivision_.Close();
                VoltDivision_ = null;
            }
        }
        #endregion
        #region AmperDivision_Click
        private void AmperDivision_Click(object sender, EventArgs e) {
            try {
                AmperDivision_ = new AmperDivision();
                AmperDivision_.ShowDialog();
            } finally {
                AmperDivision_.Close();
                AmperDivision_ = null;
            }
        }
        #endregion
    }
}