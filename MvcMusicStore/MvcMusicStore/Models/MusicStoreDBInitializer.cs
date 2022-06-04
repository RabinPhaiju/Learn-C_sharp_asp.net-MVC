using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace MvcMusicStore.Models
{
    public class MusicStoreDBInitializer : DropCreateDatabaseAlways<MusicStoreDB>
    {
        protected override void Seed(MusicStoreDB context)
        {
            Album album1 = new Album()
            {
                Title = "Test12",
                Price = 1200,
                AlbumArtUrl = "www.google12.com",
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