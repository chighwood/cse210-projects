using System;
using System.Collections.Generic;
using System.Text;

public class Order
{
    private List<Product> _products;
    private Customer _customer;

    public Order(List<Product> products, Customer customer)
    {
        this._products = products;
        this._customer = customer;
    }

    public double CalcTotalCost()
    {
        double totalCost = 0;
        foreach (Product product in _products)
        {
            totalCost += product.CalcTotalCost();
        }
        totalCost += _customer.IsInUSA() ? 5 : 35;
        return totalCost;
    }

    public string GeneratePackingLabel()
    {
        string label = "";
        foreach (Product product in _products)
        {
            label += $"Name: {product.Name} ID: {product._id}\n";
        }
        return label;
    }

    public string GenerateShippingLabel()
    {
        return $"Name: {_customer._name}\nAddress: {_customer._address}";
    }
}