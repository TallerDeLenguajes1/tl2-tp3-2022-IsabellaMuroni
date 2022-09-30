using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadeteria
{
    public class Persona
    {
        private int ID;
        private string Nombre;
        private string Direccion;
        private int Telefono;

        public int id { get; set; }
        public string nombre { get; set; }
        public string direccion { get; set; }
        public int telefono { get; set; }

        //Constructores
        public Persona () {}

        public Persona (int id, string nombre, string apellido, string direccion, int telefono)
        {
            this.ID = id;
            this.Nombre = nombre;
            this.Direccion = direccion;
            this.Telefono = telefono;
        }

    }

    public class Cliente: Persona
    {
        private string DatosReferenciaDireccion;

        public string datosReferenciaDireccion { get; set; }

        //Constructores
        public Cliente (): base () {}

        public Cliente (int id,
                        string nombre,
                        string apellido,
                        string direccion,
                        int telefono,
                        string datosReferenciaDireccion) : base (id, nombre, apellido, direccion, telefono)
        {
            this.DatosReferenciaDireccion = datosReferenciaDireccion;
        }

    }
}