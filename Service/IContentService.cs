using System;
using System.Collections.Generic;
using GroupAssignment.Models;

namespace GroupAssignment.Service
{
    public interface IContentService
    {
        List<Page> GetUserPages(Guid userId);
    }
}