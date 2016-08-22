using Microsoft.Practices.Unity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication15.Models;
using WebApplication15.Models.CusA;
using WebApplication15.Models.CusB;
using WebApplication15.Models.CusC;

namespace WebApplication15
{
    public partial class WebForm1 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var cus = "A";

            var basepay = new CalculateBasePay();
            var leavepay = new CalculateLeavePay();

            ICalculate otpay;

            switch (cus)
            {
                case "A":
                    otpay = new CalculateOtPayA();
                    break;
                case "B":
                    otpay = new CalculateOtPayB();
                    break;
                case "C":
                    otpay = new CalculateOtPayC();
                    break;
                default:
                    otpay = new CalculateOtPay();
                    break;

            }

            var wagecal = new CalculateWage();
            wagecal.BasePay = basepay;
            wagecal.OtPay = otpay;
            wagecal.LeavePay = leavepay;
            int result = wagecal.Calculate();

            Response.Write(result);
            
        }
    }
}