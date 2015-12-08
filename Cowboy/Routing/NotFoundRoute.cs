﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Cowboy.Responses;

namespace Cowboy.Routing
{
    public class NotFoundRoute : Route
    {
        public NotFoundRoute(string method, string path)
            : base(method, path, null, (x, c) => 
                {
                    var tcs = new TaskCompletionSource<dynamic>();
                    tcs.SetResult(new NotFoundResponse());
                    return tcs.Task;
                })
        {
        }
    }
}
