using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_C_Shasp_VAle.models
{
    public class Driver: User
    {   //atributis publicos
        public string LicenseNumber { get; set; }
        public string LicenseCategory { get; set; }
        public int DrivingExperience { get; set; }


        //constructor
        public Driver(string name, string lastname, string identificationNumber, DateOnly birthdate, string email, string phoneNumber, string address, string licenseNumber, string licenseCategory, int drivingExperence): base(name, lastname, identificationNumber, birthdate, email, phoneNumber, address)
        {
            Name = name;
            LastName = lastname;
            IdentificationNumber = identificationNumber;
            Birthdate = birthdate;
            Email = email;
            PhoneNumber = phoneNumber;
            Address = address;
            LicenseNumber = licenseNumber;
            LicenseCategory = licenseCategory;
            DrivingExperience = drivingExperence;

        }


        //metodo para actualizar la nueva categoria
        public void UpdateLicensecategory(string newCategory)
        {
            if (LicenseCategory != null)
            {
                string oldCategory = LicenseCategory;
                LicenseCategory = newCategory;
                Console.WriteLine($"Categoría de licencia actualizada de {oldCategory} a {LicenseCategory}");
            }
        }



        //metodo para añadir años de experiencia
        public void AddExperience(int years)
        {
            if (DrivingExperience > 0)
            {
                int newExperience = DrivingExperience + years;
                DrivingExperience = newExperience;
                Console.WriteLine($"Experiencia de conducción actualizada a {DrivingExperience} años");

            }
        }
    }
}