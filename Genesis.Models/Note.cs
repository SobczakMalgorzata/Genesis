using NodaTime;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genesis.Models
{
    public class Note
    {
        public string Title { get; set; }
        public string Body { get; set; }
        public HashSet<Tag> Tags { get; set; } = new HashSet<Tag>();
        public Instant Time { get; set; }

        public Note (string body = "", string title = "")
        {
            Title = title;
            Body = body;
        }
        
    }
}
