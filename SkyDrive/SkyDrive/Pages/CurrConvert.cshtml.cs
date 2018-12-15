using System;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace ContosoUniversity.Pages
{
    public class CurrConvert : PageModel
    {
        public double gbp;
        public double euro;
        public double convertedValue;

        public double rate = 1.15;
        public void OnGet()
        {

        }

        public void OnPost()
        {
            this.gbp = Convert.ToDouble(Request.Form["gbp"]);
            this.euro = Convert.ToDouble(Request.Form["euro"]);

            this.convertedValue = gbp * rate;
        }
    }
}
