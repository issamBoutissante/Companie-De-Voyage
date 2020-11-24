using System;
using System.Collections.Generic;
using System.Configuration;
using System.Data;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace Companie_de_voyage
{
    class GererData
    {
        SqlDataReader reader;
        static string conString = ConfigurationManager.ConnectionStrings["monConnection"].ConnectionString;
        public IEnumerable<SqlDataReader> GetData(string query)
        {
            SqlConnection connection = new SqlConnection(conString);
            SqlCommand command;
            try
            {
                connection.Open();
                command = new SqlCommand(query, connection);
                reader = command.ExecuteReader();
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            while (reader.Read())
            {
                yield return reader;
            }
            reader.Close();
            connection.Close();
        }
        public string Ajout(SqlCommand command)
        {
            SqlConnection connection = new SqlConnection(conString);
            try
            {
                using (connection = new SqlConnection(conString))
                {
                    connection.Open();
                    command.Connection = connection;
                    command.ExecuteNonQuery();
                }
               
            }
            catch(SqlException e)
            {
                return e.Message;
            }
            return "l'ajout a ete effectue";
        }
        public string Supprimer(string query)
        {
            SqlConnection connection = new SqlConnection(conString);
            SqlCommand command;
            try
            {
                using (connection = new SqlConnection(conString))
                {
                    connection.Open();
                    command = new SqlCommand(query, connection);
                    int numLine =command.ExecuteNonQuery();
                    if (numLine == 0) return "aucun ligne supreme";
                }

            }
            catch (SqlException e)
            {
                return e.Message;
            }
            return "la supprission a ete effectue";
        }
        public string Modifier(SqlCommand command)
        {
            SqlConnection connection = new SqlConnection(conString);
            if (connection.State == ConnectionState.Open) return "dija open";
            try
            {
                using (connection = new SqlConnection(conString))
                {
                    connection.Open();
                    command.Connection = connection;
                    int numLine =command.ExecuteNonQuery();
                    if (numLine == 0) return "aucun ligne modifie";
                }

            }
            catch (SqlException e)
            {
                return e.Message;
            }
            return "lal modification a ete effectue";
        }
    }
}
