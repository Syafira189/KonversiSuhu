namespace KonversiSuhu
{
    partial class Form1
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            label1 = new Label();
            groupBox1 = new GroupBox();
            cmbDari = new ComboBox();
            txtSuhuAwal = new TextBox();
            label3 = new Label();
            label2 = new Label();
            label4 = new Label();
            cmbKe = new ComboBox();
            btnKonversi = new Button();
            label5 = new Label();
            txtSuhuHasil = new TextBox();
            btnKeHalaman2 = new Button();
            groupBox1.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(347, 70);
            label1.Name = "label1";
            label1.Size = new Size(527, 62);
            label1.TabIndex = 0;
            label1.Text = "Aplikasi Konversi Suhu";
            label1.Click += label1_Click;
            // 
            // groupBox1
            // 
            groupBox1.Controls.Add(cmbDari);
            groupBox1.Controls.Add(txtSuhuAwal);
            groupBox1.Controls.Add(label3);
            groupBox1.Controls.Add(label2);
            groupBox1.Location = new Point(48, 205);
            groupBox1.Name = "groupBox1";
            groupBox1.Size = new Size(629, 252);
            groupBox1.TabIndex = 1;
            groupBox1.TabStop = false;
            groupBox1.Text = "Dari";
            // 
            // cmbDari
            // 
            cmbDari.FormattingEnabled = true;
            cmbDari.Items.AddRange(new object[] { "Celsius", "Fahrenheit", "Reamur" });
            cmbDari.Location = new Point(299, 155);
            cmbDari.Name = "cmbDari";
            cmbDari.Size = new Size(283, 49);
            cmbDari.TabIndex = 2;
            // 
            // txtSuhuAwal
            // 
            txtSuhuAwal.Location = new Point(299, 63);
            txtSuhuAwal.Multiline = true;
            txtSuhuAwal.Name = "txtSuhuAwal";
            txtSuhuAwal.Size = new Size(283, 44);
            txtSuhuAwal.TabIndex = 2;
            txtSuhuAwal.TextChanged += txtSuhuAwal_TextChanged;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(26, 158);
            label3.Name = "label3";
            label3.Size = new Size(186, 41);
            label3.TabIndex = 3;
            label3.Text = "Pilih Satuan :";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(26, 63);
            label2.Name = "label2";
            label2.Size = new Size(242, 41);
            label2.TabIndex = 2;
            label2.Text = "Masukkan Suhu :";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(709, 268);
            label4.Name = "label4";
            label4.Size = new Size(257, 41);
            label4.TabIndex = 2;
            label4.Text = "Dikonversikan ke :";
            label4.Click += label4_Click;
            // 
            // cmbKe
            // 
            cmbKe.FormattingEnabled = true;
            cmbKe.Items.AddRange(new object[] { "Celsius", "Fahrenheit", "Reamur" });
            cmbKe.Location = new Point(972, 268);
            cmbKe.Name = "cmbKe";
            cmbKe.Size = new Size(283, 49);
            cmbKe.TabIndex = 3;
            cmbKe.SelectedIndexChanged += comboBox2_SelectedIndexChanged;
            // 
            // btnKonversi
            // 
            btnKonversi.Location = new Point(709, 363);
            btnKonversi.Name = "btnKonversi";
            btnKonversi.Size = new Size(546, 81);
            btnKonversi.TabIndex = 4;
            btnKonversi.Text = "Konversikan";
            btnKonversi.UseVisualStyleBackColor = true;
            btnKonversi.Click += btnKonversi_Click;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(709, 491);
            label5.Name = "label5";
            label5.Size = new Size(215, 41);
            label5.TabIndex = 5;
            label5.Text = "Hasil Konversi :";
            // 
            // txtSuhuHasil
            // 
            txtSuhuHasil.Location = new Point(972, 488);
            txtSuhuHasil.Multiline = true;
            txtSuhuHasil.Name = "txtSuhuHasil";
            txtSuhuHasil.Size = new Size(283, 44);
            txtSuhuHasil.TabIndex = 6;
            // 
            // btnKeHalaman2
            // 
            btnKeHalaman2.Location = new Point(1073, 617);
            btnKeHalaman2.Name = "btnKeHalaman2";
            btnKeHalaman2.Size = new Size(227, 59);
            btnKeHalaman2.TabIndex = 7;
            btnKeHalaman2.Text = "Halaman 2";
            btnKeHalaman2.UseVisualStyleBackColor = true;
            btnKeHalaman2.Click += btnKeHalaman2_Click;
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(1343, 713);
            Controls.Add(btnKeHalaman2);
            Controls.Add(txtSuhuHasil);
            Controls.Add(label5);
            Controls.Add(btnKonversi);
            Controls.Add(cmbKe);
            Controls.Add(label4);
            Controls.Add(groupBox1);
            Controls.Add(label1);
            Name = "Form1";
            Text = "Form1";
            groupBox1.ResumeLayout(false);
            groupBox1.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private GroupBox groupBox1;
        private Label label2;
        private ComboBox cmbDari;
        private TextBox txtSuhuAwal;
        private Label label3;
        private Label label4;
        private ComboBox cmbKe;
        private Button btnKonversi;
        private Label label5;
        private TextBox txtSuhuHasil;
        private Button btnKeHalaman2;
    }
}
