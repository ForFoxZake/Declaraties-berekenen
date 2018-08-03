using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.OleDb;

namespace Declaraties_berekenen_V2
{
    public partial class HomeUserControl : UserControl
    {
        public HomeUserControl()
        {
            InitializeComponent();

            //Timepickers custom format
            TimePicker_begin.Format = DateTimePickerFormat.Custom;
            TimePicker_begin.CustomFormat = "HH:mm";

            TimePicker_einde.Format = DateTimePickerFormat.Custom;
            TimePicker_einde.CustomFormat = "HH:mm";

            //datePicker.Format = DateTimePickerFormat.Custom;
            //datePicker.CustomFormat = "dd/MM/yyyy";
        }

        private void btn_bereken_Click(object sender, EventArgs e)
        {
            try
            {
                if (TimePicker_begin.Value == TimePicker_einde.Value) { MessageBox.Show("FOUT: -- BeginTijd en EindTijd gelijk"); }//else if begintijd

                else if (tb_EuroPerUur.Text == "") { MessageBox.Show("Bedrag per gewerkt uur niet ingevult..."); }//else if euroPerUur    

                else
                {
                    ///tijdsverschil begin en eind tijd
                    //begin en eindtijd 
                    DateTime start = TimePicker_begin.Value;
                    DateTime einde = TimePicker_einde.Value;
                    int pauze_tijd;

                    //DateTime pauze = TimePicker_pauze.Value;     
                    
                    if (tb_pauzeTijd.Text == "") { pauze_tijd = 0; } //pauze box leeg = 0 geen pauze

                    else { pauze_tijd = Convert.ToInt32(tb_pauzeTijd.Text); } //pauze tijd uit tb halen


                    TimeSpan pauze = TimeSpan.FromMinutes(pauze_tijd);
                    string fromTimeString = pauze.ToString("mm");


                    //tijdsverschil
                    TimeSpan verschil = (einde - start - pauze);
                    string tijdverschil = string.Format("{0:00}:{1:00}", verschil.Hours, verschil.Minutes);
                    tb_werkuren.Text = tijdverschil;

                    //bedrag van de dag uitrekenen
                    double bedrag = Convert.ToDouble(tb_EuroPerUur.Text) * verschil.TotalHours;
                    tb_dagbedrag.Text = Convert.ToString(Math.Round(bedrag, 2));


                    DayOfWeek dag = datePicker.Value.DayOfWeek;
                    DateTime datum = datePicker.Value.Date;
                    
                    database(dag, datum, start, einde, tijdverschil, bedrag);
                }//else
            }
            catch (Exception error) { MessageBox.Show(error.Message); }

            //MessageBox.Show(Convert.ToString(String.Format("{0} {1:d}", datePicker.Value.DayOfWeek, datePicker.Value)));
        }

        /// <summary>
        /// ////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////////
        /// </summary>
        static void database(DayOfWeek dag, DateTime datum, DateTime start, DateTime einde, string tijdverschil, double bedrag)
        {
            string query;
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=werkenInfo.accdb; Persist Security Info=False;";

            query = "INSERT INTO Metro2018(Dag,Datum,Begintijd,Eindtijd,Totaal_uren,Bedrag) VALUES ('"+dag+"', '"+ datum.ToString("dd/MM/yyyy") + "' , '"+ start.ToString("HH:mm") + "' , '"+ einde.ToString("HH:mm") + "' , '"+tijdverschil+ "' , '"+bedrag+"');";///////////////////////////////////////////Hier gebleven,
            uitvoerenQuery(connString, query);    

            /*
            query = "SELECT Voornaam, Achternaam FROM Namenlijst;";
            displayData(connString, query);
            */
            /*
            query = "DELETE FROM Namenlijst     WHERE Voornaam='Jef' AND Achternaam='Cornelissen';";
            uitvoerenQuery(connString, query);

            query = "UPDATE Namenlijst SET Achternaam='Cornelissen' WHERE Voornaam='Jef' AND Achternaam='Van Veldhoven';";
            uitvoerenQuery(connString, query);
            */
        }


        // Uitvoeren van INSERT-, UPDATE- of DELETE-query’s         
        static void uitvoerenQuery(string connString, string query)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = connString;
            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand();
                command.Connection = connection;
                command.CommandText = query;
                command.ExecuteNonQuery();
            }

            catch (OleDbException error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                connection.Close();
            }
        }



        // Uitvoeren van SELECT-query’s en tonen van inhoud         
        static void displayData(string connString, string query)
        {
            OleDbConnection connection = new OleDbConnection();
            connection.ConnectionString = connString;

            try
            {
                connection.Open();
                OleDbCommand command = new OleDbCommand(); command.Connection = connection;
                command.CommandText = query;
                OleDbDataReader reader = command.ExecuteReader();
                while (reader.Read())
                {
                    Console.WriteLine(reader[0] + " " + reader[1]);
                }
            }
            catch (OleDbException error)
            {
                Console.WriteLine(error.Message);
            }
            finally
            {
                connection.Close();
            }
        }
        //////////////////////////////////////////////////////////////////////////////////////////////////
    }
}
