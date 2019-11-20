namespace ZiGongZJ
{
    partial class SettingForm
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SettingForm));
            this.skinGroupBox1 = new CCWin.SkinControl.SkinGroupBox();
            this.flatField4 = new CI.Controls.FlatField();
            this.flatField3 = new CI.Controls.FlatField();
            this.flatField2 = new CI.Controls.FlatField();
            this.flatField1 = new CI.Controls.FlatField();
            this.btnSave = new System.Windows.Forms.Button();
            this.txtSharepath = new CI.Controls.FlatField();
            this.btnSelectPath = new System.Windows.Forms.Button();
            this.settingFiller = new CI.UIComponents.Filler.EntityFiller();
            this.skinGroupBox2 = new CCWin.SkinControl.SkinGroupBox();
            this.flatField5 = new CI.Controls.FlatField();
            this.flatField6 = new CI.Controls.FlatField();
            this.flatField7 = new CI.Controls.FlatField();
            this.flatField8 = new CI.Controls.FlatField();
            this.skinGroupBox1.SuspendLayout();
            this.skinGroupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // skinGroupBox1
            // 
            this.skinGroupBox1.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox1.BorderColor = System.Drawing.Color.Red;
            this.skinGroupBox1.Controls.Add(this.flatField4);
            this.skinGroupBox1.Controls.Add(this.flatField3);
            this.skinGroupBox1.Controls.Add(this.flatField2);
            this.skinGroupBox1.Controls.Add(this.flatField1);
            this.skinGroupBox1.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBox1.Location = new System.Drawing.Point(27, 27);
            this.skinGroupBox1.Name = "skinGroupBox1";
            this.skinGroupBox1.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox1.Size = new System.Drawing.Size(384, 162);
            this.skinGroupBox1.TabIndex = 4;
            this.skinGroupBox1.TabStop = false;
            this.skinGroupBox1.Text = "数据库设置";
            this.skinGroupBox1.TitleBorderColor = System.Drawing.Color.Red;
            this.skinGroupBox1.TitleRectBackColor = System.Drawing.Color.White;
            // 
            // flatField4
            // 
            this.flatField4.BackColor = System.Drawing.Color.Transparent;
            this.flatField4.Caption = "密码:     ";
            this.flatField4.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField4.CaptionWidth = 0;
            this.settingFiller.SetEntityField(this.flatField4, new CI.UIComponents.Filler.TextEntry("DataBasePwd", ""));
            this.flatField4.Location = new System.Drawing.Point(9, 134);
            this.flatField4.Name = "flatField4";
            this.flatField4.PasswordChar = '*';
            this.flatField4.Size = new System.Drawing.Size(357, 27);
            this.flatField4.TabIndex = 3;
            // 
            // flatField3
            // 
            this.flatField3.BackColor = System.Drawing.Color.Transparent;
            this.flatField3.Caption = "用户名:   ";
            this.flatField3.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField3.CaptionWidth = 0;
            this.settingFiller.SetEntityField(this.flatField3, new CI.UIComponents.Filler.TextEntry("DataBaseUser", ""));
            this.flatField3.Location = new System.Drawing.Point(9, 97);
            this.flatField3.Name = "flatField3";
            this.flatField3.Size = new System.Drawing.Size(357, 27);
            this.flatField3.TabIndex = 2;
            // 
            // flatField2
            // 
            this.flatField2.BackColor = System.Drawing.Color.Transparent;
            this.flatField2.Caption = "数据库:   ";
            this.flatField2.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField2.CaptionWidth = 0;
            this.settingFiller.SetEntityField(this.flatField2, new CI.UIComponents.Filler.TextEntry("DataBase", ""));
            this.flatField2.Location = new System.Drawing.Point(9, 60);
            this.flatField2.Name = "flatField2";
            this.flatField2.Size = new System.Drawing.Size(357, 27);
            this.flatField2.TabIndex = 1;
            // 
            // flatField1
            // 
            this.flatField1.BackColor = System.Drawing.Color.Transparent;
            this.flatField1.Caption = "服务器:   ";
            this.flatField1.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField1.CaptionWidth = 0;
            this.settingFiller.SetEntityField(this.flatField1, new CI.UIComponents.Filler.TextEntry("DataBaseServer", ""));
            this.flatField1.Location = new System.Drawing.Point(9, 23);
            this.flatField1.Name = "flatField1";
            this.flatField1.Size = new System.Drawing.Size(357, 27);
            this.flatField1.TabIndex = 0;
            // 
            // btnSave
            // 
            this.btnSave.Location = new System.Drawing.Point(336, 413);
            this.btnSave.Name = "btnSave";
            this.btnSave.Size = new System.Drawing.Size(75, 23);
            this.btnSave.TabIndex = 5;
            this.btnSave.Text = "保 存";
            this.btnSave.UseVisualStyleBackColor = true;
            this.btnSave.Click += new System.EventHandler(this.btnSave_Click);
            // 
            // txtSharepath
            // 
            this.txtSharepath.BackColor = System.Drawing.Color.Transparent;
            this.txtSharepath.Caption = "共享文件路径:";
            this.txtSharepath.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSharepath.CaptionWidth = 0;
            this.settingFiller.SetEntityField(this.txtSharepath, new CI.UIComponents.Filler.TextEntry("ShareFilePath", ""));
            this.txtSharepath.Location = new System.Drawing.Point(27, 363);
            this.txtSharepath.Name = "txtSharepath";
            this.txtSharepath.Size = new System.Drawing.Size(384, 27);
            this.txtSharepath.TabIndex = 6;
            // 
            // btnSelectPath
            // 
            this.btnSelectPath.Location = new System.Drawing.Point(417, 363);
            this.btnSelectPath.Name = "btnSelectPath";
            this.btnSelectPath.Size = new System.Drawing.Size(29, 23);
            this.btnSelectPath.TabIndex = 7;
            this.btnSelectPath.Text = "……";
            this.btnSelectPath.UseVisualStyleBackColor = true;
            this.btnSelectPath.Click += new System.EventHandler(this.btnSelectPath_Click);
            // 
            // skinGroupBox2
            // 
            this.skinGroupBox2.BackColor = System.Drawing.Color.Transparent;
            this.skinGroupBox2.BorderColor = System.Drawing.Color.Red;
            this.skinGroupBox2.Controls.Add(this.flatField5);
            this.skinGroupBox2.Controls.Add(this.flatField6);
            this.skinGroupBox2.Controls.Add(this.flatField7);
            this.skinGroupBox2.Controls.Add(this.flatField8);
            this.skinGroupBox2.ForeColor = System.Drawing.Color.Blue;
            this.skinGroupBox2.Location = new System.Drawing.Point(27, 195);
            this.skinGroupBox2.Name = "skinGroupBox2";
            this.skinGroupBox2.RectBackColor = System.Drawing.Color.White;
            this.skinGroupBox2.Size = new System.Drawing.Size(384, 162);
            this.skinGroupBox2.TabIndex = 8;
            this.skinGroupBox2.TabStop = false;
            this.skinGroupBox2.Text = "数据库设置";
            this.skinGroupBox2.TitleBorderColor = System.Drawing.Color.Red;
            this.skinGroupBox2.TitleRectBackColor = System.Drawing.Color.White;
            // 
            // flatField5
            // 
            this.flatField5.BackColor = System.Drawing.Color.Transparent;
            this.flatField5.Caption = "摄像头密码:";
            this.flatField5.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField5.CaptionWidth = 0;
            this.settingFiller.SetEntityField(this.flatField5, new CI.UIComponents.Filler.TextEntry("CameraPwd", ""));
            this.flatField5.Location = new System.Drawing.Point(9, 134);
            this.flatField5.Name = "flatField5";
            this.flatField5.PasswordChar = '*';
            this.flatField5.Size = new System.Drawing.Size(357, 27);
            this.flatField5.TabIndex = 3;
            // 
            // flatField6
            // 
            this.flatField6.BackColor = System.Drawing.Color.Transparent;
            this.flatField6.Caption = "摄像头用户名:";
            this.flatField6.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField6.CaptionWidth = 0;
            this.settingFiller.SetEntityField(this.flatField6, new CI.UIComponents.Filler.TextEntry("CameraUser", ""));
            this.flatField6.Location = new System.Drawing.Point(9, 97);
            this.flatField6.Name = "flatField6";
            this.flatField6.Size = new System.Drawing.Size(357, 27);
            this.flatField6.TabIndex = 2;
            // 
            // flatField7
            // 
            this.flatField7.BackColor = System.Drawing.Color.Transparent;
            this.flatField7.Caption = "摄像头端口:";
            this.flatField7.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField7.CaptionWidth = 0;
            this.settingFiller.SetEntityField(this.flatField7, new CI.UIComponents.Filler.TextEntry("CameraPort", ""));
            this.flatField7.Location = new System.Drawing.Point(9, 60);
            this.flatField7.Name = "flatField7";
            this.flatField7.Size = new System.Drawing.Size(357, 27);
            this.flatField7.TabIndex = 1;
            // 
            // flatField8
            // 
            this.flatField8.BackColor = System.Drawing.Color.Transparent;
            this.flatField8.Caption = "摄像头IP: ";
            this.flatField8.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.flatField8.CaptionWidth = 0;
            this.settingFiller.SetEntityField(this.flatField8, new CI.UIComponents.Filler.TextEntry("CameraIP", ""));
            this.flatField8.Location = new System.Drawing.Point(9, 23);
            this.flatField8.Name = "flatField8";
            this.flatField8.Size = new System.Drawing.Size(357, 27);
            this.flatField8.TabIndex = 0;
            // 
            // SettingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.ClientSize = new System.Drawing.Size(453, 452);
            this.Controls.Add(this.skinGroupBox2);
            this.Controls.Add(this.btnSelectPath);
            this.Controls.Add(this.txtSharepath);
            this.Controls.Add(this.btnSave);
            this.Controls.Add(this.skinGroupBox1);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "SettingForm";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "系统设置";
            this.skinGroupBox1.ResumeLayout(false);
            this.skinGroupBox2.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private CCWin.SkinControl.SkinGroupBox skinGroupBox1;
        private CI.Controls.FlatField flatField4;
        private CI.Controls.FlatField flatField3;
        private CI.Controls.FlatField flatField2;
        private CI.Controls.FlatField flatField1;
        private System.Windows.Forms.Button btnSave;
        private CI.Controls.FlatField txtSharepath;
        private System.Windows.Forms.Button btnSelectPath;
        private CI.UIComponents.Filler.EntityFiller settingFiller;
        private CCWin.SkinControl.SkinGroupBox skinGroupBox2;
        private CI.Controls.FlatField flatField5;
        private CI.Controls.FlatField flatField6;
        private CI.Controls.FlatField flatField7;
        private CI.Controls.FlatField flatField8;
    }
}