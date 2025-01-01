using AM.ApplicationCore.Interfaces;
using AM.ApplicationCore.Services;
using ApplicationCore.Domain;
using ApplicationCore.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ApplicationCore.Services
{
    public class SinstreService : Service<Sinstre>, ISinstre
    {
        public SinstreService(IUnitOfWork unitOfWork) : base(unitOfWork)
        {
        }

        public double pourcentage(TypeAssurance type)
        {
            int a = GetAll().Where(h => h.Assurance.typeAssurance == type)
                  .Select(K => K.Assurance).Count();
         
            return (GetAll().Select(k => k.Assurance).Count() )/ a;
        }
    }
}
