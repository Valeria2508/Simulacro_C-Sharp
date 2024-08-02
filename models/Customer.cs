using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_C_Shasp_VAle.models
{
    public class Customer : User
    {
        public string MembershipLevel { get; set; }
        public string PreferredPaymentMethod { get; set; }


        //constructor
        public Customer(string name, string lastname, string identificationNumber, DateOnly birthdate, string email, string phoneNumber, string address, string membershipLevel, string preferredPaymentMethod) : base(name, lastname, identificationNumber, birthdate, email, phoneNumber, address)
        {
            Name = name;
            LastName = lastname;
            IdentificationNumber = identificationNumber;
            Birthdate = birthdate;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            MembershipLevel = membershipLevel;
            PreferredPaymentMethod = preferredPaymentMethod;
        }
        
        //metodo para actualizar nivel de membresia
        public void UpdateMembershipLevel()
        {
            Console.WriteLine("Ingresa el nivel de membresia");
            string newMembership = Console.ReadLine();
            MembershipLevel = newMembership;
            Console.WriteLine($"Nivel de membresia actualizado a: {MembershipLevel}");
        }
    }
}