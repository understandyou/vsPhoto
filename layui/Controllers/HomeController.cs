using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using System.IO;
using layuiBLL;

namespace layui.Controllers
{
    public class HomeController : Controller
    {
        public ActionResult Index()
        {
            return View();
        }

        public ActionResult ts1() {
            return View();
        }
        public ActionResult ts2()
        {
            return View();
        }
        public ActionResult btupload() {

            return View();
        }

        public ActionResult upload(HttpPostedFileBase[] file)
        {
            //string result = "";
            Dictionary<string, object> map = new Dictionary<string, object>();
            try
            {
                if (file != null)
                {
                    var path = Server.MapPath(string.Format("~/{0}", "File"));
                    mydir.createdir(path);
                    for (int i = 0; i < file.Length; i++)
                    {
                        var name = file[i].FileName;
                        file[i].SaveAs(Path.Combine(path, name));
                    }
                }
                map.Add("result", "ok");
            }
            catch (Exception e)
            {
                map.Add("result", "no");

            }
            return Json(new {
                //result = "{'result':'ok'}"
                result = map
            });
        }

    }
}