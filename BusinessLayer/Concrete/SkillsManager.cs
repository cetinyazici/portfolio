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
    public class SkillsManager : ISkillsService
    {
        private readonly ISkillsDal _skillsDal;

        public SkillsManager(ISkillsDal skillsDal)
        {
            _skillsDal = skillsDal;
        }

        public void TDelete(Skills t)
        {
            _skillsDal.Delete(t);
        }

        public Skills TGetByID(int id)
        {
            return _skillsDal.GetByID(id);
        }

        public List<Skills> TGetList()
        {
            return _skillsDal.GetList();
        }

        public void TInsert(Skills t)
        {
            _skillsDal.Insert(t);
        }

        public void TUpdate(Skills t)
        {
            _skillsDal.Update(t);
        }
    }
}
