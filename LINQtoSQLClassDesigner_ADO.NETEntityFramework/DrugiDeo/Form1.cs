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
    public partial class Form1 : Form
    {
        DBModel dc = new DBModel();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                Cursor = Cursors.WaitCursor;
                gridKlijenti.DataSource = dc.Klijenti.ToList<Klijent>();
                Cursor = Cursors.Default;
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }     
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Form2 fr2 = new Form2();
            this.Hide();
            fr2.ShowDialog();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridKlijenti.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Morate izabrati klijenta.");
                }

                else
                {
                    Form2 fr2 = new Form2(
                        (int)gridKlijenti.SelectedRows[0].Cells[0].Value,
                        gridKlijenti.SelectedRows[0].Cells[1].Value.ToString(),
                        gridKlijenti.SelectedRows[0].Cells[2].Value.ToString(),
                        gridKlijenti.SelectedRows[0].Cells[3].Value.ToString(),
                        gridKlijenti.SelectedRows[0].Cells[4].Value.ToString()
                        );

                    this.Hide();
                    fr2.ShowDialog();
                }
            }

            catch(Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }     
        }

        private void button4_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridKlijenti.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Morate izabrati klijenta.");
                }

                else
                {
                    int KlijentID = (int)gridKlijenti.SelectedRows[0].Cells[0].Value;

                    Klijent DelKlijent = dc.Klijenti.SingleOrDefault(k => k.KlijentID == KlijentID);

                    dc.Klijenti.Remove(DelKlijent);
                    dc.SaveChanges();

                    MessageBox.Show("Klijent uspesno izbrisan.");

                    button1_Click(null, null);
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

        private void button9_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            try
            {
                if(gridKlijenti.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Morate izabrati klijenta.");
                }

                else
                {
                    int KlijentID = (int)gridKlijenti.SelectedRows[0].Cells[0].Value;

                    Klijent selKlijent = dc.Klijenti.SingleOrDefault(k => k.KlijentID == KlijentID);

                    gridServisi.DataSource = selKlijent.Servisi.ToList<Servis>();
                }
                
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            Form3 fr3 = new Form3();
            this.Hide();
            fr3.ShowDialog();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridServisi.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Morate izabrati servis.");
                }

                else
                {
                    Form3 fr3 = new Form3(
                        (int)gridServisi.SelectedRows[0].Cells[0].Value,
                        (int)gridServisi.SelectedRows[0].Cells[1].Value,
                        Convert.ToDateTime(gridServisi.SelectedRows[0].Cells[2].Value),
                        gridServisi.SelectedRows[0].Cells[3].Value.ToString()
                        );

                    this.Hide();
                    fr3.ShowDialog();

                    //MessageBox.Show(gridServisi.SelectedRows[0].Cells[2].Value.ToString());
                }
            }

            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void button8_Click(object sender, EventArgs e)
        {
            try
            {
                if (gridServisi.SelectedRows.Count == 0)
                {
                    MessageBox.Show("Morate izabrati servis.");
                }

                else
                {
                    int ServisID = (int)gridServisi.SelectedRows[0].Cells[0].Value;

                    Servis DelServis = dc.Servisi.SingleOrDefault(s => s.ServisID == ServisID);

                    dc.Servisi.Remove(DelServis);
                    dc.SaveChanges();

                    MessageBox.Show("Servis uspesno izbrisan.");

                    button5_Click(null, null);
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
