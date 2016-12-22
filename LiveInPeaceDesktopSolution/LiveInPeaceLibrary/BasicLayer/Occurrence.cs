using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveInPeaceLibrary.BasicLayer
{
    public class Occurrence
    {
        Fine fine;
        Warning warning;
        User user;
        ResidenceUnit residenceUnit;
        String situation;
        Int32 number;
        String description;

        public Occurrence()
        {
            fine = new Fine();
            warning = new Warning();
            user = new User();
            residenceUnit = new ResidenceUnit();
        }

        public Fine Fine
        {
            get
            {
                return fine;
            }

            set
            {
                fine = value;
            }
        }

        public Warning Warning
        {
            get
            {
                return warning;
            }

            set
            {
                warning = value;
            }
        }

        public User User
        {
            get
            {
                return user;
            }

            set
            {
                user = value;
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

        public string Situation
        {
            get
            {
                return situation;
            }

            set
            {
                situation = value;
            }
        }

        public int Number
        {
            get
            {
                return number;
            }

            set
            {
                number = value;
            }
        }

        public string Description
        {
            get
            {
                return description;
            }

            set
            {
                description = value;
            }
        }
    }
}
