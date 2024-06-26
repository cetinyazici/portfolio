﻿using BusinessLayer.Abstract;
using DataAccessLayer.Abstract;
using EntityLayer.Concrete;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BusinessLayer.Concrete
{
    public class EducationManager : IEducationService
    {
        private readonly IEducationDal _educationDal;

        public EducationManager(IEducationDal educationDal)
        {
            _educationDal = educationDal;
        }

        public void TDelete(Education t)
        {
            _educationDal.Delete(t);
        }

        public Education TGetByID(int id)
        {
            return _educationDal.GetByID(id);
        }

        public List<Education> TGetList()
        {
            return _educationDal.GetList();
        }

        public void TInsert(Education t)
        {
            _educationDal.Insert(t);
        }

        public void TUpdate(Education t)
        {
            _educationDal.Update(t);
        }
    }
}
