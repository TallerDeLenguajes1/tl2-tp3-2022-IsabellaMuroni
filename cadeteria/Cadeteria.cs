using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadeteria
{
    public class Cadeteria
    {
        private string Nombre;
        private string Telefono;
        private List<Cadete> ListaCadetes;

        public string nombre { get; set; }
        public string telefono { get; set; }
        public List<Cadete> listaCadetes { get; set; }

        public Cadeteria (string nombre, string telefono)
        {
            this.Nombre = nombre;
            this.Telefono = telefono;
            listaCadetes = new List<Cadete> ();
        }

        public void agregarCadete (Cadete cadete)
        {
            listaCadetes.Add(cadete);
        }

        public void informePedidos ()
        {
            int cant_envios_cadetes = 0;
            int cant_envios_total = 0;
            int cant_envios_promedio = 0;

            for (int i = 0; i > listaCadetes.Count(); i++)
            {
                listaCadetes[i].
            }
        }
    }
}