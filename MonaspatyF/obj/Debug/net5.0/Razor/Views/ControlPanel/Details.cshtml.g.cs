#pragma checksum "E:\ITI\Project\ASP.net core\MonaspatyF\Monaspaty\MonaspatyF\Views\ControlPanel\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "dfe22e1371a58d83914bddc303738ca9567d49de"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ControlPanel_Details), @"mvc.1.0.view", @"/Views/ControlPanel/Details.cshtml")]
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
#nullable restore
#line 1 "E:\ITI\Project\ASP.net core\MonaspatyF\Monaspaty\MonaspatyF\Views\_ViewImports.cshtml"
using MonaspatyF;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "E:\ITI\Project\ASP.net core\MonaspatyF\Monaspaty\MonaspatyF\Views\_ViewImports.cshtml"
using MonaspatyF.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"dfe22e1371a58d83914bddc303738ca9567d49de", @"/Views/ControlPanel/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9605fff9bf3e465101d7c1638f2c3a81a14f9227", @"/Views/_ViewImports.cshtml")]
    public class Views_ControlPanel_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<HallShopOwner>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<p><span class=\"font-weight-bold\">SSN: </span>");
#nullable restore
#line 3 "E:\ITI\Project\ASP.net core\MonaspatyF\Monaspaty\MonaspatyF\Views\ControlPanel\Details.cshtml"
                                         Write(Model.SSN);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p><span class=\"font-weight-bold\">Name: </span>");
#nullable restore
#line 4 "E:\ITI\Project\ASP.net core\MonaspatyF\Monaspaty\MonaspatyF\Views\ControlPanel\Details.cshtml"
                                          Write(Model.name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p><span class=\"font-weight-bold\">E-mail: </span>");
#nullable restore
#line 5 "E:\ITI\Project\ASP.net core\MonaspatyF\Monaspaty\MonaspatyF\Views\ControlPanel\Details.cshtml"
                                            Write(Model.email);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n<p><span class=\"font-weight-bold\">Phone: </span>");
#nullable restore
#line 6 "E:\ITI\Project\ASP.net core\MonaspatyF\Monaspaty\MonaspatyF\Views\ControlPanel\Details.cshtml"
                                           Write(Model.phone);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<HallShopOwner> Html { get; private set; }
    }
}
#pragma warning restore 1591