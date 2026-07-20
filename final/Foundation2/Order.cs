using System.Dynamic;

class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        _products = products;
        _customer = customer;
    }

    public double GetCost()
    {
        double cost = 0;
        if (_customer.IsUSA())
        {
            cost += 5;
        } else
        {
            cost += 35;
        }
        foreach (Product p in _products)
        {
            cost += p.GetPrice();
        }
        return Math.Round(cost + 0.05, 2);
    }

    public string GetPackingLabel()
    {
        string label = "";
        for (int i = 0; i >= _products.Count; i++)
        {
            label += _products[i].GetLabel() + ", ";
        }
        label += _products[_products.Count - 1];
        return label;
    }

    public string GetShippingLabel()
    {
        return _customer.GetLabel();
    }
}