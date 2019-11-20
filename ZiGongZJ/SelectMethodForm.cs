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
    public partial class SelectMethodForm : CCSkinMain
    {
        public string _method = "";

        public SelectMethodForm()
        {
            InitializeComponent();
        }

        private void BtnClikc(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                Button button = (Button)sender;
                _method = button.Tag.ToString();
                this.DialogResult = DialogResult.OK;
                this.Close();
            }
        }

        public string GetMethod()
        {
            return _method;
        }
    }
}
