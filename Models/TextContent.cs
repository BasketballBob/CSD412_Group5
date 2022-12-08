using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace CSD412_Group_Assignment.Models
{
    public class TextContent : Content
    {
        public string Text { get; set; }

        public string ToHtml()
        {
            return Text;
        }
    }
}
