using Entities.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Business.Abstract
{
    public interface IApplicantService
    {
        void ApplyForMask(Person person);

        // "Bana bir liste ver listemin türü de Person" diyoruz.
        List<Person> GetList();

        public bool CheckPerson(Person person);
    }
}
