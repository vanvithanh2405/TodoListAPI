namespace TodoList.Infrastructure.Data.Entities
{
    public class TodoItems
    {
        public Guid Id { get; set; }
        public string? Name { get; set; }
        public string? Description { get; set; }
        public int StatusRefId { get; set; }
        public Guid CategoryId { get; set; }
        public int DisplayOrder { get; set; }
        public DateTime? CreatedDate { get; set; }
        public Guid? CreatedBy { get; set; }
        public DateTime? UpdatedDate { get; set; }
        public Guid? UpdatedBy { get; set; }
        public virtual Categories Categories { get; set; }
        public virtual References References { get; set; }

    }
}
