using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using WebApplication15.Models;

namespace WebApplication15
{
    public partial class WebForm2 : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
            var basepay = CalculateBaseFactory.CalBasePay;
            var leavepay = CalculateLeavePayFactory.CalLeavePay;
            var otpay = CalculateOtFactory.CalOtPay;

            var wagecal = new CalculateWage();
            wagecal.BasePay = basepay;
            wagecal.OtPay = otpay;
            wagecal.LeavePay = leavepay;
            int result = wagecal.Calculate();

            Response.Write(result);
        }
    }
}