using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ComicBookGallery.Models
{
    class ComicBook
    {
        public int Id { get; set; }
        public string SeriesTitle { get; set; }
        public int IssueNumber { get; set; }
        public string DescriptionHtml { get; set; }
        public Artist[] Artists { get; set; }
        public bool Favourite { get; set; }
    }
}
