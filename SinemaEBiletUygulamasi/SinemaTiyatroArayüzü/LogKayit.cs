using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace SinemaTiyatroArayüzü
{
    public class LogKayit
    {
        string connectionString = @"Data Source=.;Initial Catalog=gorselproje;Integrated Security=True;TrustServerCertificate=True";

        public void AddLog(string logType, string message, string detail)
        {
            using (SqlConnection connection = new SqlConnection(connectionString))
            {
                string query = "INSERT INTO LogKayitlar (LogType, Message, Detail) VALUES (@LogType, @Message, @Detail)";
                using (SqlCommand command = new SqlCommand(query, connection))
                {
                    command.Parameters.AddWithValue("@LogType", logType);
                    command.Parameters.AddWithValue("@Message", message);
                    command.Parameters.AddWithValue("@Detail", detail);

                    connection.Open();
                    command.ExecuteNonQuery();
                }
            }
        }
    }
}
