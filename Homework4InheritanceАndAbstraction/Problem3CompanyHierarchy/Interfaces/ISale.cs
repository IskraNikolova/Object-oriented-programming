using System;

namespace Problem3CompanyHierarchy.Interfaces
{
    public interface ISale
    {
        string ProductName { get; set; }
        DateTime Date { get; set; }
        decimal Price { get; set; }
    }
}