using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNoticeTimer
{
    class Przedmiot
    {
        private string nazwa;
        private int pozostalo_czasu_min, pozostalo_czasu_sek;
        public string Nazwa { get { return nazwa; } set { nazwa = value; } }
        public int Pozostalo_czasu_min { get { return pozostalo_czasu_min; } set { pozostalo_czasu_min = value; } }
        public int Pozostalo_czasu_sek { get { return pozostalo_czasu_sek; } set { pozostalo_czasu_sek = value; } }


    }
}
