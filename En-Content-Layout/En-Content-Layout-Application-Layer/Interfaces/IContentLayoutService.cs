using En_Content_Layout_Domain_Layer.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace En_Content_Layout_Application_Layer.Interfaces
{
    public interface IContentLayoutService
    {
        Task<AdminPage> CreatePage(AdminPage page);
        Task DeletePage(int pageId);
        Task<IList<AdminPage>> GetPages();
        Task<AdminPage> UpdatePage(AdminPage pageDetails, int pageId);
    }
}
