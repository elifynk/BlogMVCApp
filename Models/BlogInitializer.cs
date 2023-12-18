using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace BlogMvcApp.Models
{
    public class BlogInitializer:DropCreateDatabaseIfModelChanges<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            List<Category> kategoriler = new List<Category>() 
            {
                new Category {KategoriAdi = "C#"},
                new Category {KategoriAdi = "Asp.Net MVC"},
                new Category {KategoriAdi = "Asp.Net Web Forms"},
                new Category {KategoriAdi = "Asp.Net Windows Forms"},
            };

            foreach (var item in kategoriler)
            {
                context.Kategoriler.Add(item);
            }
            context.SaveChanges();

            List<Blog> bloglar = new List<Blog>() 
            {
                new Blog { Baslik = "C# Delegates", Aciklama = "C# Delegates Hakkında", EklenmeTarihi= DateTime.Now.AddDays(-10), Icerik = "C# Delegates Hakkında Uzun Açıklama", Anasayfa = true, Onay = true, Resim = "1.jpg"},
                new Blog { Baslik = "C# Generative", Aciklama = "C# Generative Hakkında", EklenmeTarihi= DateTime.Now.AddDays(-20), Icerik = "C# Generative Hakkında Uzun Açıklama", Anasayfa = true, Onay = false, Resim = "2.jpg"},
                new Blog { Baslik = "C# Loop", Aciklama = "C# Loop Hakkında", EklenmeTarihi= DateTime.Now.AddDays(-1), Icerik = "C# Loop Hakkında Uzun Açıklama", Anasayfa = false, Onay = true, Resim = "1.jpg"},
                new Blog { Baslik = "C# Condition", Aciklama = "C# Condition Hakkında", EklenmeTarihi= DateTime.Now.AddDays(-5), Icerik = "C# Generative Hakkında Uzun Açıklama", Anasayfa = true, Onay = false, Resim = "2.jpg"},
                new Blog { Baslik = "C# Delegates-2", Aciklama = "C# Delegates Hakkında", EklenmeTarihi= DateTime.Now.AddDays(-30), Icerik = "C# Condition Hakkında Uzun Açıklama", Anasayfa = false, Onay = true, Resim = "1.jpg"},
                new Blog { Baslik = "C# Generative-2", Aciklama = "C# Generative Generative", EklenmeTarihi= DateTime.Now.AddDays(-12), Icerik = "C# Loop Hakkında Uzun Açıklama", Anasayfa = true, Onay = true, Resim = "2.jpg"},
                new Blog { Baslik = "C# Loop-2", Aciklama = "C# Loop Hakkında", EklenmeTarihi= DateTime.Now.AddDays(-8), Icerik = "C# Delegates Hakkında Uzun Açıklama", Anasayfa = true, Onay = false, Resim = "1.jpg"},
                new Blog { Baslik = "C# Condition-2", Aciklama = "C# Condition Hakkında", EklenmeTarihi= DateTime.Now.AddDays(-18), Icerik = "C# Condition Hakkında Uzun Açıklama", Anasayfa = false, Onay = true, Resim = "1.jpg"},
            };

            foreach (var item in bloglar)
            {
                context.Bloglar.Add(item);
            }

            context.SaveChanges();

            base.Seed(context);
        }
    }
}