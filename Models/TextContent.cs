using System;

namespace GroupAssignment.Models
{
    public class TextContent: Content
    {
        public Guid Id { get; set; }
        public string Text { get; set; }

        public string ToHtml()
        {
            return Text;
        }
    }
}

