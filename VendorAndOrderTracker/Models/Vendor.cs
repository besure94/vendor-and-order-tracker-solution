using System.Collections.Generic;

namespace VendorAndOrderTracker.Models
{
  public class Vendor
  {
    public string Name { get; set; }
    public string VendorDescription { get; set; }
    public int Id { get; }
    private static List<Vendor> _instances = new List<Vendor> {};

    public Vendor(string name, string vendorDescription)
    {
      Name = name;
      VendorDescription = vendorDescription;
      _instances.Add(this);
      Id = _instances.Count;
    }
    public static List<Vendor> GetAll()
    {
      return _instances;
    }
    public static void ClearAll()
    {
      _instances.Clear();
    }
  }
}