using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Declaraties_berekenen
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

            //Timepickers custom format
            TimePicker_begin.Format = DateTimePickerFormat.Custom;
            TimePicker_begin.CustomFormat = "HH:mm";

            TimePicker_einde.Format = DateTimePickerFormat.Custom;
            TimePicker_einde.CustomFormat = "HH:mm";

            datePicker.Format = DateTimePickerFormat.Custom;
            datePicker.CustomFormat = "dd/MM/yyyy";

            //weekdag + datum in string zetten
            string datum = (Convert.ToString(String.Format("{0} {1:d}", datePicker.Value.DayOfWeek, datePicker.Value)));
        }//form1

        private void btn_bereken_Click(object sender, EventArgs e)
        {
            if (TimePicker_begin.Value == TimePicker_einde.Value)
            {
                MessageBox.Show("FOUT: -- BeginTijd en EindTijd gelijk");
            }//else if begintijd

            else if (tb_EuroPerUur.Text == "")
            {
                MessageBox.Show("Bedrag per gewerkt uur niet ingevult...");
            }//else if euroPerUur    
                    
            else
            {
                ///tijdsverschil begin en eind tijd
                //begin en eindtijd 
                DateTime start = TimePicker_begin.Value;
                DateTime einde = TimePicker_einde.Value;
                int pauze_tijd;
                
                //DateTime pauze = TimePicker_pauze.Value;             
                if (tb_pauzeTijd.Text == "") //pauze box leeg = 0 geen pauze
                {
                    pauze_tijd = 0;
                }

                else
                {
                    pauze_tijd = Convert.ToInt32(tb_pauzeTijd.Text);
                }   
                            
                TimeSpan pauze = TimeSpan.FromMinutes(pauze_tijd);
                string fromTimeString = pauze.ToString("mm");

                //tijdsverschil
                TimeSpan verschil = (einde - start - pauze);
                string tijdverschil = string.Format("{0:00}:{1:00}", verschil.Hours, verschil.Minutes);
                tb_werkuren.Text = tijdverschil;
                
                //bedrag van de dag uitrekenen
                double bedrag = Convert.ToDouble(tb_EuroPerUur.Text) * verschil.TotalHours;
                tb_dagbedrag.Text = Convert.ToString(Math.Round(bedrag,2));
                ///
            }//else

            MessageBox.Show(Convert.ToString(String.Format("{0} {1:d}", datePicker.Value.DayOfWeek, datePicker.Value)));

        }//btn_bereken_Click

        private void btn_job_toevoegen_Click(object sender, EventArgs e)
        {
            string job = tb_job_toevoegen.Text;
            cb_job.Items.Add(job);
        }
    }
}