using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication15.Models
{
    public static class CalculateBaseFactory
    {
        public static ICalculate CalBasePay { get; private set; }

        static CalculateBaseFactory()
        {
            IUnityContainer container = new UnityContainer().LoadConfiguration();
         
            if (container.IsRegistered<ICalculate>("CalBasePay"))
            {
                CalBasePay = container.Resolve<ICalculate>("CalBasePay");
            }
        }
    }
}