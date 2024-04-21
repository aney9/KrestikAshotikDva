using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace krestikashotikDva.Model
{
    internal class model
    {
        public string Nickname { get; set; }
        public string Password { get; set; }
       
        public model(string nickname, string password)
        {
            nickname = Nickname;
            password = Password;
        }
    }
}
