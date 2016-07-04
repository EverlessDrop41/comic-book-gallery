using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookGallery.Models
{
    public class Artist
    {
        public string Role { get; set; }
        public string Name { get; set; }
        public string FormatedString => $"{Role}: {Name}";
    }
}
