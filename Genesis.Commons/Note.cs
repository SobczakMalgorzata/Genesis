﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genesis.Commons
{
    public class Note : INote
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public HashSet<Tag> Tags { get; set; }

        public Note (string body = "", string title = "")
        {
            Title = title;
            Body = body;
            Tags = new HashSet<Tag>();
        }
        
    }
}
