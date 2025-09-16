using En_Content_Layout_Domain_Layer.Entities;
using En_Content_Layout_Domain_Layer.Interfaces;

namespace En_Content_Layout_Infrastructure_Layer
{
    public class ContentLayoutRepository : IContentLayoutRepository
    {
        public Task<AdminPage> CreatePage(AdminPage page)
        {
            throw new NotImplementedException();
        }

        public Task DeletePage(int pageId)
        {
            throw new NotImplementedException();
        }

        public Task<IList<AdminPage>> GetPages()
        {
            throw new NotImplementedException();
        }

        public Task<AdminPage> UpdatePage(AdminPage pageDetails, int pageId)
        {
            throw new NotImplementedException();
        }
    }
}
