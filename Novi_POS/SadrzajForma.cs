using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Novi_POS
{
    public partial class SadrzajForma : Form
    {
        Database1Entities dbe = new Database1Entities();

        BindingList<tblProizvod> proizvodi = new BindingList<tblProizvod>();

        public SadrzajForma()
        {
            InitializeComponent();

            listBox1.DataSource = proizvodi;

            AddButtons();
        }

        private decimal total;

        public decimal Total
        {
            get { return total; }
            set { 
                total = value;
                txtTotal.Text = String.Format("{0:c}", total);
            }
        }
        private void AddButtons()
        {
            foreach (tblKategorija kor in dbe.tblKategorija)
            {
                Button btn = new Button();
                btn.Text = kor.naziv;
                btn.Size = new System.Drawing.Size(70, 70);
                btn.Tag = kor.kategorijaId;
                flowLayoutPanel2.Controls.Add(btn);
                this.Controls.Add(flowLayoutPanel2);
                btn.Click += btn_Click;
            }
        }

        void btn_Click(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            int kategorijaID = (int)b.Tag;

            var query = from p in dbe.tblProizvod where p.kategorijaId == kategorijaID select p;

            var queryList = query.ToList();

            foreach (tblProizvod pro in queryList)
            {
                List<Control> listControls = flowLayoutPanel1.Controls.Cast<Control>().ToList();

                foreach (Control control in listControls)
                {
                    flowLayoutPanel1.Controls.Remove(control);
                    control.Dispose();
                }
                Button btn = new Button();
                btn.Text = pro.naziv;
                btn.Size = new System.Drawing.Size(70, 70);
                flowLayoutPanel1.Controls.Add(btn);
                this.Controls.Add(flowLayoutPanel1);
                btn.Click +=btn_Click2;
                btn.Tag = pro;
            }
        }
        private void btn_Click2(object sender, EventArgs e)
        {
            Button b = (Button)sender;

            tblProizvod tp = (tblProizvod)b.Tag;

            string proizvod = tp.naziv;

            string proizvodPadded = tp.naziv.PadRight(15);

            string cenaProizvoda = String.Format("{0:c}", tp.cena);

            proizvodi.Add(tp);

            txtInfoPanel.Text = proizvodPadded + cenaProizvoda;

            total += (decimal)tp.cena;

            txtTotal.Text = String.Format("{0:c}", total);
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            string selectedItem = listBox1.GetItemText(listBox1.SelectedItem);

            txtInfoPanel.Text = selectedItem;
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            tblProizvod selected = (tblProizvod)(listBox1.SelectedItem);

            Total -= (decimal)selected.cena;

            proizvodi.Remove(selected);
        }

        private void listBox1_Format(object sender, ListControlConvertEventArgs e)
        {
            string currentProductName = ((tblProizvod)e.ListItem).naziv;

            string currentPrice = String.Format("{0:c}", ((tblProizvod)e.ListItem).cena);

            string currentProductNamePadded = currentProductName.PadRight(15);

            e.Value = currentProductNamePadded + currentPrice;
        }

        private void btnViewProducts_Click(object sender, EventArgs e)
        {
            ViewProductsForm vpf1 = new ViewProductsForm();

            vpf1.Show();
        }
    }
}
