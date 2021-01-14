using System;
using System.Collections.Generic;
using System.Text;
using System.Data;
using System.Data.SqlClient;
using System.Windows;
using System.Windows.Controls;

namespace GitHuubXD
{
    class ClassBase
    {
        public static string connetionString;
        public static SqlConnection cnn;
        public static SqlCommand command;
        public static SqlDataAdapter adapter = new SqlDataAdapter();
        public static DataTable dataTable = new DataTable();
        

        public static void openConnection()
        {
            connetionString = @"Data source=DESKTOP-9KBMJ3P; database=PersonDatabase; Integrated Security=SSPI;";
            cnn = new SqlConnection(connetionString);
            cnn.Open();

        }

        public static void closeConnection()
        {
            cnn.Close();
        }

        public static void readBase()
        {
            try
            {
                openConnection();
                command = new SqlCommand();

                command.CommandText = "SELECT [Name], [Surname], [Pesel], [City], [Adress] FROM PersonList";
                command.CommandType = CommandType.Text;
                command.Connection = cnn;

                adapter = new SqlDataAdapter(command);
                dataTable = new DataTable("PersonList");
                adapter.Fill(dataTable);
                closeConnection();
            }
            catch (Exception blad)
            {
                MessageBox.Show(blad.Message);
            }

        }

        public static void addBase(string update)
        {
            try
            {
                openConnection();
                command = new SqlCommand();
                command.CommandText = update;
                command.CommandType = CommandType.Text;
                command.Connection = cnn;
                adapter = new SqlDataAdapter(command);
                dataTable = new DataTable("PersonList");
                adapter.Fill(dataTable);
                closeConnection();

            }
            catch (Exception blad)
            { 
                MessageBox.Show(blad.Message); 
            }
        }
    }
}
