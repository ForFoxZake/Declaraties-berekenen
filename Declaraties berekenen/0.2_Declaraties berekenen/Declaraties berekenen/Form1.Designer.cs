namespace Declaraties_berekenen
{
    partial class Form1
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
            this.lbl_BeginUur = new System.Windows.Forms.Label();
            this.lbl_EindUue = new System.Windows.Forms.Label();
            this.tb_werkuren = new System.Windows.Forms.TextBox();
            this.lbl_urenGewerkt = new System.Windows.Forms.Label();
            this.tb_EuroPerUur = new System.Windows.Forms.TextBox();
            this.btn_bereken = new System.Windows.Forms.Button();
            this.lbl_DagBedrag = new System.Windows.Forms.Label();
            this.tb_dagbedrag = new System.Windows.Forms.TextBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.gb_gegevens = new System.Windows.Forms.GroupBox();
            this.lbl_pauze = new System.Windows.Forms.Label();
            this.tb_pauzeTijd = new System.Windows.Forms.TextBox();
            this.TimePicker_einde = new System.Windows.Forms.DateTimePicker();
            this.TimePicker_begin = new System.Windows.Forms.DateTimePicker();
            this.lbl_EuroPerUur = new System.Windows.Forms.Label();
            this.gb_WerkDag = new System.Windows.Forms.GroupBox();
            this.btn_job_toevoegen = new System.Windows.Forms.Button();
            this.tb_job_toevoegen = new System.Windows.Forms.TextBox();
            this.lbl_job = new System.Windows.Forms.Label();
            this.lbl_werkdatum = new System.Windows.Forms.Label();
            this.cb_job = new System.Windows.Forms.ComboBox();
            this.label1 = new System.Windows.Forms.Label();
            this.gb_gegevens.SuspendLayout();
            this.gb_WerkDag.SuspendLayout();
            this.SuspendLayout();
            // 
            // lbl_BeginUur
            // 
            this.lbl_BeginUur.AutoSize = true;
            this.lbl_BeginUur.Location = new System.Drawing.Point(6, 16);
            this.lbl_BeginUur.Name = "lbl_BeginUur";
            this.lbl_BeginUur.Size = new System.Drawing.Size(54, 13);
            this.lbl_BeginUur.TabIndex = 24;
            this.lbl_BeginUur.Text = "Begin Uur";
            // 
            // lbl_EindUue
            // 
            this.lbl_EindUue.AutoSize = true;
            this.lbl_EindUue.Location = new System.Drawing.Point(12, 56);
            this.lbl_EindUue.Name = "lbl_EindUue";
            this.lbl_EindUue.Size = new System.Drawing.Size(48, 13);
            this.lbl_EindUue.TabIndex = 25;
            this.lbl_EindUue.Text = "Eind Uur";
            // 
            // tb_werkuren
            // 
            this.tb_werkuren.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_werkuren.Location = new System.Drawing.Point(144, 155);
            this.tb_werkuren.Name = "tb_werkuren";
            this.tb_werkuren.ReadOnly = true;
            this.tb_werkuren.Size = new System.Drawing.Size(100, 20);
            this.tb_werkuren.TabIndex = 26;
            // 
            // lbl_urenGewerkt
            // 
            this.lbl_urenGewerkt.AutoSize = true;
            this.lbl_urenGewerkt.Location = new System.Drawing.Point(141, 139);
            this.lbl_urenGewerkt.Name = "lbl_urenGewerkt";
            this.lbl_urenGewerkt.Size = new System.Drawing.Size(96, 13);
            this.lbl_urenGewerkt.TabIndex = 27;
            this.lbl_urenGewerkt.Text = "Aantal uur gewerkt";
            // 
            // tb_EuroPerUur
            // 
            this.tb_EuroPerUur.Location = new System.Drawing.Point(9, 111);
            this.tb_EuroPerUur.Name = "tb_EuroPerUur";
            this.tb_EuroPerUur.Size = new System.Drawing.Size(100, 20);
            this.tb_EuroPerUur.TabIndex = 28;
            // 
            // btn_bereken
            // 
            this.btn_bereken.Location = new System.Drawing.Point(9, 137);
            this.btn_bereken.Name = "btn_bereken";
            this.btn_bereken.Size = new System.Drawing.Size(75, 23);
            this.btn_bereken.TabIndex = 30;
            this.btn_bereken.Text = "Bereken ";
            this.btn_bereken.UseVisualStyleBackColor = true;
            this.btn_bereken.Click += new System.EventHandler(this.btn_bereken_Click);
            // 
            // lbl_DagBedrag
            // 
            this.lbl_DagBedrag.AutoSize = true;
            this.lbl_DagBedrag.Location = new System.Drawing.Point(141, 178);
            this.lbl_DagBedrag.Name = "lbl_DagBedrag";
            this.lbl_DagBedrag.Size = new System.Drawing.Size(64, 13);
            this.lbl_DagBedrag.TabIndex = 32;
            this.lbl_DagBedrag.Text = "Dag Bedrag";
            // 
            // tb_dagbedrag
            // 
            this.tb_dagbedrag.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_dagbedrag.Location = new System.Drawing.Point(144, 194);
            this.tb_dagbedrag.Name = "tb_dagbedrag";
            this.tb_dagbedrag.ReadOnly = true;
            this.tb_dagbedrag.Size = new System.Drawing.Size(100, 20);
            this.tb_dagbedrag.TabIndex = 31;
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(6, 36);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 33;
            // 
            // gb_gegevens
            // 
            this.gb_gegevens.Controls.Add(this.lbl_pauze);
            this.gb_gegevens.Controls.Add(this.tb_pauzeTijd);
            this.gb_gegevens.Controls.Add(this.TimePicker_einde);
            this.gb_gegevens.Controls.Add(this.TimePicker_begin);
            this.gb_gegevens.Controls.Add(this.lbl_EuroPerUur);
            this.gb_gegevens.Controls.Add(this.lbl_urenGewerkt);
            this.gb_gegevens.Controls.Add(this.lbl_DagBedrag);
            this.gb_gegevens.Controls.Add(this.tb_dagbedrag);
            this.gb_gegevens.Controls.Add(this.btn_bereken);
            this.gb_gegevens.Controls.Add(this.lbl_BeginUur);
            this.gb_gegevens.Controls.Add(this.lbl_EindUue);
            this.gb_gegevens.Controls.Add(this.tb_EuroPerUur);
            this.gb_gegevens.Controls.Add(this.tb_werkuren);
            this.gb_gegevens.Location = new System.Drawing.Point(367, 29);
            this.gb_gegevens.Name = "gb_gegevens";
            this.gb_gegevens.Size = new System.Drawing.Size(350, 264);
            this.gb_gegevens.TabIndex = 34;
            this.gb_gegevens.TabStop = false;
            this.gb_gegevens.Text = "Gegevens";
            // 
            // lbl_pauze
            // 
            this.lbl_pauze.AutoSize = true;
            this.lbl_pauze.Location = new System.Drawing.Point(112, 95);
            this.lbl_pauze.Name = "lbl_pauze";
            this.lbl_pauze.Size = new System.Drawing.Size(95, 13);
            this.lbl_pauze.TabIndex = 36;
            this.lbl_pauze.Text = "Pauze (In minuten)";
            // 
            // tb_pauzeTijd
            // 
            this.tb_pauzeTijd.Location = new System.Drawing.Point(115, 111);
            this.tb_pauzeTijd.Name = "tb_pauzeTijd";
            this.tb_pauzeTijd.Size = new System.Drawing.Size(94, 20);
            this.tb_pauzeTijd.TabIndex = 36;
            // 
            // TimePicker_einde
            // 
            this.TimePicker_einde.Checked = false;
            this.TimePicker_einde.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.TimePicker_einde.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker_einde.Location = new System.Drawing.Point(9, 72);
            this.TimePicker_einde.Name = "TimePicker_einde";
            this.TimePicker_einde.Size = new System.Drawing.Size(200, 20);
            this.TimePicker_einde.TabIndex = 36;
            // 
            // TimePicker_begin
            // 
            this.TimePicker_begin.Checked = false;
            this.TimePicker_begin.CustomFormat = "hh:mm:ss";
            this.TimePicker_begin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker_begin.Location = new System.Drawing.Point(9, 34);
            this.TimePicker_begin.Name = "TimePicker_begin";
            this.TimePicker_begin.Size = new System.Drawing.Size(200, 20);
            this.TimePicker_begin.TabIndex = 35;
            // 
            // lbl_EuroPerUur
            // 
            this.lbl_EuroPerUur.AutoSize = true;
            this.lbl_EuroPerUur.Location = new System.Drawing.Point(15, 97);
            this.lbl_EuroPerUur.Name = "lbl_EuroPerUur";
            this.lbl_EuroPerUur.Size = new System.Drawing.Size(35, 13);
            this.lbl_EuroPerUur.TabIndex = 33;
            this.lbl_EuroPerUur.Text = "€/Uur";
            // 
            // gb_WerkDag
            // 
            this.gb_WerkDag.Controls.Add(this.btn_job_toevoegen);
            this.gb_WerkDag.Controls.Add(this.tb_job_toevoegen);
            this.gb_WerkDag.Controls.Add(this.lbl_job);
            this.gb_WerkDag.Controls.Add(this.lbl_werkdatum);
            this.gb_WerkDag.Controls.Add(this.cb_job);
            this.gb_WerkDag.Controls.Add(this.datePicker);
            this.gb_WerkDag.Location = new System.Drawing.Point(12, 29);
            this.gb_WerkDag.Name = "gb_WerkDag";
            this.gb_WerkDag.Size = new System.Drawing.Size(275, 264);
            this.gb_WerkDag.TabIndex = 35;
            this.gb_WerkDag.TabStop = false;
            this.gb_WerkDag.Text = "Werkdag en Job";
            // 
            // btn_job_toevoegen
            // 
            this.btn_job_toevoegen.Location = new System.Drawing.Point(6, 162);
            this.btn_job_toevoegen.Name = "btn_job_toevoegen";
            this.btn_job_toevoegen.Size = new System.Drawing.Size(121, 23);
            this.btn_job_toevoegen.TabIndex = 40;
            this.btn_job_toevoegen.Text = "Voeg Job toe aan lijst";
            this.btn_job_toevoegen.UseVisualStyleBackColor = true;
            this.btn_job_toevoegen.Click += new System.EventHandler(this.btn_job_toevoegen_Click);
            // 
            // tb_job_toevoegen
            // 
            this.tb_job_toevoegen.Location = new System.Drawing.Point(6, 132);
            this.tb_job_toevoegen.Name = "tb_job_toevoegen";
            this.tb_job_toevoegen.Size = new System.Drawing.Size(121, 20);
            this.tb_job_toevoegen.TabIndex = 39;
            // 
            // lbl_job
            // 
            this.lbl_job.AutoSize = true;
            this.lbl_job.Location = new System.Drawing.Point(6, 72);
            this.lbl_job.Name = "lbl_job";
            this.lbl_job.Size = new System.Drawing.Size(24, 13);
            this.lbl_job.TabIndex = 38;
            this.lbl_job.Text = "Job";
            // 
            // lbl_werkdatum
            // 
            this.lbl_werkdatum.AutoSize = true;
            this.lbl_werkdatum.Location = new System.Drawing.Point(7, 20);
            this.lbl_werkdatum.Name = "lbl_werkdatum";
            this.lbl_werkdatum.Size = new System.Drawing.Size(51, 13);
            this.lbl_werkdatum.TabIndex = 37;
            this.lbl_werkdatum.Text = "Werkdag";
            // 
            // cb_job
            // 
            this.cb_job.FormattingEnabled = true;
            this.cb_job.Items.AddRange(new object[] {
            "Dynamo",
            "Out of The Box"});
            this.cb_job.Location = new System.Drawing.Point(6, 87);
            this.cb_job.Name = "cb_job";
            this.cb_job.Size = new System.Drawing.Size(121, 21);
            this.cb_job.TabIndex = 36;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(216, 424);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(201, 13);
            this.label1.TabIndex = 36;
            this.label1.Text = "Opmerking: Reisvergoeding toevoegen!!!";
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(729, 446);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gb_WerkDag);
            this.Controls.Add(this.gb_gegevens);
            this.Name = "Form1";
            this.Text = "Declaraties berekenen";
            this.gb_gegevens.ResumeLayout(false);
            this.gb_gegevens.PerformLayout();
            this.gb_WerkDag.ResumeLayout(false);
            this.gb_WerkDag.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label lbl_BeginUur;
        private System.Windows.Forms.Label lbl_EindUue;
        private System.Windows.Forms.Label lbl_urenGewerkt;
        private System.Windows.Forms.TextBox tb_EuroPerUur;
        private System.Windows.Forms.Button btn_bereken;
        private System.Windows.Forms.TextBox tb_werkuren;
        private System.Windows.Forms.Label lbl_DagBedrag;
        private System.Windows.Forms.TextBox tb_dagbedrag;
        private System.Windows.Forms.DateTimePicker datePicker;
        private System.Windows.Forms.GroupBox gb_gegevens;
        private System.Windows.Forms.Label lbl_EuroPerUur;
        private System.Windows.Forms.GroupBox gb_WerkDag;
        private System.Windows.Forms.DateTimePicker TimePicker_einde;
        private System.Windows.Forms.DateTimePicker TimePicker_begin;
        private System.Windows.Forms.Label lbl_pauze;
        private System.Windows.Forms.TextBox tb_pauzeTijd;
        private System.Windows.Forms.Button btn_job_toevoegen;
        private System.Windows.Forms.TextBox tb_job_toevoegen;
        private System.Windows.Forms.Label lbl_job;
        private System.Windows.Forms.Label lbl_werkdatum;
        private System.Windows.Forms.ComboBox cb_job;
        private System.Windows.Forms.Label label1;
    }
}

