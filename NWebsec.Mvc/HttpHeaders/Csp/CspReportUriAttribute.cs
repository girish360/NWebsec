﻿// Copyright (c) André N. Klingsheim. See License.txt in the project root for license information.

using System;

namespace NWebsec.Mvc.HttpHeaders.Csp
{
    [AttributeUsage(AttributeTargets.Class | AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public class CspReportUriAttribute : CspReportUriAttributeBase
    {
        
        protected override bool ReportOnly
        {
            get { return false; }
        }
    }
}
