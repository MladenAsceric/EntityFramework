using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Validation;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DrugiDeo
{
    public partial class Form3 : Form
    {
        DBModel dc = new DBModel();

        string operacija;
        int ServisID;
        int KlijentID;

        public Form3()
        {
            InitializeComponent();
            this.operacija = "Insert";
            button1.Text = "Insert";
        }

        public Form3(int ServisID, int KlijentID, DateTime DatumServisa, string OpisUsluge)
        {
            InitializeComponent();
            this.operacija = "Update";
            button1.Text = "Update";
            this.ServisID = ServisID;
            this.KlijentID = KlijentID;
            comboBox1.SelectedValue = KlijentID;
            dateTimePicker1.Value = DatumServisa;
            textBox1.Text = OpisUsluge;
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form1 fr1 = new Form1();
            this.Hide();
            fr1.ShowDialog();
        }

        private void Form3_Load(object sender, EventArgs e)
        {
            comboBox1.DataSource = dc.Klijenti.ToList<Klijent>();
            comboBox1.DisplayMember = "NazivKlijenta";
            comboBox1.ValueMember = "KlijentID";

            if (operacija == "Insert")
            {
                comboBox1.Enabled = true;              
            }

            else
            {
                if(operacija == "Update")
                {
                    comboBox1.Enabled = false;
                    comboBox1.SelectedItem = dc.Klijenti.SingleOrDefault(k => k.KlijentID == KlijentID);
                }
            }
            
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                if (operacija == "Insert")
                {
                    Servis noviServis = new Servis
                    {
                        KlijentID = (int)comboBox1.SelectedValue,
                        DatumServisa = dateTimePicker1.Value,
                        OpisUsluge = textBox1.Text
                    };

                    dc.Servisi.Add(noviServis);

                    dc.SaveChanges();

                    MessageBox.Show("Servis uspesno upisan.");
                }

                else
                {
                    if (operacija == "Update")
                    {
                        Servis updateServis = dc.Servisi.SingleOrDefault(s => s.ServisID == ServisID);

                        updateServis.DatumServisa = dateTimePicker1.Value;
                        updateServis.OpisUsluge = textBox1.Text;

                        dc.SaveChanges();

                        MessageBox.Show("Servis uspesno izmenjen.");
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
