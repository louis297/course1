using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using course1.Models;

namespace course1.Controllers
{
    public class PostController : Controller
    {
        //List<Post> postList;
        PostDB1 _db = new PostDB1();
        // GET: Post
        public ActionResult Index()
        {
            var model = _db.Posts.ToList();
            return View(model);
        }

        // GET: Post/Details/5
        public ActionResult Details(int id)
        {
            var models = from p in _db.Posts
                        where p.postId == id
                        select p;
            
            if (models != null)
            {
                var model = models.First();
                return View(model);
            }
            else
            {
                return Content("Post not found");
            }
        }

        // GET: Post/Create
        public ActionResult Create()
        {
            return View();
        }

        // POST: Post/Create
        [HttpPost]
        public ActionResult Create(Post post)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    _db.Posts.Add(post);
                    _db.SaveChanges();
                }

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Post/Edit/5
        public ActionResult Edit(int id)
        {

            var models = from p in _db.Posts
                         where p.postId == id
                         select p;

            if (models != null)
            {
                var model = models.First();
                return View(model);
            }
            else
            {
                return Content("Post not found");
            }
        }

        // POST: Post/Edit/5
        [HttpPost]
        public ActionResult Edit(int id, Post post)
        {
            try
            {
                if (ModelState.IsValid)
                {
                    var target = _db.Posts.First(i => i.postId == id);
                    target.postTitle = post.postTitle;
                    target.postBody = post.postBody;
                    target.postAuthor = post.postAuthor;

                    _db.SaveChanges();
                }
                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }

        // GET: Post/Delete/5
        public ActionResult Delete(int id)
        {
            //postList.RemoveAll(i => i.postId == id);
            //System.Console.WriteLine(postList.Count());
            var target = _db.Posts.First(i => i.postId == id);
            _db.Posts.Remove(target);
            _db.SaveChanges();
            return RedirectToAction("Index");
        }

        // POST: Post/Delete/5
        [HttpPost]
        public ActionResult Delete(int id, Post post)
        {
            try
            {
                // TODO: Add delete logic here
                //postList.RemoveAll(i => i.postId == id);

                return RedirectToAction("Index");
            }
            catch
            {
                return View();
            }
        }
        //public PostController() 
        //{
        //    this.postList = new List<Post>
        //    {
        //        new Post
        //        {
        //            postId = 1,
        //            postTitle = "title 1",
        //            postAuthor = "A",
        //            postBody = "content 1"
        //        },
        //        new Post
        //        {
        //            postId = 2,
        //            postTitle = "title 2",
        //            postAuthor = "author 2",
        //            postBody = "content 2"
        //        },
        //        new Post
        //        {
        //            postId = 3,
        //            postTitle = "title 3",
        //            postAuthor = "A",
        //            postBody = "content 3"
        //        }
        //    };
            
        //}

        protected override void Dispose(bool disposing)
        {
            if(_db != null)
            {
                _db.Dispose();
            }
            base.Dispose(disposing);
        }
    }
}
