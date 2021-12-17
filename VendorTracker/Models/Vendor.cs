using System.Collections.Generic;

namespace VendorTracker.Models
{
  public class Vendor
  {
    private static List<Vendor> _instances = new List<Vendor> { };
    public string Name { get; set; }
    public string VendorDescription { get; set; }
    public int Id { get; set; }
    public List<Order> Orders { get; set; }
    public Vendor(string vendorName, string vendorDescription)
    {
      Name = vendorName;
      VendorDescription = vendorDescription;
      _instances.Add(this);
      Id = _instances.Count;
      Orders = new List<Order> { };
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}