namespace BE302FirstProject.Entities;

public abstract class BaseEntity
{
    public int Id { get; set; }
    public abstract void InfoEntity();
}
