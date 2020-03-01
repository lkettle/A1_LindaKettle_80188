using System;

namespace A1_LindaKettle_80188
{
    partial class Form_BonusCalculator
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_BonusCalculator));
            this.gbx_language = new System.Windows.Forms.GroupBox();
            this.rbtn_French = new System.Windows.Forms.RadioButton();
            this.rbtn_portuguese = new System.Windows.Forms.RadioButton();
            this.rbtn_english = new System.Windows.Forms.RadioButton();
            this.lbl_name = new System.Windows.Forms.Label();
            this.txt_name = new System.Windows.Forms.TextBox();
            this.txt_ID = new System.Windows.Forms.TextBox();
            this.lbl_ID = new System.Windows.Forms.Label();
            this.txt_hours = new System.Windows.Forms.TextBox();
            this.lbl_hours = new System.Windows.Forms.Label();
            this.txt_storeSales = new System.Windows.Forms.TextBox();
            this.lbl_storeSales = new System.Windows.Forms.Label();
            this.txt_bonusResult = new System.Windows.Forms.TextBox();
            this.lbl_bonusResult = new System.Windows.Forms.Label();
            this.btn_Calculate = new System.Windows.Forms.Button();
            this.btn_Print = new System.Windows.Forms.Button();
            this.btn_Clear = new System.Windows.Forms.Button();
            this.gbx_language.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbx_language
            // 
            this.gbx_language.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("gbx_language.BackgroundImage")));
            this.gbx_language.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.gbx_language.Controls.Add(this.rbtn_French);
            this.gbx_language.Controls.Add(this.rbtn_portuguese);
            this.gbx_language.Controls.Add(this.rbtn_english);
            this.gbx_language.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbx_language.Location = new System.Drawing.Point(12, 10);
            this.gbx_language.Name = "gbx_language";
            this.gbx_language.Size = new System.Drawing.Size(200, 104);
            this.gbx_language.TabIndex = 0;
            this.gbx_language.TabStop = false;
            this.gbx_language.Text = "Language";
            // 
            // rbtn_French
            // 
            this.rbtn_French.AutoSize = true;
            this.rbtn_French.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_French.Location = new System.Drawing.Point(6, 46);
            this.rbtn_French.Name = "rbtn_French";
            this.rbtn_French.Size = new System.Drawing.Size(72, 20);
            this.rbtn_French.TabIndex = 2;
            this.rbtn_French.TabStop = true;
            this.rbtn_French.Text = " French";
            this.rbtn_French.UseVisualStyleBackColor = false;
            this.rbtn_French.CheckedChanged += new System.EventHandler(this.rbtn_french_CheckedChanged);
            // 
            // rbtn_portuguese
            // 
            this.rbtn_portuguese.AutoSize = true;
            this.rbtn_portuguese.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_portuguese.Location = new System.Drawing.Point(6, 72);
            this.rbtn_portuguese.Name = "rbtn_portuguese";
            this.rbtn_portuguese.Size = new System.Drawing.Size(99, 20);
            this.rbtn_portuguese.TabIndex = 3;
            this.rbtn_portuguese.Text = " Portuguese";
            this.rbtn_portuguese.UseVisualStyleBackColor = false;
            this.rbtn_portuguese.CheckedChanged += new System.EventHandler(this.rbtn_portuguese_CheckedChanged);
            // 
            // rbtn_english
            // 
            this.rbtn_english.AutoSize = true;
            this.rbtn_english.BackColor = System.Drawing.Color.Transparent;
            this.rbtn_english.Checked = true;
            this.rbtn_english.Location = new System.Drawing.Point(6, 20);
            this.rbtn_english.Name = "rbtn_english";
            this.rbtn_english.Size = new System.Drawing.Size(71, 20);
            this.rbtn_english.TabIndex = 1;
            this.rbtn_english.TabStop = true;
            this.rbtn_english.Text = " English";
            this.rbtn_english.UseVisualStyleBackColor = false;
            this.rbtn_english.CheckedChanged += new System.EventHandler(this.rbtn_english_CheckedChanged);
            // 
            // lbl_name
            // 
            this.lbl_name.AutoSize = true;
            this.lbl_name.BackColor = System.Drawing.Color.Transparent;
            this.lbl_name.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_name.Location = new System.Drawing.Point(561, 35);
            this.lbl_name.Name = "lbl_name";
            this.lbl_name.Size = new System.Drawing.Size(106, 16);
            this.lbl_name.TabIndex = 1;
            this.lbl_name.Text = "Employee Name:";
            // 
            // txt_name
            // 
            this.txt_name.AcceptsReturn = true;
            this.txt_name.AcceptsTab = true;
            this.txt_name.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_name.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_name.Location = new System.Drawing.Point(740, 33);
            this.txt_name.Name = "txt_name";
            this.txt_name.Size = new System.Drawing.Size(130, 22);
            this.txt_name.TabIndex = 4;
            this.txt_name.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_name.TextChanged += new System.EventHandler(this.txt_name_TextChanged);
            // 
            // txt_ID
            // 
            this.txt_ID.AcceptsReturn = true;
            this.txt_ID.AcceptsTab = true;
            this.txt_ID.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ID.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_ID.Location = new System.Drawing.Point(740, 70);
            this.txt_ID.Name = "txt_ID";
            this.txt_ID.Size = new System.Drawing.Size(130, 22);
            this.txt_ID.TabIndex = 5;
            this.txt_ID.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_ID.TextChanged += new System.EventHandler(this.txt_ID_TextChanged);
            // 
            // lbl_ID
            // 
            this.lbl_ID.AutoSize = true;
            this.lbl_ID.BackColor = System.Drawing.Color.Transparent;
            this.lbl_ID.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_ID.Location = new System.Drawing.Point(561, 73);
            this.lbl_ID.Name = "lbl_ID";
            this.lbl_ID.Size = new System.Drawing.Size(84, 16);
            this.lbl_ID.TabIndex = 3;
            this.lbl_ID.Text = "Employee ID:";
            // 
            // txt_hours
            // 
            this.txt_hours.AcceptsReturn = true;
            this.txt_hours.AcceptsTab = true;
            this.txt_hours.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_hours.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_hours.Location = new System.Drawing.Point(740, 108);
            this.txt_hours.Name = "txt_hours";
            this.txt_hours.Size = new System.Drawing.Size(130, 22);
            this.txt_hours.TabIndex = 6;
            this.txt_hours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_hours.TextChanged += new System.EventHandler(this.txt_hours_TextChanged);
            // 
            // lbl_hours
            // 
            this.lbl_hours.AutoSize = true;
            this.lbl_hours.BackColor = System.Drawing.Color.Transparent;
            this.lbl_hours.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_hours.Location = new System.Drawing.Point(561, 111);
            this.lbl_hours.Name = "lbl_hours";
            this.lbl_hours.Size = new System.Drawing.Size(95, 16);
            this.lbl_hours.TabIndex = 5;
            this.lbl_hours.Text = "Hours Worked:";
            // 
            // txt_storeSales
            // 
            this.txt_storeSales.AcceptsReturn = true;
            this.txt_storeSales.AcceptsTab = true;
            this.txt_storeSales.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_storeSales.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_storeSales.Location = new System.Drawing.Point(740, 146);
            this.txt_storeSales.Name = "txt_storeSales";
            this.txt_storeSales.Size = new System.Drawing.Size(130, 22);
            this.txt_storeSales.TabIndex = 7;
            this.txt_storeSales.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_storeSales.TextChanged += new System.EventHandler(this.txt_storeSales_TextChanged);
            // 
            // lbl_storeSales
            // 
            this.lbl_storeSales.AutoSize = true;
            this.lbl_storeSales.BackColor = System.Drawing.Color.Transparent;
            this.lbl_storeSales.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_storeSales.Location = new System.Drawing.Point(561, 149);
            this.lbl_storeSales.Name = "lbl_storeSales";
            this.lbl_storeSales.Size = new System.Drawing.Size(74, 16);
            this.lbl_storeSales.TabIndex = 7;
            this.lbl_storeSales.Text = "Store Sales:";
            // 
            // txt_bonusResult
            // 
            this.txt_bonusResult.BackColor = System.Drawing.SystemColors.ControlLight;
            this.txt_bonusResult.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_bonusResult.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.txt_bonusResult.Location = new System.Drawing.Point(740, 184);
            this.txt_bonusResult.Name = "txt_bonusResult";
            this.txt_bonusResult.ReadOnly = true;
            this.txt_bonusResult.Size = new System.Drawing.Size(130, 22);
            this.txt_bonusResult.TabIndex = 9;
            this.txt_bonusResult.TabStop = false;
            this.txt_bonusResult.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // lbl_bonusResult
            // 
            this.lbl_bonusResult.AutoSize = true;
            this.lbl_bonusResult.BackColor = System.Drawing.Color.Transparent;
            this.lbl_bonusResult.Font = new System.Drawing.Font("Berlin Sans FB", 7.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_bonusResult.Location = new System.Drawing.Point(561, 187);
            this.lbl_bonusResult.Name = "lbl_bonusResult";
            this.lbl_bonusResult.Size = new System.Drawing.Size(45, 16);
            this.lbl_bonusResult.TabIndex = 9;
            this.lbl_bonusResult.Text = "Bonus:";
            // 
            // btn_Calculate
            // 
            this.btn_Calculate.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Calculate.BackColor = System.Drawing.Color.Transparent;
            this.btn_Calculate.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Calculate.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Calculate.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Calculate.Location = new System.Drawing.Point(740, 435);
            this.btn_Calculate.Name = "btn_Calculate";
            this.btn_Calculate.Size = new System.Drawing.Size(130, 30);
            this.btn_Calculate.TabIndex = 8;
            this.btn_Calculate.Text = "Calculate";
            this.btn_Calculate.TextAlign = System.Drawing.ContentAlignment.BottomCenter;
            this.btn_Calculate.UseVisualStyleBackColor = true;
            this.btn_Calculate.Click += new System.EventHandler(this.btn_Calculate_Click);
            // 
            // btn_Print
            // 
            this.btn_Print.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Print.BackColor = System.Drawing.Color.Transparent;
            this.btn_Print.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Print.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Print.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Print.Location = new System.Drawing.Point(740, 471);
            this.btn_Print.Name = "btn_Print";
            this.btn_Print.Size = new System.Drawing.Size(130, 30);
            this.btn_Print.TabIndex = 9;
            this.btn_Print.Text = "Print";
            this.btn_Print.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Print.UseVisualStyleBackColor = true;
            this.btn_Print.Click += new System.EventHandler(this.btn_Print_Click);
            // 
            // btn_Clear
            // 
            this.btn_Clear.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_Clear.BackColor = System.Drawing.Color.Transparent;
            this.btn_Clear.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btn_Clear.Font = new System.Drawing.Font("Berlin Sans FB Demi", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_Clear.ForeColor = System.Drawing.Color.Yellow;
            this.btn_Clear.Location = new System.Drawing.Point(740, 507);
            this.btn_Clear.Name = "btn_Clear";
            this.btn_Clear.Size = new System.Drawing.Size(130, 30);
            this.btn_Clear.TabIndex = 10;
            this.btn_Clear.Text = "Next";
            this.btn_Clear.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            this.btn_Clear.UseVisualStyleBackColor = true;
            this.btn_Clear.Click += new System.EventHandler(this.btn_Next_Click);
            // 
            // Form_BonusCalculator
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Center;
            this.ClientSize = new System.Drawing.Size(882, 553);
            this.Controls.Add(this.btn_Clear);
            this.Controls.Add(this.btn_Print);
            this.Controls.Add(this.btn_Calculate);
            this.Controls.Add(this.txt_bonusResult);
            this.Controls.Add(this.lbl_bonusResult);
            this.Controls.Add(this.txt_storeSales);
            this.Controls.Add(this.lbl_storeSales);
            this.Controls.Add(this.txt_hours);
            this.Controls.Add(this.lbl_hours);
            this.Controls.Add(this.txt_ID);
            this.Controls.Add(this.lbl_ID);
            this.Controls.Add(this.txt_name);
            this.Controls.Add(this.lbl_name);
            this.Controls.Add(this.gbx_language);
            this.Name = "Form_BonusCalculator";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sharp Auto:  Bonus Calculator";
            this.gbx_language.ResumeLayout(false);
            this.gbx_language.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
                private void txt_bonusResult_TextChanged(object sender, EventArgs e)
        {
            //throw new NotImplementedException();
        }

        #endregion

        private System.Windows.Forms.GroupBox gbx_language;
        private System.Windows.Forms.RadioButton rbtn_english;
        private System.Windows.Forms.RadioButton rbtn_portuguese;
        private System.Windows.Forms.Label lbl_name;
        private System.Windows.Forms.TextBox txt_name;
        private System.Windows.Forms.TextBox txt_ID;
        private System.Windows.Forms.Label lbl_ID;
        private System.Windows.Forms.TextBox txt_hours;
        private System.Windows.Forms.Label lbl_hours;
        private System.Windows.Forms.TextBox txt_storeSales;
        private System.Windows.Forms.Label lbl_storeSales;
        private System.Windows.Forms.TextBox txt_bonusResult;
        private System.Windows.Forms.Label lbl_bonusResult;
        private System.Windows.Forms.Button btn_Calculate;
        private System.Windows.Forms.Button btn_Print;
        private System.Windows.Forms.Button btn_Clear;
        private System.Windows.Forms.RadioButton rbtn_French;
    }
}

