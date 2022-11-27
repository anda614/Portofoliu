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
    public partial class MainForm : Form
    {
        public MainForm()
        {
            InitializeComponent();
        }

        private void btnStadioane_Click(object sender, EventArgs e)
        {
            FormaAfisare stadioane = new FormaAfisare();
            stadioane.Show();
            //this.Hide();
        }

        private void btnMeciuri_Click(object sender, EventArgs e)
        {
            FormaMeci meciuri = new FormaMeci();
            meciuri.Show();
            //this.Hide();
        }

        private void MainForm_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            FormaSpectatori spectatori = new FormaSpectatori();
            spectatori.Show();
        }
    }
}
