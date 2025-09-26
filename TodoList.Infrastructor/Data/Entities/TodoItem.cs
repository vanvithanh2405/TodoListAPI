namespace TodoList.Infrastructure.Data.Entities
{
    public class TodoItem
    {
        public Guid Id { get; set; }
        public string? Description { get; set; }
        public Guid PersonId { get; set; }
        public string? Title { get; set; }
    }
}
