namespace KonversiSuhu
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {

        }

        private void txtSuhuAwal_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnKonversi_Click(object sender, EventArgs e)
        {
            double suhuAwal, suhuHasil = 0;
            string dariSatuan, keSatuan;

            if (!double.TryParse(txtSuhuAwal.Text, out suhuAwal))
            {
                MessageBox.Show("Masukkan angka yang valid untuk suhu!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            if (cmbDari.SelectedItem == null || cmbKe.SelectedItem == null)
            {
                MessageBox.Show("Pilih satuan suhu terlebih dahulu!", "Input Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            dariSatuan = cmbDari.SelectedItem.ToString();
            keSatuan = cmbKe.SelectedItem.ToString();

            // Logika konversi suhu
            if (dariSatuan == "Celsius")
            {
                if (keSatuan == "Fahrenheit")
                    suhuHasil = (suhuAwal * 9 / 5) + 32;
                else if (keSatuan == "Reamur")
                    suhuHasil = suhuAwal * 4 / 5;
                else
                    suhuHasil = suhuAwal;
            }
            else if (dariSatuan == "Fahrenheit")
            {
                if (keSatuan == "Celsius")
                    suhuHasil = (suhuAwal - 32) * 5 / 9;
                else if (keSatuan == "Reamur")
                    suhuHasil = (suhuAwal - 32) * 4 / 9;
                else
                    suhuHasil = suhuAwal;
            }
            else if (dariSatuan == "Reamur")
            {
                if (keSatuan == "Celsius")
                    suhuHasil = suhuAwal * 5 / 4;
                else if (keSatuan == "Fahrenheit")
                    suhuHasil = (suhuAwal * 9 / 4) + 32;
                else
                    suhuHasil = suhuAwal;
            }

            txtSuhuHasil.Text = suhuHasil.ToString("F2");
        }

        private void btnKeHalaman2_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
            form2.Show();
            this.Hide();
        }
    }
}
