﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MVCHome.DAL.Data;
using MVCHome.DAL.Repository;
using MVCHome.DAL;

namespace MVCHome.DAL.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private BlogContext db;
        private RepositoryArticle repositoryArticle;
        private RepositoryReview repositoryReview;
        //private RepositoryVote repositoryVote;
        private RepositoryTag repositoryTag;
        public UnitOfWork(string stringConection)
        {
            db = new BlogContext(stringConection);
        }
        public UnitOfWork() 
        {
            db = new BlogContext();
        }
        public IRepository<Artiсle> Articles
        {
            get
            {
                if (repositoryArticle == null)
                    repositoryArticle = new RepositoryArticle(db);
                return repositoryArticle;
            }
        }
        public IRepository<Review> Reviews
        {
            get
            {
                if (repositoryReview == null)
                    repositoryReview = new RepositoryReview(db);
                return repositoryReview;
            }
        }
        //public IRepository<Vote> Votes
        //{
        //    get
        //    {
        //        if (repositoryVote == null)
        //            repositoryVote = new RepositoryVote(db);
        //        return repositoryVote;
        //    }
        //}
        public IRepository<Tag> Tags
        {
            get
            {
                if (repositoryTag == null)
                    repositoryTag = new RepositoryTag(db);
                return repositoryTag;
            }
        }
        public void Save()
        {
            db.SaveChanges();
        }
    }
}
