using Concesionario.Dtos;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Timers;

namespace Concesionario.Servicios
{
    internal class ClienteImplementacion : ClienteInterfaz
    {

        public void altaCliente(List<Cliente> listaClientes)
        {
            Cliente clienteNuevo = new Cliente();

            Console.WriteLine("DNI: ");
            clienteNuevo.DniCliente = Console.ReadLine();
            Console.WriteLine("NOMBRE: ") ;
            clienteNuevo.NombreCli = Console.ReadLine();
            Console.WriteLine("APELLIDOS: ") ;
            clienteNuevo.ApellidosCli = Console.ReadLine();
            Console.WriteLine("TELEFONO: ") ;
            clienteNuevo.NumeroTelf = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("NUMERO AFILIACION: ");
            clienteNuevo.NumeroAfiliacion = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("COLOR COCHE: ");
            clienteNuevo.ColorCoche = Console.ReadLine();
            Console.WriteLine("MODELO COCHE: ");
            clienteNuevo.ModeloCoche = Console.ReadLine();

            listaClientes.Add(clienteNuevo);


        }


        public void validarCliente (List<Cliente> clientes)
        {

            Console.WriteLine("DNI CLIENTE A VALIDAR");

            string dniAValidar = Console.ReadLine();


            foreach (Cliente cliente in clientes)
            {

                if (cliente.DniCliente.Equals(dniAValidar))
                {

                    cliente.Concedido = true;



                };



            }




        }











        public void modificarCliente(List<Cliente> listaClientes, int seleccioMenu)
        {

          



            Console.WriteLine("INTRODUZCA SU DNI");
            string dniCliente = Console.ReadLine();




            foreach (Cliente cliente in listaClientes)
            {

                


                if (cliente.DniCliente.Equals(dniCliente) & cliente.Concedido == true) {

                    
                    switch (seleccioMenu)
                    {
                        case 0:
                            
                            break;

                        case 1:
                            Console.WriteLine("DNI: ");
                            cliente.DniCliente = Console.ReadLine();
                            break;

                        case 2:
                            Console.WriteLine("NOMBRE: ");
                            cliente.NombreCli = Console.ReadLine();
                            break;

                        case 3:
                            Console.WriteLine("APELLIDOS: ");
                            cliente.ApellidosCli = Console.ReadLine();
                            break;

                        case 4:
                            Console.WriteLine("TELEFONO: ");
                            cliente.NumeroTelf = Convert.ToInt32(Console.ReadLine());
                            break;
                         case 5:
                            Console.WriteLine("NUMERO AFILIACION: ");
                            cliente.NumeroAfiliacion = Convert.ToInt32(Console.ReadLine());
                       
                            break;

                        case 6:
                            Console.WriteLine("COLOR COCHE: ");
                            cliente.ColorCoche = Console.ReadLine();
                            break;

                        case 7:
                            Console.WriteLine("MODELO: ");
                            cliente.ModeloCoche = Console.ReadLine();
                            break;



                    }

                }


                else
                {
                    Console.WriteLine("El cliente no ha sido concedido");
                }

            }

        }


    }
}
