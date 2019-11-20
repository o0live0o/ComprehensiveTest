namespace ZiGongZJ
{
    partial class AlterStandardForm
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
            this.txtXX = new CI.Controls.FlatField();
            this.txtSX = new CI.Controls.FlatField();
            this.btnConfirm = new System.Windows.Forms.Button();
            this.saveValidator = new CI.UIComponents.Validate.Validator();
            this.SuspendLayout();
            // 
            // txtXX
            // 
            this.txtXX.BackColor = System.Drawing.Color.Transparent;
            this.txtXX.Caption = "过量空气系数上限:";
            this.txtXX.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtXX.CaptionWidth = 0;
            this.txtXX.Location = new System.Drawing.Point(13, 95);
            this.txtXX.Name = "txtXX";
            this.txtXX.Size = new System.Drawing.Size(357, 27);
            this.txtXX.TabIndex = 3;
            this.saveValidator.SetTaget(this.txtXX, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("限值格式不正确", "^[0-9]+([.]{1}[0-9]+){0,1}$")))}));
            // 
            // txtSX
            // 
            this.txtSX.BackColor = System.Drawing.Color.Transparent;
            this.txtSX.Caption = "过量空气系数上限:";
            this.txtSX.CaptionFont = new System.Drawing.Font("宋体", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(134)));
            this.txtSX.CaptionWidth = 0;
            this.txtSX.Location = new System.Drawing.Point(13, 53);
            this.txtSX.Name = "txtSX";
            this.txtSX.Size = new System.Drawing.Size(357, 27);
            this.txtSX.TabIndex = 2;
            this.saveValidator.SetTaget(this.txtSX, new CI.UIComponents.Validate.TextTaget(new CI.UIComponents.Validate.BaseValidator[] {
                ((CI.UIComponents.Validate.BaseValidator)(new CI.UIComponents.Validate.RegularExpressionValidator("限值格式不正确", "^[0-9]+([.]{1}[0-9]+){0,1}$")))}));
            // 
            // btnConfirm
            // 
            this.btnConfirm.Location = new System.Drawing.Point(290, 136);
            this.btnConfirm.Name = "btnConfirm";
            this.btnConfirm.Size = new System.Drawing.Size(75, 33);
            this.btnConfirm.TabIndex = 4;
            this.btnConfirm.Text = "确 认";
            this.btnConfirm.UseVisualStyleBackColor = true;
            this.btnConfirm.Click += new System.EventHandler(this.btnConfirm_Click);
            // 
            // AlterStandardForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 15F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 185);
            this.Controls.Add(this.btnConfirm);
            this.Controls.Add(this.txtXX);
            this.Controls.Add(this.txtSX);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "AlterStandardForm";
            this.ShowDrawIcon = false;
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "";
            this.ResumeLayout(false);

        }

        #endregion

        private CI.Controls.FlatField txtXX;
        private CI.Controls.FlatField txtSX;
        private System.Windows.Forms.Button btnConfirm;
        private CI.UIComponents.Validate.Validator saveValidator;
    }
}