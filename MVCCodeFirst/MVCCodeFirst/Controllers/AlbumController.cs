using MVCCodeFirst.Models.DBContext;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;

namespace MVCCodeFirst.Controllers
{
    public class AlbumController : Controller
    {
        // GET: Album
        public ActionResult Index()
        {
            MusicStoreRepository repository = new MusicStoreRepository();
            return View(repository.GetAlbums());
        }
        public void DisplaySqlResult()
        {
            MusicStoreRepository repository = new MusicStoreRepository();

            var data = repository.FilterDataFunc();
            foreach (var item in data)
            {
                Response.Write("id:"+ item.AlbumId + " " + item.Title + " " + item.AlbumArtUrl + " " + item.Price.ToString());
            }
        }
        public void SelectManyResult()
        {
            MusicStoreRepository repository = new MusicStoreRepository();
            //Using Method syntax
            //IEnumerable<string> allSubjects = repository.GetAllStudentsList().SelectMany(s => s.Subjects);

            // using query syntax
            IEnumerable<string> allSubjects = from student in repository.GetAllStudentsList() from subject in student.Subjects select subject;

            foreach (string subject in allSubjects)
            {
                Response.Write(subject + "</br>");
            }
        }
        //Test
        public void Test()
        {
            int[] Numbers = { 1, 2, 3, 4, 5, 6, 7, 8 };
            int result = Numbers.Min();
            //OR find min even number
            int result2 = Numbers.Where(x=> x%2 == 0).Min();
            Response.Write(result2.ToString());
        }
        public void Test2()
        {
           
            List<int> Numbers = new List<int> { 1, 2, 3, 4, 5, 6, 7, 8, 9 };
            //IEnumerable<int> result = from num in Numbers where num % 2 == 0 select num;
            IEnumerable<int> result = Numbers.Where(x => x % 3 == 0);
            foreach (int num in result)
            {
                Response.Write(num.ToString() + "</br>");
            }
        }
    }
}