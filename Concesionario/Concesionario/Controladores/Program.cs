using Concesionario.Dtos;
using Concesionario.Servicios;






    class Program
    {


        public static void Main(string[] args)
        {

            List<Cliente> listaClientes = new List<Cliente>();

            MenuInterfaz menu = new MenuImplementacion();

            ClienteInterfaz cli = new ClienteImplementacion();

            bool cerrarMenu = false;

            do
            {

             int seleccionMenu =  menu.MenuPrincipla();

                switch (seleccionMenu)
                    {

                        case 0:

                        cerrarMenu = true;
                    break;

                    case 1:

                      cli.altaCliente(listaClientes);
                    break;


                     case 2:

                        cli.validarCliente(listaClientes);
                    break;


                    case 3:
                       

                        int seleccioMenu = menu.modMenuCliente();

                        cli.modificarCliente(listaClientes, seleccioMenu);

                    break;

                    }
                

   



            }



            while (!cerrarMenu);



        }


    }








