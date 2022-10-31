namespace P7_1_1214062
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
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.tbNama = new System.Windows.Forms.TextBox();
            this.tbProdi = new System.Windows.Forms.TextBox();
            this.tbKelas = new System.Windows.Forms.TextBox();
            this.rbIsnain = new System.Windows.Forms.RadioButton();
            this.rbAhad = new System.Windows.Forms.RadioButton();
            this.cbKuliah = new System.Windows.Forms.CheckBox();
            this.cbLibur = new System.Windows.Forms.CheckBox();
            this.cbTuru = new System.Windows.Forms.CheckBox();
            this.btnCek = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(41, 40);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(35, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Nama";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(41, 89);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(31, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Prodi";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(41, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(33, 13);
            this.label3.TabIndex = 2;
            this.label3.Text = "Kelas";
            // 
            // tbNama
            // 
            this.tbNama.Location = new System.Drawing.Point(164, 40);
            this.tbNama.Name = "tbNama";
            this.tbNama.Size = new System.Drawing.Size(100, 20);
            this.tbNama.TabIndex = 3;
            // 
            // tbProdi
            // 
            this.tbProdi.Location = new System.Drawing.Point(164, 89);
            this.tbProdi.Name = "tbProdi";
            this.tbProdi.Size = new System.Drawing.Size(100, 20);
            this.tbProdi.TabIndex = 4;
            // 
            // tbKelas
            // 
            this.tbKelas.Location = new System.Drawing.Point(164, 142);
            this.tbKelas.Name = "tbKelas";
            this.tbKelas.Size = new System.Drawing.Size(100, 20);
            this.tbKelas.TabIndex = 5;
            // 
            // rbIsnain
            // 
            this.rbIsnain.AutoSize = true;
            this.rbIsnain.Location = new System.Drawing.Point(44, 240);
            this.rbIsnain.Name = "rbIsnain";
            this.rbIsnain.Size = new System.Drawing.Size(53, 17);
            this.rbIsnain.TabIndex = 6;
            this.rbIsnain.TabStop = true;
            this.rbIsnain.Text = "Isnain";
            this.rbIsnain.UseVisualStyleBackColor = true;
            this.rbIsnain.CheckedChanged += new System.EventHandler(this.rbIsnain_CheckedChanged);
            // 
            // rbAhad
            // 
            this.rbAhad.AutoSize = true;
            this.rbAhad.Location = new System.Drawing.Point(44, 263);
            this.rbAhad.Name = "rbAhad";
            this.rbAhad.Size = new System.Drawing.Size(50, 17);
            this.rbAhad.TabIndex = 7;
            this.rbAhad.TabStop = true;
            this.rbAhad.Text = "Ahad";
            this.rbAhad.UseVisualStyleBackColor = true;
            this.rbAhad.CheckedChanged += new System.EventHandler(this.rbAhad_CheckedChanged);
            // 
            // cbKuliah
            // 
            this.cbKuliah.AutoSize = true;
            this.cbKuliah.Location = new System.Drawing.Point(44, 316);
            this.cbKuliah.Name = "cbKuliah";
            this.cbKuliah.Size = new System.Drawing.Size(57, 17);
            this.cbKuliah.TabIndex = 8;
            this.cbKuliah.Text = "Kuli\'ah";
            this.cbKuliah.UseVisualStyleBackColor = true;
            // 
            // cbLibur
            // 
            this.cbLibur.AutoSize = true;
            this.cbLibur.Location = new System.Drawing.Point(44, 340);
            this.cbLibur.Name = "cbLibur";
            this.cbLibur.Size = new System.Drawing.Size(52, 17);
            this.cbLibur.TabIndex = 9;
            this.cbLibur.Text = "Hiling";
            this.cbLibur.UseVisualStyleBackColor = true;
            // 
            // cbTuru
            // 
            this.cbTuru.AutoSize = true;
            this.cbTuru.Location = new System.Drawing.Point(44, 364);
            this.cbTuru.Name = "cbTuru";
            this.cbTuru.Size = new System.Drawing.Size(48, 17);
            this.cbTuru.TabIndex = 10;
            this.cbTuru.Text = "Turu";
            this.cbTuru.UseVisualStyleBackColor = true;
            // 
            // btnCek
            // 
            this.btnCek.Location = new System.Drawing.Point(164, 192);
            this.btnCek.Name = "btnCek";
            this.btnCek.Size = new System.Drawing.Size(100, 23);
            this.btnCek.TabIndex = 11;
            this.btnCek.Text = "Check";
            this.btnCek.UseVisualStyleBackColor = true;
            this.btnCek.Click += new System.EventHandler(this.btnCek_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(331, 405);
            this.Controls.Add(this.btnCek);
            this.Controls.Add(this.cbTuru);
            this.Controls.Add(this.cbLibur);
            this.Controls.Add(this.cbKuliah);
            this.Controls.Add(this.rbAhad);
            this.Controls.Add(this.rbIsnain);
            this.Controls.Add(this.tbKelas);
            this.Controls.Add(this.tbProdi);
            this.Controls.Add(this.tbNama);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Name = "Form1";
            this.Text = "Form1";
            this.Load += new System.EventHandler(this.Form1_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox tbNama;
        private System.Windows.Forms.TextBox tbProdi;
        private System.Windows.Forms.TextBox tbKelas;
        private System.Windows.Forms.RadioButton rbIsnain;
        private System.Windows.Forms.RadioButton rbAhad;
        private System.Windows.Forms.CheckBox cbKuliah;
        private System.Windows.Forms.CheckBox cbLibur;
        private System.Windows.Forms.CheckBox cbTuru;
        private System.Windows.Forms.Button btnCek;
    }
}

