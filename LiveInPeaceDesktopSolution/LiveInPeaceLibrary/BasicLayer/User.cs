using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveInPeaceLibrary.BasicLayer
{
    public class User
    {
        String name;
        Int32 age;
        String login;
        String password;
        UserType userType;
        ResidenceUnit residenceUnit;

        public string Name
        {
            get
            {
                return name;
            }

            set
            {
                name = value;
            }
        }

        public int Age
        {
            get
            {
                return age;
            }

            set
            {
                age = value;
            }
        }

        public string Login
        {
            get
            {
                return login;
            }

            set
            {
                login = value;
            }
        }

        public string Password
        {
            get
            {
                return password;
            }

            set
            {
                password = value;
            }
        }

        public UserType UserType
        {
            get
            {
                return userType;
            }

            set
            {
                userType = value;
            }
        }

        public ResidenceUnit ResidenceUnit
        {
            get
            {
                return residenceUnit;
            }

            set
            {
                residenceUnit = value;
            }
        }
    }
}
