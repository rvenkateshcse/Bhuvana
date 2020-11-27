using Repository;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace StudentAttendenceManagementProject.Controllers
{
    public class ProgramsController : Controller
    {
        // GET: Programs
        public ActionResult Programs(string P1,string Input1,string Input2)
        {
            if (P1 == "StringReverse")
            {
                string re = Services.LogInservice.StringReverse(Input1);
                ViewBag.Ans = re;
            }
            if (P1 == "StringPalindrome")
            {
                string re = Services.LogInservice.StringPalindrome(Input1);
                ViewBag.Ans = re;
            }
            if (P1 == "StringLength")
            {
                int re = Services.LogInservice.StringLength(Input1);
                ViewBag.Ans = re;
            }
            if (P1 == "IndividualcharactersInString")
            {
                string re = Services.LogInservice.IndividualcharactersInString(Input1);
                ViewBag.Ans = re;
            }
            if (P1 == "IndividualcharactersOfStringInReverseOrder")
            {
                string re = Services.LogInservice.IndividualcharactersOfStringInReverseOrder(Input1);
                ViewBag.Ans = re;
            }
            if (P1 =="NumberOfWordsInString")
            {
                int re = Services.LogInservice.NumberOfWordsInString(Input1);
                ViewBag.Ans = re;
            }
            if (P1 == "CompareTwoStrings")
            {
                string re = Services.LogInservice.CompareTwoStrings(Input1,Input2);
                ViewBag.Ans = re;
            }
            if (P1 == "NumberOfAlaphabetsandVowels")
            {
                string re = Services.LogInservice.NumberOfAlaphabetsandVowels(Input1);
                ViewBag.Ans = re;
            }
            if (P1 =="StringCopy")
            {
                string re = Services.LogInservice.StringCopy(Input1);
                ViewBag.Ans = re;
            }
            int IntInput1 = Convert.ToInt32(Input1);
            if (P1 == "Factorial")
            {
                int re = Services.LogInservice.Factorial(IntInput1);
                ViewBag.Ans = re;
            }
            if (P1 == "SumOfDigits")
            {
                int re = Services.LogInservice.SumOfDigits(IntInput1);
                ViewBag.Ans = re;
            }
            if (P1 == "ReverseNumber")
            {
                int re = Services.LogInservice.ReverseNumber(IntInput1);
                ViewBag.Ans = re;
            }
            if (P1 == "Palindrome")
            {
                string re = Services.LogInservice.Palindrome(IntInput1);
                ViewBag.Ans = re;
            }
            if (P1 == "ArmstrongNumber")
            {
                string re = Services.LogInservice.ArmstrongNumber(IntInput1);
                ViewBag.Ans = re;
            }
            return View();
        }
    }
}
