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
        /// <summary>
        /// Fetches all admin pages
        /// </summary>
        /// <returns>200 status code on successful retrieval, 204 if no pages are found</returns>
        [HttpGet("pages")]
        public async Task<IActionResult> GetPages()
        {
            var allPages = await _contentLayoutService.GetPages();
            
            if (allPages?.Count>0) 
                return Ok(allPages);
            return NoContent();
        }
        /// <summary>
        /// Creates a new page in the admin panel database
        /// </summary>
        /// <param name="page">Page to be created</param>
        /// <returns>201 status code with the page id on successful execution, 400 on failure</returns>
        [HttpPost("pages")]
        public async Task<IActionResult> CreatePage(AdminPage page)
        {
            var createdPage = await _contentLayoutService.CreatePage(page);

            if (createdPage!=null)
            //placeholder until endpoints are clarified
                return CreatedAtAction(nameof(GetPages), new { pageId = createdPage.PageId});
            return BadRequest();
        }
        /// <summary>
        /// Updates the content, layout, or metadata of an existing page
        /// </summary>
        /// <param name="pageDetails">Updated page details</param>
        /// <param name="pageId">Id of page to update</param>
        /// <returns>200 status code on successful update</returns>
        [HttpPut("pages/{pageId}")]
        public async Task<IActionResult> UpdatePage(AdminPage pageDetails, int pageId)
        {
            var updatedPage = await _contentLayoutService.UpdatePage(pageDetails, pageId);

            if (updatedPage != null)
                return Ok();
            return BadRequest();
        }
        /// <summary>
        /// Deletes a page from the admin panel database
        /// </summary>
        /// <param name="pageId">Id of page to be deleted</param>
        /// <returns>200 status code on successful delete</returns>
        [HttpDelete("pages/{pageId}")]
        public async Task<IActionResult> DeletePage(int pageId)
        {
            await _contentLayoutService.DeletePage(pageId);

            return Ok();
        }
    }
}
