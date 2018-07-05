using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genesis.Commons
{
    public class Tag
    {
        public string Name { get; set; }

        public Tag(string name = "")
        {
            Name = name;
        }

        public bool updateTag(string name = "")
        {
            if (String.Equals(Name, name))
            { return false; }
            else
            {
                Name = name;
                return true;
            }
        }
    }
}
