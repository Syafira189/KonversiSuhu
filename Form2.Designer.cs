namespace KonversiSuhu
{
    partial class Form2
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
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            btnKembali = new Button();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Segoe UI", 14.1F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.Location = new Point(277, 35);
            label1.Name = "label1";
            label1.Size = new Size(403, 62);
            label1.TabIndex = 0;
            label1.Text = "Tentang Aplikasi ";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(126, 207);
            label2.Name = "label2";
            label2.Size = new Size(727, 41);
            label2.TabIndex = 1;
            label2.Text = "Aplikasi ini dibuat untuk ulangan mata pelajaran MK 2";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(162, 284);
            label3.Name = "label3";
            label3.Size = new Size(666, 41);
            label3.TabIndex = 2;
            label3.Text = "Dibuat Oleh : Syafira Nurfauziyah / XI PPLG 1 / 31";
            // 
            // btnKembali
            // 
            btnKembali.Location = new Point(28, 594);
            btnKembali.Name = "btnKembali";
            btnKembali.Size = new Size(239, 62);
            btnKembali.TabIndex = 3;
            btnKembali.Text = "Kembali";
            btnKembali.UseVisualStyleBackColor = true;
            btnKembali.Click += btnKembali_Click;
            // 
            // Form2
            // 
            AutoScaleDimensions = new SizeF(17F, 41F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = SystemColors.ButtonShadow;
            ClientSize = new Size(990, 696);
            Controls.Add(btnKembali);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(label1);
            Name = "Form2";
            Text = "Form2";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private Label label2;
        private Label label3;
        private Button btnKembali;
    }
}