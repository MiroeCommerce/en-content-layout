using En_Content_Layout_Application_Layer.Interfaces;
using En_Content_Layout_Domain_Layer.Entities;
using Microsoft.AspNetCore.Mvc;

namespace En_Content_Layout
{
    [Route("api/admin")]
    [ApiController]
    public class ContentLayoutController : ControllerBase
    {
        private readonly IContentLayoutService _contentLayoutService;
        public ContentLayoutController(IContentLayoutService contentLayoutService)
        {
            _contentLayoutService = contentLayoutService;
        }
        [HttpGet("pages")]
        public async Task<IActionResult> GetPages()
        {
            var allPages = await _contentLayoutService.GetPages();
            
            if (allPages?.Count>0) 
                return Ok(allPages);
            return NoContent();
        }
        [HttpPost("pages")]
        public async Task<IActionResult> CreatePage(AdminPage page)
        {
            var createdPage = await _contentLayoutService.CreatePage(page);

            if (createdPage!=null)
            //placeholder until endpoints are clarified
                return CreatedAtAction(nameof(GetPages), new { pageId = createdPage.PageId});
            return BadRequest();
        }
        [HttpPut("pages/{pageId}")]
        public async Task<IActionResult> UpdatePage(AdminPage pageDetails, int pageId)
        {
            var updatedPage = await _contentLayoutService.UpdatePage(pageDetails, pageId);

            if (updatedPage != null)
                return Ok();
            return BadRequest();
        }
        [HttpDelete("pages/{pageId}")]
        public async Task<IActionResult> DeletePage(int pageId)
        {
            await _contentLayoutService.DeletePage(pageId);

            return Ok();
        }
    }
}
