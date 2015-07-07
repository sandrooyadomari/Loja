using System;
using System.Web.Http;

namespace Loja.WebApi.Controllers
{
    public class TokenController : ApiController
    {
        [HttpGet]
        public IHttpActionResult GenerateToken()
        {
            var token = new Token();

            return Ok(token);
        }
    }

    public class Token
    {
        public string CodigoDoToken { get; private set; }
        public string ExpiraEm { get; private set; }

        public Token()
        {
            CodigoDoToken = Guid.NewGuid().ToString();
            ExpiraEm = DateTime.Now.AddMinutes(1).ToString();
        }
    }

}