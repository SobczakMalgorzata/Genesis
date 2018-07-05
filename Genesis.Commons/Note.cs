using System;
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
        public List<Tag> Tags { get; set; }

        public Note (string body = "", string title = "")
        {
            Title = title;
            Body = body;
            Tags = new List<Tag>();
        }

        public bool updateTitle(string title)
        {
            //checking if title is realy changing
            if (String.Equals(Title, title))
                { return false; }
            else
            {
                Title = title;
                return true;
            }
        }

        public bool addTag(Tag tag)
        {
            //checking if tag is already on the list
            if (Tags.Contains(tag))
            {
                //if it exists we do not double
                return false;
            }
            else
            {
                Tags.Add(tag);
                return true;
            }
        }

        public bool removeTag(Tag tag)
        {
            //checking if tag is already on the list
            if (Tags.Contains(tag))
            {
                //we remove only if it exist
                Tags.Remove(tag);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
