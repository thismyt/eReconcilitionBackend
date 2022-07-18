using eReconcilition.Business.Abstract;
using eReconcilition.DataAccess.Abstract;
using eReconcilition.DataAccess.Concreate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eReconcilition.Business.Concreate
{
    public class AccountReconcilitaionDetailManager : IAccountReconcilitaionDetailService
    {
        private readonly IAccountReconcilitaionDetailDal _accountReconcilitionDetailDal;

        public AccountReconcilitaionDetailManager(IAccountReconcilitaionDetailDal accountReconcilitionDetailDal)
        {
            _accountReconcilitionDetailDal = accountReconcilitionDetailDal;
        }
    }
}
