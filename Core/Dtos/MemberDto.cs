using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Dtos
{
    public class MemberDto
    {
        public int Id {get; set;}
        public string Username {get; set;} = string.Empty;
        public DateTime Created {get; set;}
        public string Name {get; set;} = string.Empty;
        public List<PostDto> Posts {get ; set;} = new List<PostDto>();
    }
}