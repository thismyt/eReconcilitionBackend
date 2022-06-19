using eReconcilition.Business.Abstract;
using eReconcilition.DataAccess.Abstract;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eReconcilition.Business.Concreate
{
    public class BaBsReconcilitionManager : IBaBsReconcilitionService
    {
        private readonly IBaBsReconcilitionDal _baBsReconcilitionDal;

        public BaBsReconcilitionManager(IBaBsReconcilitionDal baBsReconcilitionDal)
        {
            _baBsReconcilitionDal = baBsReconcilitionDal;
        }
    }
}
