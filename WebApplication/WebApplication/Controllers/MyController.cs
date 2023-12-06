using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace WebApplication.Controllers
{
    public class MyController : Controller
    {
        // GET: My
        public ActionResult FirstViewMethod()
        {
            List<string> list = GetTeamsList();
            return View(list);
        }

        public ActionResult SecondViewMethod() 
        {
            return View(GetTeamsList().OrderBy(x => x).ToList());
        }

        public ActionResult ThirdViewMethod()
        {
            return View(GetTeamsList().OrderBy(x => x).ToList());
        }

        public List<string> GetTeamsList()
        {
            List<string> teams = new List<string>
            {
                "Краснодар",
                "Зенит",
                "Динамо",
                "Крылья Советов",
                "ЦСКА",
                "Локомотив",
                "Спартак",
                "Рубин",
                "Нижний Новгород",
                "Ростов",
                "Факел",
                "Урал",
                "Ахмат",
                "Оренбург",
                "Балтика",
                "Сочи"
            };

            return teams;
        }
    }
}