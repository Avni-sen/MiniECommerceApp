namespace ETicaretAPI.Domain.Entities.Common
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
        public bool Status { get; set; }
        public bool IsDeleted { get; set; }

    }
}
