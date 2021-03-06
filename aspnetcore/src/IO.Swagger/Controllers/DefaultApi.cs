/*
 * defaultTitle
 *
 * defaultDescription
 *
 * OpenAPI spec version: 0.1
 * 
 * Generated by: https://github.com/swagger-api/swagger-codegen.git
 */
using System;
using System.Collections.Generic;
using Microsoft.AspNetCore.Mvc;
using Swashbuckle.AspNetCore.Annotations;
using Swashbuckle.AspNetCore.SwaggerGen;
using Newtonsoft.Json;
using System.ComponentModel.DataAnnotations;
using IO.Swagger.Attributes;

using Microsoft.AspNetCore.Authorization;
using IO.Swagger.Models;

namespace IO.Swagger.Controllers
{ 
    /// <summary>
    /// 
    /// </summary>
    [ApiController]
    public class DefaultApiController : ControllerBase
    { 
        /// <summary>
        /// 
        /// </summary>
        /// <remarks>Auto generated using Swagger Inspector</remarks>
        /// <response code="200">Auto generated using Swagger Inspector</response>
        [HttpGet]
        [Route("/api/papi-client/stats/cod/v1/title/cw/platform/xbl/gamer/munchinxbox69/profile/type/mp")]
        [ValidateModelState]
        [SwaggerOperation("ApiPapiClientStatsCodV1TitleCwPlatformXblGamerMunchinxbox69ProfileTypeMpGet")]
        public virtual IActionResult ApiPapiClientStatsCodV1TitleCwPlatformXblGamerMunchinxbox69ProfileTypeMpGet()
        { 
            //TODO: Uncomment the next line to return response 200 or use other options such as return this.NotFound(), return this.BadRequest(..), ...
            // return StatusCode(200);

            throw new NotImplementedException();
        }
    }
}
