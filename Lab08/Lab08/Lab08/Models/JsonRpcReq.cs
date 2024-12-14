using System;

namespace Lab08.Models
{
    public class JsonRpcReq
    {
        public int? Id { get; set; }
        public string Method { get; set; }

        private JsonParams _params { get; set; } = new JsonParams();
        public string Jsonrpc { get; set; }

        public object Params
        {
            get { return _params; }
            set
            {
                if (value is object[] array && array.Length == 2)
                {
                    _params.K = array[0]?.ToString();
                    _params.X = array[1] is int ? (int)array[1] : (int?)null;
                }
                else if (value is JsonParams jsonParams)
                {
                    _params = jsonParams;
                }
                else
                {
                    throw new ArgumentException("Invalid type for Params");
                }
            }
        }
    }

    public class JsonParams
    {
        public string K { get; set; } = null;
        public int? X { get; set; } = null;
    }
}
