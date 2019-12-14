using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ZadDomLab4JakubKazimierski.Models
{
    class FBIdbContext : DbContext
    {
        /// <summary>
        /// Constructor
        /// </summary>
        public FBIdbContext() : base("AppContext")
        {

        }

        /// <summary>
        /// Adding objects into data base
        /// </summary>
        public virtual DbSet<FBIagentsList> Agents { get; set; }
        public virtual DbSet<FBIcriminalsList> Criminals { get; set; }
        public virtual DbSet<FBIagentsType> AgentsTypes { get; set; }
        public virtual DbSet<FBIcriminalsType> CriminalsTypes { get; set; }
        public virtual DbSet<FBIagentsUndercover> AgentsUndercover { get; set; }


    }
}
