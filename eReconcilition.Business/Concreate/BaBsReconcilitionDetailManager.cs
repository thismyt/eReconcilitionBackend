using eReconcilition.Business.Abstract;
using eReconcilition.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eReconcilition.Business.Concreate
{
    public class BaBsReconcilitionDetailManager : IBaBsReconcilitionDetailService
    {
        private readonly IBaBsReconcilitionDetailDal _baBsReconcilitionDetailDal;

        public BaBsReconcilitionDetailManager(IBaBsReconcilitionDetailDal baBsReconcilitionDetailDal)
        {
            _baBsReconcilitionDetailDal = baBsReconcilitionDetailDal;
        }
    }
}
