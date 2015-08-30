using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Web;

namespace SocialNetwork1._1.Models
{
    public class UserDbInitializer : DropCreateDatabaseAlways<UserContext>
    {
        protected override void Seed(UserContext db)
        {
            db.Users.Add(new Admin { Login = "lighthinata@gmail.com", Password = "kuroshitsuji1" });
            db.Users.Add(new User { Login = "ololosha@gmail.com", Password = "hYhCfIjhbdV" });
            db.Users.Add(new User { Login = "5526894@gmail.com", Password = "tybskafBFGFf~&bnsi" });

            base.Seed(db);
        }
    }
}