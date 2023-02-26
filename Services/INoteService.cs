using Microsoft.AspNetCore.Mvc;
using notes_app_backend.Models;
using notes_app_backend.Models.Entities;

namespace notes_app_backend.Services
{
    public interface INoteService
    {
        Note Get(int id);
        List<Note> GetAll();
        void AddNote(NoteDto request);
    }
}
