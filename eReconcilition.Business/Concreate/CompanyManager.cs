﻿using eReconcilition.Business.Abstract;
using eReconcilition.Business.Constans;
using eReconcilition.Core.Utilities.Results.Abstract;
using eReconcilition.Core.Utilities.Results.Concreate;
using eReconcilition.DataAccess.Abstract;
using eReconcilition.DataAccess.Concreate.EntityFramework;
using eReconcilition.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eReconcilition.Business.Concreate
{
    public class CompanyManager : ICompanyService
    {
        private readonly ICompanyDal _companyDal;
        public CompanyManager(ICompanyDal companyDal)
        {
            _companyDal = companyDal;
        }

        public IResult Add(Company company)
        {
            _companyDal.Add(company);
            return new SuccessResult(Messages.AddedCompany);
        }

        public IDataResult<List<Company>> GetList()
        {
            return new SuccessDataResult<List<Company>>(_companyDal.GetList());
        }
    }
}