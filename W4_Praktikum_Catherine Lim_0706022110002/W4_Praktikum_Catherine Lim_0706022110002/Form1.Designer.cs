
namespace W4_Praktikum_Catherine_Lim_0706022110002
{
    partial class Form1
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
            this.buttonClear = new System.Windows.Forms.Button();
            this.radioButtonMerah = new System.Windows.Forms.RadioButton();
            this.listBoxKoleksi = new System.Windows.Forms.ListBox();
            this.buttonAdd = new System.Windows.Forms.Button();
            this.radioButtonBiru = new System.Windows.Forms.RadioButton();
            this.labelData = new System.Windows.Forms.Label();
            this.textBoxData = new System.Windows.Forms.TextBox();
            this.labelKoleksi = new System.Windows.Forms.Label();
            this.labelOutput = new System.Windows.Forms.Label();
            this.labelHasilOutput = new System.Windows.Forms.Label();
            this.checkBoxAktif = new System.Windows.Forms.CheckBox();
            this.labelSetting = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // buttonClear
            // 
            this.buttonClear.Location = new System.Drawing.Point(285, 348);
            this.buttonClear.Name = "buttonClear";
            this.buttonClear.Size = new System.Drawing.Size(326, 40);
            this.buttonClear.TabIndex = 0;
            this.buttonClear.Text = "Clear";
            this.buttonClear.UseVisualStyleBackColor = true;
            this.buttonClear.Click += new System.EventHandler(this.buttonClear_Click);
            // 
            // radioButtonMerah
            // 
            this.radioButtonMerah.AutoSize = true;
            this.radioButtonMerah.Location = new System.Drawing.Point(317, 124);
            this.radioButtonMerah.Name = "radioButtonMerah";
            this.radioButtonMerah.Size = new System.Drawing.Size(130, 24);
            this.radioButtonMerah.TabIndex = 2;
            this.radioButtonMerah.TabStop = true;
            this.radioButtonMerah.Text = "Warna Merah";
            this.radioButtonMerah.UseVisualStyleBackColor = true;
            this.radioButtonMerah.CheckedChanged += new System.EventHandler(this.radioButtonMerah_CheckedChanged);
            // 
            // listBoxKoleksi
            // 
            this.listBoxKoleksi.FormattingEnabled = true;
            this.listBoxKoleksi.ItemHeight = 20;
            this.listBoxKoleksi.Location = new System.Drawing.Point(42, 124);
            this.listBoxKoleksi.Name = "listBoxKoleksi";
            this.listBoxKoleksi.Size = new System.Drawing.Size(204, 264);
            this.listBoxKoleksi.TabIndex = 3;
            this.listBoxKoleksi.SelectedIndexChanged += new System.EventHandler(this.listBoxKoleksi_SelectedIndexChanged);
            // 
            // buttonAdd
            // 
            this.buttonAdd.Location = new System.Drawing.Point(524, 27);
            this.buttonAdd.Name = "buttonAdd";
            this.buttonAdd.Size = new System.Drawing.Size(92, 32);
            this.buttonAdd.TabIndex = 4;
            this.buttonAdd.Text = "Add";
            this.buttonAdd.UseVisualStyleBackColor = true;
            this.buttonAdd.Click += new System.EventHandler(this.buttonAdd_Click);
            // 
            // radioButtonBiru
            // 
            this.radioButtonBiru.AutoSize = true;
            this.radioButtonBiru.Location = new System.Drawing.Point(317, 154);
            this.radioButtonBiru.Name = "radioButtonBiru";
            this.radioButtonBiru.Size = new System.Drawing.Size(113, 24);
            this.radioButtonBiru.TabIndex = 5;
            this.radioButtonBiru.TabStop = true;
            this.radioButtonBiru.Text = "Warna Biru";
            this.radioButtonBiru.UseVisualStyleBackColor = true;
            this.radioButtonBiru.CheckedChanged += new System.EventHandler(this.radioButtonBiru_CheckedChanged);
            // 
            // labelData
            // 
            this.labelData.AutoSize = true;
            this.labelData.Location = new System.Drawing.Point(38, 33);
            this.labelData.Name = "labelData";
            this.labelData.Size = new System.Drawing.Size(48, 20);
            this.labelData.TabIndex = 6;
            this.labelData.Text = "Data:";
            // 
            // textBoxData
            // 
            this.textBoxData.Location = new System.Drawing.Point(92, 27);
            this.textBoxData.Name = "textBoxData";
            this.textBoxData.Size = new System.Drawing.Size(426, 26);
            this.textBoxData.TabIndex = 7;
            // 
            // labelKoleksi
            // 
            this.labelKoleksi.AutoSize = true;
            this.labelKoleksi.Location = new System.Drawing.Point(42, 84);
            this.labelKoleksi.Name = "labelKoleksi";
            this.labelKoleksi.Size = new System.Drawing.Size(63, 20);
            this.labelKoleksi.TabIndex = 8;
            this.labelKoleksi.Text = "Koleksi:";
            // 
            // labelOutput
            // 
            this.labelOutput.AutoSize = true;
            this.labelOutput.Location = new System.Drawing.Point(281, 198);
            this.labelOutput.Name = "labelOutput";
            this.labelOutput.Size = new System.Drawing.Size(62, 20);
            this.labelOutput.TabIndex = 9;
            this.labelOutput.Text = "Output:";
            // 
            // labelHasilOutput
            // 
            this.labelHasilOutput.AutoSize = true;
            this.labelHasilOutput.Location = new System.Drawing.Point(281, 281);
            this.labelHasilOutput.Name = "labelHasilOutput";
            this.labelHasilOutput.Size = new System.Drawing.Size(29, 20);
            this.labelHasilOutput.TabIndex = 10;
            this.labelHasilOutput.Text = "[...]";
            // 
            // checkBoxAktif
            // 
            this.checkBoxAktif.AutoSize = true;
            this.checkBoxAktif.Location = new System.Drawing.Point(351, 83);
            this.checkBoxAktif.Name = "checkBoxAktif";
            this.checkBoxAktif.Size = new System.Drawing.Size(67, 24);
            this.checkBoxAktif.TabIndex = 11;
            this.checkBoxAktif.Text = "Aktif";
            this.checkBoxAktif.UseVisualStyleBackColor = true;
            this.checkBoxAktif.CheckedChanged += new System.EventHandler(this.checkBoxAktif_CheckedChanged);
            // 
            // labelSetting
            // 
            this.labelSetting.AutoSize = true;
            this.labelSetting.Location = new System.Drawing.Point(281, 84);
            this.labelSetting.Name = "labelSetting";
            this.labelSetting.Size = new System.Drawing.Size(64, 20);
            this.labelSetting.TabIndex = 12;
            this.labelSetting.Text = "Setting:";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(653, 446);
            this.Controls.Add(this.labelSetting);
            this.Controls.Add(this.checkBoxAktif);
            this.Controls.Add(this.labelHasilOutput);
            this.Controls.Add(this.labelOutput);
            this.Controls.Add(this.labelKoleksi);
            this.Controls.Add(this.textBoxData);
            this.Controls.Add(this.labelData);
            this.Controls.Add(this.radioButtonBiru);
            this.Controls.Add(this.buttonAdd);
            this.Controls.Add(this.listBoxKoleksi);
            this.Controls.Add(this.radioButtonMerah);
            this.Controls.Add(this.buttonClear);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button buttonClear;
        private System.Windows.Forms.RadioButton radioButtonMerah;
        private System.Windows.Forms.ListBox listBoxKoleksi;
        private System.Windows.Forms.Button buttonAdd;
        private System.Windows.Forms.RadioButton radioButtonBiru;
        private System.Windows.Forms.Label labelData;
        private System.Windows.Forms.TextBox textBoxData;
        private System.Windows.Forms.Label labelKoleksi;
        private System.Windows.Forms.Label labelOutput;
        private System.Windows.Forms.Label labelHasilOutput;
        private System.Windows.Forms.CheckBox checkBoxAktif;
        private System.Windows.Forms.Label labelSetting;
    }
}

