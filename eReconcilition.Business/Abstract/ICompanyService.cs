using eReconcilition.Core.Utilities.Results.Abstract;
using eReconcilition.Entities.Concreate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eReconcilition.Business.Abstract
{
    public interface ICompanyService
    {
        IResult Add (Company company); 
        IDataResult<List<Company>> GetList();
        IResult CompanyExists(Company company);
    }
}
