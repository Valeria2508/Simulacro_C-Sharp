using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_C_Shasp_VAle.models
{
    public class User
    {   //atributos protegidos
        protected Guid Id  { get; set; }
        protected string Name { get; set; }
        protected string LastName { get; set; }
        protected string IdentificationNumber { get; set; }
        protected DateOnly Birthdate { get; set; }
        protected string Email { get; set; }
        protected string PhoneNumber { get; set; }
        protected string Address { get; set; }

        //constructor
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

        //mostrar detalle
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

        //metodo calcular edad
        protected int CalculateAge(){
            DateOnly dateCurrent = DateOnly.FromDateTime(DateTime.Now);//resta la fecha actual con la fecha de nacimiento
            int age = dateCurrent.Year - Birthdate.Year;
            return age;//devuelve la edad
        }

        //metodo mostrar edad
        protected void ShowAge(){
            Console.WriteLine($"Age: {CalculateAge()}");
        }



    }
}