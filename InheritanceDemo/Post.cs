using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InheritanceDemo
{
    class Post
    {
        private static int currentPostID;

        // properties
        protected int ID { get; set; }
        protected string Title { get; set; }
        public string SendByUsername { get; set; }
        public bool IsPublic { get; set; }

        // 
        
    }
}
