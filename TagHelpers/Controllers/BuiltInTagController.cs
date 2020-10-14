using Microsoft.AspNetCore.Mvc;

namespace TagHelpers.Controllers
{
    public class BuiltInTagController : Controller
    {
        public IActionResult Index()
        {
            return View();
        }

        public IActionResult AnchorTagHelper()
        {
            return View();
        }

        public IActionResult ScriptTagHelper()
        {
            return View();
        }

        public IActionResult CacheTagHelper(string id, string myParameter1, string myParameter2)
        {
            var viewName = id == null
                ? "CacheTagHelper/no-parameters"
                : "CacheTagHelper/" + id;
             
            int.TryParse(myParameter1, out var num1);
            int.TryParse(myParameter2, out var num2);

            var model = new ModelParam
            {
                Sum = num1 + num2,
                Param1 = "value1",
                Param2 = "value2"
            };

            return View(viewName, model);
        }

        public IActionResult EnvironmentTagHelper()
        {
            return View();
        }
        public IActionResult ImageTagHelper()
        {
            return View();
        }
    }

    public class ModelParam
    {
        public string Param2 { get; set; }
        public string Param1 { get; set; }
        public int Sum { get; set; }
    }

    public class Speaker
    {
        public int SpeakerId { get; set; }
        public string SpeakerNaöe { get; set; }
    }
}
