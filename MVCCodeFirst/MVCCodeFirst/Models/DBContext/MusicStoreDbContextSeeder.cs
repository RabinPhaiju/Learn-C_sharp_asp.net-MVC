using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MVCCodeFirst.Models.DBContext
{
    public class MusicStoreDbContextSeeder:DropCreateDatabaseIfModelChanges<MusicStoreDbContent>
    {
        protected override void Seed(MusicStoreDbContent context)
        {
            Album album1 = new Album()
            {
                Title = "Test1111",
                Price = 1200,
                AlbumArtUrl = "www.googless.com",
                Genre = new Genre()
                {
                    Name = "GTest",
                    Description = " G_Description",
                },
                Artist = new Artist()
                {
                    Name = "Artist_Name",
                }
            };
            context.Albums.Add(album1);
            context.SaveChanges();

        }
    }
}