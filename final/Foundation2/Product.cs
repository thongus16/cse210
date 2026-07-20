class Product
{
    private string _name;
    private int _id;
    private double _ppu;
    private int _count;

    public Product(string name, int id, double ppu, int count)
    {
        _name = name;
        _id = id;
        _ppu = ppu;
        _count = count;
    }

    public double GetPrice()
    {
        return Math.Round((_ppu * _count) + 0.05, 2);
    }

    public string GetLabel()
    {
        return $"{_name} ({_id})";
    }
}