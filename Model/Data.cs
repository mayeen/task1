using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Model
{
    public class Data
    {
        private string _FullName;
        public string FullName
        {
            get { return _FullName; }
            set
            {
                if (value.Length  >20)
                    Console.WriteLine("Error! Fullname must be less than 21 characters!");
                else
                    _FullName = value;
            }
        }

        private string _VoterID;
        public string VoterID
        {
            get { return _VoterID; }
            set
            {
                if (value.Length > 16)
                    Console.WriteLine("Error! VoterID must be less than 17 characters!");
                else
                    _VoterID = value;
            }
        }

        private string _PhoneNumber;
        public string PhoneNumber
        {
            get { return _PhoneNumber; }
            set
            {
                if (value.Length > 11)
                    Console.WriteLine("Error! Phone No must be less than 11 characters!");
                else
                    _PhoneNumber = value;
            }
        }

        private string _Occupation;
        public string Occupation
        {
            get { return _Occupation; }
            set
            {
                _Occupation = value;
            }
        }

        private string _DateOfBirth;
        public string DateOfBirth
        {
            get { return _DateOfBirth; }
            set
            {
                    _DateOfBirth = value;
            }
        }

        public Data(string fullname, string voterID, string phonenumber, string occupation, string dateOfBirth)
        {
            FullName = fullname;
            VoterID = voterID;
            PhoneNumber = phonenumber;
            Occupation = occupation;
            DateOfBirth = dateOfBirth;
        }


    }
}
