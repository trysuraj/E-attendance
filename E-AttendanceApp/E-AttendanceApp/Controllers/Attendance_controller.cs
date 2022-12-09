using Application.Interface;
using Domain.ViewModel;
using Microsoft.AspNetCore.Mvc;

namespace E_AttendanceApp.Controllers
{
    public class Attendance_controller : Controller
    {
        private IServices _Services;

        public Attendance_controller(IServices services)
        {
            _Services = services;
        }
        [HttpGet]
        public IActionResult Index()
        {
            return View();
        }
        [HttpPost]
        public async Task <IActionResult> Index([FromForm] AttendeesVM model)
        {
            if (!ModelState.IsValid)
            {
                ViewBag.Message = "fill in the empty spaces";
                return View();
            }
            var res = await _Services.CreateAttendee(model);
            if (!res)
            {
                ViewBag.Message = "could not create User";
            }
            ViewBag.Message = "User Created successfully";
            return View();
        }

    }
}
