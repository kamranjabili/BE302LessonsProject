namespace BE302FirstProject.Entities;

public class Manat
{
    public decimal Azn { get; set; }
    public Manat(decimal azn)
    {
        Azn = azn;
    }

    public static explicit operator Dollar(Manat manat)
    {
        return new Dollar(manat.Azn / 1.7m);
    }
}

public class Dollar
{
    public decimal Usd { get; set; }
    public Dollar(decimal usd)
    {
        Usd = usd;
    }

    
}
