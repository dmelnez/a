using Concesionario.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario.Servicios
{
    internal interface ClienteInterfaz
    {
        public void altaCliente(List<Cliente> listaClientes);

        public void validarCliente(List<Cliente> clientes);
        public void modificarCliente(List<Cliente> listaClientes, int seleccioMenu);
    }
}
