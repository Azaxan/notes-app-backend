using Microsoft.AspNetCore.Mvc;
using notes_app_backend.Models;

namespace notes_app_backend.Services
{
    public interface INoteService
    {
        void AddNote(NoteDto request);
    }
}
