using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.RazorPages;

namespace AspNetCore_RazorPages.Pages.Modul01
{
    public class Calc1Model : PageModel
    {
        public int Ergebnis { get; set; }

        public void OnGet()
        {
            Ergebnis = 0;
        }



        //URL müsste lauten: 
        public void OnGetHannes()
        {
            Ergebnis = 42;
        }


        //Bei einem einfachen Submit wird OnPost ausgeführt
        public void OnPost()
        {
            int eins = int.Parse(Request.Form["eins"].FirstOrDefault());
            int zwei = int.Parse(Request.Form["zwei"].FirstOrDefault());

            Ergebnis = eins + zwei;
        }

    }
}