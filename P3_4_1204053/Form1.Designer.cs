namespace P3_4_1204053
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form1));
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.kelas = new System.Windows.Forms.GroupBox();
            this.cbKomposer = new System.Windows.Forms.CheckBox();
            this.cbVokal = new System.Windows.Forms.CheckBox();
            this.cbDrum = new System.Windows.Forms.CheckBox();
            this.cbPiano = new System.Windows.Forms.CheckBox();
            this.cbKonduktor = new System.Windows.Forms.CheckBox();
            this.cbsaxophone = new System.Windows.Forms.CheckBox();
            this.cbGitar = new System.Windows.Forms.CheckBox();
            this.cbBiola = new System.Windows.Forms.CheckBox();
            this.jadwal = new System.Windows.Forms.GroupBox();
            this.rbJadwal4 = new System.Windows.Forms.RadioButton();
            this.rbJadwal3 = new System.Windows.Forms.RadioButton();
            this.rbJadwal2 = new System.Windows.Forms.RadioButton();
            this.rbJadwal1 = new System.Windows.Forms.RadioButton();
            this.btTampilkan = new System.Windows.Forms.Button();
            this.btSelesai = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.JudulLabel = new System.Windows.Forms.Label();
            this.cbJK = new System.Windows.Forms.ComboBox();
            this.dtTglLahir = new System.Windows.Forms.DateTimePicker();
            this.txtNama = new System.Windows.Forms.TextBox();
            this.kelas.SuspendLayout();
            this.jadwal.SuspendLayout();
            this.SuspendLayout();
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(242, 114);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(152, 22);
            this.label2.TabIndex = 1;
            this.label2.Text = "Nama                  :";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(242, 165);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(151, 22);
            this.label3.TabIndex = 2;
            this.label3.Text = "Jenis Kelamin     :";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // kelas
            // 
            this.kelas.Controls.Add(this.cbKomposer);
            this.kelas.Controls.Add(this.cbVokal);
            this.kelas.Controls.Add(this.cbDrum);
            this.kelas.Controls.Add(this.cbPiano);
            this.kelas.Controls.Add(this.cbKonduktor);
            this.kelas.Controls.Add(this.cbsaxophone);
            this.kelas.Controls.Add(this.cbGitar);
            this.kelas.Controls.Add(this.cbBiola);
            this.kelas.Location = new System.Drawing.Point(37, 281);
            this.kelas.Name = "kelas";
            this.kelas.Size = new System.Drawing.Size(380, 285);
            this.kelas.TabIndex = 6;
            this.kelas.TabStop = false;
            this.kelas.Text = "Pilihan Kelas";
            this.kelas.Enter += new System.EventHandler(this.kelas_Enter);
            // 
            // cbKomposer
            // 
            this.cbKomposer.AutoSize = true;
            this.cbKomposer.Location = new System.Drawing.Point(228, 219);
            this.cbKomposer.Name = "cbKomposer";
            this.cbKomposer.Size = new System.Drawing.Size(117, 26);
            this.cbKomposer.TabIndex = 7;
            this.cbKomposer.Text = "Komposer";
            this.cbKomposer.UseVisualStyleBackColor = true;
            // 
            // cbVokal
            // 
            this.cbVokal.AutoSize = true;
            this.cbVokal.Location = new System.Drawing.Point(228, 162);
            this.cbVokal.Name = "cbVokal";
            this.cbVokal.Size = new System.Drawing.Size(81, 26);
            this.cbVokal.TabIndex = 6;
            this.cbVokal.Text = "Vokal";
            this.cbVokal.UseVisualStyleBackColor = true;
            // 
            // cbDrum
            // 
            this.cbDrum.AutoSize = true;
            this.cbDrum.Location = new System.Drawing.Point(228, 100);
            this.cbDrum.Name = "cbDrum";
            this.cbDrum.Size = new System.Drawing.Size(79, 26);
            this.cbDrum.TabIndex = 5;
            this.cbDrum.Text = "Drum";
            this.cbDrum.UseVisualStyleBackColor = true;
            // 
            // cbPiano
            // 
            this.cbPiano.AutoSize = true;
            this.cbPiano.Location = new System.Drawing.Point(228, 45);
            this.cbPiano.Name = "cbPiano";
            this.cbPiano.Size = new System.Drawing.Size(82, 26);
            this.cbPiano.TabIndex = 4;
            this.cbPiano.Text = "Piano";
            this.cbPiano.UseVisualStyleBackColor = true;
            // 
            // cbKonduktor
            // 
            this.cbKonduktor.AutoSize = true;
            this.cbKonduktor.Location = new System.Drawing.Point(26, 219);
            this.cbKonduktor.Name = "cbKonduktor";
            this.cbKonduktor.Size = new System.Drawing.Size(118, 26);
            this.cbKonduktor.TabIndex = 3;
            this.cbKonduktor.Text = "Konduktor";
            this.cbKonduktor.UseVisualStyleBackColor = true;
            // 
            // cbsaxophone
            // 
            this.cbsaxophone.AutoSize = true;
            this.cbsaxophone.Location = new System.Drawing.Point(26, 162);
            this.cbsaxophone.Name = "cbsaxophone";
            this.cbsaxophone.Size = new System.Drawing.Size(127, 26);
            this.cbsaxophone.TabIndex = 2;
            this.cbsaxophone.Text = "Saxophone";
            this.cbsaxophone.UseVisualStyleBackColor = true;
            // 
            // cbGitar
            // 
            this.cbGitar.AutoSize = true;
            this.cbGitar.Location = new System.Drawing.Point(26, 100);
            this.cbGitar.Name = "cbGitar";
            this.cbGitar.Size = new System.Drawing.Size(75, 26);
            this.cbGitar.TabIndex = 1;
            this.cbGitar.Text = "Gitar";
            this.cbGitar.UseVisualStyleBackColor = true;
            // 
            // cbBiola
            // 
            this.cbBiola.AutoSize = true;
            this.cbBiola.Location = new System.Drawing.Point(26, 45);
            this.cbBiola.Name = "cbBiola";
            this.cbBiola.Size = new System.Drawing.Size(76, 26);
            this.cbBiola.TabIndex = 0;
            this.cbBiola.Text = "Biola";
            this.cbBiola.UseVisualStyleBackColor = true;
            this.cbBiola.CheckedChanged += new System.EventHandler(this.cbBiola_CheckedChanged);
            // 
            // jadwal
            // 
            this.jadwal.Controls.Add(this.rbJadwal4);
            this.jadwal.Controls.Add(this.rbJadwal3);
            this.jadwal.Controls.Add(this.rbJadwal2);
            this.jadwal.Controls.Add(this.rbJadwal1);
            this.jadwal.Location = new System.Drawing.Point(450, 281);
            this.jadwal.Name = "jadwal";
            this.jadwal.Size = new System.Drawing.Size(359, 285);
            this.jadwal.TabIndex = 7;
            this.jadwal.TabStop = false;
            this.jadwal.Text = "Pilihan Jadwal";
            // 
            // rbJadwal4
            // 
            this.rbJadwal4.AutoSize = true;
            this.rbJadwal4.Location = new System.Drawing.Point(35, 218);
            this.rbJadwal4.Name = "rbJadwal4";
            this.rbJadwal4.Size = new System.Drawing.Size(209, 26);
            this.rbJadwal4.TabIndex = 3;
            this.rbJadwal4.TabStop = true;
            this.rbJadwal4.Text = "Minggu, 13.00 - 17.00";
            this.rbJadwal4.UseVisualStyleBackColor = true;
            // 
            // rbJadwal3
            // 
            this.rbJadwal3.AutoSize = true;
            this.rbJadwal3.Location = new System.Drawing.Point(35, 161);
            this.rbJadwal3.Name = "rbJadwal3";
            this.rbJadwal3.Size = new System.Drawing.Size(296, 26);
            this.rbJadwal3.TabIndex = 2;
            this.rbJadwal3.TabStop = true;
            this.rbJadwal3.Text = "Sabtu dan Minggu, 09.00 - 11.00";
            this.rbJadwal3.UseVisualStyleBackColor = true;
            // 
            // rbJadwal2
            // 
            this.rbJadwal2.AutoSize = true;
            this.rbJadwal2.Location = new System.Drawing.Point(35, 99);
            this.rbJadwal2.Name = "rbJadwal2";
            this.rbJadwal2.Size = new System.Drawing.Size(295, 26);
            this.rbJadwal2.TabIndex = 1;
            this.rbJadwal2.TabStop = true;
            this.rbJadwal2.Text = "Selasa dan Kamis, 14.00 - 16.00";
            this.rbJadwal2.UseVisualStyleBackColor = true;
            // 
            // rbJadwal1
            // 
            this.rbJadwal1.AutoSize = true;
            this.rbJadwal1.Font = new System.Drawing.Font("Trebuchet MS", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbJadwal1.Location = new System.Drawing.Point(35, 45);
            this.rbJadwal1.Name = "rbJadwal1";
            this.rbJadwal1.Size = new System.Drawing.Size(272, 27);
            this.rbJadwal1.TabIndex = 0;
            this.rbJadwal1.TabStop = true;
            this.rbJadwal1.Text = "Senin dan Rabu, 14.00 - 16.00\r\n";
            this.rbJadwal1.UseVisualStyleBackColor = true;
            // 
            // btTampilkan
            // 
            this.btTampilkan.BackColor = System.Drawing.Color.SaddleBrown;
            this.btTampilkan.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btTampilkan.Location = new System.Drawing.Point(291, 605);
            this.btTampilkan.Name = "btTampilkan";
            this.btTampilkan.Size = new System.Drawing.Size(108, 47);
            this.btTampilkan.TabIndex = 8;
            this.btTampilkan.Text = "Tampilkan";
            this.btTampilkan.UseVisualStyleBackColor = false;
            this.btTampilkan.Click += new System.EventHandler(this.btTampilkan_Click);
            // 
            // btSelesai
            // 
            this.btSelesai.BackColor = System.Drawing.Color.SaddleBrown;
            this.btSelesai.ForeColor = System.Drawing.SystemColors.ButtonHighlight;
            this.btSelesai.Location = new System.Drawing.Point(450, 605);
            this.btSelesai.Name = "btSelesai";
            this.btSelesai.Size = new System.Drawing.Size(106, 47);
            this.btSelesai.TabIndex = 9;
            this.btSelesai.Text = "Selesai";
            this.btSelesai.UseVisualStyleBackColor = false;
            this.btSelesai.Click += new System.EventHandler(this.btSelesai_Click);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(242, 218);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(151, 22);
            this.label4.TabIndex = 10;
            this.label4.Text = "Tanggal Lahir     :";
            this.label4.Click += new System.EventHandler(this.label4_Click);
            // 
            // JudulLabel
            // 
            this.JudulLabel.AutoSize = true;
            this.JudulLabel.BackColor = System.Drawing.Color.Transparent;
            this.JudulLabel.Font = new System.Drawing.Font("Trebuchet MS", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.JudulLabel.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(128)))), ((int)(((byte)(64)))), ((int)(((byte)(64)))));
            this.JudulLabel.Location = new System.Drawing.Point(272, 33);
            this.JudulLabel.Name = "JudulLabel";
            this.JudulLabel.Size = new System.Drawing.Size(369, 44);
            this.JudulLabel.TabIndex = 11;
            this.JudulLabel.Text = "FORM PENDAFTARAN";
            this.JudulLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // cbJK
            // 
            this.cbJK.FormattingEnabled = true;
            this.cbJK.Items.AddRange(new object[] {
            "Laki Laki",
            "Perempuan"});
            this.cbJK.Location = new System.Drawing.Point(400, 162);
            this.cbJK.Name = "cbJK";
            this.cbJK.Size = new System.Drawing.Size(231, 30);
            this.cbJK.TabIndex = 12;
            // 
            // dtTglLahir
            // 
            this.dtTglLahir.Location = new System.Drawing.Point(400, 214);
            this.dtTglLahir.Name = "dtTglLahir";
            this.dtTglLahir.Size = new System.Drawing.Size(231, 28);
            this.dtTglLahir.TabIndex = 5;
            this.dtTglLahir.ValueChanged += new System.EventHandler(this.dtTglLahir_ValueChanged);
            // 
            // txtNama
            // 
            this.txtNama.Location = new System.Drawing.Point(399, 114);
            this.txtNama.Name = "txtNama";
            this.txtNama.Size = new System.Drawing.Size(232, 28);
            this.txtNama.TabIndex = 14;
            // 
            // Form1
            // 
            this.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.AutoScaleDimensions = new System.Drawing.SizeF(10F, 22F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.SeaShell;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(862, 714);
            this.Controls.Add(this.txtNama);
            this.Controls.Add(this.dtTglLahir);
            this.Controls.Add(this.cbJK);
            this.Controls.Add(this.JudulLabel);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.btSelesai);
            this.Controls.Add(this.btTampilkan);
            this.Controls.Add(this.jadwal);
            this.Controls.Add(this.kelas);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Name = "Form1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Astra Music School";
            this.kelas.ResumeLayout(false);
            this.kelas.PerformLayout();
            this.jadwal.ResumeLayout(false);
            this.jadwal.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.GroupBox kelas;
        private System.Windows.Forms.CheckBox cbKomposer;
        private System.Windows.Forms.CheckBox cbVokal;
        private System.Windows.Forms.CheckBox cbDrum;
        private System.Windows.Forms.CheckBox cbPiano;
        private System.Windows.Forms.CheckBox cbKonduktor;
        private System.Windows.Forms.CheckBox cbsaxophone;
        private System.Windows.Forms.CheckBox cbGitar;
        private System.Windows.Forms.CheckBox cbBiola;
        private System.Windows.Forms.GroupBox jadwal;
        private System.Windows.Forms.RadioButton rbJadwal4;
        private System.Windows.Forms.RadioButton rbJadwal3;
        private System.Windows.Forms.RadioButton rbJadwal2;
        private System.Windows.Forms.RadioButton rbJadwal1;
        private System.Windows.Forms.Button btTampilkan;
        private System.Windows.Forms.Button btSelesai;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label JudulLabel;
        private System.Windows.Forms.ComboBox cbJK;
        private System.Windows.Forms.DateTimePicker dtTglLahir;
        private System.Windows.Forms.TextBox txtNama;
    }
}

