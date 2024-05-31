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
    public class PortfolioDetailsManager : IPortfolioDetailsService
    {
        private readonly IPortfolioDetailsDal _portfolioDetailsDal;

        public PortfolioDetailsManager(IPortfolioDetailsDal portfolioDetailsDal)
        {
            _portfolioDetailsDal = portfolioDetailsDal;
        }

        public void TDelete(PortfolioDetails t)
        {
            _portfolioDetailsDal.Delete(t);
        }

        public PortfolioDetails TGetByID(int id)
        {
            return _portfolioDetailsDal.GetByID(id);
        }

        public List<PortfolioDetails> TGetList()
        {
            return _portfolioDetailsDal.GetList();
        }

        public void TInsert(PortfolioDetails t)
        {
            _portfolioDetailsDal.Insert(t);
        }

        public void TUpdate(PortfolioDetails t)
        {
            _portfolioDetailsDal.Update(t);
        }
    }
}
