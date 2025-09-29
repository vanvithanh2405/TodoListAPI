

namespace TodoList.Infrastructure.Data.Entities
{
    public class Categories
    {
        public Guid Id { get; set; }
        public string CategoryName { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid? UpdatedBy { get; set; }
        public virtual ICollection<TodoItems> TodoItems { get; set; }
    }
}
