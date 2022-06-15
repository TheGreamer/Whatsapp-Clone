using System;
using System.Data;
using System.Data.SqlClient;

namespace Whatsapp
{
    public class WhatsappDB
    {
        public static SqlConnection connection = new("Data Source = .; Initial Catalog = WhatsappDB; Integrated Security = True;");

        public static int GetData(string query, int index)
        {
            connection.Open();
            SqlCommand command = new(query, connection);
            SqlDataReader reader = command.ExecuteReader();
            int value = 0;
            if (reader.Read())
                value = Convert.ToInt32(reader.GetInt32(index));
            else
                value++;
            connection.Close();

            return value;
        }

        public static void AddData(string tableName, string columns, object values)
        {
            connection.Open();

            SqlCommand addCommand = new($"INSERT INTO {tableName} ({columns}) VALUES ({values})", connection);
            addCommand.ExecuteNonQuery();

            connection.Close();
        }

        public static void UpdateData(string tableName, string column, object value, string whereColumn, object whereValue)
        {
            connection.Open();
            SqlCommand updateCommand = new($"UPDATE {tableName} SET {column} = {value} WHERE {whereColumn} = {whereValue}", connection);
            updateCommand.ExecuteNonQuery();
            connection.Close();
        }

        public static void ExecuteProcedure(string procedure, string[] parameters, SqlDbType[] dbTypes, object[] values)
        {
            connection.Open();

            SqlCommand command = new()
            {
                Connection = connection,
                CommandType = CommandType.StoredProcedure,
                CommandText = procedure
            };

            for (int i = 0; i < parameters.Length; i++)
            {
                command.Parameters.Add(parameters[i], dbTypes[i]).Value = values[i];
            }

            command.ExecuteNonQuery();
            connection.Close();
        }
    }
}