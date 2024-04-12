using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

//Course
public class CourseController : Controller
{
    // /course/index
    public IActionResult Index(){
        return View();
    }
    // /course/list
    public IActionResult List(){
        return View();
    }
    public IActionResult CourseList(){
        return View();
    }
}