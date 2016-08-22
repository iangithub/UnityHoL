using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace WebApplication15.Models
{
    public class CalculateWage
    {
        public ICalculate BasePay { get; set; }
        public ICalculate OtPay { get; set; }
        public ICalculate LeavePay { get; set; }

        public int Calculate()
        {
            int result = 0;
            if (BasePay != null)
                result += BasePay.Calculate();
            if (OtPay != null)
                result += OtPay.Calculate();
            if (LeavePay != null)
                result += LeavePay.Calculate();
            return result;
        }
    }
}