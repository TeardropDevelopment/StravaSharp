using StravaSharp.Exception;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaSharp.API.Helpers
{
    public static class ObjectExtensions
    {
        /// <summary>
        /// Checks if the given object is type <see cref="Fault"/>
        /// </summary>
        /// <param name="o">The given object</param>
        /// <returns>True, if the object is type <see cref="Fault"/></returns>
        public static bool IsFault(this object o)
        {
            return o is Fault;
        }

        /// <summary>
        /// Throws a <seealso cref="ResponseTypeException"/> if the given object is type <see cref="Fault"/>
        /// </summary>
        /// <param name="o">The given object</param>
        /// <exception cref="ResponseTypeException"></exception>
        public static void ThrowOnFault(this object o)
        {
            if (o.IsFault())
            {
                Fault? fault = o as Fault;
                throw new ResponseTypeException(fault?.Message, fault?.Errors);
            }
        }
    }
}
