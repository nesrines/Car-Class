using System.Xml.Schema;

class Car
{
    private string _model;
    private string _modelInfo;
    private int _topSpeed;
    private string _topSpeedInfo;
    private double _engine;
    private string _engineInfo;
    private double _kilometers;
    private string _kilometersInfo;
    private int _horsePower;
    private string _horsePowerInfo;

    public string Model
    {
        get { return _model; }
        set
        {
            if (string.IsNullOrWhiteSpace(value) || value.Length < 2 || value.Length > 10) { _modelInfo = $"('{value}'? Menim masindan basim cixmir, ancaq, mence, bele model yoxdur.)"; }
            else { _model = value; }
        }
    }
    
    public int TopSpeed
    {
        get { return _topSpeed; }
        set
        {
            if (value < 10) { _topSpeedInfo = $"({value} km/saat? Piyada getmeyinizi tovsiyye ederdim.)"; }
            else if (value > 1000) { _topSpeedInfo = $"({value} km/saat? Atma Ziya)"; }
            else { _topSpeed = value; }
        }
    }

    public double Engine
    {
        get { return _engine; }
        set
        {
            if (value < 0.3 || value > 10) { _engineInfo = $"({value} vermisdiniz, bele motor olmadigini dusunduyumu nezerinize catdiriram.)"; }
            else { _engine = value; }
        }
    }

    public double Kilometers
    {
        get { return _kilometers; }
        set
        {
            if (value < 0) { _kilometersInfo = $"({value} km vermisdiniz, masini dal-dala surmusunuz?)"; }
            else { _kilometers = value; }
        }
    }

    public int HorsePower
    {
        get { return _horsePower; }
        set
        {
            if (value < 50) { _horsePowerInfo = $"({value}? Uzrlu sayin, amma yox bir essek gucu)"; }
            else if (value > 1000) { _horsePowerInfo = $"{value}? Baxin, bu ag oldu"; }
            else { _horsePower = value; }
        }
    }

    public Car(string Model, int TopSpeed, double Engine, double Kilometers, int HorsePower)
    {
        this.Model = Model;
        this.TopSpeed = TopSpeed;
        this.Engine = Engine;
        this.Kilometers = Kilometers;
        this.HorsePower = HorsePower;
    }

    public void GetFullInfo()
    { Console.Write($"Model = {_model} {_modelInfo}, Top Speed = {_topSpeed} {_topSpeedInfo}, Engine = {_engine} {_engineInfo}, Kilometers = {_kilometers} {_kilometersInfo}, Horse Power = {_horsePower} {_horsePowerInfo}"); }
}