using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Model;


namespace Controller
{
    public interface IUserView
    {
        void SetController(UserController controller);
        void ClearGrid();
        void AddUserToGrid(Data user);

        string FullName { get; set; }
        string VoterID { get; set; }
        string Occupation { get; set; }
        string DateOfBirth { get; set; }
        string PhoneNumber { get; set; }
        int Age { set; }

    }
}
