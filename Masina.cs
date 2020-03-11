using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Proiect
{
    //clasa Masina
    public class Masina
    {
        string marca;
        string culoare;
        double pret;
        int anFabricatie;


        //Constructor fara parametrii
        public Masina()
        {
            marca = string.Empty;
            culoare = string.Empty;
            pret = 0;
            anFabricatie = 0;

        }
        //Constructor cu parametrii
        public Masina(string _marca, string _culoare, double _pret, int _anFabricatie)
        {
            marca = _marca;
            culoare = _culoare;
            pret = _pret;
            anFabricatie = _anFabricatie;

        }
        public string Info()
        {
            return string.Format("Masina este {0}, are culoarea {1}, pretul de {2}, din anul {3}", marca, culoare, pret, anFabricatie);

        }
    }
}
