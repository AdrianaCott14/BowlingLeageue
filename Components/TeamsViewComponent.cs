using BowlingLeague.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace BowlingLeague.Components
{
    public class TeamsViewComponent : ViewComponent
    {
        private BowlingLeagueContext context;
        //constructor
        public TeamsViewComponent(BowlingLeagueContext con)
        {
            context = con;
        }

        public IViewComponentResult Invoke()
        {
            ViewBag.SelectedTeam = RouteData?.Values["teamid"];

            return View(context.Teams
                .Distinct()
                .OrderBy(x => x));
        }
    }
}
