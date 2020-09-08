using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugiDeo
{
    public partial class Form2 : Form
    {
        DBModel dc = new DBModel();

        string operacija;
        int KlijentID;
        public Form2()
        {
            InitializeComponent();
            this.operacija = "Insert";
            button1.Text = "Insert";
        }

        public Form2(int KlijentID, string NazivKlijenta, string RegistarskiBroj, string Kontakt, string DodatniKomentar)
        {
            InitializeComponent();
            this.operacija = "Update";
            button1.Text = "Update";
            this.KlijentID = KlijentID;
            textBox1.Text = NazivKlijenta;
            textBox2.Text = RegistarskiBroj;
            textBox3.Text = Kontakt;
            textBox4.Text = DodatniKomentar;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            this.Hide();
            fr1.ShowDialog();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if(operacija == "Insert")
                {
                    Klijent novKlijent = new Klijent
                    {
                        NazivKlijenta = textBox1.Text,
                        RegistarskiBroj = textBox2.Text,
                        Kontakt=textBox3.Text,
                        DodatniKomentar = textBox4.Text
                    };

                    dc.Klijenti.Add(novKlijent);

                    dc.SaveChanges();

                    MessageBox.Show("Klijent uspesno upisan.");
                }

                else
                {
                    if(operacija == "Update")
                    {
                        Klijent updateKlijent = dc.Klijenti.SingleOrDefault(k => k.KlijentID == KlijentID);

                        updateKlijent.NazivKlijenta = textBox1.Text;
                        updateKlijent.RegistarskiBroj = textBox2.Text;
                        updateKlijent.Kontakt = textBox3.Text;
                        updateKlijent.DodatniKomentar = textBox4.Text;

                        dc.SaveChanges();

                        MessageBox.Show("Klijent uspesno izmenjen.");
                    }

                    else
                    {
                        MessageBox.Show("Greska.");
                    }
                }
            }

            catch (DbEntityValidationException EFex)
            {
                foreach (DbEntityValidationResult s in EFex.EntityValidationErrors)
                {
                    foreach (DbValidationError x in s.ValidationErrors)
                    {
                        MessageBox.Show(x.ErrorMessage);
                    }
                }
                dc.Dispose();
                dc = new DBModel();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
