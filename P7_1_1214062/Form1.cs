using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace P7_1_1214062
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            this.Size = new System.Drawing.Size(347, 273);
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnCek_Click(object sender, EventArgs e)
        {
            if (tbNama.Text != "")
            {
                if (tbProdi.Text != "")
                {
                    if (tbKelas.Text != "")
                    {
                        MessageBox.Show
                            ("Data Sudah Lengkap!",
                            "Informasi Data Submit",
                            MessageBoxButtons.OK, MessageBoxIcon.Information);
                            this.Size = new System.Drawing.Size(347, 444);
                    }
                    else
                    {
                        MessageBox.Show
                            ("Kelas Belum Di Isi!",
                            "Informasi Data Submit",
                            MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                else
                {
                    MessageBox.Show
                    ("Prodi Belum Di Isi!",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                MessageBox.Show
                    ("Nama Belum Di Isi!",
                    "Informasi Data Submit",
                    MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void rbIsnain_CheckedChanged(object sender, EventArgs e)
        {
            if (rbIsnain.Checked)
            {
                cbKuliah.Enabled = true; cbKuliah.Checked = false;
                cbLibur.Enabled = false; cbLibur.Checked = false;
                cbTuru.Enabled = false; cbTuru.Checked = false;
            }
        }

        private void rbAhad_CheckedChanged(object sender, EventArgs e)
        {
            if (rbAhad.Checked)
            {
                cbLibur.Enabled = true; cbLibur.Checked = false;
                cbTuru.Enabled = true; cbTuru.Checked = false;
                cbKuliah.Enabled = false; cbKuliah.Checked = false;
            }
        }
    }
}
