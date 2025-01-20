public class Function : BaseEntity
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Code { get; set; }
    public string Icon { get; set; }
    public int Parent_ID { get; set; }
    public string Remark { get; set; }
    public ICollection<Role> Roles { get; set; } // 多对多关系
}
