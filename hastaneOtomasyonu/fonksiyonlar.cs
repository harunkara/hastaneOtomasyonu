using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace hastaneOtomasyonu
{
    class fonksiyonlar
    {

        private static string hasta_tc = "";
        private static string doktor_tc = "";
        public static string doktortc
        {
            get { return doktor_tc; }
            set { doktor_tc = value; }
        }
        public static string hastatc
        {
            get { return hasta_tc; }
            set { hasta_tc = value; }
        }
    }
}
