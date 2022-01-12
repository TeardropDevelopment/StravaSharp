using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace StravaSharp.API.Authentication
{
    //
    // Summary:
    //     Used to specify what data from Strava can be received by your application.
    public enum Scope
    {
        //
        // Summary:
        //     Only public data can be received.
        Public,
        //
        // Summary:
        //     Data can be written. This scope is needed if you want to upload activities.
        Write,
        //
        // Summary:
        //     Only private data can be received.
        ViewPrivate,
        //
        // Summary:
        //     Private and public data can be received and write permissions are granted.
        Full
    }
}
