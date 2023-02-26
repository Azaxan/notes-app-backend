using Microsoft.AspNetCore.Mvc;
using notes_app_backend.Models;
using notes_app_backend.Models.Entities;

namespace notes_app_backend.Services
{
    public class NoteService : INoteService
    {
        private readonly MyNotesContext _context;
        public NoteService(MyNotesContext context)
        {
            _context = context;
        }

        public Note Get(int id)
        {
            return _context.Notes.First(n => n.Id == id);
        }

        public List<Note> GetAll()
        {
            var notes = _context.Notes.ToList();
            return notes;
        }

        public void AddNote(NoteDto request)
        {
            var note = new Note
            {
                Title = request.Title,
                Description = request.Description,
                CreatedDate = request.CreatedDate
            };

            _context.Notes.Add(note);
            _context.SaveChanges();
        }
    }
}
