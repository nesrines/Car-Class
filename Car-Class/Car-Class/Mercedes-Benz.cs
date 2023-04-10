class Mercedes : Car
{
    public bool IsAmg;
    public Mercedes(bool IsAmg, string Model, int TopSpeed, double Engine, double Kilometers, int HorsePower) : base(Model, TopSpeed, Engine, Kilometers, HorsePower)
    {
        this.IsAmg = IsAmg;
    }
    public void GetFullMercedesInfo()
    {
        GetFullInfo();
        if (IsAmg) { Console.WriteLine(", AMG nedirse, ondandir"); }
        else { Console.WriteLine(", AMG deyil"); }
    }
}