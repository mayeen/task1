using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using View;
using Controller;
using System.Collections;
using System.Data.SqlClient;

namespace Reservation
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            UserView view = new UserView();
            view.Visible = false;
            //string connectionString = "Data Source=./;Initial Catalog=demo;Persist Security Info=True;User ID=sa;Password=ddm@TT";
            //SqlConnection conn = new SqlConnection(connectionString);

            //conn.Open();
            //string query = "SELECT * FROM reserveDemo;";
            //SqlCommand cmd = new SqlCommand(query,conn);

            //SqlDataReader reader = cmd.ExecuteReader();

            //if (reader.HasRows)
            //{
            //    while (reader.Read())
            //    {
            //        Console.WriteLine("{0}\t{1}", reader.GetInt32(0), reader.GetString(1));
            //    }
            //}
            //else
            //{
            //    Console.WriteLine("No rows found.");
            //}
            //reader.Close();
            //Console.ReadKey();

            //UserView view = new UserView();
            //view.Visible = false;

            // Add some dummy data
            IList users = new ArrayList();
          //  users.Add(new Data("Kazi Mostafa Shahriar", "Rafi", "122", "gmail", "Dhaka"));
           // users.Add(new Data("Nazmul Hasan", "Mostofa", "123", "gmail", "USA"));
           // users.Add(new Data("Refat", "Harper", "124", "gmail", "Canada"));

            UserController controller = new UserController(view, users);

            controller.LoadView();
            view.ShowDialog();
        }
    }
}
