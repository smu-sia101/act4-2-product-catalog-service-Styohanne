using Microsoft.AspNetCore.Mvc;

namespace ProductCatalogueService.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class ProductsController : ControllerBase
    {
    
        [HttpGet]
        public ActionResult GetAllProducts()
        {
     
            throw new NotImplementedException();
        }

     
        [HttpGet("{id}")]
        public ActionResult GetProductById(int id)
        {
           
            throw new NotImplementedException();
        }

     
        [HttpPost]
        public ActionResult CreateProduct([FromBody] object newProduct)
        {
           
            throw new NotImplementedException();
        }

        
        [HttpPut("{id}")]
        public ActionResult UpdateProduct(int id, [FromBody] object updatedProduct)
        {
        
            throw new NotImplementedException();
        }

       
        [HttpDelete("{id}")]
        public ActionResult DeleteProduct(int id)
        {
          
            throw new NotImplementedException();
        }
    }
}