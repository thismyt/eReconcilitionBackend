using eReconcilition.DataAccess.Abstract;
using eReconcilition.Business.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eReconcilition.Business.Concreate
{
    public class AccountReconcilitionManager : IAccountReconcilitionService
{
        private readonly IAccountReconcilitionDal _accountReconcilitionDal;

        public AccountReconcilitionManager(IAccountReconcilitionDal accountReconcilitionDal)
        {
            _accountReconcilitionDal = accountReconcilitionDal;
        }
    }
}
