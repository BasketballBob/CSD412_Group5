using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using GroupAssignment.Models.Repository_Interfaces;

namespace GroupAssignment.Models.Repositories
{
    public class PageRepository : IPageRepository
    {
        private readonly DatabaseContext context;

        public PageRepository(DatabaseContext context)
        {
            this.context = context;
        }

        public Page GetPage(Guid Id)
        {
            return new Page(); // context.Pages.Find(Id);
        }

        public Page AddPage(Page page)
        {
            // context.Pages.Add(page);
            // context.SaveChanges();

            return page;
        }

        public Page UpdatePage(Page pageChanges)
        {
            // var page = context.Pages.Attach(pageChanges);
            // page.State = Microsoft.EntityFrameworkCore.EntityState.Modified;
            // context.SaveChanges();

            return pageChanges;
        }

        public Page DeletePage(Page pageToDelete)
        {
            // context.Pages.Remove(pageToDelete);
            // context.SaveChanges();

            return pageToDelete;
        }

        public List<Page> GetAllPages()
        {
            // return context.Pages.ToList();

            return null;
        }
    }
}
