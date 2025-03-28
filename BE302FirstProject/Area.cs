namespace BE302FirstProject;

//struct - inheretance(miras vermir),default parameterless ctor don't be overrided 
public struct Area
{
    public int Length { get; set; }
    public int Height { get; set; }

    public Area(int length)
    {
        Length = length;
    }
}
