using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using MVCHome.DAL.Data;
using System.Data.Entity;

namespace MVCHome.DAL.Repository
{
    public class RepositoryArticle : IRepository<Artiсle>
    {
        private BlogContext db;
        public RepositoryArticle()
        {
            db = new BlogContext();
        }
        public RepositoryArticle(BlogContext context)
        {
            this.db = context;
        }
        public IEnumerable<Artiсle> GetAll()
        {
            return db.Articles;
        }
        public Artiсle Get(int id)
        {
            return db.Articles.Find(id);
        }
        public void Create(Artiсle article)
        {
            db.Articles.Add(article);
        }

        public void Update(Artiсle article)
        {
            db.Entry(article).State = EntityState.Modified;
        }
        public void Delete(int id)
        {
            Artiсle article = db.Articles.Find(id);
            if (article != null)
            {
                db.Articles.Remove(article);
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}