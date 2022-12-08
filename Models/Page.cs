using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSD412_Group_Assignment.Models
{
    public class Page
    {
        public Guid Id { get; set; }
        public User Owner;
        public string Title;
        private List<Content> PageContent { get; set; }
    }
}
