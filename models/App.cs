using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_C_Shasp_VAle.models
{
    public class App
    {
        public static List<Vehicle> ListaVehiculos { get; set; } = new List<Vehicle>();
        public static List<Customer> ListaCustomeres { get; set; } = new List<Customer>();
        public static List<Driver> ListaDrivers { get; set; } = new List<Driver>();

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
                        // App.AgregarVehiculo();

                        break;

                    default:
                        Console.WriteLine("Opción no válida. Por favor, intente de nuevo.");
                    
                        break;
                }
            }
        }

        public static void AggregateVehicle(Vehicle vehicle)
        {   
            Console.WriteLine("tu id: ");
            int id = Convert.ToInt32(Console.ReadLine);
            Console.WriteLine("Ingresa la placa del vehiculo");
            string placa = Console.ReadLine();
            Console.WriteLine("Ingresa el tipo del vehiculo");
            string tipo = Console.ReadLine();
            Console.WriteLine("Ingresa el numero de motor del vehiculo");
            string engineNumber = Console.ReadLine();
            Console.WriteLine("Ingresa el numero de serie del vehiculo");
            string serialNumber = Console.ReadLine();
            Console.WriteLine("Ingresa la capacidad de pasajeros del vehiculo");
            byte peopleCapacity = Convert.ToByte(Console.ReadLine());
            Console.WriteLine("Ingresa el nombre del conductor");

            

            var driver = new Driver("nombre", "apellido", "identificacion", new DateOnly(1990, 1, 1), "email", "telefono", "direccion", "licencia", "categoría", 0);

            var vh1 = new Vehicle(id,placa,tipo,engineNumber,serialNumber,peopleCapacity,driver);
            ListaVehiculos.Add(vehicle);
            ListaDrivers.Add(driver);
        }

         public void DeleteVehicle(int id, List<Vehicle> ListaVehiculos)
        {
            ListaVehiculos.RemoveAll(i => i.Id == id);
            Console.WriteLine($"El vehículo con ID {id} ha sido eliminado.");
        }



    }
}