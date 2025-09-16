using En_Content_Layout_Domain_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace En_Content_Layout_Domain_Layer.Interfaces
{
    public interface IContentLayoutRepository
    {
        Task<IList<AdminPage>> GetPages();
        Task<AdminPage> CreatePage(AdminPage page);
        Task<AdminPage> UpdatePage(AdminPage pageDetails, int pageId);
        Task DeletePage(int pageId);
    }
}
