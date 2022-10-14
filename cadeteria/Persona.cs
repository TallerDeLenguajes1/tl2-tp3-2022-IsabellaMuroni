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

        //Metodos
        public void mostrarInformacion ()
        {
            Console.WriteLine("ID: ");
            Console.Write(id);
            Console.WriteLine("Nombre: ");
            Console.Write(nombre);
            Console.WriteLine("Dirección: ");
            Console.Write(direccion);
            Console.WriteLine("Telefono: ");
            Console.Write(telefono);
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

    public class Cadete: Persona
    {
        private List<Pedido> Pedidos;
        public List<Pedido> pedidos;

        //Constructores
        public Cadete (int id,
                       string nombre,
                       string apellido,
                       string direccion,
                       int telefono) : base (id, nombre, apellido, direccion, telefono)
        {
            pedidos = new List<Pedido> ();
        } 

        public void ingresarPedido (Pedido pedido)
        {
            pedido.pedidoIniciado();
            pedidos.Add(pedido);
        }

        public float jornalACobrar()
        {
            float jornal = 0;

            for ( int i = 0; i < pedidos.Count(); i++ )
            {
                jornal = jornal + ( 300 * Convert.ToInt32 (pedidos[i].estado) );
            }

            return jornal;

        }
    }
}