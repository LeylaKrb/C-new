using Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Concrete
{
    public class ForeignerManager : IApplicantService
    {
        public void ApplyForMask(Abstract.Person person)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Abstract.Person person)
        {
            throw new NotImplementedException();
        }

        public bool CheckPerson(Person person)
        {
            throw new NotImplementedException();
        }

        public List<Abstract.Person> Getlist()
        {
            throw new NotImplementedException();
        }
    }
}
