namespace ETicaretAPI.Domain.Entities.Common
{
    public class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; } = DateTime.Now;
        public DateTime LastUpdatedDate { get; set; } = DateTime.Now;
        public bool Status { get; set; } = true;
        public bool IsDeleted { get; set; } = false;

    }
}
