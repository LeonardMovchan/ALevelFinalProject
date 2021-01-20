using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PokerTrainingWebsite.DAL
{
    public class PokerTrainingContext : DbContext
    {
        public PokerTrainingContext() : base("Default")
        {

        }
    }
}
