using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace cadeteria
{
    public class Pedido
    {
        private int NRO;
        private string OBS;
        private Cliente Cliente;
        private bool Estado;

        public int nro { get; set; }
        public string obs { get; set; }
        public Cliente cliente { get; set; }
        public bool estado { get; set; }

        //Constructores
        public Pedido () {}

        public Pedido (int nro, string obs, Cliente cliente, bool estado)
        {
            this.NRO = nro;
            this.OBS = obs;
            this.Cliente = cliente;
            this.Estado = estado;
        }
    }
}