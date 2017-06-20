using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Model;
using System.Collections;


namespace Controller
{
    public class UserController: SystemException
    {
        IUserView _view;
        IList _users;
        Data _selectedUser;


        public UserController(IUserView view, IList users)
        {
            _view = view;
            _users = users;
            view.SetController(this);
        }
        public IList Users
        {
            get { return ArrayList.ReadOnly(_users); }
        }

        private void updateUserWithViewValues(Data usr)
        {
            usr.FullName = _view.FullName;
            usr.VoterID = _view.VoterID;
            usr.PhoneNumber = _view.PhoneNumber;
            usr.DateOfBirth = _view.DateOfBirth;
            usr.PhoneNumber = _view.PhoneNumber;
        }

        public void LoadView()
        {
            _view.ClearGrid();
            _view.DisplayData();
            foreach (Data usr in _users)
                _view.AddUserToGrid(usr);
            

        }

        public void Save()
        {
            _selectedUser = new Data("",
                                    "" ,
                                    "" ,
                                    "" ,
                                    "" );
            updateUserWithViewValues(_selectedUser);

            // Add new user
            this._users.Add(_selectedUser);
            this._view.AddUserToGrid(_selectedUser);
       
   

        }


    }
}
