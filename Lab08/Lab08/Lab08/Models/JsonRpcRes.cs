using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace Lab08.Models
{
    public class JsonRpcRes
    {
        public int? Id { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object Result { get; set; } = null;
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public RpcError Error { get; set; } = null;
        public string Jsonrpc { get; set; }
    }

    public class RpcError 
    {
        public int Code { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public string Message { get; set; }
        [JsonProperty(NullValueHandling = NullValueHandling.Ignore)]
        public object Data { get; set; }
    }

    public class RpcException : Exception
    {
        public int Code { get; set; }

        public RpcException(string message, int code) : base(message)
        {
            Code = code;
        }
    }
}