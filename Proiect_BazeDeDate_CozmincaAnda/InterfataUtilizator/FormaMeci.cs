using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using NivelAccesDate;
using LibrarieModele;
using InterfataUtilizator;

namespace DotNetOracle
{
    public partial class FormaMeci : Form
    {
        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;

        IStocareMeci stocareMeciuri = (IStocareMeci)new StocareFactory().GetTipStocare(typeof(Meci));
        IStocareStadion stocareStadioane = (IStocareStadion)new StocareFactory().GetTipStocare(typeof(Stadion));
        public FormaMeci()
        {
            InitializeComponent();
            if (stocareMeciuri == null || stocareStadioane == null)
            {
                MessageBox.Show("Eroare la initializare");
            }
        }

        private void AfiseazaMeciuri()
        {
            try
            {
                var meciuri = stocareMeciuri.GetMeciuri();
                if (meciuri != null && meciuri.Any())
                {
                    dgvMeciuri.DataSource = meciuri.Select(m => new { m.idMeci, m.tipSport, m.numeEchipa, m.dataMeci, m.durataInOre, m.stadionID, m.pretBilet }).ToList();

                    dgvMeciuri.Columns["idMeci"].Visible = false;
                    dgvMeciuri.Columns["tipSport"].HeaderText = "Tip Sport";
                    dgvMeciuri.Columns["numeEchipa"].HeaderText = "Nume Echipa";
                    dgvMeciuri.Columns["dataMeci"].HeaderText = "Data Meci";
                    dgvMeciuri.Columns["durataInOre"].HeaderText = "Durata(h)";
                    dgvMeciuri.Columns["stadionID"].HeaderText = "Stadion";
                    dgvMeciuri.Columns["pretBilet"].HeaderText = "Pret Bilet";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void FormaMeci_Load(object sender, EventArgs e)
        {
            gbActualizare.Enabled = false;
            gbRezervare.Enabled = true;

            dtpData.Format = DateTimePickerFormat.Custom;
            dtpData.CustomFormat = "dd/MM/yyyy HH:mm";

            dtpDataEditare.Format = DateTimePickerFormat.Custom;
            dtpDataEditare.CustomFormat = "dd/MM/yyyy HH:mm";

            AfiseazaMeciuri();

            List<Stadion> stadioane = stocareStadioane.GetStadioane();
            foreach (Stadion s in stadioane)
            {
                cbStadion.Items.Add(s.nume);
                cbStadionEditare.Items.Add(s.nume);
            }

            string[] sporturi = { "Fotbal", "Rugby", "Baseball", "Tenis", "Badminton", "Altele" };
            foreach (string s in sporturi)
            {
                cbTipSport.Items.Add(s);
                cbTipSportEditare.Items.Add(s);
            }
        }

        public bool checkRezervare(Meci m)
        {
            bool verificare = true;
            List<Meci> meciuri = stocareMeciuri.GetMeciuri();

            foreach (Meci meci in meciuri)
                if (meci.dataMeci == m.dataMeci && meci.stadionID == m.stadionID)
                {
                    verificare = false;
                    break;
                }
                else if (meci.dataMeci != m.dataMeci && meci.stadionID == m.stadionID)
                {
                    for (int i = 1; i <= meci.durataInOre; i++)
                        if (meci.dataMeci.AddHours(i) == m.dataMeci)
                        {
                            verificare = false;
                            break;
                        }
                    for (int i = 1; i <= m.durataInOre; i++)
                        if (meci.dataMeci == m.dataMeci.AddHours(i))
                        {
                            verificare = false;
                            break;
                        }
                }
                else verificare = true;
            return verificare;
        }
        private void btnRezervare_Click(object sender, EventArgs e)
        {
            try
            {
                int idStadion = 0;
                List<Stadion> stadioane = stocareStadioane.GetStadioane();
                foreach (Stadion s in stadioane)
                    if(s.nume == cbStadion.SelectedItem.ToString())
                    {
                        idStadion = s.id;
                    }

                var meci = new Meci(
                0,
                cbTipSport.Text,
                txtNumeEchipa.Text,
                dtpData.Value > DateTime.Now ? dtpData.Value : throw(new Exception()),
                Convert.ToInt32(numDurata.Value),
                idStadion != 0 ? idStadion : throw(new Exception()),
                Convert.ToInt32(txtPret.Text));

                var verificare = checkRezervare(meci); 
                bool rezultat = false;
                if (verificare)
                     rezultat = stocareMeciuri.AddMeci(meci);
                else
                {
                    MessageBox.Show("Eroare: datele introduse se suprapun cu datele altui meci (verifica locatia, data, ora)");
                }

                if (rezultat == SUCCES)
                {
                    AfiseazaMeciuri();
                    txtNumeEchipa.Text = txtPret.Text = "";
                    numDurata.Value = 0;

                    MessageBox.Show("Rezervare realizata cu succes");
                }
                else
                {
                    MessageBox.Show("Eroare la rezervare");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie: " + ex.Message);
            }
        }

        private void txtPret_TextChanged(object sender, EventArgs e)
        {

        }
        private void btnActualizeazaMeci_Click(object sender, EventArgs e)
        {
            try
            {
                int idStadion = 0;
                List<Stadion> stadioane = stocareStadioane.GetStadioane();
                foreach (Stadion s in stadioane)
                    if (s.nume == cbStadionEditare.SelectedItem.ToString())
                    {
                        idStadion = s.id;
                    }

                var meci = new Meci(
                0,
                cbTipSportEditare.SelectedItem.ToString(),
                txtNumeEchipaEditare.Text,
                dtpDataEditare.Value > DateTime.Now ? dtpData.Value : throw (new Exception()),
                Convert.ToInt32(numDurataEditare.Value),
                idStadion != 0 ? idStadion : throw (new Exception()),
                Convert.ToInt32(txtPretEditare.Text));

                /*var verificare = checkRezervare(meci);
                bool rezultat = false;
                if (verificare)*/
                var rezultat = stocareMeciuri.UpdateMeci(meci);
                /*else
                {
                  MessageBox.Show("Eroare: datele introduse se suprapun cu datele altui meci (verifica locatia, data, ora)");
                }*/

                if (rezultat == SUCCES)
                {
                    AfiseazaMeciuri();
                    txtNumeEchipaEditare.Text = txtPretEditare.Text = "";
                    numDurataEditare.Value = 0;
                    MessageBox.Show("Actualizare meci realizata cu succes");
                }
                else
                MessageBox.Show("Eroare la actualizare meci");

                dgvMeciuri.ClearSelection();
                gbActualizare.Enabled = false;
                gbRezervare.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie " + ex.Message);
            }
        }

        private void dgvMeciuri_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRowIndex = dgvMeciuri.CurrentCell.RowIndex;
            string idMeci = dgvMeciuri[PRIMA_COLOANA, currentRowIndex].Value.ToString();

            try
            {
                Meci m = stocareMeciuri.GetMeci(Int32.Parse(idMeci));

                string numeStadion = "";
                List<Stadion> stadioane = stocareStadioane.GetStadioane();
                foreach (Stadion s in stadioane)
                    if (m.stadionID == s.id)
                    {
                        numeStadion = s.nume;
                    }
                //incarcarea datelor in controalele de pe forma
                if (m != null)
                {
                    cbTipSportEditare.SelectedItem = m.tipSport;
                    txtNumeEchipaEditare.Text = m.numeEchipa;
                    dtpDataEditare.Value = m.dataMeci;
                    numDurataEditare.Value = m.durataInOre;
                    cbStadionEditare.SelectedItem = numeStadion;
                    txtPretEditare.Text = m.pretBilet.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            gbActualizare.Enabled = true;
            gbRezervare.Enabled = false;
        }

        private void btnAnuleaza_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dgvMeciuri.CurrentCell.RowIndex;
                int idMeciForDelete = Convert.ToInt32(dgvMeciuri.Rows[rowindex].Cells[0].Value);
                Meci m = stocareMeciuri.GetMeci(idMeciForDelete);
                bool rezultat = stocareMeciuri.DeleteMeci(m);
                if (rezultat == SUCCES)
                {
                    AfiseazaMeciuri();
                    txtNumeEchipa.Text = txtPret.Text = "";
                    numDurata.Value = 0;
                    MessageBox.Show("Meciul a fost anulat");
                }
                else MessageBox.Show("Eroare la anularea meciului (posibil locuri rezervate pentru spectatori)");
                dgvMeciuri.ClearSelection();
                gbActualizare.Enabled = false;
                gbRezervare.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie " + ex.Message);
            }
        }
    }
}
