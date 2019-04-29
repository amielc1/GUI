using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerBox
{
   public  class PostsGenerator
    {
        static int i = 0;
        public static IEnumerable<string> GetPosts()
        {
            var postList = new List<string>();
            for (int j = 0; j < 100; j++, i++)
            {
                postList.Add("Post" + i);
            }
            return postList;
        }
    }
}
