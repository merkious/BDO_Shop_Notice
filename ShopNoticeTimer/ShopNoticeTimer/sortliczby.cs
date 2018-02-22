using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ShopNoticeTimer
{
    class sortliczby : IComparer<Przedmiot>
    {
        public int Compare(Przedmiot x, Przedmiot y)
        {
            if (x.Pozostalo_czasu_min < y.Pozostalo_czasu_min)
                return -1;
            else if (x.Pozostalo_czasu_min > y.Pozostalo_czasu_min)
                return 1;
            else
            {
                if (x.Pozostalo_czasu_sek < y.Pozostalo_czasu_sek)
                    return -1;
                else if (x.Pozostalo_czasu_sek > y.Pozostalo_czasu_sek)
                    return 1;
                else
                    return 0;
            }
            
        }
    }
}
