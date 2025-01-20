public class Role : BaseEntity
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public string Remark { get; set; }
    public ICollection<User> Users { get; set; } // һ�Զ��ϵ
    public ICollection<Function> Functions { get; set; } // ��Զ��ϵ
}
