using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class PostDto
    {
        public int Id {get; set;}
        public int UserId {get; set;}
        public string Content {get; set;} = string.Empty;

    }
}