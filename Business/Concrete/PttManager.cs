using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Business.Abstract;
using Entities.Concrete;

namespace Business.Concrete
{
    public class PttManager : ISupplierService
    { 
    
        private IApplicantService _applicantService;

        public PttManager(IApplicantService applicantService)// bu blok constructor dur bu class new yapıldıgında ilk burası çalışır.
        {
            _applicantService = applicantService;
        }

        public void GiveMask(Person person)
        {
            //PersonManager personManager = new PersonManager();
            //bir iş sınıfı başka bir iş sınıfını kullanırken newliyorsa ileriye dönük değişiklik talebinde direnç gösterir.
            //yani newlediğimiz classa bağımlı hale geliriz


            if (_applicantService.CheckPerson(person))//== true koymasak bile default olarak true alındıgı için true kabul edilir.
            {
                Console.WriteLine(person.FirstName + " için maske verildi."); 
            }
            else
            {
                Console.WriteLine(person.FirstName + " için maske VERİLEMEDİ.");
            }
        }

    }
}
