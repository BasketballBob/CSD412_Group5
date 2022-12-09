using System;
using System.Collections.Generic;

namespace GroupAssignment.Models
{
    public class Page
    {
        public Guid Id { get; set; }
        public User Owner;
        public string Title;
        public List<TextContent> PageContent { get; set; }
    }
}

