#pragma checksum "C:\Users\Maggie\Documents\Grand Circus\Projects\YarnTodayStorefront\YarnTodayStorefront\Views\Storefront\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ce1ea37021f198b79af496528577d916d343354"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Storefront_Index), @"mvc.1.0.view", @"/Views/Storefront/Index.cshtml")]
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
#line 1 "C:\Users\Maggie\Documents\Grand Circus\Projects\YarnTodayStorefront\YarnTodayStorefront\Views\_ViewImports.cshtml"
using YarnTodayStorefront;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Maggie\Documents\Grand Circus\Projects\YarnTodayStorefront\YarnTodayStorefront\Views\_ViewImports.cshtml"
using YarnTodayStorefront.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ce1ea37021f198b79af496528577d916d343354", @"/Views/Storefront/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1338890831b695d8cd10d5c0705c7d1e996c776e", @"/Views/_ViewImports.cshtml")]
    public class Views_Storefront_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Product>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("width", new global::Microsoft.AspNetCore.Html.HtmlString("150"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Buy", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Storefront", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n<div style=\"padding-left: 25%; padding-right: 25%\">\r\n<h1 style=\"color: purple\">Yarn Inventory</h1>\r\n\r\n");
#nullable restore
#line 6 "C:\Users\Maggie\Documents\Grand Circus\Projects\YarnTodayStorefront\YarnTodayStorefront\Views\Storefront\Index.cshtml"
     foreach (Product p in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div>\r\n            <div style=\"float: right; margin: 0px 0px 15px 15px; border:2px solid rgb(3, 31, 3);\">\r\n                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9ce1ea37021f198b79af496528577d916d3433544852", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 316, "~/", 316, 2, true);
#nullable restore
#line 10 "C:\Users\Maggie\Documents\Grand Circus\Projects\YarnTodayStorefront\YarnTodayStorefront\Views\Storefront\Index.cshtml"
AddHtmlAttributeValue("", 318, p.Photo, 318, 8, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n            </div>\r\n            <p>\r\n                <h3>");
#nullable restore
#line 13 "C:\Users\Maggie\Documents\Grand Circus\Projects\YarnTodayStorefront\YarnTodayStorefront\Views\Storefront\Index.cshtml"
               Write(p.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h3>\r\n                Color: ");
#nullable restore
#line 14 "C:\Users\Maggie\Documents\Grand Circus\Projects\YarnTodayStorefront\YarnTodayStorefront\Views\Storefront\Index.cshtml"
                  Write(p.Color);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                Price: $");
#nullable restore
#line 15 "C:\Users\Maggie\Documents\Grand Circus\Projects\YarnTodayStorefront\YarnTodayStorefront\Views\Storefront\Index.cshtml"
                   Write(Math.Round(p.Price, 2));

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                Description: ");
#nullable restore
#line 16 "C:\Users\Maggie\Documents\Grand Circus\Projects\YarnTodayStorefront\YarnTodayStorefront\Views\Storefront\Index.cshtml"
                        Write(p.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br>\r\n                Available: ");
#nullable restore
#line 17 "C:\Users\Maggie\Documents\Grand Circus\Projects\YarnTodayStorefront\YarnTodayStorefront\Views\Storefront\Index.cshtml"
                      Write(p.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("<br />\r\n                <center>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9ce1ea37021f198b79af496528577d916d3433548048", async() => {
                WriteLiteral("<input action=\"Buy\" type=\"submit\" value=\"Buy Yarn\" />");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-Id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 19 "C:\Users\Maggie\Documents\Grand Circus\Projects\YarnTodayStorefront\YarnTodayStorefront\Views\Storefront\Index.cshtml"
                                                                      WriteLiteral(p.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-Id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["Id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </center>\r\n\r\n            </p>\r\n            <br />\r\n        </div>\r\n");
#nullable restore
#line 25 "C:\Users\Maggie\Documents\Grand Circus\Projects\YarnTodayStorefront\YarnTodayStorefront\Views\Storefront\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("   \r\n\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Product>> Html { get; private set; }
    }
}
#pragma warning restore 1591