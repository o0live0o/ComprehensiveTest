using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using ZiGongZJ.Dtos;

namespace ZiGongZJ
{

    public partial class SettingForm : CCWin.CCSkinMain
    {
        SettingEntity _settingEntity = null;
        public SettingForm()
        {
            InitializeComponent();
            _settingEntity = AppHelper.AppSetting;
            settingFiller.DisplayEntity(_settingEntity);
        }

        private void btnSelectPath_Click(object sender, EventArgs e)
        {
            if (sender is Button)
            {
                FolderBrowserDialog folderBrowserDialog = new FolderBrowserDialog();
                if (folderBrowserDialog.ShowDialog() == DialogResult.OK)
                {
                    Button skinButton = sender as Button;
                    switch (skinButton.Name)
                    {
                        case "btnSelectPath":
                            _settingEntity.ShareFilePath = folderBrowserDialog.SelectedPath;
                            txtSharepath.Text = _settingEntity.ShareFilePath;
                            break;
                    }
                }
            }
        }

        private void btnSave_Click(object sender, EventArgs e)
        {
            settingFiller.FillEntity(_settingEntity);
            File.WriteAllText(AppHelper.SettingPath, JsonConvert.SerializeObject(_settingEntity));
            this.Close();
        }
    }
}


