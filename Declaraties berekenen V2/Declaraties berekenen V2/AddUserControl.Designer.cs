namespace Declaraties_berekenen_V2
{
    partial class AddUserControl
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
            this.gb_WerkDag = new System.Windows.Forms.GroupBox();
            this.btn_job_toevoegen = new System.Windows.Forms.Button();
            this.tb_job_toevoegen = new System.Windows.Forms.TextBox();
            this.lbl_job = new System.Windows.Forms.Label();
            this.lbl_werkdatum = new System.Windows.Forms.Label();
            this.cb_job = new System.Windows.Forms.ComboBox();
            this.datePicker = new System.Windows.Forms.DateTimePicker();
            this.gb_WerkDag.SuspendLayout();
            this.SuspendLayout();
            // 
            // gb_WerkDag
            // 
            this.gb_WerkDag.Controls.Add(this.btn_job_toevoegen);
            this.gb_WerkDag.Controls.Add(this.tb_job_toevoegen);
            this.gb_WerkDag.Controls.Add(this.lbl_job);
            this.gb_WerkDag.Controls.Add(this.lbl_werkdatum);
            this.gb_WerkDag.Controls.Add(this.cb_job);
            this.gb_WerkDag.Controls.Add(this.datePicker);
            this.gb_WerkDag.Location = new System.Drawing.Point(152, 34);
            this.gb_WerkDag.Name = "gb_WerkDag";
            this.gb_WerkDag.Size = new System.Drawing.Size(275, 264);
            this.gb_WerkDag.TabIndex = 36;
            this.gb_WerkDag.TabStop = false;
            this.gb_WerkDag.Text = "Werkdag en Job";
            // 
            // btn_job_toevoegen
            // 
            this.btn_job_toevoegen.Location = new System.Drawing.Point(6, 162);
            this.btn_job_toevoegen.Name = "btn_job_toevoegen";
            this.btn_job_toevoegen.Size = new System.Drawing.Size(200, 73);
            this.btn_job_toevoegen.TabIndex = 40;
            this.btn_job_toevoegen.Text = "Voeg Job toe aan lijst";
            this.btn_job_toevoegen.UseVisualStyleBackColor = true;
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
            // datePicker
            // 
            this.datePicker.Location = new System.Drawing.Point(6, 36);
            this.datePicker.Name = "datePicker";
            this.datePicker.Size = new System.Drawing.Size(200, 20);
            this.datePicker.TabIndex = 33;
            // 
            // AddUserControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gb_WerkDag);
            this.Name = "AddUserControl";
            this.Size = new System.Drawing.Size(670, 393);
            this.gb_WerkDag.ResumeLayout(false);
            this.gb_WerkDag.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox gb_WerkDag;
        private System.Windows.Forms.Button btn_job_toevoegen;
        private System.Windows.Forms.TextBox tb_job_toevoegen;
        private System.Windows.Forms.Label lbl_job;
        private System.Windows.Forms.Label lbl_werkdatum;
        private System.Windows.Forms.ComboBox cb_job;
        private System.Windows.Forms.DateTimePicker datePicker;
    }
}
