using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SQLiteDemo.Models;

namespace SQLiteDemo
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                using (DBContext db = new DBContext())
                {
                    //User user = new User()
                    //{
                    //    Name = "zhangsan"
                    //};
                    //db.Users.Add(user);
                    //db.SaveChanges();

                    List<User> users = db.Users.ToList();
                    foreach (var item in users)
                        Console.WriteLine(item.Name);
                }
            }
            catch { }
        }
    }
}
