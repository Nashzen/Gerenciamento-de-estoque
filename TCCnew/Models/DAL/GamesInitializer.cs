using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace TCCnew.Models.DAL
{
    public class GamesInitializer : System.Data.Entity.DropCreateDatabaseIfModelChanges<GamesContext>
    {
        protected override void Seed(GamesContext context)
        {
            base.Seed(context);
        }
    }
}