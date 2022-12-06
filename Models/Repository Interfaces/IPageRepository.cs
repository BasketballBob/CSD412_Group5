using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace GroupAssignment.Models.Repository_Interfaces
{
    public interface IPageRepository
    {
        Page AddPage(Page page);
        Page GetPage(Guid Id);
        Page UpdatePage(Page pageChanges);
        Page DeletePage(Page page);

        List<Page> GetAllPages();
    }
}
