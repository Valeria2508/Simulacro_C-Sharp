using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Simulacro_C_Shasp_VAle.models
{
    public class Driver
    {   //atributis publicos
        public string LicenseNumber { get; set; }
        public string LicenseCategory { get; set; }
        public int DrivingExperience { get; set; }


        //constructor
        public Driver(string licenseNumber, string licenseCategory, int drivingExperence)
        {   
            LicenseNumber = licenseNumber;
            LicenseCategory = licenseCategory;
            DrivingExperience = drivingExperence;

        }


        //metodo para actualizar la nueva categoria
        public void UpdateLicensecategory(string newCategory){
            if (LicenseCategory!=null)
            {
                string oldCategory = LicenseCategory;
                LicenseCategory = newCategory;
                Console.WriteLine($"License category updated from {oldCategory} to {LicenseCategory}");
            }
        }
    }
}