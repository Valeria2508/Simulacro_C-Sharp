using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_C_Shasp_VAle.models
{
    public class App
    {
        public List<Vehicle> ListaVehiculos { get; set; } = new List<Vehicle>();
        public List<Customer> ListaCustomeres { get; set; } = new List<Customer>();
        public List<Driver> ListaDrivers { get; set; } = new List<Driver>();

        public static void Menu()
        {

            bool exit = false;
            while (!exit)
            {
                Console.WriteLine("------------------------------------");
                Console.WriteLine("Bienvedido al sistema TransRiwi");
                Console.WriteLine("Elige una opcion");
                Console.WriteLine("1. Agg Vehicle");
                Console.WriteLine("2. Mostrar Vehicle");
                Console.WriteLine("3. Editar Vehicle");
                Console.WriteLine("4. Eliminar Vehicle");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("5. Agg Customer");
                Console.WriteLine("6. Mostrar Customer");
                Console.WriteLine("7. Editar Customer");
                Console.WriteLine("8. Eliminar Customer");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("9. Agg Driver");
                Console.WriteLine("10. Mostrar Driver");
                Console.WriteLine("11. Editar Driver");
                Console.WriteLine("12. Eliminar Driver");
                Console.WriteLine("13. Agg experiencia como driver");
                Console.WriteLine("------------------------------------");

                Console.WriteLine("0. Salir");

                string option = Console.ReadLine();

                switch (option)
                {
                    case "0":
                        exit = true;
                        break;
                    case "1":
                        App.AgregarVehiculo();

                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                    
                        break;
                }
            }
        }

    }
}