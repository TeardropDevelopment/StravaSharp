using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaSharp.Client
{
    internal class StravaFactory
    {
        public static StravaSharp GetApiInstance(AppClient client)
        {
            return new StravaSharp(Guid.NewGuid(), client);
        }
    }
}
