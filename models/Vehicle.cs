using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_C_Shasp_VAle.models
{
    public class Vehicle
    {
        // atributos
        public int Id { get; set; }
        public string Placa { get; set; }
        public string Tipo { get; set; }
        public string EngineNumber { get; set; }
        public string SerialNumber { get; set; }
        public byte PeopleCapacity { get; set; }
        public Driver Owner { get; set; }


        //constructor
        public Vehicle(int id, string placa, string tipo, string engineNumber, string serialNumber, byte peopleCapacity, Driver owner)
        {
            Id = id;
            Placa = placa;
            Tipo = tipo;
            EngineNumber = engineNumber;
            SerialNumber = serialNumber;
            PeopleCapacity = peopleCapacity;
            Owner = owner;
        }

        public void DeleteVehicle(int id, List<Vehicle> ListaVehiculos)
        {
            ListaVehiculos.RemoveAll(i => i.Id == id);
            Console.WriteLine($"El vehículo con ID {id} ha sido eliminado.");
        }

        public void AggregateVehicle(List<Vehicle> ListaVehicle)
        {
            Vehicle vh1 = new Vehicle():
            ListaVehicle.Add()
        }

    }
}