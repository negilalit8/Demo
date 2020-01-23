using BAL;
using DemoModal;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Demo.Controllers
{
    public class ConvertToWordsController : ApiController
    {
        // GET: api/ConvertToWords
        //public IEnumerable<string> Get()
        //{           
        //    return new string[] { "value1", "value2" };
        //}
        private IValueBAL _IvalueBAL;
        /// <summary>
        /// 
        /// </summary>
        /// <param name="IvalueBAL"></param>
        public  ConvertToWordsController(IValueBAL IvalueBAL)
        {
            _IvalueBAL = IvalueBAL;
        }

        // GET: api/ConvertToWords       
        public string Get([FromUri]ValuesModal obj)
        {
            
            string result = "";            
            result = _IvalueBAL.ConvertToWords(Convert.ToString(obj.amount));
            //return Ok(result).ToString();
            // return Request.CreateResponse(HttpStatusCode.OK, "success");
            return obj.name + " " + result;
        }

        // POST: api/ConvertToWords
        public void Post([FromBody]string value)
        {
        }

        // PUT: api/ConvertToWords/5
        public void Put(int id, [FromBody]string value)
        {
        }

        // DELETE: api/ConvertToWords/5
        public void Delete(int id)
        {
        }

       
    }
}
