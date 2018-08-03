namespace Declaraties_berekenen_V2
{
    partial class HomeUserControl
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

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.gb_gegevens = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.lbl_pauze = new System.Windows.Forms.Label();
            this.tb_pauzeTijd = new System.Windows.Forms.TextBox();
            this.TimePicker_einde = new System.Windows.Forms.DateTimePicker();
            this.TimePicker_begin = new System.Windows.Forms.DateTimePicker();
            this.lbl_EuroPerUur = new System.Windows.Forms.Label();
            this.lbl_urenGewerkt = new System.Windows.Forms.Label();
            this.lbl_DagBedrag = new System.Windows.Forms.Label();
            this.tb_dagbedrag = new System.Windows.Forms.TextBox();
            this.btn_bereken = new System.Windows.Forms.Button();
            this.lbl_BeginUur = new System.Windows.Forms.Label();
            this.lbl_EindUue = new System.Windows.Forms.Label();
            this.tb_EuroPerUur = new System.Windows.Forms.TextBox();
            this.tb_werkuren = new System.Windows.Forms.TextBox();
            this.lbl_werkdatum = new System.Windows.Forms.Label();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.gb_gegevens.SuspendLayout();
            this.SuspendLayout();
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
            this.gb_gegevens.Controls.Add(this.label1);
            this.gb_gegevens.Controls.Add(this.comboBox1);
            this.gb_gegevens.Controls.Add(this.lbl_werkdatum);
            this.gb_gegevens.Controls.Add(this.datePicker);
            this.gb_gegevens.Controls.Add(this.btn_bereken);
            this.gb_gegevens.Controls.Add(this.lbl_BeginUur);
            this.gb_gegevens.Controls.Add(this.lbl_EindUue);
            this.gb_gegevens.Controls.Add(this.tb_EuroPerUur);
            this.gb_gegevens.Controls.Add(this.tb_werkuren);
            this.gb_gegevens.Location = new System.Drawing.Point(3, 3);
            this.gb_gegevens.Name = "gb_gegevens";
            this.gb_gegevens.Size = new System.Drawing.Size(552, 516);
            this.gb_gegevens.TabIndex = 35;
            this.gb_gegevens.TabStop = false;
            this.gb_gegevens.Text = "Gegevens";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.label1.Location = new System.Drawing.Point(9, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(145, 24);
            this.label1.TabIndex = 41;
            this.label1.Text = "Selecteer job";
            // 
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(13, 66);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(230, 21);
            this.comboBox1.TabIndex = 40;
            // 
            // lbl_pauze
            // 
            this.lbl_pauze.AutoSize = true;
            this.lbl_pauze.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_pauze.Location = new System.Drawing.Point(295, 201);
            this.lbl_pauze.Name = "lbl_pauze";
            this.lbl_pauze.Size = new System.Drawing.Size(201, 24);
            this.lbl_pauze.TabIndex = 36;
            this.lbl_pauze.Text = "Pauze (In minuten)";
            // 
            // tb_pauzeTijd
            // 
            this.tb_pauzeTijd.Location = new System.Drawing.Point(299, 229);
            this.tb_pauzeTijd.Name = "tb_pauzeTijd";
            this.tb_pauzeTijd.Size = new System.Drawing.Size(230, 20);
            this.tb_pauzeTijd.TabIndex = 38;
            // 
            // TimePicker_einde
            // 
            this.TimePicker_einde.Checked = false;
            this.TimePicker_einde.CustomFormat = "MM/dd/yyyy hh:mm:ss";
            this.TimePicker_einde.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker_einde.Location = new System.Drawing.Point(299, 144);
            this.TimePicker_einde.Name = "TimePicker_einde";
            this.TimePicker_einde.Size = new System.Drawing.Size(230, 20);
            this.TimePicker_einde.TabIndex = 36;
            // 
            // TimePicker_begin
            // 
            this.TimePicker_begin.Checked = false;
            this.TimePicker_begin.CustomFormat = "hh:mm:ss";
            this.TimePicker_begin.Format = System.Windows.Forms.DateTimePickerFormat.Time;
            this.TimePicker_begin.Location = new System.Drawing.Point(13, 144);
            this.TimePicker_begin.Name = "TimePicker_begin";
            this.TimePicker_begin.Size = new System.Drawing.Size(230, 20);
            this.TimePicker_begin.TabIndex = 35;
            // 
            // lbl_EuroPerUur
            // 
            this.lbl_EuroPerUur.AutoSize = true;
            this.lbl_EuroPerUur.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EuroPerUur.Location = new System.Drawing.Point(13, 201);
            this.lbl_EuroPerUur.Name = "lbl_EuroPerUur";
            this.lbl_EuroPerUur.Size = new System.Drawing.Size(236, 24);
            this.lbl_EuroPerUur.TabIndex = 33;
            this.lbl_EuroPerUur.Text = "Bedrag per uur (€/uur)";
            // 
            // lbl_urenGewerkt
            // 
            this.lbl_urenGewerkt.AutoSize = true;
            this.lbl_urenGewerkt.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lbl_urenGewerkt.Location = new System.Drawing.Point(21, 381);
            this.lbl_urenGewerkt.Name = "lbl_urenGewerkt";
            this.lbl_urenGewerkt.Size = new System.Drawing.Size(206, 24);
            this.lbl_urenGewerkt.TabIndex = 27;
            this.lbl_urenGewerkt.Text = "Aantal uur gewerkt";
            // 
            // lbl_DagBedrag
            // 
            this.lbl_DagBedrag.AutoSize = true;
            this.lbl_DagBedrag.Font = new System.Drawing.Font("Century Gothic", 15.75F);
            this.lbl_DagBedrag.Location = new System.Drawing.Point(21, 442);
            this.lbl_DagBedrag.Name = "lbl_DagBedrag";
            this.lbl_DagBedrag.Size = new System.Drawing.Size(134, 24);
            this.lbl_DagBedrag.TabIndex = 32;
            this.lbl_DagBedrag.Text = "Dag Bedrag";
            // 
            // tb_dagbedrag
            // 
            this.tb_dagbedrag.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_dagbedrag.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_dagbedrag.Location = new System.Drawing.Point(25, 469);
            this.tb_dagbedrag.Name = "tb_dagbedrag";
            this.tb_dagbedrag.ReadOnly = true;
            this.tb_dagbedrag.Size = new System.Drawing.Size(199, 33);
            this.tb_dagbedrag.TabIndex = 31;
            // 
            // btn_bereken
            // 
            this.btn_bereken.BackColor = System.Drawing.Color.Black;
            this.btn_bereken.FlatAppearance.BorderSize = 0;
            this.btn_bereken.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_bereken.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_bereken.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.btn_bereken.Location = new System.Drawing.Point(13, 277);
            this.btn_bereken.Name = "btn_bereken";
            this.btn_bereken.Size = new System.Drawing.Size(151, 69);
            this.btn_bereken.TabIndex = 39;
            this.btn_bereken.Text = "Bereken ";
            this.btn_bereken.UseVisualStyleBackColor = false;
            this.btn_bereken.Click += new System.EventHandler(this.btn_bereken_Click);
            // 
            // lbl_BeginUur
            // 
            this.lbl_BeginUur.AutoSize = true;
            this.lbl_BeginUur.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_BeginUur.Location = new System.Drawing.Point(9, 117);
            this.lbl_BeginUur.Name = "lbl_BeginUur";
            this.lbl_BeginUur.Size = new System.Drawing.Size(104, 24);
            this.lbl_BeginUur.TabIndex = 24;
            this.lbl_BeginUur.Text = "Begin Uur";
            // 
            // lbl_EindUue
            // 
            this.lbl_EindUue.AutoSize = true;
            this.lbl_EindUue.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_EindUue.Location = new System.Drawing.Point(295, 117);
            this.lbl_EindUue.Name = "lbl_EindUue";
            this.lbl_EindUue.Size = new System.Drawing.Size(89, 24);
            this.lbl_EindUue.TabIndex = 25;
            this.lbl_EindUue.Text = "Eind Uur";
            // 
            // tb_EuroPerUur
            // 
            this.tb_EuroPerUur.Location = new System.Drawing.Point(13, 229);
            this.tb_EuroPerUur.Name = "tb_EuroPerUur";
            this.tb_EuroPerUur.Size = new System.Drawing.Size(230, 20);
            this.tb_EuroPerUur.TabIndex = 37;
            // 
            // tb_werkuren
            // 
            this.tb_werkuren.BackColor = System.Drawing.SystemColors.Control;
            this.tb_werkuren.Cursor = System.Windows.Forms.Cursors.No;
            this.tb_werkuren.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.tb_werkuren.ForeColor = System.Drawing.SystemColors.WindowText;
            this.tb_werkuren.Location = new System.Drawing.Point(25, 408);
            this.tb_werkuren.Name = "tb_werkuren";
            this.tb_werkuren.ReadOnly = true;
            this.tb_werkuren.Size = new System.Drawing.Size(199, 33);
            this.tb_werkuren.TabIndex = 26;
            // 
            // lbl_werkdatum
            // 
            this.lbl_werkdatum.AutoSize = true;
            this.lbl_werkdatum.Font = new System.Drawing.Font("Century Gothic", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbl_werkdatum.Location = new System.Drawing.Point(295, 36);
            this.lbl_werkdatum.Name = "lbl_werkdatum";
            this.lbl_werkdatum.Size = new System.Drawing.Size(102, 24);
            this.lbl_werkdatum.TabIndex = 41;
            this.lbl_werkdatum.Text = "Werkdag";
            // 
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(299, 66);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(230, 20);
            this.datePicker.TabIndex = 40;
            // 
            // HomeUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_gegevens);
            this.Name = "HomeUserControl";
            this.Size = new System.Drawing.Size(1600, 900);
            this.gb_gegevens.ResumeLayout(false);
            this.gb_gegevens.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_gegevens;
        private System.Windows.Forms.Label lbl_pauze;
        private System.Windows.Forms.TextBox tb_pauzeTijd;
        private System.Windows.Forms.DateTimePicker TimePicker_einde;
        private System.Windows.Forms.DateTimePicker TimePicker_begin;
        private System.Windows.Forms.Label lbl_EuroPerUur;
        private System.Windows.Forms.Label lbl_urenGewerkt;
        private System.Windows.Forms.Label lbl_DagBedrag;
        private System.Windows.Forms.TextBox tb_dagbedrag;
        private System.Windows.Forms.Button btn_bereken;
        private System.Windows.Forms.Label lbl_BeginUur;
        private System.Windows.Forms.Label lbl_EindUue;
        private System.Windows.Forms.TextBox tb_EuroPerUur;
        private System.Windows.Forms.TextBox tb_werkuren;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Label lbl_werkdatum;
        private System.Windows.Forms.DateTimePicker datePicker;
    }
}
