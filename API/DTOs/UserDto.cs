using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace API.DTOs
{
    public class UserDto
    {
        public string userName { get; set; }
        public string token { get; set; }

        public string photoUrl { get; set; }
    }
}