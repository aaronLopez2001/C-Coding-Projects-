#pragma checksum "C:\Users\azehu\OneDrive\Desktop\Basic C# Programs\FinalAssignment\FinalAssignment\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3ada01996c137358c41305d8e431c4a4f53447a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
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
#line 1 "C:\Users\azehu\OneDrive\Desktop\Basic C# Programs\FinalAssignment\FinalAssignment\Views\_ViewImports.cshtml"
using FinalAssignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\azehu\OneDrive\Desktop\Basic C# Programs\FinalAssignment\FinalAssignment\Views\_ViewImports.cshtml"
using FinalAssignment.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3ada01996c137358c41305d8e431c4a4f53447a6", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"060a51d135c605de16012896ee0e93217cf79c36", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n");
#nullable restore
#line 3 "C:\Users\azehu\OneDrive\Desktop\Basic C# Programs\FinalAssignment\FinalAssignment\Views\Home\Index.cshtml"
  
        ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(" <script type=\"text/javascript\" src=\"./js/JavaScript.js\"></script>\r\n<div class=\"text-center\">\r\n    <h1 class=\"display-4\">Welcome</h1>\r\n\r\n    <h2 style=\"color:orange;\" >");
#nullable restore
#line 10 "C:\Users\azehu\OneDrive\Desktop\Basic C# Programs\FinalAssignment\FinalAssignment\Views\Home\Index.cshtml"
                          Write(DateTime.Now.DayOfWeek);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h2>\r\n    <p>Learn about <a href=\"https://docs.microsoft.com/aspnet/core\">building Web apps with ASP.NET Core</a>.</p>\r\n    <button type=\"button\" id=\"btn\" onclick=\"Click()\">Click Me!</button>\r\n</div>\r\n");
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
