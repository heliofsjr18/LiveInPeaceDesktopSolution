using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LiveInPeaceLibrary.BasicLayer
{
    public class Fine
    {
        String description;
        Double price;

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

        public double Price
        {
            get
            {
                return price;
            }

            set
            {
                price = value;
            }
        }
    }
}
