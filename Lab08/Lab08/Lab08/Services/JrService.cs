using Lab08.Models;
using System;
using System.Web;

namespace Lab08.Services
{
    public class JrService
    {
        private bool ignoreMethods = false;

        public JsonRpcRes ProcessMethod(JsonRpcReq rpc)
        {
            try
            {
                CheckRpcReq(rpc);
                if (ignoreMethods)
                    return null;

                var res = new JsonRpcRes
                {
                    Id = rpc.Id,
                    Jsonrpc = "2.0"
                };

                switch (rpc.Method)
                {
                    case "SetM":
                        ValidateKey(rpc);
                        ValidateValue(rpc);
                        SetValue(((JsonParams)(rpc.Params)).K, ((JsonParams)(rpc.Params)).X);
                        res.Result = GetValue(((JsonParams)(rpc.Params)).K);
                        break;
                    case "GetM":
                        ValidateKey(rpc);
                        res.Result = GetValue(((JsonParams)(rpc.Params)).K);
                        break;
                    case "AddM":
                        ValidateKey(rpc);
                        ValidateValue(rpc);
                        SetValue(((JsonParams)(rpc.Params)).K, GetValue(((JsonParams)(rpc.Params)).K) + ((JsonParams)(rpc.Params)).X);
                        res.Result = GetValue(((JsonParams)(rpc.Params)).K);
                        break;
                    case "SubM":
                        ValidateKey(rpc);
                        ValidateValue(rpc);
                        SetValue(((JsonParams)(rpc.Params)).K, GetValue(((JsonParams)(rpc.Params)).K) - ((JsonParams)(rpc.Params)).X);
                        res.Result = GetValue(((JsonParams)(rpc.Params)).K);
                        break;
                    case "MulM":
                        ValidateKey(rpc);
                        ValidateValue(rpc);
                        SetValue(((JsonParams)(rpc.Params)).K, GetValue(((JsonParams)(rpc.Params)).K) * ((JsonParams)(rpc.Params)).X);
                        res.Result = GetValue(((JsonParams)(rpc.Params)).K);
                        break;
                    case "DivM":
                        ValidateKey(rpc);
                        ValidateValue(rpc);
                        SetValue(((JsonParams)(rpc.Params)).K, GetValue(((JsonParams)(rpc.Params)).K) / ((JsonParams)(rpc.Params)).X);
                        res.Result = GetValue(((JsonParams)(rpc.Params)).K);
                        break;
                    case "ErrorExit":
                        ignoreMethods = true;
                        HttpContext.Current.Session.Clear();
                        break;
                    default:
                        throw new RpcException("Unknown method", -32601);
                }

                if (res.Result == null)
                    res.Result = "";

                return res;
            }
            catch (RpcException ex)
            {
                return new JsonRpcRes
                {
                    Id = rpc?.Id,
                    Error = new RpcError
                    {
                        Code = ex.Code,
                        Message = ex.Message
                    },
                    Jsonrpc = "2.0"
                };
            }
            catch (Exception ex)
            {
                return new JsonRpcRes
                {
                    Id = rpc?.Id,
                    Error = new RpcError
                    {
                        Code = -32603,
                        Message = "Internal error"
                    },
                    Jsonrpc = "2.0"
                };
            }
        }

        private void CheckRpcReq(JsonRpcReq rpc)
        {
            if (rpc == null)
                throw new RpcException("Parse error", -32700);

            if (rpc.Jsonrpc != "2.0")
                throw new RpcException("Invalid request", -32600);

            if (string.IsNullOrEmpty(rpc.Method))
                throw new RpcException("Method not found", -32601);
        }

        private void ValidateKey(JsonRpcReq rpc)
        {
            var jsonParams = rpc.Params as JsonParams;
            if (jsonParams == null || string.IsNullOrEmpty(jsonParams.K))
                throw new RpcException("Invalid params: missing key", -32602);
        }

        private void ValidateValue(JsonRpcReq rpc)
        {
            var jsonParams = rpc.Params as JsonParams;
            if (jsonParams == null || jsonParams.X == null)
                throw new RpcException("Invalid params: missing value", -32602);
        }

        private int GetValue(string key)
        {
            var data = HttpContext.Current.Session[key];
            if (data == null)
                return 0;

            if (int.TryParse(data.ToString(), out var value))
                return value;

            return 0;
        }

        private void SetValue(string key, int? value)
        {
            HttpContext.Current.Session[key] = value;
        }
    }
}
