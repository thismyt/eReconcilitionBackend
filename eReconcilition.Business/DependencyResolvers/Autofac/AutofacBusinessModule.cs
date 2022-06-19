using Autofac;
using eReconcilition.Business.Abstract;
using eReconcilition.Business.Concreate;
using eReconcilition.DataAccess.Abstract;
using eReconcilition.DataAccess.Concreate.EntityFramework;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace eReconcilition.Business.DependencyResolvers.Autofac
{
    public class AutofacBusinessModule : Module
    {
        protected override void Load(ContainerBuilder builder)
        {
            builder.RegisterType<CompanyManager>().As<ICompanyService>();
            builder.RegisterType<EFCompanyDal>().As<ICompanyDal>();

            builder.RegisterType<AccountReconcilitaionDetailManager>().As<IAccountReconcilitaionDetailService>();
            builder.RegisterType<EFAccountReconcilitaionDetailDal>().As<IAccountReconcilitaionDetailDal>();

            builder.RegisterType<BaBsReconcilitionDetailManager>().As<IBaBsReconcilitionDetailService>();
            builder.RegisterType<EFBaBsReconcilitionDetailDal>().As<IBaBsReconcilitionDetailDal>();

            builder.RegisterType<BaBsReconcilitionManager>().As<IBaBsReconcilitionService>();
            builder.RegisterType<EFBaBsReconcilitionDal>().As<IBaBsReconcilitionDal>();

            builder.RegisterType<CurrencyAccountManager>().As<ICurrencyAccountService>();
            builder.RegisterType<EFCurrencyAccountDal>().As<ICurrencyAccountDal>();

            builder.RegisterType<CurrencyManager>().As<ICurrencyService>();
            builder.RegisterType<EFCurrencyDal>().As<ICurrencyDal>();

            builder.RegisterType<MailParameterManager>().As<IMailParameterService>();
            builder.RegisterType<EFMailParameterDal>().As<IMailParameterDal>();
        }
    }
}
