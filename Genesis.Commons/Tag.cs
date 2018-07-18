using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genesis.Commons
{
    public class Tag : ITag
    {
        private string _Name;

        public string Name
        {
            get
            {
                return _Name;
            }

            set
            {
                _Name = value;
            }
        }

        public Tag(string name = "")
        {
            _Name = name;
        }

        bool ITag.updateTagName(string name = "")
        {
            if (String.Equals(_Name, name))
            { return false; }
            else
            {
                _Name = name;
                return true;
            }
        }
    }
}
