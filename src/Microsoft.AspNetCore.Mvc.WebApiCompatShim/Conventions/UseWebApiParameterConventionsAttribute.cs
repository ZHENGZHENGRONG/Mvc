// Copyright (c) .NET Foundation. All rights reserved.
// Licensed under the Apache License, Version 2.0. See License.txt in the project root for license information.

using System;

namespace Microsoft.AspNetCore.Mvc.WebApiCompatShim
{
    /// <summary>
    /// Indicates the model binding system should use ASP.NET Web API conventions for parameters of a controller's
    /// actions. For example, bind simple types from the URI.
    /// </summary>
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = false, Inherited = true)]
    public class UseWebApiParameterConventionsAttribute : Attribute, IUseWebApiParameterConventions
    {
    }
}