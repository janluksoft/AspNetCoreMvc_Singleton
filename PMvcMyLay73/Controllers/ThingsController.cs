using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using PMvcMyLay73.Models;
using System.Diagnostics;


namespace PMvcMyLay73.Controllers
{
    public class ThingsController : Controller
    {
        //Stuff

        //private readonly Stuff cStuff;

        //public ThingsController(Stuff xStuff)
        //{
        //    cStuff = xStuff;
        //}

        private readonly IStuffService _stuffService;
        private readonly IStuffServiceSingle _stuffServiceSingle;
        //private readonly IUserService _userService;
        public ThingsController(IStuffService stuffService, IStuffServiceSingle stuffServiceSingle)
        {
            //_userService = userService;
            _stuffService = stuffService;
            _stuffServiceSingle = stuffServiceSingle;
        }


        // GET: ThingsController
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult Stuff0()
        {
            var aStuff = _stuffService.GetStuff();
            //return Ok(user);
            return View(aStuff);
            //return View();
        }

        public ActionResult Stuff1(int id)
        {
            var aStuff = _stuffService.GetStuff(id);
            return View(aStuff);
        }

        public ActionResult Single(int id)
        {
            var aStuff = _stuffServiceSingle.GetStuff(id);
            return View(aStuff);
        }


        public ActionResult Stuff5()
        {
            //var user = _userService.GetUser();
            //return Ok(user);
            //return View(user);
            return View();
        }


        // GET: ThingsController/Details/5
        public ActionResult Details(int id)
        {
            return View();
        }

        // GET: ThingsController/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: ThingsController/Create
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Create(IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ThingsController/Edit/5
        public ActionResult Edit(int id)
        {
            return View();
        }

        // POST: ThingsController/Edit/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }

        // GET: ThingsController/Delete/5
        public ActionResult Delete(int id)
        {
            return View();
        }

        // POST: ThingsController/Delete/5
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(int id, IFormCollection collection)
        {
            try
            {
                return RedirectToAction(nameof(Index));
            }
            catch
            {
                return View();
            }
        }
    }
}
