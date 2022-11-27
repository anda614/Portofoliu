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
    public partial class FormaSpectatori : Form
    {
        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;

        IStocareMeci stocareMeciuri = (IStocareMeci)new StocareFactory().GetTipStocare(typeof(Meci));
        IStocareSpectatori stocareSpectatori = (IStocareSpectatori)new StocareFactory().GetTipStocare(typeof(Spectator));
        IStocareStadion stocareStadioane = (IStocareStadion)new StocareFactory().GetTipStocare(typeof(Stadion));
        public FormaSpectatori()
        {
            InitializeComponent();
        }

        private void AfiseazaMeciuri()
        {
            try
            {
                var meciuri = stocareMeciuri.GetMeciuri();
                if (meciuri != null && meciuri.Any())
                {
                    dgvMeciuriSpectatori.DataSource = meciuri.Select(m => new { m.idMeci, m.tipSport, m.numeEchipa, m.dataMeci, m.durataInOre, m.stadionID, m.pretBilet }).ToList();

                    dgvMeciuriSpectatori.Columns["idMeci"].Visible = false;
                    dgvMeciuriSpectatori.Columns["tipSport"].HeaderText = "Tip Sport";
                    dgvMeciuriSpectatori.Columns["numeEchipa"].HeaderText = "Nume Echipa";
                    dgvMeciuriSpectatori.Columns["dataMeci"].HeaderText = "Data Meci";
                    dgvMeciuriSpectatori.Columns["durataInOre"].HeaderText = "Durata(h)";
                    dgvMeciuriSpectatori.Columns["stadionID"].HeaderText = "Stadion";
                    dgvMeciuriSpectatori.Columns["pretBilet"].HeaderText = "Pret Bilet";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void FormaSpectatori_Load(object sender, EventArgs e)
        {
            AfiseazaMeciuri();
            AfiseazaSpectatori();
        }

        private void dgvMeciuriSpectatori_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            int currentRowIndex = dgvMeciuriSpectatori.CurrentCell.RowIndex;
            string id = dgvMeciuriSpectatori[PRIMA_COLOANA, currentRowIndex].Value.ToString();

            try
            {
                Meci m = stocareMeciuri.GetMeci(Int32.Parse(id));
                if (m != null)
                { 
                    lblMeciSelectat.Text = "selectat cu succes" ;
                    List<Stadion> stadioane = stocareStadioane.GetStadioane();
                    foreach(Stadion s in stadioane)
                        if(m.stadionID == s.id)
                            lblNr.Text = s.capacitate.ToString(); 
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        private void AfiseazaSpectatori()
        {
            try
            {
                var spectatori = stocareSpectatori.GetSpectatori();
                if (spectatori != null && spectatori.Any())
                {
                    dgvBileteAchitate.DataSource = spectatori.Select(s => new { s.idSpec, s.numeSpec, s.idMeci, s.nrScaun }).ToList();

                    dgvBileteAchitate.Columns["idSpec"].Visible = false;
                    dgvBileteAchitate.Columns["numeSpec"].HeaderText = "Nume";
                    dgvBileteAchitate.Columns["idMeci"].HeaderText = "Meci";
                    dgvBileteAchitate.Columns["nrScaun"].HeaderText = "Nr.Scaun";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }
        private void btnCumparaBilet_Click(object sender, EventArgs e)
        {
            try
            {
                if (Convert.ToInt32(txtNrScaun.Text) > Convert.ToInt32(lblNr.Text) || Convert.ToInt32(txtNrScaun.Text) < 1)
                {
                    MessageBox.Show("Nr scaunului nu poate depasi capacitatea maxima a stadionului is nu poate fi <1");
                    throw new Exception();
                }

                List<Spectator> spectatori = stocareSpectatori.GetSpectatori();
                foreach(Spectator s in spectatori)
                    if(Convert.ToInt32(txtNrScaun.Text) == s.nrScaun)
                    {
                        MessageBox.Show("Scaunul este deja ocupat");
                        throw new Exception();
                    }

                int currentRowIndex = dgvMeciuriSpectatori.CurrentCell.RowIndex;
                string id = dgvMeciuriSpectatori[PRIMA_COLOANA, currentRowIndex].Value.ToString();

                var spectator = new Spectator(
                    0,
                    txtNume.Text,
                    Convert.ToInt32(id),
                    Convert.ToInt32(txtNrScaun.Text));

                /*List<Meci> meciuri = stocareMeciuri.GetMeciuri();
                List<Stadion> stadioane = stocareStadioane.GetStadioane();
                foreach (Meci m in meciuri)
                    foreach (Stadion s in stadioane)
                        if (spectator.idMeci == m.idMeci && m.stadionID == s.id && s.capacitate > 0)
                        {
                            s.capacitate = s.capacitate--;
                            stocareStadioane.UpdateStadion(s);
                        }
                        else
                        {
                            MessageBox.Show("Nu mai sunt locuri disponibile");
                            throw new Exception();
                        }*/

                var rezultat = stocareSpectatori.AddSpectator(spectator);
                if (rezultat == SUCCES)
                {
                    AfiseazaSpectatori();
                    txtNume.Text = txtNrScaun.Text = lblMeciSelectat.Text = "";
                    MessageBox.Show("Bilet achitat cu succes");
                }
                else
                {
                    MessageBox.Show("Eroare la achitare bilet");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie" + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
            try
            {
                int rowindex = dgvBileteAchitate.CurrentCell.RowIndex;
                int idSpectatorForDelete = Convert.ToInt32(dgvBileteAchitate.Rows[rowindex].Cells[0].Value);
                Spectator s = stocareSpectatori.GetSpectator(idSpectatorForDelete);
                bool rezultat = stocareSpectatori.DeleteSpectator(s);
                if (rezultat == SUCCES)
                {
                    AfiseazaSpectatori();
                    txtNumeEditare.Text = txtNrScaunEditare.Text = lblFinal.Text = "";
                    MessageBox.Show("Bilet anulat cu succes");
                }
                else MessageBox.Show("Eroare la anularea biletului");
                dgvBileteAchitate.ClearSelection();
                //gbEditare.Enabled = false;
                //gbAdaugare.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie " + ex.Message);
            }
        }

        private void dgvBileteAchitate_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*int currentRowIndex = dgvBileteAchitate.CurrentCell.RowIndex;
            string id = dgvBileteAchitate[PRIMA_COLOANA, currentRowIndex].Value.ToString();

            int currentRowIndex2 = dgvMeciuriSpectatori.CurrentCell.RowIndex;
            string id2 = dgvMeciuriSpectatori[PRIMA_COLOANA, currentRowIndex].Value.ToString();
            try
            {
                Spectator s = stocareSpectatori.GetSpectator(Int32.Parse(id));
                if (s != null)
                {
                    lblFinal.Text = "selectat cu succes";
                    txtNumeEditare.Text = s.numeSpec;
                    txtNrScaun.Text = s.nrScaun.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }*/
        }
    }
}
