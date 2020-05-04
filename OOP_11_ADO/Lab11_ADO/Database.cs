using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Configuration;

namespace Lab11_ADO
{
    public static class Database
    {
        private static string connectionStringApp = ConfigurationManager.ConnectionStrings["DefaultConnection"].ConnectionString;
        static SqlConnection connection = new SqlConnection(connectionStringApp);
        static SqlCommand command;
        static TextBlock textBlock;

        public static void DoTransaction()
        {
            SqlTransaction transaction = connection.BeginTransaction();

            SqlCommand command = connection.CreateCommand();
            command.Transaction = transaction;

            try
            {
                // выполняем две отдельные команды
                command.CommandText = "insert into Planet(Name,Radius,Temperature,IsLife,IsAtmosphere,Satellites) values('Earth2', 6371, 287.2, 'Y', 'Y', 'Moon')";
                command.ExecuteNonQuery();
                command.CommandText = "insert into Planet(Name,Radius,Temperature,IsLife,IsAtmosphere,Satellites) values('Earth2', 6371, 287.2, 'Y', 'Y', 'Moon')";
                command.ExecuteNonQuery();

                // подтверждаем транзакцию
                transaction.Commit();
                textBlock.Text = "OK";
            }
            catch (Exception ex)
            {
                textBlock.Text = ex.Message;
                transaction.Rollback();
            }
        }

        public static void OpenConnection(TextBlock block)
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
            textBlock = block;
        }

        public static void OpenConnection()
        {
            if (connection.State != System.Data.ConnectionState.Open)
            {
                connection.Open();
            }
        }

        public static void CloseConnection()
        {
            connection.Close();
        }

        public static void DoCommand(SqlCommand sqlCommand)
        {
            command = sqlCommand;
            command.Connection = connection;
        }


        public static void AddDescription(string desc, string planet)
        {
            string sqlExpression = "insert into MoreInformation (Discriprion,PlanetName) values ('" + desc + "','" + planet + "')";
            textBlock.Text = "";
            if (connection.State == System.Data.ConnectionState.Open)
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                textBlock.Text += "Добавлено объектов: " + number;
            }
            else
            {
                textBlock.Text += (connection.State.ToString());
            }
        }



        public static void UpdateDescription(string desc, string planet)
        {
            string sqlExpression = "UPDATE MoreInformation SET Discriprion='" + desc + "' WHERE PlanetName='" + planet + "'";
            textBlock.Text = "";

            if (connection.State == System.Data.ConnectionState.Open)
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                int number = command.ExecuteNonQuery();
                textBlock.Text += "Измененно объектов: " + number;
            }
            else
            {
                textBlock.Text += (connection.State.ToString());
            }
        }



        public static List<MoreInformation> GetDescriptions(bool ForPlanet, string planet)
        {
            List<MoreInformation> rc = new List<MoreInformation>();
            string sqlExpression = "SELECT * FROM MoreInformation";
            if (ForPlanet)
            {
                sqlExpression += " where PlanetName='" + planet + "'";
            }
            textBlock.Text = "";

            if (connection.State == System.Data.ConnectionState.Open)
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        object id = reader.GetValue(0);
                        object descriprion = reader.GetValue(1);
                        object Planet = reader.GetValue(5);

                        rc.Add(new MoreInformation((int)id, (string)descriprion, (string)Planet));
                    }
                }
                reader.Close();
            }
            else
            {
                textBlock.Text += (connection.State.ToString());
            }
            return rc;
        }

        public static List<Satellite> GetSatellite(bool ForPlanet, string planet)
        {
            List<Satellite> rc = new List<Satellite>();
            string sqlExpression = "SELECT * FROM Satellite";
            if (ForPlanet)
            {
                sqlExpression += " where PlanetName='" + planet + "'";
            }
            textBlock.Text = "";

            if (connection.State == System.Data.ConnectionState.Open)
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        object id = reader["id"];
                        object name = reader["Name"];
                        object radius = reader["Radius"];
                        object dist = reader["Distance_to_Planet"];
                        object planetN = reader["PlanetName"];

                        rc.Add(new Satellite(int.Parse(id.ToString()), (double)radius, (string)name,
                            (double)dist, (string)planetN));
                    }
                }
                reader.Close();
            }
            else
            {
                textBlock.Text += (connection.State.ToString());
            }
            return rc;
        }

        public static List<Planet> GetPlanet()
        {
            List<Planet> rc = new List<Planet>();
            string sqlExpression = "SELECT * FROM Planet";
            textBlock.Text = "";

            if (connection.State != System.Data.ConnectionState.Open)
            {
                OpenConnection();
            }

            if (connection.State == System.Data.ConnectionState.Open)
            {
                SqlCommand command = new SqlCommand(sqlExpression, connection);
                SqlDataReader reader = command.ExecuteReader();

                if (reader.HasRows) // если есть данные
                {
                    while (reader.Read()) // построчно считываем данные
                    {
                        object id = reader["id"];
                        object name = reader["Name"];
                        object radius = reader["Radius"];
                        object temper = reader["Temperature"];
                        object IsLife = reader["IsLife"];
                        object IsAtmos = reader["IsAtmosphere"];


                        rc.Add(new Planet(int.Parse(id.ToString()), name.ToString(), (double)radius,
                            (double)temper, ((string)IsLife)[0], ((string)IsAtmos)[0]));
                    }
                }
                reader.Close();
            }
            else
            {
                textBlock.Text += (connection.State.ToString());
            }
            return rc;
        }
    }
}
