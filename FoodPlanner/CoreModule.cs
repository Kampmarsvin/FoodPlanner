using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Ninject.Activation;


namespace FoodPlanner.Core
{
    public class CoreModule : NinjectModule
    {
        public override void Load()
        {
            //Bind<BusinessService>().ToSelf();
            //Bind<IDataAccessComponent>().ToProvider(new DataAccessComponentProvider());
            //Bind<IWebServiceProxy>().ToProvider(new WebServiceProxyComponentProvider());

            Bind<IDishRepository>().To<DishRepository>();
            Bind<IDishService>().To<DishService>();

        }
    }
}
