using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace MVCCodeFirst.Models.DBContext
{

    public class MusicStoreRepository
    {
        private MusicStoreDbContent _dbcontext;
        public MusicStoreRepository()
        {
            _dbcontext = new MusicStoreDbContent();
        }
        public List<Album> GetAlbums()
        {
         
            return _dbcontext.Albums.Include("Genre").Include("Artist").ToList(); // Join
        }
        public List<Album> FilterDataFunc(){

            //var query = from a in _dbcontext.Albums where a.AlbumId >= 6 select a;
            //var query = _dbcontext.Albums.Include("Genre").Include("Artist").Where(a => a.AlbumId <= 6);
            var query = from a in _dbcontext.Albums where a.AlbumId >= 1 select a;

            return query.ToList();
        }
        public List<Student> GetAllStudentsList()
        {

            List<Student> listStudents = new List<Student>
            {
            new Student{
            Name = "Tom",
            Gender = "Male",
            Subjects = new List<string> { "ASP.NET", "C#" }
            },
            new Student{
            Name = "Mike",
            Gender = "Male",
            Subjects = new List<string> { "ADO.NET", "C#", "AJAX" }
            },
            new Student{
            Name = "Pam",
            Gender = "Female",
            Subjects = new List<string> { "WCF", "SQL Server", "C#" }
            },
            new Student{
            Name = "Mary",
            Gender = "Female",
            Subjects = new List<string> { "WPF", "LINQ", "ASP.NET" }
            },
            };
            return listStudents;
        }
    }
}