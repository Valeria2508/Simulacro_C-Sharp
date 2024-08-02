using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_C_Shasp_VAle.models
{
    public class User
    {
        protected Guid Id  { get; set; }
        protected string Name { get; set; }
        protected string LastName { get; set; }
        protected string IdentificationNumber { get; set; }
        protected DateOnly Birthdate { get; set; }
        protected string Email { get; set; }
        protected string PhoneNumber { get; set; }
        protected string Address { get; set; }

        protected User(string name, string lastname, string identificationNumber, DateOnly birthdate, string email, string phoneNumber, string address)
        {
            Name = name;
            LastName = lastname;
            IdentificationNumber = identificationNumber;
            Birthdate = birthdate;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
        }

        protected void ShowDetails(){
            Console.WriteLine(@$"
            Id: {Id}
            Name: {Name}
            Last Name: {LastName}
            Identification Number: {IdentificationNumber}
            Birthdate: {Birthdate}
            Email: {Email}
            Phone Number: {PhoneNumber}
            Address: {Address}");
        }

        

    }
}