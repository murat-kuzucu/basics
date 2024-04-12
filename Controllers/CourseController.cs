using Microsoft.AspNetCore.Mvc;

namespace basics.Controllers;

//Course
public class CourseController : Controller
{
    // /course/index
    public string Index(){
        return "course/index";
    }
    // /course/list
    public string List(){
        return "course/list";
    }
}