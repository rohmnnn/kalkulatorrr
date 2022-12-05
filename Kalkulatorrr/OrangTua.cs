using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace Kalkulatorrr
{
    public partial class OrangTua : Form
    {
        private IList<KalkulatorMain> listOfHasil = new List<KalkulatorMain>();

        public OrangTua()
        {
            InitializeComponent();
            InisialisasiListView();
        }

        private void InisialisasiListView()
        {
            listView1.View = View.Details;
            listView1.FullRowSelect = true;
            listView1.GridLines = true;

            listView1.Columns.Add("[ Hasil ]", 352, HorizontalAlignment.Center);
        }

        private void OnCreate(KalkulatorMain k)
        {
            listOfHasil.Add(k);
            ListViewItem item = new ListViewItem(k.Hasil.ToString());
            listView1.Items.Add(item);
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Anak x = new Anak("Form Proses");
            x.OnCreate += OnCreate;
            x.ShowDialog();
        }
    }
}
