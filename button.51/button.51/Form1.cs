using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace button._51
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }
        Tiyatrocuk tiyatro;
        List<Tiyatrocuk> tiyatroList=new List<Tiyatrocuk>();
        private void Form1_Load(object sender, EventArgs e)
        {
            tiyatroList.Add(new Tiyatrocuk(1, "12.Gece", new DateTime(2024, 8, 27), 220, "İstanbul/Büyükşehir", false, 150));
            tiyatroList.Add(new Tiyatrocuk(2, "Bekçi İle Postacı", new DateTime(2024, 6, 10), 100, "İstanbul/bağcılar", false, 200));
            tiyatroList.Add(new Tiyatrocuk(3, "Bir Halk Masakı", new DateTime(2024, 6, 11), 210, "İstanbul/Küçükçekmece", true, 180));
            tiyatroList.Add(new Tiyatrocuk(4, "Cadı Kazanı", new DateTime(2024, 2, 3), 150, "İstanbul/Esenler", true, 110));
            tiyatroList.Add(new Tiyatrocuk(5, "Elma Kurdu Kırtık", new DateTime(2024, 3, 23), 140, "İstanbul/Eminönü", false, 212));

            dgvListe.DataSource = tiyatroList;
        }

        private void dgvListe_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            txtId.Text = dgvListe.CurrentRow.Cells["id"].Value.ToString();
            cmbOyunAd.Text = dgvListe.CurrentRow.Cells["ad"].Value.ToString();
            dtpTarih.Value = (DateTime)dgvListe.CurrentRow.Cells["tarih"].Value;
            nudOyunSure.Value = (Decimal)dgvListe.CurrentRow.Cells["sure"].Value;
            cmbSahne.Text = dgvListe.CurrentRow.Cells["sahne"].Value.ToString();
            chkMuzikal.Checked = (bool)dgvListe.CurrentRow.Cells["muzikal"].Value;
            txtFiyat.Text = dgvListe.CurrentRow.Cells["fiyat"].Value.ToString();

        }

        private void btnKaydet_Click(object sender, EventArgs e)
        {
            int id=Convert.ToInt32(txtId.Text);
            string ad = cmbOyunAd.Text;
            DateTime tarih=dtpTarih.Value;
            Decimal sure = nudOyunSure.Value;
            string sahne=cmbSahne.Text;
            bool muzikal = chkMuzikal.Checked;
            double fiyat=Convert.ToDouble(txtFiyat.Text);
            nudOyunSure.Value = sure;
            Tiyatrocuk yeniTiyatro = new Tiyatrocuk(id, ad, tarih, sure, sahne, muzikal, fiyat);
            tiyatroList.Add(yeniTiyatro);

        }

        private void btnSil_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir=dgvListe.SelectedRows[0];
            Tiyatrocuk secilenTiyatro = secilenSatir.DataBoundItem as Tiyatrocuk;
            DialogResult dr = MessageBox.Show("Seçtiğin tiyatro silinsin mi?", "TİYATROYU SİL", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if(dr== DialogResult.Yes)
            {
                tiyatroList.Remove(secilenTiyatro);
            }
            dgvListe.DataSource = tiyatroList.ToList();

        }

        private void btnGuncelle_Click(object sender, EventArgs e)
        {
            DataGridViewRow secilenSatir=dgvListe.SelectedRows[0];
            Tiyatrocuk secilenTiyatro = secilenSatir.DataBoundItem as Tiyatrocuk;
            int id = Convert.ToInt32(txtId.Text);
            string ad = cmbOyunAd.Text;
            DateTime tarih = dtpTarih.Value;
            Decimal sure = nudOyunSure.Value;
            string sahne = cmbSahne.Text;
            bool muzikal = chkMuzikal.Checked;
            double fiyat = Convert.ToDouble(txtFiyat.Text);
            nudOyunSure.Value = sure;
            secilenTiyatro.Id = id;
            secilenTiyatro.Ad = ad;
            secilenTiyatro.Tarih = tarih;
            secilenTiyatro.Sure = sure;
            secilenTiyatro.Sahne = sahne;
            secilenTiyatro.Muzikal = muzikal;
            secilenTiyatro.Fiyat= fiyat;
            dgvListe.DataSource = null;
            dgvListe.DataSource = tiyatroList.ToList();

        }
    }
}
