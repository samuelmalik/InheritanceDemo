using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    internal class ImagePost : Post
    {
        public string ImageURL { get; set; }

        public ImagePost() { }

        public ImagePost(string title, string sendByUsername,  bool isPublic, string imageURL) : base(title, isPublic, sendByUsername)
        {
            this.ID = GetNextID();
            this.ImageURL = imageURL;
        }

        public override string ToString()
        {
            return String.Format($"{base.ToString()} - {this.ImageURL}");
        }
    }
}
