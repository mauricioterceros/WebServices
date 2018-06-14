using Newtonsoft.Json;
using SingletonPattern;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Text;
using System.Web.Http;

namespace WebAPI.Controllers
{
    public class ProductController : ApiController
    {
        [HttpGet]
        [Route("api/getInfo/{id:int}")]
        public HttpResponseMessage GetProduct(int id)
        {
            Product prods = MySingleton.Instance.GetProducts().ToList()[id]; //Servicios
            string productsJSON = JsonConvert.SerializeObject(prods, Formatting.Indented);
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(productsJSON, Encoding.UTF8, "application/json");
            return response;
        }

        [HttpPost, ActionName("postInfo")]
        public HttpResponseMessage PostInfo(Object content)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(content.ToString(), Encoding.UTF8, "application/json");
            return response;
        }

        [HttpPut, ActionName("updateInfo")]
        public HttpResponseMessage UpdateInfo(Object res)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(res.ToString(), Encoding.UTF8, "application/json");
            return response;
        }

        [HttpDelete, ActionName("DeleteInfo")]
        public HttpResponseMessage DeleteInfo(Object id)
        {
            var response = Request.CreateResponse(HttpStatusCode.OK);
            response.Content = new StringContent(id.ToString(), Encoding.UTF8, "application/json");
            return response;
        }
    }
}
