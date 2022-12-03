using System;

namespace GroupAssignment.Models
{
    public class TextContent: Content
    {
        public string Text { get; set; }

        public string ToHtml()
        {
            return Text;
        }
    }
}

