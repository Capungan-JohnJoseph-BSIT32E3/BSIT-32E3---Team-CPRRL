namespace TodoList.Models
{
    public class TodoItem
    {
        public int Id { get; set; }
        public string? TaskDescription { get; set; }
        public bool IsCompleted { get; set; }
    }
}
