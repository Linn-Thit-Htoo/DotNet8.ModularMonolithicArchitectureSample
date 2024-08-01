using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shared.DTOs.Features.Blog
{
    public class BlogRequestModel
    {
        public string BlogTitle { get; set; }
        public string BlogAuthor { get; set; }
        public string BlogContent { get; set; }
    }
}
