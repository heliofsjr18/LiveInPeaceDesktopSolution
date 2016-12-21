using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveInPeaceLibrary.BasicLayer
{
    public class ResidenceUnit
    {
        Int32 number;
        String description;

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
