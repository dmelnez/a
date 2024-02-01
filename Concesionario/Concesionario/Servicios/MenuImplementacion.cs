using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Concesionario.Servicios
{
    internal class MenuImplementacion : MenuInterfaz
    {

        public int MenuPrincipla()
        {

            Console.WriteLine("######################");
            Console.WriteLine("[0] -> Cerrar Aplicacion");
            Console.WriteLine("[1] -> Alta Cliente");
            Console.WriteLine("[2] -> Validar a un Cliente");
            Console.WriteLine("[3] -> Modificar un campo");
            Console.WriteLine("######################");


            int menuPrin = Convert.ToInt32(Console.ReadLine());
            return menuPrin;
        }


        public int modMenuCliente ()
        {
            Console.WriteLine("[0] -> Subir una Pagina" );

            Console.WriteLine("[1] -> DNI: ");
            
            Console.WriteLine("[2] -> NOMBRE: ");
         
            Console.WriteLine("[3] -> APELLIDOS: ");
        
            Console.WriteLine("[4] -> TELEFONO: ");
          
            Console.WriteLine("[5] -> NUMERO AFILIACION: ");
          
            Console.WriteLine("[6] -> COLOR COCHE: ");
      
            Console.WriteLine("[7] -> MODELO COCHE: ");
           

            int seleccionMenu = Convert.ToInt32(Console.ReadLine());
            return seleccionMenu;



        }







    }
}
