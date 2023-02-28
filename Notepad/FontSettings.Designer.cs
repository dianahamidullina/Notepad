namespace Notepad
{
    partial class FontSettings
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FontSettings));
            this.Examplelable = new System.Windows.Forms.Label();
            this.ExapleText = new System.Windows.Forms.Label();
            this.fontBox = new System.Windows.Forms.ComboBox();
            this.styleBox = new System.Windows.Forms.ComboBox();
            this.ClickOk = new System.Windows.Forms.Button();
            this.colorDialog1 = new System.Windows.Forms.ColorDialog();
            this.sizelabel = new System.Windows.Forms.Label();
            this.fontlabel = new System.Windows.Forms.Label();
            this.colorClick = new System.Windows.Forms.Button();
            this.colorlabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // Examplelable
            // 
            this.Examplelable.AutoSize = true;
            this.Examplelable.Location = new System.Drawing.Point(36, 129);
            this.Examplelable.Name = "Examplelable";
            this.Examplelable.Size = new System.Drawing.Size(54, 16);
            this.Examplelable.TabIndex = 0;
            this.Examplelable.Text = "Sample";
            // 
            // ExapleText
            // 
            this.ExapleText.AutoSize = true;
            this.ExapleText.Font = new System.Drawing.Font("Microsoft Sans Serif", 18.55F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ExapleText.Location = new System.Drawing.Point(33, 173);
            this.ExapleText.Name = "ExapleText";
            this.ExapleText.Size = new System.Drawing.Size(163, 35);
            this.ExapleText.TabIndex = 1;
            this.ExapleText.Text = "AaBbYyZz";
            // 
            // fontBox
            // 
            this.fontBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.fontBox.FormattingEnabled = true;
            this.fontBox.Items.AddRange(new object[] {
            "8",
            "9",
            "10",
            "11",
            "12",
            "14",
            "16",
            "18",
            "20",
            "22",
            "24",
            "26",
            "28",
            "30",
            "32"});
            this.fontBox.Location = new System.Drawing.Point(12, 33);
            this.fontBox.Name = "fontBox";
            this.fontBox.Size = new System.Drawing.Size(121, 24);
            this.fontBox.TabIndex = 3;
            this.fontBox.SelectedValueChanged += new System.EventHandler(this.OnFontChanged);
            // 
            // styleBox
            // 
            this.styleBox.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.styleBox.FormattingEnabled = true;
            this.styleBox.Items.AddRange(new object[] {
            "Regular",
            "Italics",
            "Bold",
            ""});
            this.styleBox.Location = new System.Drawing.Point(158, 33);
            this.styleBox.Name = "styleBox";
            this.styleBox.Size = new System.Drawing.Size(131, 24);
            this.styleBox.TabIndex = 4;
            this.styleBox.SelectedIndexChanged += new System.EventHandler(this.OnStyleChanged);
            // 
            // ClickOk
            // 
            this.ClickOk.Location = new System.Drawing.Point(214, 268);
            this.ClickOk.Name = "ClickOk";
            this.ClickOk.Size = new System.Drawing.Size(75, 23);
            this.ClickOk.TabIndex = 5;
            this.ClickOk.Text = "Ok";
            this.ClickOk.UseVisualStyleBackColor = true;
            this.ClickOk.Click += new System.EventHandler(this.ClickOk_Click);
            // 
            // sizelabel
            // 
            this.sizelabel.AutoSize = true;
            this.sizelabel.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.sizelabel.Location = new System.Drawing.Point(12, 14);
            this.sizelabel.Name = "sizelabel";
            this.sizelabel.Size = new System.Drawing.Size(33, 16);
            this.sizelabel.TabIndex = 7;
            this.sizelabel.Text = "Size";
            // 
            // fontlabel
            // 
            this.fontlabel.AutoSize = true;
            this.fontlabel.Location = new System.Drawing.Point(155, 14);
            this.fontlabel.Name = "fontlabel";
            this.fontlabel.Size = new System.Drawing.Size(33, 16);
            this.fontlabel.TabIndex = 8;
            this.fontlabel.Text = "Font";
            // 
            // colorClick
            // 
            this.colorClick.Location = new System.Drawing.Point(329, 34);
            this.colorClick.Name = "colorClick";
            this.colorClick.Size = new System.Drawing.Size(75, 23);
            this.colorClick.TabIndex = 10;
            this.colorClick.Text = "Chose color";
            this.colorClick.UseVisualStyleBackColor = true;
            this.colorClick.Click += new System.EventHandler(this.OnColorChanged);
            // 
            // colorlabel
            // 
            this.colorlabel.AutoSize = true;
            this.colorlabel.Location = new System.Drawing.Point(326, 14);
            this.colorlabel.Name = "colorlabel";
            this.colorlabel.Size = new System.Drawing.Size(39, 16);
            this.colorlabel.TabIndex = 9;
            this.colorlabel.Text = "Color";
            // 
            // FontSettings
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(451, 313);
            this.Controls.Add(this.colorClick);
            this.Controls.Add(this.colorlabel);
            this.Controls.Add(this.fontlabel);
            this.Controls.Add(this.sizelabel);
            this.Controls.Add(this.ClickOk);
            this.Controls.Add(this.styleBox);
            this.Controls.Add(this.fontBox);
            this.Controls.Add(this.ExapleText);
            this.Controls.Add(this.Examplelable);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "FontSettings";
            this.Text = "Font";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Examplelable;
        private System.Windows.Forms.Label ExapleText;
        private System.Windows.Forms.ComboBox fontBox;
        private System.Windows.Forms.ComboBox styleBox;
        private System.Windows.Forms.Button ClickOk;
        private System.Windows.Forms.ColorDialog colorDialog1;
        private System.Windows.Forms.Label sizelabel;
        private System.Windows.Forms.Label fontlabel;
        private System.Windows.Forms.Button colorClick;
        private System.Windows.Forms.Label colorlabel;
    
    }
}