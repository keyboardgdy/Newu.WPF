public class Role : BaseEntity
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Remark { get; set; }
    public ICollection<User> Users { get; set; } // 一对多关系
    public ICollection<Function> Functions { get; set; } // 多对多关系
}
