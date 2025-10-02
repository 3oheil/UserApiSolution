namespace UserApi.Models
{
    public class User : BaseModel
    {
        public string UserName { get; set; }
        public string PasswordHash { get; set; }
        public string Role { get; set; } = "User";
    }
}
