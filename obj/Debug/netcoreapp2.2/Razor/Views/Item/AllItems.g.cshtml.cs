#pragma checksum "C:\Users\Owner\desktop\csharp_project\DogScover\Views\Item\AllItems.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ca0383d312c35ae0341698d38a99702d20f1bf7a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Item_AllItems), @"mvc.1.0.view", @"/Views/Item/AllItems.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Item/AllItems.cshtml", typeof(AspNetCore.Views_Item_AllItems))]
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
#line 1 "C:\Users\Owner\desktop\csharp_project\DogScover\Views\_ViewImports.cshtml"
using DogScover;

#line default
#line hidden
#line 2 "C:\Users\Owner\desktop\csharp_project\DogScover\Views\_ViewImports.cshtml"
using DogScover.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ca0383d312c35ae0341698d38a99702d20f1bf7a", @"/Views/Item/AllItems.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abb0bae0290f2857ea99e35ab11ffebc84f9ffe7", @"/Views/_ViewImports.cshtml")]
    public class Views_Item_AllItems : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Item>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "ShowProject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Item", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(19, 63, true);
            WriteLiteral("  \r\n<div class=\"ViewSize\">\r\n  <h3>Support a Project!</h3><br>\r\n");
            EndContext();
#line 5 "C:\Users\Owner\desktop\csharp_project\DogScover\Views\Item\AllItems.cshtml"
   foreach(var item in Model)
  {

#line default
#line hidden
            BeginContext(118, 106, true);
            WriteLiteral("  <div class=\"card border-primary mb-3 \" style=\"max-width: 20rem;\">\r\n    <div class=\"card-body  \">\r\n      ");
            EndContext();
            BeginContext(224, 249, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ca0383d312c35ae0341698d38a99702d20f1bf7a4219", async() => {
                BeginContext(302, 75, true);
                WriteLiteral("\r\n        <h4 style=\"color:#02b875; text-align:center;\" class=\"card-title\">");
                EndContext();
                BeginContext(378, 9, false);
#line 10 "C:\Users\Owner\desktop\csharp_project\DogScover\Views\Item\AllItems.cshtml"
                                                                    Write(item.Name);

#line default
#line hidden
                EndContext();
                BeginContext(387, 19, true);
                WriteLiteral("</h4>\r\n        <img");
                EndContext();
                BeginWriteAttribute("src", " src=\"", 406, "\"", 426, 1);
#line 11 "C:\Users\Owner\desktop\csharp_project\DogScover\Views\Item\AllItems.cshtml"
WriteAttributeValue("", 412, item.ImageURL, 412, 14, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(427, 42, true);
                WriteLiteral(" alt=\"image\" style=\"width: 18rem\">\r\n      ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 9 "C:\Users\Owner\desktop\csharp_project\DogScover\Views\Item\AllItems.cshtml"
                                                          WriteLiteral(item.ItemId);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(473, 41, true);
            WriteLiteral("\r\n      <br>\r\n      <p class=\"card-text\">");
            EndContext();
            BeginContext(515, 16, false);
#line 14 "C:\Users\Owner\desktop\csharp_project\DogScover\Views\Item\AllItems.cshtml"
                      Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(531, 28, true);
            WriteLiteral("</p>\r\n    </div>\r\n  </div>\r\n");
            EndContext();
#line 17 "C:\Users\Owner\desktop\csharp_project\DogScover\Views\Item\AllItems.cshtml"
  }

#line default
#line hidden
            BeginContext(564, 6, true);
            WriteLiteral("</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Item>> Html { get; private set; }
    }
}
#pragma warning restore 1591