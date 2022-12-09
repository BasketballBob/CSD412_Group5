using System;
using System.Collections.Generic;
using GroupAssignment.Models;

namespace GroupAssignment.Service
{
    public class ContentService : IContentService
    {
        public List<Page> GetUserPages(Guid userId)
        {
            return new List<Page>()
            {
                new Page()
                {
                    Title = "Page 1",
                    PageContent = new System.Collections.Generic.List<TextContent>()
                    {
                        new TextContent()
                        {
                            Text = "Page1 Header"
                        },
                        new TextContent()
                        {
                            Text = "Page Content"
                        },
                    }
                },
                new Page()
                {
                    Title = "Page 2",
                    PageContent = new System.Collections.Generic.List<TextContent>()
                    {
                        new TextContent()
                        {
                            Text = "Page2 Header"
                        },
                        new TextContent()
                        {
                            Text = "Page Content"
                        },
                    }
                }
            };
        }
    }
}

