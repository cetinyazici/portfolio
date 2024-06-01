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
    public class SummaryManager : ISummaryService
    {
        private readonly ISummaryDal _summaryDal;

        public SummaryManager(ISummaryDal summaryDal)
        {
            _summaryDal = summaryDal;
        }

        public void TDelete(Summary t)
        {
            _summaryDal.Delete(t);
        }

        public Summary TGetByID(int id)
        {
            return _summaryDal.GetByID(id);
        }

        public List<Summary> TGetList()
        {
            return _summaryDal.GetList();
        }

        public void TInsert(Summary t)
        {
            _summaryDal.Insert(t);
        }

        public void TUpdate(Summary t)
        {
            _summaryDal.Update(t);
        }
    }
}
