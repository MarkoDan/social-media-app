using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Threading.Tasks;

namespace Core.Models
{
    [Table("Photos")]
    public class Photo
    {
        public int Id {get; set;}
        public string Url {get; set;} = string.Empty;
        public string PublicId {get; set;} = string.Empty;
    }
}