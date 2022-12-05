using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Kalkulatorrr
{
    public partial class Anak : Form
    {
        public delegate void CreateUpdateEventHandler(KalkulatorMain k);
        public event CreateUpdateEventHandler OnCreate;
        private KalkulatorMain k;
        
        public Anak()
        {
            InitializeComponent();
        }

        public Anak(string title) : this()
        {
            this.Text = title;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            k = new KalkulatorMain();
            string hasil = "";

            if(a.Text != "" && b.Text != "")
            {
                var inta = Convert.ToInt32(a.Text);
                var intb = Convert.ToInt32(b.Text);

                switch (o.SelectedIndex)
                {
                    case 0:
                        hasil = String.Format("Hasil Penjumlahan dari {0} + {1} = {2}", a.Text, b.Text, KalkulatorMain.Penambahan(inta, intb).ToString());
                        break;
                    case 1:
                        hasil = String.Format("Hasil Penjumlahan dari {0} - {1} = {2}", a.Text, b.Text, KalkulatorMain.Pengurangan(inta, intb).ToString());
                        break;
                    case 2:
                        hasil = String.Format("Hasil Penjumlahan dari {0} x {1} = {2}", a.Text, b.Text, KalkulatorMain.Perkalian(inta, intb).ToString());
                        break;
                    case 3:
                        hasil = String.Format("Hasil Penjumlahan dari {0} : {1} = {2}", a.Text, b.Text, KalkulatorMain.Pembagian(inta, intb).ToString());
                        break;
                    default:
                        MessageBox.Show("Operasi belum dipilih", "Error", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        break;
                }

                k.Hasil = hasil.ToString();
                OnCreate(k);

                a.Clear();
                b.Clear();
            }            
        }
    }
}
