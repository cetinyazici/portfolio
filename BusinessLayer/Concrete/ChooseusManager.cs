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
    public class ChooseusManager : IChooseusService
    {
        private readonly IChooseusDal _chooseusDal;
        public void TDelete(Chooseus t)
        {
            _chooseusDal.Delete(t);
        }

        public Chooseus TGetByID(int id)
        {
            return _chooseusDal.GetByID(id);
        }

        public List<Chooseus> TGetList()
        {
            return _chooseusDal.GetList();
        }

        public void TInsert(Chooseus t)
        {
            _chooseusDal.Insert(t);
        }

        public void TUpdate(Chooseus t)
        {
            _chooseusDal.Update(t);
        }
    }
}
