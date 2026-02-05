using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.IO;
using System.Windows.Forms;

namespace WindowsFormsApp1
{
    public static class Admin
    {
        public static void SaveProizvod(string proizvod)
        {
            using (StreamWriter sw = new StreamWriter("proizvodi.txt", true))
            {
                sw.WriteLine(proizvod);
                sw.Close();
            }
        }
        public static List<string> SearchByNameOrCategory(string kriterij)
        {
            List<string> rezultati = new List<string>();
            if (File.Exists("proizvodi.txt"))
            {
                StreamReader sr = new StreamReader("proizvodi.txt");
                string linija;
                while ((linija = sr.ReadLine()) != null)
                {
                    string[] dijelovi = linija.Split(',');
                    if (string.Equals(dijelovi[0], kriterij) == true || string.Equals(dijelovi[1], kriterij) == true)
                    {
                        rezultati.Add(linija);
                    }
                }
                sr.Close();

            }
            return rezultati;

        }
        public static List<string> GetAllAsStrings()
        {
            List<string> rezultati = new List<string>();
            if (File.Exists("proizvodi.txt"))
            {
                StreamReader sr = new StreamReader("proizvodi.txt");
                string linija;
                while ((linija = sr.ReadLine()) != null)
                {
                    rezultati.Add(linija);
                }
                sr.Close();
            }
            return rezultati;
        }
        public static List<string> GetCountByCategory()
        {
            List<string> kategorija = new List<string>();
            int Hrana = 0, Pice = 0, Potrepstine = 0, Ostalo = 0;
            if (File.Exists("proizvodi.txt"))
            {
                StreamReader sr = new StreamReader("proizvodi.txt");
                string linija;
                while ((linija = sr.ReadLine()) != null)
                {
                    string[] dijelovi = linija.Split(',');
                    if (string.Equals(dijelovi[1], "Hrana") == true)
                    {
                        Hrana++;
                    }
                    else if (string.Equals(dijelovi[1], "Piće") == true)
                    {
                        Pice++;
                    }
                    else if (string.Equals(dijelovi[1], "potrepstine") == true)
                    {
                        Potrepstine++;
                    }
                    else if (string.Equals(dijelovi[1], "Ostalo") == true)
                    {
                        Ostalo++;
                    }
                }
                sr.Close();
                kategorija.Add("Hrana: " + Hrana);
                kategorija.Add("Piće: " + Pice);
                kategorija.Add("Potrepstine: " + Potrepstine);
                kategorija.Add("Ostalo: " + Ostalo);
            }
            return kategorija;
        }
    }
}
