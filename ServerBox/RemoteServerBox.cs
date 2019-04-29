using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerBox
{
    public class RemoteServerBox : IServerBoxOperations
    {
        public IEnumerable<string> GetAllPossts()
        {
            System.Threading.Thread.Sleep(5000);
            var posts =  PostsGenerator.GetPosts();
            return posts; 
        }

        public bool Insert(string post)
        {
            System.Threading.Thread.Sleep(2000);
            System.Threading.Thread.Sleep(3000);
            return true;
        }

        public bool Remove(string post)
        {
            throw new NotImplementedException();
        }

        public bool RemoveAllPosts()
        {
            throw new NotImplementedException();
        }

        public bool Update(string post)
        {
            throw new NotImplementedException();
        }
    }
}
