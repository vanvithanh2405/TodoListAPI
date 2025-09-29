

namespace TodoList.Infrastructure.Data.Entities
{
    public class References
    {
        public int Id { get; set; }
        public string? RefType { get; set; }
        public string? RefValue { get; set; }
        public string? RefDesc { get; set; }
        public int? DisplayOrder { get; set; }
        public virtual ICollection<TodoItems> TodoItems { get; set; }
    }
}
