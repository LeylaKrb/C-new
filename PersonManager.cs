using Business.Abstract;
using MernisServiceReference;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class PersonManager : IApplicantService
        //public verilmezse sınıfa erişimde sorun yaşanır
    {
        public void ApplyForMask(Person person)
        {
        
        
        
        }



        public List<Person> Getlist()
        {
            return null;

        }
        public bool CheckPerson(Person person)

        {




          return true;


        }

        public void ApplyForMask(Abstract.Person person)
        {
            throw new NotImplementedException();
        }

        List<Abstract.Person> IApplicantService.Getlist()
        {
            throw new NotImplementedException();
        }

        public async bool CheckPerson(Abstract.Person person)
        {
            KPSPublicSoapClient client =new KPSPublicSoapClient(KPSPublicSoapClient.EndpointConfiguration.KPSPublicSoap);
            return await client.TCKimlikNoDogrulaAsync(
                new TCKimlikNoDogrulaRequest
                (new TCKimlikNoDogrulaRequestBody(123, Ad: "Leyla", Soyad: "Karabayir", Dogumyili: 1988)))
                .Result.Body.TCKimlikNoDogrulamaResult;


            throw new NotImplementedException();
        }

        void IApplicantService.ApplyForMask(Abstract.Person person)
        {
            throw new NotImplementedException();
        }

        bool IApplicantService.CheckPerson(Abstract.Person person)
        {
            throw new NotImplementedException();
        }

        bool IApplicantService.CheckPerson(Concrete.Person person)
        {
            throw new NotImplementedException();
        }

        public class Person
        {
        }
    }
     
    
    
    







}


