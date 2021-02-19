using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Web.Http;

namespace Assignment_2.Controllers
{
    public class J1Controller : ApiController
    {


        /// <summary>
        /// jgaipjgpoajgpoaj
        /// </summary>
        [HttpGet]
        [Route("api/J1/Menu/{burger}/{side}/{drink}/{dessert}")]
        public string Menu()
        {
            return "Hello World";
        }



           


    }
}
