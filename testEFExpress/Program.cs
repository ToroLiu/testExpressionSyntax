using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using testEFExpress.Models;

namespace testEFExpress
{
    class Program
    {
        static void Main(string[] args)
        {
            Guid gid = Guid.NewGuid();
            int cateId = 0;
            using (MyContent db = new MyContent()) {
                Category cate = new Category();
                cate.Name = "Hello World" + gid;
                db.CategorySet.Add(cate);

                List<Data> cntList = new List<Data>() {
                    new Data() { FirstName = "ff" },
                    new Data() { FirstName = "aaa"},
                    new Data() { FirstName = "bbb"},
                };
                foreach (var cnt in cntList)
                {
                    cate.ContactSet.Add(cnt);
                }

                cateId = cate.Id;
                db.SaveChanges();
            }

            //! Test Expression<<T,U>> syntax for OrderBy() method.
            Expression<Func<Data, string>> orderField = (obj) => obj.FirstName;
            using (MyContent db = new MyContent())
            {
                List<Data> results = db.ContactSet.OrderBy(orderField).ToList();
                results.ForEach(obj => Console.WriteLine(obj.Id + ":" + obj.FirstName));

                results.ForEach(obj => db.ContactSet.Remove(obj));
                db.SaveChanges();
            }
        }
    }
}
