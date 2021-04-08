using System.Collections.Generic;
using System;
using Newtonsoft.Json;
using Newtonsoft.Json.Linq;

namespace AltMarkedDownClient.Models
{
  public class Product
  {
    public int Id { get; set; }
    public string Name { get; set; }
    public string Description { get; set; }
    public decimal Price { get; set; }
    public string PictureUrl { get; set; }
    // public ProductType ProductType { get; set; }
    // public int ProductTypeId { get; set; }
    // public ProductBrand ProductBrand { get; set; }
    // public int ProductBrandId { get; set; }
    
    public static List<Product> GetProducts()
    {
      var apiCallTask = ApiHelper.GetAll();
      var result = apiCallTask.Result;
      
      JObject jsonResponse = JsonConvert.DeserializeObject<JObject>(result);
      List<Product> productList = JsonConvert.DeserializeObject<List<Product>>(jsonResponse["data"].ToString());

      return productList;
    }

  }
}