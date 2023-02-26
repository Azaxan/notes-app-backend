namespace notes_app_backend.Models
{
    public class NoteDto
    {
        public int Id { get; set; }
        public string? Title { get; set; }
        public string Description { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}
