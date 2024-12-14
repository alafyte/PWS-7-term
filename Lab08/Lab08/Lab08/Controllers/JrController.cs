using Newtonsoft.Json;
using Newtonsoft.Json.Linq;
using Lab08.Models;
using Lab08.Services;
using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using System.Web.Http;

namespace Lab08.Controllers
{
    [RoutePrefix("jr")]
    public class JrController : ApiController
    {
        private readonly JrService _jrService;

        public JrController()
        {
            _jrService = new JrService();
        }

        [HttpPost]
        public async Task<IHttpActionResult> Process(object reqData)
        {
            var responses = new List<JsonRpcRes>();
            try
            {
                if (reqData is JArray rpcArray)
                {


                    foreach (var rpcItem in rpcArray)
                    {
                        var rpcObject = JObject.Parse(rpcItem.ToString());

                        if (rpcObject["params"] is JArray arrayParams)
                        {
                            var rpc = new JsonRpcReq
                            {
                                Id = (int?)rpcObject["id"],
                                Method = (string)rpcObject["method"],
                                Jsonrpc = (string)rpcObject["jsonrpc"],
                                Params = new object[] { arrayParams[0]?.ToString(), arrayParams[1]?.ToObject<int?>() }
                            };

                            var rpcRes = _jrService.ProcessMethod(rpc);
                            if (rpcRes != null)
                            {
                                responses.Add(rpcRes);
                            }
                        }
                        else
                        {
                            var rpc = JsonConvert.DeserializeObject<JsonRpcReq>(rpcItem.ToString());
                            var rpcRes = _jrService.ProcessMethod(rpc);
                            if (rpcRes != null)
                            {
                                responses.Add(rpcRes);
                            }
                        }
                    }

                    return Ok(responses);
                }
                else
                {
                    JObject rpcObject = JObject.Parse(reqData.ToString());

                    if (rpcObject["params"] is JArray arrayParams)
                    {
                        var rpc = new JsonRpcReq
                        {
                            Id = (int?)rpcObject["id"],
                            Method = (string)rpcObject["method"],
                            Jsonrpc = (string)rpcObject["jsonrpc"],
                            Params = new object[] { arrayParams[0]?.ToString(), arrayParams[1]?.ToObject<int?>() }
                        };

                        var rpcRes = _jrService.ProcessMethod(rpc);
                        if (rpcRes == null || rpcRes.Id == null)
                        {
                            return Ok();
                        }

                        return Ok(rpcRes);
                    }
                    else
                    {
                        var rpc = JsonConvert.DeserializeObject<JsonRpcReq>(reqData.ToString());
                        var rpcRes = _jrService.ProcessMethod(rpc);
                        if (rpcRes == null || rpcRes.Id == null)
                        {
                            return Ok();
                        }

                        return Ok(rpcRes);
                    }
                }
            }
            catch (Exception ex)
            {
                int? id = null;
                if (reqData != null)
                {
                    var property = reqData.GetType().GetProperty("id");

                    if (property != null)
                    {
                        var value = property.GetValue(reqData);
                        if (value != null && int.TryParse(value.ToString(), out var idVal))
                        {
                            id = idVal;
                        }
                    }
                }
                if (responses.Count == 0)
                {
                    return Ok(new JsonRpcRes
                    {
                        Id = id,
                        Error = new RpcError
                        {
                            Code = -32700,
                            Message = "Parse error",
                            Data = ex.Message
                        },
                        Jsonrpc = "2.0"
                    });
                }
                else
                {
                    responses.Add(new JsonRpcRes
                    {
                        Id = id,
                        Error = new RpcError
                        {
                            Code = -32700,
                            Message = "Parse error",
                            Data = ex.Message
                        },
                        Jsonrpc = "2.0"
                    });
                    return Ok(responses);
                }

            }
        }
    }
}
