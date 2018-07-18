﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genesis.Commons
{
    interface INote
    {
        //Properties
        List<Tag> Tags { get; set; }

        //Methods
        //Title
        bool updateTitle(string title);
        //Tag
        bool addTag(Tag tag);
        bool removeTag(Tag tag);

    }
}
