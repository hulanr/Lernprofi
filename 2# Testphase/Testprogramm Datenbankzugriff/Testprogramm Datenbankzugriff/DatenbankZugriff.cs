using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Testprogramm_Datenbankzugriff
{
    class DatenbankZugriff
    {
        //fields

        List<string> Liste = new List<string>();

        //constructor
        public DatenbankZugriff()
        {
            Liste.Add("Nummer 1 Test");
            Liste.Add("Nummer 2 Test");
        }

        //properties

        public List<string> GetData
        {
            get
            {
                if(Liste != null)
                {
                    return Liste;
                }
                else
                {
                    return null;
                }
            }
        }



        //methods

    }
}
