#pragma checksum "C:\Users\AmineH\projects-dotnet\FirstWebApp\Views\Test\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4b0f30feffbbb115baedc27f796730e18eb3e914"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_Index), @"mvc.1.0.view", @"/Views/Test/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4b0f30feffbbb115baedc27f796730e18eb3e914", @"/Views/Test/Index.cshtml")]
    public class Views_Test_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.IList<string>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<h1>Here is a list sent from the controller Test</h1>\r\n<div class=\"row container-fluid\">\r\n    <ul class=\"list-group col-md-4\">\r\n");
#nullable restore
#line 7 "C:\Users\AmineH\projects-dotnet\FirstWebApp\Views\Test\Index.cshtml"
     foreach (string item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <li class=\"list-group-item\">");
#nullable restore
#line 9 "C:\Users\AmineH\projects-dotnet\FirstWebApp\Views\Test\Index.cshtml"
                               Write(item);

#line default
#line hidden
#nullable disable
            WriteLiteral("</li>\r\n");
#nullable restore
#line 10 "C:\Users\AmineH\projects-dotnet\FirstWebApp\Views\Test\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.IList<string>> Html { get; private set; }
    }
}
#pragma warning restore 1591
