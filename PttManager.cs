using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PttManager:ISupplierService
    {
       private IApplicantService _applicantService;  
        public PttManager(IApplicantService applicantService)//Counstractor new yapıldığında çalışır
        
       {
            _applicantService = _applicantService;
        }
       

        public void GiveMask(Person person)
        {
              
            
            if (_applicantService.CheckPerson(person))
            {
                Console.WriteLine(person.FirstName + "için maske verildi");

            }

        }

        public void GiveMask(global::Person person1)
        {
            throw new NotImplementedException();
        }

        public void GiveMask(Abstract.Person person)
        {
            throw new NotImplementedException();
        }
    }

    public class Person
    {
        public string FirstName { get; internal set; }
    }
}
