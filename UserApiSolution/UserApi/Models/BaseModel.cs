namespace UserApi.Models
{
    public class BaseModel
    {
        public int Id { get; set; }
        public DateTime? ActiviteTime { get; set; } = DateTime.Now;
    }
}
