using CCWin;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace ZiGongZJ
{
    public partial class AlterStandardForm : CCSkinMain
    {
        public string _method = "";

        public AlterStandardForm()
        {
            InitializeComponent();
            txtSX.Text = GlobalVar.GLKQXSSX;
            txtXX.Text = GlobalVar.GLKQXSXX;
        }

        private void btnConfirm_Click(object sender, EventArgs e)
        {
            if (saveValidator.Validate())
            {
                if (string.IsNullOrEmpty(txtSX.Text.Trim()) || string.IsNullOrEmpty(txtXX.Text.Trim()))
                    return;
                GlobalVar.GLKQXSSX = txtSX.Text.Trim();
                GlobalVar.GLKQXSXX = txtXX.Text.Trim();
                this.Close();
            }
        }
    }
}
