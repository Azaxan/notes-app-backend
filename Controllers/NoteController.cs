using Microsoft.AspNetCore.Mvc;
using notes_app_backend.Models;
using notes_app_backend.Services;

namespace notes_app_backend.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class NoteController : ControllerBase
    {
        private readonly INoteService _noteService;
        public NoteController(INoteService noteService)
        {
            _noteService = noteService;
        }

        [HttpPost]
        public ActionResult AddNote(NoteDto request)
        {
            if (request == null)
            {
                return BadRequest();
            }

            _noteService.AddNote(request);

            return Ok();
        }
    }
}
