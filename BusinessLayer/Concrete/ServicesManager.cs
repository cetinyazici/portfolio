using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class ServicesManager : IServicesService
    {
        private readonly IServicesDal _servicesDal;
        public void TDelete(Services t)
        {
            _servicesDal.Delete(t);
        }

        public Services TGetByID(int id)
        {
            return _servicesDal.GetByID(id);
        }

        public List<Services> TGetList()
        {
            return _servicesDal.GetList();
        }

        public void TInsert(Services t)
        {
            _servicesDal.Insert(t);
        }

        public void TUpdate(Services t)
        {
            _servicesDal.Update(t);
        }
    }
}
