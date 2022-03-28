using System;
using System.Collections.Generic;
using System.Web.Http;
using TrepupAPI.Filter;
using TrepupAPI.Models;
using TrepupAPI.Repository;

namespace TrepupAPI.Controllers
{
    [Authorize]
    public class ProductController : ApiController
    {
        private IProductRepository productRepository = null;
        public ProductController(IProductRepository productRepository)
        {
            this.productRepository = productRepository;
        }

        [HttpGet]
        [Route("api/product")]
        [ValidationActionFilter]
        public Response GetProductSinglePageDetails([FromUri] ProductRequest objparam)
        {
            Response response = new Response();
            try
            {
                if (ModelState.IsValid)
                {
                    List<Product> products = productRepository.GetProducDetails(objparam);
                    response.data = products;
                    response.code = "1000";
                    response.status = Codes.dict[1000].Item1;
                    response.message = Codes.dict[1000].Item2;
                }
                else
                {
                    response.code = "9001";
                    response.data = 0;
                    response.status = Codes.dict[9001].Item1;
                    response.message = Codes.dict[9001].Item2;
                }
            }
            catch (Exception e)
            {
                response.code = "9001";
                response.status = Codes.dict[9001].Item1;
                response.message = Codes.dict[9001].Item2;
            }

            return response;
        }

    }
}