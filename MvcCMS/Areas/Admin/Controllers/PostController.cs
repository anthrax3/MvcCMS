using System.Web.Mvc;
using MvcCMS.Models;

namespace MvcCMS.Areas.Admin.Controllers
{
    [RouteArea("Admin")]
    [RoutePrefix("post")]
    public class PostController : Controller
    {
        // GET: Admin/Post
        public ActionResult Index()
        {
            return View();
        }

        //admin/post/create
        [HttpGet]
        [Route("create")]

        public ActionResult Create()
        {
            //TODO: retrieve the model from data store
            var model = new Post();

            return View(model);
        }

        //admin/post/create
        [HttpPost]
        [Route("create")]
        [ValidateAntiForgeryToken]

        public ActionResult Create(Post model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            //TODO: create model in data store

            return RedirectToAction("Index");
        }


        //admin/post/edit/post-to-edit
        [HttpGet]
        [Route("edit/{id}")]
        public ActionResult Edit(string id)
        {
            //TODO: retrieve the model from data store
            var model = new Post();

            return View(model);
        }

        //admin/post/edit/post-to-edit
        [HttpPost]
        [Route("edit/{id}")]
        [ValidateAntiForgeryToken]
        public ActionResult Edit(Post model)
        {
            if (!ModelState.IsValid)
            {
                return View(model);
            }

            //TODO: update model in data store

            return RedirectToAction("Index");
        }
    }
}