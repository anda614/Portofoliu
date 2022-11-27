
namespace DotNetOracle
{
    partial class FormaMeci
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormaMeci));
            this.dgvMeciuri = new System.Windows.Forms.DataGridView();
            this.txtNumeEchipa = new System.Windows.Forms.TextBox();
            this.txtPret = new System.Windows.Forms.TextBox();
            this.lblTipSport = new System.Windows.Forms.Label();
            this.lblNumeEchipa = new System.Windows.Forms.Label();
            this.lblDataMeci = new System.Windows.Forms.Label();
            this.lblDurata = new System.Windows.Forms.Label();
            this.lblStadion = new System.Windows.Forms.Label();
            this.lblPretBilet = new System.Windows.Forms.Label();
            this.dtpData = new System.Windows.Forms.DateTimePicker();
            this.numDurata = new System.Windows.Forms.NumericUpDown();
            this.cbStadion = new System.Windows.Forms.ComboBox();
            this.btnRezervare = new System.Windows.Forms.Button();
            this.cbTipSport = new System.Windows.Forms.ComboBox();
            this.gbRezervare = new System.Windows.Forms.GroupBox();
            this.gbActualizare = new System.Windows.Forms.GroupBox();
            this.cbTipSportEditare = new System.Windows.Forms.ComboBox();
            this.txtNumeEchipaEditare = new System.Windows.Forms.TextBox();
            this.txtPretEditare = new System.Windows.Forms.TextBox();
            this.cbStadionEditare = new System.Windows.Forms.ComboBox();
            this.lblTipSportEditare = new System.Windows.Forms.Label();
            this.numDurataEditare = new System.Windows.Forms.NumericUpDown();
            this.lblNumeEchipaEditare = new System.Windows.Forms.Label();
            this.dtpDataEditare = new System.Windows.Forms.DateTimePicker();
            this.lblDataEditare = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.lblDurataEditare = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.btnAnuleaza = new System.Windows.Forms.Button();
            this.btnActualizeazaMeci = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeciuri)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurata)).BeginInit();
            this.gbRezervare.SuspendLayout();
            this.gbActualizare.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDurataEditare)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvMeciuri
            // 
            this.dgvMeciuri.BackgroundColor = System.Drawing.Color.LemonChiffon;
            this.dgvMeciuri.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvMeciuri.Cursor = System.Windows.Forms.Cursors.Hand;
            this.dgvMeciuri.Location = new System.Drawing.Point(14, 41);
            this.dgvMeciuri.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dgvMeciuri.Name = "dgvMeciuri";
            this.dgvMeciuri.RowHeadersWidth = 51;
            this.dgvMeciuri.RowTemplate.Height = 24;
            this.dgvMeciuri.Size = new System.Drawing.Size(1081, 331);
            this.dgvMeciuri.TabIndex = 0;
            this.dgvMeciuri.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvMeciuri_CellContentClick);
            // 
            // txtNumeEchipa
            // 
            this.txtNumeEchipa.Location = new System.Drawing.Point(124, 87);
            this.txtNumeEchipa.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumeEchipa.Name = "txtNumeEchipa";
            this.txtNumeEchipa.Size = new System.Drawing.Size(224, 28);
            this.txtNumeEchipa.TabIndex = 2;
            // 
            // txtPret
            // 
            this.txtPret.Location = new System.Drawing.Point(124, 293);
            this.txtPret.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPret.Name = "txtPret";
            this.txtPret.Size = new System.Drawing.Size(224, 28);
            this.txtPret.TabIndex = 6;
            this.txtPret.TextChanged += new System.EventHandler(this.txtPret_TextChanged);
            // 
            // lblTipSport
            // 
            this.lblTipSport.AutoSize = true;
            this.lblTipSport.Location = new System.Drawing.Point(37, 38);
            this.lblTipSport.Name = "lblTipSport";
            this.lblTipSport.Size = new System.Drawing.Size(73, 21);
            this.lblTipSport.TabIndex = 7;
            this.lblTipSport.Text = "Tip Sport";
            // 
            // lblNumeEchipa
            // 
            this.lblNumeEchipa.AutoSize = true;
            this.lblNumeEchipa.Location = new System.Drawing.Point(8, 87);
            this.lblNumeEchipa.Name = "lblNumeEchipa";
            this.lblNumeEchipa.Size = new System.Drawing.Size(101, 21);
            this.lblNumeEchipa.TabIndex = 8;
            this.lblNumeEchipa.Text = "Nume Echipa";
            // 
            // lblDataMeci
            // 
            this.lblDataMeci.AutoSize = true;
            this.lblDataMeci.Location = new System.Drawing.Point(37, 144);
            this.lblDataMeci.Name = "lblDataMeci";
            this.lblDataMeci.Size = new System.Drawing.Size(80, 21);
            this.lblDataMeci.TabIndex = 9;
            this.lblDataMeci.Text = "Data Meci";
            // 
            // lblDurata
            // 
            this.lblDurata.AutoSize = true;
            this.lblDurata.Location = new System.Drawing.Point(39, 194);
            this.lblDurata.Name = "lblDurata";
            this.lblDurata.Size = new System.Drawing.Size(76, 21);
            this.lblDurata.TabIndex = 10;
            this.lblDurata.Text = "Durata(h)";
            // 
            // lblStadion
            // 
            this.lblStadion.AutoSize = true;
            this.lblStadion.Location = new System.Drawing.Point(48, 251);
            this.lblStadion.Name = "lblStadion";
            this.lblStadion.Size = new System.Drawing.Size(63, 21);
            this.lblStadion.TabIndex = 11;
            this.lblStadion.Text = "Stadion";
            // 
            // lblPretBilet
            // 
            this.lblPretBilet.AutoSize = true;
            this.lblPretBilet.Location = new System.Drawing.Point(38, 299);
            this.lblPretBilet.Name = "lblPretBilet";
            this.lblPretBilet.Size = new System.Drawing.Size(74, 21);
            this.lblPretBilet.TabIndex = 12;
            this.lblPretBilet.Text = "Pret Bilet";
            // 
            // dtpData
            // 
            this.dtpData.Location = new System.Drawing.Point(124, 144);
            this.dtpData.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpData.Name = "dtpData";
            this.dtpData.Size = new System.Drawing.Size(224, 28);
            this.dtpData.TabIndex = 13;
            // 
            // numDurata
            // 
            this.numDurata.Location = new System.Drawing.Point(124, 188);
            this.numDurata.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numDurata.Name = "numDurata";
            this.numDurata.Size = new System.Drawing.Size(225, 28);
            this.numDurata.TabIndex = 14;
            // 
            // cbStadion
            // 
            this.cbStadion.FormattingEnabled = true;
            this.cbStadion.Location = new System.Drawing.Point(124, 242);
            this.cbStadion.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbStadion.Name = "cbStadion";
            this.cbStadion.Size = new System.Drawing.Size(224, 29);
            this.cbStadion.TabIndex = 15;
            // 
            // btnRezervare
            // 
            this.btnRezervare.BackColor = System.Drawing.Color.LawnGreen;
            this.btnRezervare.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnRezervare.Location = new System.Drawing.Point(218, 344);
            this.btnRezervare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnRezervare.Name = "btnRezervare";
            this.btnRezervare.Size = new System.Drawing.Size(130, 46);
            this.btnRezervare.TabIndex = 16;
            this.btnRezervare.Text = "Rezervare";
            this.btnRezervare.UseVisualStyleBackColor = false;
            this.btnRezervare.Click += new System.EventHandler(this.btnRezervare_Click);
            // 
            // cbTipSport
            // 
            this.cbTipSport.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.cbTipSport.FormattingEnabled = true;
            this.cbTipSport.Location = new System.Drawing.Point(124, 29);
            this.cbTipSport.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTipSport.Name = "cbTipSport";
            this.cbTipSport.Size = new System.Drawing.Size(224, 29);
            this.cbTipSport.TabIndex = 17;
            // 
            // gbRezervare
            // 
            this.gbRezervare.BackColor = System.Drawing.Color.Transparent;
            this.gbRezervare.Controls.Add(this.cbTipSport);
            this.gbRezervare.Controls.Add(this.txtNumeEchipa);
            this.gbRezervare.Controls.Add(this.btnRezervare);
            this.gbRezervare.Controls.Add(this.txtPret);
            this.gbRezervare.Controls.Add(this.cbStadion);
            this.gbRezervare.Controls.Add(this.lblTipSport);
            this.gbRezervare.Controls.Add(this.numDurata);
            this.gbRezervare.Controls.Add(this.lblNumeEchipa);
            this.gbRezervare.Controls.Add(this.dtpData);
            this.gbRezervare.Controls.Add(this.lblDataMeci);
            this.gbRezervare.Controls.Add(this.lblPretBilet);
            this.gbRezervare.Controls.Add(this.lblDurata);
            this.gbRezervare.Controls.Add(this.lblStadion);
            this.gbRezervare.Location = new System.Drawing.Point(14, 390);
            this.gbRezervare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbRezervare.Name = "gbRezervare";
            this.gbRezervare.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbRezervare.Size = new System.Drawing.Size(371, 415);
            this.gbRezervare.TabIndex = 18;
            this.gbRezervare.TabStop = false;
            this.gbRezervare.Text = "Rezervare ";
            // 
            // gbActualizare
            // 
            this.gbActualizare.BackColor = System.Drawing.Color.Transparent;
            this.gbActualizare.Controls.Add(this.cbTipSportEditare);
            this.gbActualizare.Controls.Add(this.txtNumeEchipaEditare);
            this.gbActualizare.Controls.Add(this.txtPretEditare);
            this.gbActualizare.Controls.Add(this.cbStadionEditare);
            this.gbActualizare.Controls.Add(this.lblTipSportEditare);
            this.gbActualizare.Controls.Add(this.numDurataEditare);
            this.gbActualizare.Controls.Add(this.lblNumeEchipaEditare);
            this.gbActualizare.Controls.Add(this.dtpDataEditare);
            this.gbActualizare.Controls.Add(this.lblDataEditare);
            this.gbActualizare.Controls.Add(this.label4);
            this.gbActualizare.Controls.Add(this.lblDurataEditare);
            this.gbActualizare.Controls.Add(this.label6);
            this.gbActualizare.Controls.Add(this.btnAnuleaza);
            this.gbActualizare.Controls.Add(this.btnActualizeazaMeci);
            this.gbActualizare.Location = new System.Drawing.Point(644, 390);
            this.gbActualizare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbActualizare.Name = "gbActualizare";
            this.gbActualizare.Padding = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.gbActualizare.Size = new System.Drawing.Size(451, 425);
            this.gbActualizare.TabIndex = 19;
            this.gbActualizare.TabStop = false;
            this.gbActualizare.Text = "Actualizare rezervare meci";
            // 
            // cbTipSportEditare
            // 
            this.cbTipSportEditare.Font = new System.Drawing.Font("Calibri", 10.2F);
            this.cbTipSportEditare.FormattingEnabled = true;
            this.cbTipSportEditare.Location = new System.Drawing.Point(163, 35);
            this.cbTipSportEditare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbTipSportEditare.Name = "cbTipSportEditare";
            this.cbTipSportEditare.Size = new System.Drawing.Size(224, 29);
            this.cbTipSportEditare.TabIndex = 29;
            // 
            // txtNumeEchipaEditare
            // 
            this.txtNumeEchipaEditare.Location = new System.Drawing.Point(163, 93);
            this.txtNumeEchipaEditare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtNumeEchipaEditare.Name = "txtNumeEchipaEditare";
            this.txtNumeEchipaEditare.Size = new System.Drawing.Size(224, 28);
            this.txtNumeEchipaEditare.TabIndex = 18;
            // 
            // txtPretEditare
            // 
            this.txtPretEditare.Location = new System.Drawing.Point(163, 299);
            this.txtPretEditare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtPretEditare.Name = "txtPretEditare";
            this.txtPretEditare.Size = new System.Drawing.Size(224, 28);
            this.txtPretEditare.TabIndex = 19;
            // 
            // cbStadionEditare
            // 
            this.cbStadionEditare.FormattingEnabled = true;
            this.cbStadionEditare.Location = new System.Drawing.Point(163, 248);
            this.cbStadionEditare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.cbStadionEditare.Name = "cbStadionEditare";
            this.cbStadionEditare.Size = new System.Drawing.Size(224, 29);
            this.cbStadionEditare.TabIndex = 28;
            // 
            // lblTipSportEditare
            // 
            this.lblTipSportEditare.AutoSize = true;
            this.lblTipSportEditare.Location = new System.Drawing.Point(76, 45);
            this.lblTipSportEditare.Name = "lblTipSportEditare";
            this.lblTipSportEditare.Size = new System.Drawing.Size(73, 21);
            this.lblTipSportEditare.TabIndex = 20;
            this.lblTipSportEditare.Text = "Tip Sport";
            // 
            // numDurataEditare
            // 
            this.numDurataEditare.Location = new System.Drawing.Point(163, 194);
            this.numDurataEditare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.numDurataEditare.Name = "numDurataEditare";
            this.numDurataEditare.Size = new System.Drawing.Size(225, 28);
            this.numDurataEditare.TabIndex = 27;
            // 
            // lblNumeEchipaEditare
            // 
            this.lblNumeEchipaEditare.AutoSize = true;
            this.lblNumeEchipaEditare.Location = new System.Drawing.Point(47, 93);
            this.lblNumeEchipaEditare.Name = "lblNumeEchipaEditare";
            this.lblNumeEchipaEditare.Size = new System.Drawing.Size(101, 21);
            this.lblNumeEchipaEditare.TabIndex = 21;
            this.lblNumeEchipaEditare.Text = "Nume Echipa";
            // 
            // dtpDataEditare
            // 
            this.dtpDataEditare.Location = new System.Drawing.Point(163, 151);
            this.dtpDataEditare.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dtpDataEditare.Name = "dtpDataEditare";
            this.dtpDataEditare.Size = new System.Drawing.Size(224, 28);
            this.dtpDataEditare.TabIndex = 26;
            // 
            // lblDataEditare
            // 
            this.lblDataEditare.AutoSize = true;
            this.lblDataEditare.Location = new System.Drawing.Point(76, 151);
            this.lblDataEditare.Name = "lblDataEditare";
            this.lblDataEditare.Size = new System.Drawing.Size(80, 21);
            this.lblDataEditare.TabIndex = 22;
            this.lblDataEditare.Text = "Data Meci";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(78, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(74, 21);
            this.label4.TabIndex = 25;
            this.label4.Text = "Pret Bilet";
            // 
            // lblDurataEditare
            // 
            this.lblDurataEditare.AutoSize = true;
            this.lblDurataEditare.Location = new System.Drawing.Point(79, 201);
            this.lblDurataEditare.Name = "lblDurataEditare";
            this.lblDurataEditare.Size = new System.Drawing.Size(76, 21);
            this.lblDurataEditare.TabIndex = 23;
            this.lblDurataEditare.Text = "Durata(h)";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(88, 257);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 21);
            this.label6.TabIndex = 24;
            this.label6.Text = "Stadion";
            // 
            // btnAnuleaza
            // 
            this.btnAnuleaza.BackColor = System.Drawing.Color.LawnGreen;
            this.btnAnuleaza.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAnuleaza.Location = new System.Drawing.Point(225, 352);
            this.btnAnuleaza.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnAnuleaza.Name = "btnAnuleaza";
            this.btnAnuleaza.Size = new System.Drawing.Size(170, 38);
            this.btnAnuleaza.TabIndex = 1;
            this.btnAnuleaza.Text = "Anuleaza Meci";
            this.btnAnuleaza.UseVisualStyleBackColor = false;
            this.btnAnuleaza.Click += new System.EventHandler(this.btnAnuleaza_Click);
            // 
            // btnActualizeazaMeci
            // 
            this.btnActualizeazaMeci.BackColor = System.Drawing.Color.LawnGreen;
            this.btnActualizeazaMeci.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnActualizeazaMeci.Location = new System.Drawing.Point(91, 352);
            this.btnActualizeazaMeci.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.btnActualizeazaMeci.Name = "btnActualizeazaMeci";
            this.btnActualizeazaMeci.Size = new System.Drawing.Size(127, 38);
            this.btnActualizeazaMeci.TabIndex = 0;
            this.btnActualizeazaMeci.Text = "Actualizeaza";
            this.btnActualizeazaMeci.UseVisualStyleBackColor = false;
            this.btnActualizeazaMeci.Click += new System.EventHandler(this.btnActualizeazaMeci_Click);
            // 
            // FormaMeci
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 21F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("$this.BackgroundImage")));
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1125, 820);
            this.Controls.Add(this.gbActualizare);
            this.Controls.Add(this.gbRezervare);
            this.Controls.Add(this.dgvMeciuri);
            this.Font = new System.Drawing.Font("Calibri", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "FormaMeci";
            this.Text = "FormaMeci";
            this.Load += new System.EventHandler(this.FormaMeci_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvMeciuri)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.numDurata)).EndInit();
            this.gbRezervare.ResumeLayout(false);
            this.gbRezervare.PerformLayout();
            this.gbActualizare.ResumeLayout(false);
            this.gbActualizare.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.numDurataEditare)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvMeciuri;
        private System.Windows.Forms.TextBox txtNumeEchipa;
        private System.Windows.Forms.TextBox txtPret;
        private System.Windows.Forms.Label lblTipSport;
        private System.Windows.Forms.Label lblNumeEchipa;
        private System.Windows.Forms.Label lblDataMeci;
        private System.Windows.Forms.Label lblDurata;
        private System.Windows.Forms.Label lblStadion;
        private System.Windows.Forms.Label lblPretBilet;
        private System.Windows.Forms.DateTimePicker dtpData;
        private System.Windows.Forms.NumericUpDown numDurata;
        private System.Windows.Forms.ComboBox cbStadion;
        private System.Windows.Forms.Button btnRezervare;
        private System.Windows.Forms.ComboBox cbTipSport;
        private System.Windows.Forms.GroupBox gbRezervare;
        private System.Windows.Forms.GroupBox gbActualizare;
        private System.Windows.Forms.ComboBox cbTipSportEditare;
        private System.Windows.Forms.TextBox txtNumeEchipaEditare;
        private System.Windows.Forms.TextBox txtPretEditare;
        private System.Windows.Forms.ComboBox cbStadionEditare;
        private System.Windows.Forms.Label lblTipSportEditare;
        private System.Windows.Forms.NumericUpDown numDurataEditare;
        private System.Windows.Forms.Label lblNumeEchipaEditare;
        private System.Windows.Forms.DateTimePicker dtpDataEditare;
        private System.Windows.Forms.Label lblDataEditare;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label lblDurataEditare;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Button btnAnuleaza;
        private System.Windows.Forms.Button btnActualizeazaMeci;
    }
}