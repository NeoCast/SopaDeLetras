using System;
using System.Collections.Generic;
using System.Text;

namespace SopaDeLetras.Entidades
{
    public class Palabra : CoreObjPalabra
    {

      

        public List<char> Letras { get; set; } =  new List<char>();
        public int EmpiezaEn { get; set; }
        public int TerminaEn { get; set; }
        public int PosX { get; set; }
        public int PosY { get; set; }
        public int Direccion { get; set; }
        public int CantLetras { get; set; }


 

        public string SepararPalabra(string palabraEntera)
        {
            

            return "";
        }

    }
}
