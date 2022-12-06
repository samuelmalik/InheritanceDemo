using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Post
    {
        private static int currentPostID = 0;

        // properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        public string SendByUsername { get; set; }
        public bool IsPublic { get; set; }

        // default construcotr
        public Post()
        {
            this.ID = 0;
            this.Title = "MyfirstPost";
            this.IsPublic = true;
            this.SendByUsername = "Oliverko Krška";
        }

        // instance constructor
        public Post(string title, bool isPublic, string sendByUsername)
        {
            this.ID = GetNextID();
            this.Title = title;
            this.SendByUsername = sendByUsername;
            this.IsPublic = isPublic;
        }

        protected int GetNextID()
        {
            return ++currentPostID;
        }

        public void Update(string title, bool isPublic)
        {
            this.Title = title;
            this.IsPublic = isPublic;
        }

        public override string ToString()
        {
            return String.Format("{0} - {1} - by {2}", this.ID, this.Title, this.SendByUsername );
        }
    }
}
