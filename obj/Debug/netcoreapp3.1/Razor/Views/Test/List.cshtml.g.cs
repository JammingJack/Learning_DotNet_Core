#pragma checksum "C:\Users\AmineH\projects-dotnet\FirstWebApp\Views\Test\List.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "28d9fb02c8c4647d86e202725b4e864d6fce39ea"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Test_List), @"mvc.1.0.view", @"/Views/Test/List.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"28d9fb02c8c4647d86e202725b4e864d6fce39ea", @"/Views/Test/List.cshtml")]
    public class Views_Test_List : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<System.Collections.Generic.IList<FirstWebApp.Model.Student>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n    <table class=\"table table-bordered table-hover\">\r\n        <hr>\r\n            <td>Id</td>\r\n            <td>Name</td>\r\n            <td>Score</td>\r\n        </hr>\r\n");
#nullable restore
#line 9 "C:\Users\AmineH\projects-dotnet\FirstWebApp\Views\Test\List.cshtml"
         foreach (FirstWebApp.Model.Student st in Model)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 12 "C:\Users\AmineH\projects-dotnet\FirstWebApp\Views\Test\List.cshtml"
           Write(st.Id);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 13 "C:\Users\AmineH\projects-dotnet\FirstWebApp\Views\Test\List.cshtml"
           Write(st.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 14 "C:\Users\AmineH\projects-dotnet\FirstWebApp\Views\Test\List.cshtml"
           Write(st.Score);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 16 "C:\Users\AmineH\projects-dotnet\FirstWebApp\Views\Test\List.cshtml"
        }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<System.Collections.Generic.IList<FirstWebApp.Model.Student>> Html { get; private set; }
    }
}
#pragma warning restore 1591
