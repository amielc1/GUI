using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ServerBox
{
    
   public interface IServerBoxOperations
    {
        bool Insert(string post);
        bool Remove(string post);
        bool RemoveAllPosts();
        bool Update(string post);
        IEnumerable<string> GetAllPossts(); 
        
    }
}
