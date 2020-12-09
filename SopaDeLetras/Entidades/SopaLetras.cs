using System;
using System.Collections.Generic;
using System.Text;

namespace SopaDeLetras.Entidades
{
    public class SopaLetras
    {
        public string CadenaDePalabras { get; set; }
        public int cantFilas { get; set; }
        public int cantColumnas { get; set; }
        public List<Palabra> SopaPalabras { get; set; } = new List<Palabra>();


        /*   public void generadorDeSopas()
           {

           }*/
    }
}
