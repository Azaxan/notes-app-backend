using Microsoft.AspNetCore.Mvc;
using notes_app_backend.Models;
using notes_app_backend.Models.Entities;
using notes_app_backend.Services;

namespace notes_app_backend.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class NoteController : ControllerBase
    {
        private readonly INoteService _noteService;
        public NoteController(INoteService noteService)
        {
            _noteService = noteService;
        }


        [HttpGet("{id}")]
        public ActionResult<Note> Get(int id)
        {
            var note = _noteService.Get(id);

            if (note == null)
            {
                return NotFound("Note was not found");
            }

            return Ok(note);
        }

        [HttpGet]
        public ActionResult<List<Note>> GetAll()
        {
            var notes = _noteService.GetAll();

            if (notes == null)
            {
                return NotFound("Notes were not found");
            }

            return Ok(notes);
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
