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
        public object CountRows()
        {
            string nombreChauffeur="0";
            string nombreVoyage = "0";
            string nombreVehicule ="0";
            string nombreBillet ="0";
            
            SqlConnection connection = new SqlConnection(conString);
            try
            {
                SqlCommand command = new SqlCommand("select count(*) from chauffeur;", connection);
                connection.Open();
                nombreChauffeur= command.ExecuteScalar().ToString();
                command.CommandText = "select count (*) from voyage";
                nombreVoyage = command.ExecuteScalar().ToString();
                command.CommandText = "select count (*) from vehicule";
                nombreVehicule = command.ExecuteScalar().ToString();
                command.CommandText = "select count (*) from billet";
                nombreBillet = command.ExecuteScalar().ToString();
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return new {  nombreChauffeur,nombreVoyage,nombreVehicule,nombreBillet };
        }
        public string getScalar(string query)
        {
            SqlConnection connection = new SqlConnection(conString);
            string resultat = "0";
            try
            {
                SqlCommand command = new SqlCommand(query, connection);
                connection.Open();
                resultat= command.ExecuteScalar().ToString();
                
            }
            catch(SqlException e)
            {
                MessageBox.Show(e.Message);
            }
            finally
            {
                connection.Close();
            }
            return resultat;
        }
    }
}