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


        public static void Menu(){
            
            bool exit = false;
            while (!exit)
            {   Console.WriteLine("------------------------------------");
                Console.WriteLine("Bienvedido al sistema TransRiwi");
                Console.WriteLine("1. Elige una opcion");
                Console.WriteLine("3. Agg Vehicle");
                Console.WriteLine("3. Mostrar Vehicle");
                Console.WriteLine("3. Editar Vehicle");
                Console.WriteLine("3. Eliminar Vehicle");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("3. Agg Customer");
                Console.WriteLine("3. Mostrar Customer");
                Console.WriteLine("3. Editar Customer");
                Console.WriteLine("3. Eliminar Customer");
                Console.WriteLine("------------------------------------");
                Console.WriteLine("3. Agg Driver");
                Console.WriteLine("3. Mostrar Driver");
                Console.WriteLine("3. Editar Driver");
                Console.WriteLine("3. Eliminar Driver");
                Console.WriteLine("------------------------------------");

                Console.WriteLine("2. Salir");
            }
        }

    }
}