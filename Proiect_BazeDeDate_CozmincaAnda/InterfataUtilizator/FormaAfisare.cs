using System;
using System.Data;
using System.Linq;
using System.Windows.Forms;
using NivelAccesDate;
using LibrarieModele;
//++++++
using Oracle.DataAccess.Client;
using DotNetOracle;
//++++++
namespace InterfataUtilizator
{
    public partial class FormaAfisare : Form
    {
        private const int PRIMA_COLOANA = 0;
        private const bool SUCCES = true;

        IStocareStadion stocareStadioane = (IStocareStadion)new StocareFactory().GetTipStocare(typeof(Stadion));

        public FormaAfisare()
        {
            InitializeComponent();
            if (stocareStadioane == null)
            {
                MessageBox.Show("Eroare la initializare");
            }
        }

        private void FormaAfisare_Load(object sender, EventArgs e)
        {
            gbEditare.Enabled = false;
            lblIDEditare.Visible = false;
            txtIDEditare.Visible = false;
            AfiseazaStadioane();
            
        }
        private void FormaAfisare_FormClosed(object sender, FormClosedEventArgs e)
        {
            //Application.Exit();
            //this.Close();
            //MainForm main = new MainForm();
            //main.Show();

        }


        /*private void btnAdaugaStadion_Click(object sender, EventArgs e)
        {
            MessageBox.Show("accessed add function");
            try
            {
                var stadion = new Stadion(
                    Convert.ToInt32(txtID.Text),
                    txtNume.Text,
                    txtLocatie.Text,
                    Convert.ToInt32(txtCap.Text));

                var rezultat = stocareStadioane.AddStadion(stadion);
                if (rezultat == SUCCES)
                {
                    MessageBox.Show("Stadion adaugat");
                }
                else
                {
                    MessageBox.Show("Eroare la adaugare stadion");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie" + ex.Message);
            }
        }*/

        private void AfiseazaStadioane()
        {
            try
            {
                var stadioane = stocareStadioane.GetStadioane();
                if (stadioane != null && stadioane.Any())
                {
                    dgvStadioane.DataSource = stadioane.Select(s => new { s.id, s.nume, s.locatie, s.capacitate }).ToList();

                    dgvStadioane.Columns["id"].Visible = false;
                    dgvStadioane.Columns["nume"].HeaderText = "Nume";
                    dgvStadioane.Columns["locatie"].HeaderText = "Locatie";
                    dgvStadioane.Columns["capacitate"].HeaderText = "Capacitate Locuri";
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
        }

        //+++++++++++++++++++++++++
        private void lblLocatie_Click(object sender, EventArgs e)
        {

        }

        private void btnAdaugaStadion_Click_1(object sender, EventArgs e)
        {
            try
            {
                var stadion = new Stadion(
                    0,
                    txtNume.Text,
                    txtLocatie.Text,
                    Convert.ToInt32(txtCap.Text));

                var rezultat = stocareStadioane.AddStadion(stadion);
                if (rezultat == SUCCES)
                {
                    AfiseazaStadioane();
                    txtNume.Text = txtLocatie.Text = txtCap.Text = "";
                    MessageBox.Show("Stadion adaugat");
                }
                else
                {
                    MessageBox.Show("Eroare la adaugare stadion");
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie" + ex.Message);
            }
        }

        private void dgvStadioane_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            /*txtID.Text = dgvStadioane.Rows[e.RowIndex].Cells[0].Value.ToString();
            txtNume.Text = dgvStadioane.Rows[e.RowIndex].Cells[1].Value.ToString();
            txtLocatie.Text = dgvStadioane.Rows[e.RowIndex].Cells[2].Value.ToString();
            txtCap.Text = dgvStadioane.Rows[e.RowIndex].Cells[3].Value.ToString();*/
            int currentRowIndex = dgvStadioane.CurrentCell.RowIndex;
            string idStadion = dgvStadioane[PRIMA_COLOANA, currentRowIndex].Value.ToString();

            try
            {
                Stadion s = stocareStadioane.GetStadion(Int32.Parse(idStadion));

                //incarcarea datelor in controalele de pe forma
                if (s != null)
                {
                    txtIDEditare.Text = s.id.ToString();
                    txtNumeEditare.Text = s.nume;
                    txtLocatieEditare.Text = s.locatie;
                    txtCapacitateEditare.Text = s.capacitate.ToString();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message.ToString());
            }
            gbEditare.Enabled = true;
            gbAdaugare.Enabled = false;
        }

        /*private void btnCancelEditare_Click(object sender, EventArgs e)
        {
            gbEditare.Enabled = false;
            gbAdaugare.Enabled = true;
            dgvStadioane.ClearSelection();
        }*/

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            try
            {
                var stadion = new Stadion
                    (Convert.ToInt32(txtIDEditare.Text),
                    txtNumeEditare.Text,
                    txtLocatieEditare.Text,
                    Convert.ToInt32(txtCapacitateEditare.Text));
                var rezultat = stocareStadioane.UpdateStadion(stadion);
                if (rezultat == SUCCES)
                {
                    AfiseazaStadioane();
                    txtNumeEditare.Text = txtLocatieEditare.Text = txtCapacitateEditare.Text = "";
                    MessageBox.Show("Stadion actualizat");
                }
                else
                {
                    MessageBox.Show("Eroare la actualizare stadion");
                }
                dgvStadioane.ClearSelection();
                gbEditare.Enabled = false;
                gbAdaugare.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie " + ex.Message);
            }
        }

        private void btnDelete_Click(object sender, EventArgs e)
        {
           try
            { 
                int rowindex = dgvStadioane.CurrentCell.RowIndex;
                int idStadionForDelete = Convert.ToInt32(dgvStadioane.Rows[rowindex].Cells[0].Value);
                Stadion s = stocareStadioane.GetStadion(idStadionForDelete);
                bool rezultat = stocareStadioane.DeleteStadion(s);
                if (rezultat == SUCCES)
                {
                    AfiseazaStadioane();
                    txtNumeEditare.Text = txtLocatieEditare.Text = txtCapacitateEditare.Text = "";
                    MessageBox.Show("Stadionul a fost sters");
                }
                else MessageBox.Show("Eroare la stergerea stadionului (posibil rezervat pentru un meci)");
                dgvStadioane.ClearSelection();
                gbEditare.Enabled = false;
                gbAdaugare.Enabled = true;

            }
            catch (Exception ex)
            {
                MessageBox.Show("Exceptie " + ex.Message);
            }
        }
    }
}
