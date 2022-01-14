using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;


namespace SimpleDataBaseExample

{
    class Program
    {
        static void Main(string[] args)
        {
            string connectionString = @"Data Source=(localdb)\MSSQLLocalDB;Initial Catalog=ExampleDB;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            SqlConnection connection = new SqlConnection(connectionString);
            connection.Open();

            //SqlCommand command2 = new SqlCommand("INSERT INTO [dbo].[Table] (vcPassword, vcLogin) VALUES ('Petrov', '321')",connection);
            //SqlCommand command2 = new SqlCommand(@"UPDATE [dbo].[Table] SET vcLogin='Login', vcPassword='Password' WHERE ID = 1", connection);
            SqlCommand command2 = new SqlCommand("DELETE FROM [dbo].[Table] WHERE ID = 1", connection);
            int reader2 = command2.ExecuteNonQuery();
            SqlCommand command = new SqlCommand("SELECT Id,vcLogin,vcPassword FROM [dbo].[Table]", connection);
            SqlDataReader reader = command.ExecuteReader();
            while (reader.Read())//Считываем каждую строчку
                Console.WriteLine("{0}\t{1}\t{2}", reader.GetInt32(0), reader.GetString(1), reader.GetString(2));

            connection.Close();
            Console.ReadKey();
        }
    }
}
