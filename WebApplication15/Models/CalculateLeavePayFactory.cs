using Microsoft.Practices.Unity;
using Microsoft.Practices.Unity.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication15.Models
{
    public static class CalculateLeavePayFactory
    {
        public static ICalculate CalLeavePay { get; private set; }

        static CalculateLeavePayFactory()
        {
            IUnityContainer container = new UnityContainer().LoadConfiguration();
          
            if (container.IsRegistered<ICalculate>("CalLeavePay"))
            {
                CalLeavePay = container.Resolve<ICalculate>("CalLeavePay");
            }
        }
    }
}