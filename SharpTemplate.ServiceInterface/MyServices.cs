using System;
using System.Collections.Generic;
using System.Linq;
using ServiceStack;
using ServiceStack.Script;
using ServiceStack.DataAnnotations;
using SharpTemplate.ServiceModel;

namespace SharpTemplate.ServiceInterface
{
    public class MyServices : Service
    {
        public object Any(Hello request)
        {
            return new HelloResponse { Result = $"Hello, {request.Name}!" };
        }
    }
}
