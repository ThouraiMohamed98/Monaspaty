#pragma checksum "E:\ITI\Project\ASP.net core\MonaspatyF\Monaspaty\MonaspatyF\Views\HallShopOwner\Profile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bb110d5f51935ca0c9e9b66269bb79c81ec9fe94"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_HallShopOwner_Profile), @"mvc.1.0.view", @"/Views/HallShopOwner/Profile.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bb110d5f51935ca0c9e9b66269bb79c81ec9fe94", @"/Views/HallShopOwner/Profile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9605fff9bf3e465101d7c1638f2c3a81a14f9227", @"/Views/_ViewImports.cshtml")]
    public class Views_HallShopOwner_Profile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("card-img-top"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Card image cap"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("height:200px"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-danger"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("onclick", new global::Microsoft.AspNetCore.Html.HtmlString("return confirm(\'are you sure you want to Delete Item?\')"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        #pragma warning restore 0649
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __backed__tagHelperScopeManager = null;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager __tagHelperScopeManager
        {
            get
            {
                if (__backed__tagHelperScopeManager == null)
                {
                    __backed__tagHelperScopeManager = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperScopeManager(StartTagHelperWritingScope, EndTagHelperWritingScope);
                }
                return __backed__tagHelperScopeManager;
            }
        }
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "E:\ITI\Project\ASP.net core\MonaspatyF\Monaspaty\MonaspatyF\Views\HallShopOwner\Profile.cshtml"
  
    ViewData["Title"] = "Profile";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""modal fade"" id=""details"">
    <div class=""modal-dialog"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <button type=""button"" class=""close"" data-dismiss=""modal"">X</button>
            </div>
            <div class=""modal-body"" id=""Details_Body"">
                <partial src=""AddHS""></partial>
            </div>
            <div class=""modal-footer"">
                <input type=""button"" class=""btn btn-danger"" data-dismiss=""modal"" value=""close"" />
            </div>
        </div>
    </div>
</div>

");
            DefineSection("Name", async() => {
                WriteLiteral("\r\n    <span>");
#nullable restore
#line 23 "E:\ITI\Project\ASP.net core\MonaspatyF\Monaspaty\MonaspatyF\Views\HallShopOwner\Profile.cshtml"
     Write(ViewBag.HallShopOwner.name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</span>\r\n");
            }
            );
            WriteLiteral("\r\n<div class=\"row p-5\">\r\n");
#nullable restore
#line 27 "E:\ITI\Project\ASP.net core\MonaspatyF\Monaspaty\MonaspatyF\Views\HallShopOwner\Profile.cshtml"
     foreach (var item in ViewBag.HallShop)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"card m-2\" style=\"width: 18rem;\">\r\n            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "bb110d5f51935ca0c9e9b66269bb79c81ec9fe947054", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 906, "~/attach/", 906, 9, true);
#nullable restore
#line 30 "E:\ITI\Project\ASP.net core\MonaspatyF\Monaspaty\MonaspatyF\Views\HallShopOwner\Profile.cshtml"
AddHtmlAttributeValue("", 915, item.Image, 915, 11, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            <div class=\"card-body\">\r\n                <h5 class=\"card-title\">");
#nullable restore
#line 32 "E:\ITI\Project\ASP.net core\MonaspatyF\Monaspaty\MonaspatyF\Views\HallShopOwner\Profile.cshtml"
                                  Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                <h6 class=\"card-subtitle mb-2 text-muted\">");
#nullable restore
#line 33 "E:\ITI\Project\ASP.net core\MonaspatyF\Monaspaty\MonaspatyF\Views\HallShopOwner\Profile.cshtml"
                                                     Write(item.Station);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ,");
#nullable restore
#line 33 "E:\ITI\Project\ASP.net core\MonaspatyF\Monaspaty\MonaspatyF\Views\HallShopOwner\Profile.cshtml"
                                                                    Write(item.City);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ,");
#nullable restore
#line 33 "E:\ITI\Project\ASP.net core\MonaspatyF\Monaspaty\MonaspatyF\Views\HallShopOwner\Profile.cshtml"
                                                                                Write(item.Street);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</h6>\r\n                <p class=\"card-text\">");
#nullable restore
#line 34 "E:\ITI\Project\ASP.net core\MonaspatyF\Monaspaty\MonaspatyF\Views\HallShopOwner\Profile.cshtml"
                                Write(item.description);

#line default
#line hidden
#nullable disable
            WriteLiteral(".</p>\r\n                <a");
            BeginWriteAttribute("onclick", " onclick=\"", 1249, "\"", 1276, 3);
            WriteAttributeValue("", 1259, "EditHOS(", 1259, 8, true);
#nullable restore
#line 35 "E:\ITI\Project\ASP.net core\MonaspatyF\Monaspaty\MonaspatyF\Views\HallShopOwner\Profile.cshtml"
WriteAttributeValue("", 1267, item.Id, 1267, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1275, ")", 1275, 1, true);
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary\">Edit</a>\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "bb110d5f51935ca0c9e9b66269bb79c81ec9fe9411003", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "E:\ITI\Project\ASP.net core\MonaspatyF\Monaspaty\MonaspatyF\Views\HallShopOwner\Profile.cshtml"
                                         WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 39 "E:\ITI\Project\ASP.net core\MonaspatyF\Monaspaty\MonaspatyF\Views\HallShopOwner\Profile.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
    <div class=""card text-center  bg-light"" style=""width: 18rem;height:200px;margin:10px"">
        <div class=""card-body"">
            <h5 class=""card-title"">Add New Card</h5>
            <p class=""card-text"">
                You Can Add Details of Hall OR Shop
            </p>
            <button type=""button"" class=""btn btn-secondary""");
            BeginWriteAttribute("onclick", " onclick=\"", 1865, "\"", 1911, 3);
            WriteAttributeValue("", 1875, "createHOS(", 1875, 10, true);
#nullable restore
#line 47 "E:\ITI\Project\ASP.net core\MonaspatyF\Monaspaty\MonaspatyF\Views\HallShopOwner\Profile.cshtml"
WriteAttributeValue("", 1885, ViewBag.HallShopOwner.Id, 1885, 25, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1910, ")", 1910, 1, true);
            EndWriteAttribute();
            WriteLiteral(">Add</button>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        function createHOS(id) {
            $.ajax({
                type: ""Get"",
                url: ""/HallShopOwner/AddHS"",
                data: { ownerid: id },
                success: function (response) {
                    $(""#details #Details_Body"").html(response);
                    $("".modal-header"").html(""Create User"");
                    $(""#details"").modal(""show"");
                },
                error: function () {
                    console.log(""Error"");
                }
            })
        }

        function EditHOS(id) {
            $.ajax({
                type: ""Get"",
                url: ""/HallShopOwner/EditHOS"",
                data: { HOSid: id },
                success: function (response) {
                    $(""#details #Details_Body"").html(response);
                    $("".modal-header"").html(""Create User"");
                    $(""#details"").modal(""show"");
                },
                error: function () {
           ");
                WriteLiteral("         console.log(\"Error\");\r\n                }\r\n            })\r\n        }\r\n    </script>\r\n");
            }
            );
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
