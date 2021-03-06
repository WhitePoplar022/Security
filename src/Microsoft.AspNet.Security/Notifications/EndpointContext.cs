// Copyright (c) Microsoft Open Technologies, Inc. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.


using Microsoft.AspNet.Http;

namespace Microsoft.AspNet.Security.Notifications
{
    public abstract class EndpointContext : BaseContext
    {
        protected EndpointContext(HttpContext context)
            : base(context)
        {
        }

        public bool IsRequestCompleted { get; private set; }

        public void RequestCompleted()
        {
            IsRequestCompleted = true;
        }
    }
}
