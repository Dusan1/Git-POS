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
    public partial class loginForm : Form
    {
        public loginForm()
        {
            InitializeComponent();
        }

        Database1Entities dbe = new Database1Entities();
        private void btnOk_Click(object sender, EventArgs e)
        {
            if (txtKorIme.Text == "" || txtLozinka.Text == "")
            {
                MessageBox.Show("Please enter username and password.");
                return;
            }

            tblKorisnici l = new tblKorisnici();

            foreach (var p in dbe.tblKorisnici)
            {
                if (p.korisnickoIme == txtKorIme.Text && p.lozinka == txtLozinka.Text)
                {
                    MessageBox.Show("Successfully Logged In.");

                    SadrzajForma c = new SadrzajForma();

                    //var query = from g in dbe.tblKorisnici where g.korisnickoIme == txtKorIme.Text select g;

                    //var queryList = query.ToList();

                    c.label1.Text = "Zdravo, " + p.korisnickoIme;

                    c.Show();

                    return;
                }
            }
            foreach (var p in dbe.tblKorisnici)
            {
                if (p.korisnickoIme != txtKorIme.Text || p.lozinka != txtLozinka.Text)
                {
                    MessageBox.Show("Wrong Username and/or Password.");
                    return;
                }
            }
            // ako ovo vidis git je uspeo!!!
        }
    }
}
