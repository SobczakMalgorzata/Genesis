﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genesis.Commons
{
    interface ITag
    {
        //Properties
        string Name { get; set; }

        //Methods
        bool updateTagName(string name);
    }
}
