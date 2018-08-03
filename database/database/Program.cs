using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Collections;
using System.IO;
using System.Data.OleDb;

namespace TestConsole
{
    class Program
    {
        static void Main(string[] args)
        {
            string query;
            string connString = @"Provider=Microsoft.ACE.OLEDB.12.0;Data Source=Database1.accdb; Persist Security Info=False;";

            DateTime nu = DateTime.Now;
            string voornaam = "kevin";
            string achternaam = "v3l";

            query = "INSERT INTO Namenlijst(Voornaam, Achternaam) VALUES ('"+nu+"', '"+achternaam+"');";
            uitvoerenQuery(connString, query);

            /*
            query = "UPDATE Namenlijst SET Achternaam='Cornelissen' WHERE Voornaam='Jef' AND Achternaam='Van Veldhoven';";
            uitvoerenQuery(connString, query);

            query = "SELECT Voornaam, Achternaam FROM Namenlijst;";
            displayData(connString, query);

            query = "DELETE FROM Namenlijst     WHERE Voornaam='Jef' AND Achternaam='Cornelissen';";
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
    }
} 