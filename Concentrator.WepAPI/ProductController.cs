using System;
using System.Web.Http;
using Concentrator.SharedObjects.Dtos;
using Concentrator.SharedObjects.Enums;
using Concentrator.SharedObjects.Interfaces;

namespace Concentrator.WepAPI
{
  public class ProductController : ApiController
  {
    private readonly IProductService _productService;
    
    public ProductController(IProductService productService)
    {
      _productService = productService;
    }

    // GET api/<controller>/5
    public ProductDto Get(int id)
    {
      var context = new CallerContextDto()
      {
        DataSource = "ProductController"
      };

      if (!context.Rights.HasFlag(Rights.Read))
      {
       throw new AccessViolationException(); 
      }

      return _productService.GetProduct(context, id);
    }

    // POST api/<controller>
    public void Post([FromBody] ProductDto product) 
    {
      var context = new CallerContextDto()
      {
        DataSource = "ProductController"
      };

      if (!context.Rights.HasFlag(Rights.Write))
      {
        throw new AccessViolationException(); 
      }

      _productService.SendToBus(context, product);
    }

    // PUT api/<controller>/5
    public void Put(int id, [FromBody]string value)
    {
    }

    // DELETE api/<controller>/5
    public void Delete(int id)
    {
      var context = new CallerContextDto()
      {
        DataSource = "ProductController"
      };
      
      if (!context.Rights.HasFlag(Rights.Delete))
      {
        throw new AccessViolationException(); 
      }

      _productService.GetProduct(context, id);
    }
  }
}