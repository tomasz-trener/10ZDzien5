using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace P01AplikacjaBazodanowa
{
    class Program
    {
        static void Main(string[] args)
        {
            SqlConnection connection; // służy do komunikacji z baza 
            SqlCommand command; // przechowuje polecenia SQL
            SqlDataReader dataReader; // czytanie wynikow z bazy 

            // string connectionString = "Data Source=.;Initial Catalog=a_zawodnicy;integrated security=true"; // windows auth

            string connectionString = "Data Source=.;Initial Catalog=a_zawodnicy;user id=sa;password=alx";

            connection = new SqlConnection(connectionString);
            command = new SqlCommand("SELECT * FROM zawodnicy", connection);

            connection.Open();
            dataReader = command.ExecuteReader();


            while (dataReader.Read())
            {
                string wynik = (string)dataReader.GetValue(2) + " " +
                    (string)dataReader.GetValue(3);
                Console.WriteLine(wynik);
            }



            connection.Close();

            Console.ReadKey();
        }
    }
}
