public class Organization : BaseEntity
{
    public int ID { get; set; }
    public string Name { get; set; }
    public string Leader { get; set; }
    public string Telephone { get; set; }
    public int Parent_ID { get; set; }
    public string Remark { get; set; }
}
