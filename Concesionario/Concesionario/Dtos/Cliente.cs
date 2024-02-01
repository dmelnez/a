using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario.Dtos
{
    internal class Cliente
    {
        int idCliente = 0;

        string dniCliente = "aaaaa";

        string nombreCli = "aaaaa";

        string apellidosCli = "aaaaa";

        int numeroTelf = 11111;

        bool concedido = false;

        int numeroAfiliacion = 11111;

        string colorCoche = "aaaaa";

        string modeloCoche = "aaaaa";

        public Cliente(int idCliente, string dniCliente, string nombreCli, string apellidosCli, int numeroTelf, bool concedido, int numeroAfiliacion, string colorCoche, string modeloCoche)
        {
            this.idCliente = idCliente;
            this.dniCliente = dniCliente;
            this.nombreCli = nombreCli;
            this.apellidosCli = apellidosCli;
            this.numeroTelf = numeroTelf;
            this.concedido = concedido;
            this.numeroAfiliacion = numeroAfiliacion;
            this.colorCoche = colorCoche;
            this.modeloCoche = modeloCoche;
        }

        public int IdCliente { get => idCliente; set => idCliente = value; }
        public string DniCliente { get => dniCliente; set => dniCliente = value; }
        public string NombreCli { get => nombreCli; set => nombreCli = value; }
        public string ApellidosCli { get => apellidosCli; set => apellidosCli = value; }
        public int NumeroTelf { get => numeroTelf; set => numeroTelf = value; }
        public bool Concedido { get => concedido; set => concedido = value; }
        public int NumeroAfiliacion { get => numeroAfiliacion; set => numeroAfiliacion = value; }
        public string ColorCoche { get => colorCoche; set => colorCoche = value; }
        public string ModeloCoche { get => modeloCoche; set => modeloCoche = value; }





        public Cliente()
        {

        }









    }
}
