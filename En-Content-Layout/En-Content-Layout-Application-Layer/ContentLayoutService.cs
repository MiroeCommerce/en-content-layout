using En_Content_Layout_Application_Layer.Interfaces;
using En_Content_Layout_Domain_Layer.Entities;
using En_Content_Layout_Domain_Layer.Interfaces;

namespace En_Content_Layout_Application_Layer
{
    public class ContentLayoutService : IContentLayoutService
    {
        private readonly IContentLayoutRepository _contentLayoutRepository;
        public ContentLayoutService(IContentLayoutRepository contentLayoutRepository)
        {
            _contentLayoutRepository = contentLayoutRepository;
        }

        public async Task<AdminPage> CreatePage(AdminPage page)
        {
            return await _contentLayoutRepository.CreatePage(page);
        }

        public async Task DeletePage(int pageId)
        {
            await _contentLayoutRepository.DeletePage(pageId);
        }

        public async Task<IList<AdminPage>> GetPages()
        {
            return await _contentLayoutRepository.GetPages();
        }

        public async Task<AdminPage> UpdatePage(AdminPage pageDetails, int pageId)
        {
            return await _contentLayoutRepository.UpdatePage(pageDetails, pageId);
        }
    }
}
