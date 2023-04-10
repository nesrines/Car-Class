class BMW : Car
{
    public bool IsMpower;
    public BMW(bool IsMpower, string Model, int TopSpeed, double Engine, double Kilometers, int HorsePower) : base(Model, TopSpeed, Engine, Kilometers, HorsePower)
    {
        this.IsMpower = IsMpower;
    }
    public void GetFullBMWInfo()
    {
        GetFullInfo();
        if (IsMpower) { Console.WriteLine(", Mpower nedirse, ondandir"); }
        else { Console.WriteLine(", Mpower deyil"); }
    }
}
