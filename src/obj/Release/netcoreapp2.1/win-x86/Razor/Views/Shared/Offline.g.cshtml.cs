#pragma checksum "C:\Projetos\Miniblog.Core-master\src\Views\Shared\Offline.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "99f109fd99fee3803f70b91cbe6973a3414f63e2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Offline), @"mvc.1.0.view", @"/Views/Shared/Offline.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/Offline.cshtml", typeof(AspNetCore.Views_Shared_Offline))]
namespace AspNetCore
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Projetos\Miniblog.Core-master\src\Views\_ViewImports.cshtml"
using Miniblog.Core;

#line default
#line hidden
#line 2 "C:\Projetos\Miniblog.Core-master\src\Views\_ViewImports.cshtml"
using Miniblog.Core.Models;

#line default
#line hidden
#line 3 "C:\Projetos\Miniblog.Core-master\src\Views\_ViewImports.cshtml"
using Microsoft.Extensions.Options;

#line default
#line hidden
#line 4 "C:\Projetos\Miniblog.Core-master\src\Views\_ViewImports.cshtml"
using WebEssentials.AspNetCore.Pwa;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"99f109fd99fee3803f70b91cbe6973a3414f63e2", @"/Views/Shared/Offline.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"698bc5c2bf880e0068e5406ccd42e18b65ba6a52", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Offline : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 1 "C:\Projetos\Miniblog.Core-master\src\Views\Shared\Offline.cshtml"
  
    ViewData["Title"] = "Offline";

#line default
#line hidden
            BeginContext(40, 128, true);
            WriteLiteral("\n<div class=\"container\">\n    <h1>Offline</h1>\n    <p>The page you requested can not be shown because you are offline.</p>\n</div>");
            EndContext();
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
