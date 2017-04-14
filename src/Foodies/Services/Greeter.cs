using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Foodies.Services
{
    public interface IGreeter
    {
        string GetGreeting();
    }


    public class Greeter : IGreeter 
    {
        private string _config;

        public Greeter(IConfiguration config)
        {
            _config = config["greeting"];
        }

        public string GetGreeting()
        {
            return _config;
        }
    }
}
