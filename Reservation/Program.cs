using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
using Model;
using View;
using Controller;
using System.Collections;


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

            // Add some dummy data
            IList users = new ArrayList();
            users.Add(new Data("Kazi Mostafa Shahriar", "Rafi", "122", "gmail", "Dhaka"));
            users.Add(new Data("Nazmul Hasan", "Mostofa", "123", "gmail", "USA"));
            users.Add(new Data("Refat", "Harper", "124", "gmail", "Canada"));

            UserController controller = new UserController(view, users);

            controller.LoadView();
            view.ShowDialog();
        }
    }
}
