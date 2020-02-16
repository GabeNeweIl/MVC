using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Data.Entity;
using MVCHome.DAL.Data;

namespace MVCHome.DAL
{
    public class BlogDbInitializer : CreateDatabaseIfNotExists<BlogContext>
    {
        protected override void Seed(BlogContext context)
        {
            context.Articles.Add(new Artiсle { Heading = "Интеграл", Publish = new DateTime(2019, 7, 25), Text = "Интеграл — одно из важнейших понятий математического анализа," +
                    " которое возникает при решении задач о нахождении площади под кривой, пройденного пути при неравномерном движении," +
                    " массы неоднородного тела, и тому подобных, а также в задаче о восстановлении функции по её производной."
            });
            context.Reviews.Add(new Review
            {
                Name = "Артем",
                Publish = DateTime.Now,
                Text = "Замечательный сайт"
            }) ;
            base.Seed(context);
        }
    }
}