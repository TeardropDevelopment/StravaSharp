using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaSharp.Exception
{

    [Serializable]
    public class ResponseTypeException : System.Exception
    {
        private List<Error>? errors;

        public ResponseTypeException() { }

        public ResponseTypeException(string? message, List<Error>? e) : base(message) 
        {
            errors = e;
        }

        public ResponseTypeException(string? message, System.Exception inner) : base(message, inner) { }
        protected ResponseTypeException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }

        public string PrintErrors()
        {
            if(errors != null)
                return string.Join(Environment.NewLine, errors.Select(e => e.ToString()));
            return string.Empty;
        }
    }
}
