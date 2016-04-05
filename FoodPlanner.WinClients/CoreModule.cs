using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Ninject.Modules;
using Ninject.Activation;
using Moq;
using FoodPlanner.Core;

namespace FoodPlanner.WinClients
{
    public class CoreModule : NinjectModule
    {
        public override void Load()
        {
            Bind<IDishRepository>().To<DishRepository>();
            Bind<IDishService>().To<DishService>();
          
        }
    }
}
