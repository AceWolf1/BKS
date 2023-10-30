using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BKS.ClassHelper
{
    internal class EF
    {
        public static DB.Entity Context { get; set; } = new DB.Entity();
    }
}
