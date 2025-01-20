public class User : BaseEntity
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Account { get; set; }
    public string Password { get; set; }
    public string Telephone { get; set; }
    public string Email { get; set; }
    public string Status { get; set; }
    public int Organization_ID { get; set; }
    public string Remark { get; set; }
    public string Profile { get; set; }
    public ICollection<Role> Roles { get; set; } // 一对多关系
}
