#pragma checksum "C:\Users\Owner\desktop\csharp_project\DogScover\Views\Shared\ShowProject.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a08f8d3bdaca7a6204103c573754a576b406f9a9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_ShowProject), @"mvc.1.0.view", @"/Views/Shared/ShowProject.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Shared/ShowProject.cshtml", typeof(AspNetCore.Views_Shared_ShowProject))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a08f8d3bdaca7a6204103c573754a576b406f9a9", @"/Views/Shared/ShowProject.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"abb0bae0290f2857ea99e35ab11ffebc84f9ffe7", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_ShowProject : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Item>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("color:black;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Item", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "UpdateProject", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(13, 439, true);
            WriteLiteral(@"
    <link rel=""stylesheet"" href=""https://stackpath.bootstrapcdn.com/bootswatch/4.3.1/litera/bootstrap.min.css"">
    <style>
        .col {
            display: inline-block;
            margin-left: auto;
            margin-right: auto;
        }

        body {
            margin-left: auto;
            margin-right: auto;
            height: 100vh;
        }
    </style>


    <div class=""text-center"">
        <h2>");
            EndContext();
            BeginContext(453, 10, false);
#line 20 "C:\Users\Owner\desktop\csharp_project\DogScover\Views\Shared\ShowProject.cshtml"
       Write(Model.Name);

#line default
#line hidden
            EndContext();
            BeginContext(463, 127, true);
            WriteLiteral("</h2>\r\n        <br>\r\n    </div>\r\n    <section class=\"main text-center\">\r\n        <div class=\"d-inline-block\">\r\n            <img");
            EndContext();
            BeginWriteAttribute("src", " src=\"", 590, "\"", 611, 1);
#line 25 "C:\Users\Owner\desktop\csharp_project\DogScover\Views\Shared\ShowProject.cshtml"
WriteAttributeValue("", 596, Model.ImageURL, 596, 15, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(612, 393, true);
            WriteLiteral(@" alt=""product"">
        </div>
        <div class=""d-inline-block"">
            <div class=""progress"">
                <div class=""progress-bar progress-bar-striped progress-bar-animated"" role=""progressbar""
                    aria-valuenow=""30"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 30%""></div>
            </div>
            <p></p>
            <p></p>
            <p>");
            EndContext();
            BeginContext(1006, 17, false);
#line 34 "C:\Users\Owner\desktop\csharp_project\DogScover\Views\Shared\ShowProject.cshtml"
          Write(Model.FundingGoal);

#line default
#line hidden
            EndContext();
            BeginContext(1023, 381, true);
            WriteLiteral(@"</p>
            <button class=""btn btn-success"">Back This Project</button>
            <button class=""btn btn-success"">Favorite this Item</button>
        </div>
        <hr>
        <div class=""row"">
            <div class=""card text-white bg-success mb-3 col"" style=""max-width: 20rem;"">
                <div class=""card-body"">
                    <h4 class=""card-title"">");
            EndContext();
            BeginContext(1405, 11, false);
#line 42 "C:\Users\Owner\desktop\csharp_project\DogScover\Views\Shared\ShowProject.cshtml"
                                      Write(Model.Brand);

#line default
#line hidden
            EndContext();
            BeginContext(1416, 230, true);
            WriteLiteral("</h4>\r\n                    <p class=\"card-text\">About the company, mission statement</p>\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <hr>\r\n    </section>\r\n    <section>\r\n        <h4>About</h4>\r\n        <p>");
            EndContext();
            BeginContext(1647, 17, false);
#line 51 "C:\Users\Owner\desktop\csharp_project\DogScover\Views\Shared\ShowProject.cshtml"
      Write(Model.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1664, 121, true);
            WriteLiteral("</p>\r\n    </section>\r\n    <section>\r\n        <p>Partials goes here but not working for some reason?</p>\r\n    </section>\r\n");
            EndContext();
#line 56 "C:\Users\Owner\desktop\csharp_project\DogScover\Views\Shared\ShowProject.cshtml"
     if(@Model.UserId == ViewBag.SessionId)
    {

#line default
#line hidden
            BeginContext(1837, 100, true);
            WriteLiteral("    <div class=\"row\">\r\n        <div class=\"\">\r\n            <button class=\"btn btn-outline-success\" >");
            EndContext();
            BeginContext(1937, 119, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a08f8d3bdaca7a6204103c573754a576b406f9a98357", async() => {
                BeginContext(2032, 20, true);
                WriteLiteral("Delete Your Starter?");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 60 "C:\Users\Owner\desktop\csharp_project\DogScover\Views\Shared\ShowProject.cshtml"
                                                                                                                         WriteLiteral(Model.ItemId);

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
            BeginContext(2056, 103, true);
            WriteLiteral("</button>\r\n        </div>\r\n       <div class=\"\">\r\n            <button class=\"btn btn-outline-success\" >");
            EndContext();
            BeginContext(2159, 125, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a08f8d3bdaca7a6204103c573754a576b406f9a911188", async() => {
                BeginContext(2261, 19, true);
                WriteLiteral("Update Your Project");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 63 "C:\Users\Owner\desktop\csharp_project\DogScover\Views\Shared\ShowProject.cshtml"
                                                                                                                                WriteLiteral(Model.ItemId);

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
            BeginContext(2284, 39, true);
            WriteLiteral("</button>\r\n        </div>\r\n    </div>\r\n");
            EndContext();
#line 66 "C:\Users\Owner\desktop\csharp_project\DogScover\Views\Shared\ShowProject.cshtml"
    }

#line default
#line hidden
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Item> Html { get; private set; }
    }
}
#pragma warning restore 1591
