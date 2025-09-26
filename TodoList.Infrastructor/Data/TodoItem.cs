namespace TodoList.Infrastructure.Data
{
    public class TodoItem
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public Guid PersonId { get; set; }
        public string? Title { get; set; }
    }
}
