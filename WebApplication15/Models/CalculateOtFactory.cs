using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication15.Models
{
    public static class CalculateOtFactory
    {
        public static ICalculate CalOtPay { get; private set; }

        static CalculateOtFactory()
        {
            IUnityContainer container = new UnityContainer().LoadConfiguration();
            
            if (container.IsRegistered<ICalculate>("CalOtPay"))
            {
                CalOtPay = container.Resolve<ICalculate>("CalOtPay");
            }
        }
    }
}