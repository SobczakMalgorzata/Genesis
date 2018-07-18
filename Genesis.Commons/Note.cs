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
        private List<Tag> _Tags;

        public List<Tag> Tags
        {
            get
            {
                return _Tags;
            }

            set
            {
                _Tags = value;
            }
        }

        public Note (string body = "", string title = "")
        {
            Title = title;
            Body = body;
            _Tags = new List<Tag>();
        }

        bool INote.updateTitle(string title)
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

        bool INote.addTag(Tag tag)
        {
            //checking if tag is already on the list
            if (_Tags.Contains(tag))
            {
                //if it exists we do not double
                return false;
            }
            else
            {
                _Tags.Add(tag);
                return true;
            }
        }

        bool INote.removeTag(Tag tag)
        {
            //checking if tag is already on the list
            if (_Tags.Contains(tag))
            {
                //we remove only if it exist
                _Tags.Remove(tag);
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
