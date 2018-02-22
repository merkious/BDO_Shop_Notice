using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ShopNoticeTimer
{
    class Mechanizm
    {
        private List<string> wyswietlana_lista;
        private List<Przedmiot> lista_przedmiotow;
        private int licznik_blokdy_messagebox;
        public List<string> Wyswietlana_Lista { get { return wyswietlana_lista; } }
        public List<Przedmiot> Lista_przedmiotow { get { return lista_przedmiotow; } }

        public Mechanizm()
        {
            wyswietlana_lista = new List<string>();
            lista_przedmiotow = new List<Przedmiot>();
            licznik_blokdy_messagebox = 0;
        }
        private void okno(string co_biduje)
        {
            MessageBox.Show(
                        co_biduje,
                        "BID BID BID",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information,
                        MessageBoxDefaultButton.Button1,
                        MessageBoxOptions.DefaultDesktopOnly);
        }
        public List<string> usun(int index)
        {
            lista_przedmiotow.RemoveAt(index);
            return Odswierz_listBox();
        }
        public List<string> Tick(bool powiadomienie, bool wycisz_dzwiek)
        {
            string nazwa = "Na market wchodzą:\n";
            if (licznik_blokdy_messagebox > 0) licznik_blokdy_messagebox--;
            for (int i = 0; i < lista_przedmiotow.Count(); i++)
            {
                if (lista_przedmiotow[i].Pozostalo_czasu_min == 0)
                {
                    nazwa += lista_przedmiotow[i].Nazwa + "\n";
                }
            }
            for (int i = 0; i < lista_przedmiotow.Count(); i++)
            {

                if (lista_przedmiotow[i].Pozostalo_czasu_sek != 0)
                {
                    lista_przedmiotow[i].Pozostalo_czasu_sek -= 1;
                }
                else
                {
                    if (lista_przedmiotow[i].Pozostalo_czasu_min == 0 
                        && lista_przedmiotow[i].Pozostalo_czasu_sek == 0)
                    {
                        if (powiadomienie == true && licznik_blokdy_messagebox == 0)
                        {
                            Thread T1 = new Thread(() => okno(nazwa));
                            T1.Start();
                            licznik_blokdy_messagebox = 59;
                        }
                        if(wycisz_dzwiek==false)
                        System.Media.SystemSounds.Beep.Play();
                    }
                    if (lista_przedmiotow[i].Pozostalo_czasu_min <= -2)
                    {
                        lista_przedmiotow.RemoveAt(i);
                    }
                    else
                    {
                        lista_przedmiotow[i].Pozostalo_czasu_min -= 1;
                        lista_przedmiotow[i].Pozostalo_czasu_sek = 59;
                    }
                }                               
            }
            return Odswierz_listBox();
        }
        public List<string> DodajPrzedmiot(string nazwa_przedmiotu, int czas)
        {
            lista_przedmiotow.Add(new Przedmiot() { Pozostalo_czasu_min = czas,
                Pozostalo_czasu_sek = 0,
                Nazwa = nazwa_przedmiotu });
            sortliczby sort = new sortliczby();
            lista_przedmiotow.Sort(sort);
            return Odswierz_listBox();
        }

        public List<string> Odswierz_listBox()
        {
            wyswietlana_lista.Clear();
            foreach (Przedmiot left in lista_przedmiotow)
            {
                if (left.Pozostalo_czasu_min < 0)
                {
                    wyswietlana_lista.Add(left.Nazwa + " czeka na markecie ");
                }
                else if (left.Pozostalo_czasu_sek <= 9)
                    wyswietlana_lista.Add(left.Pozostalo_czasu_min + ":0" + left.Pozostalo_czasu_sek+ " <- "+left.Nazwa );
                else
                    wyswietlana_lista.Add(left.Pozostalo_czasu_min + ":" + left.Pozostalo_czasu_sek+ " <- "+left.Nazwa);                
            }                          
            return wyswietlana_lista;
        }
    }
}
