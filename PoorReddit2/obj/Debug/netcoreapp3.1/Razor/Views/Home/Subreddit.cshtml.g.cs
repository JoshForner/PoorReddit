#pragma checksum "C:\Users\forne\source\repos\CSHARP\PoorReddit2\PoorReddit2\Views\Home\Subreddit.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7bfb0db612b1c47f769ced33d452b5fed3bc2bec"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Subreddit), @"mvc.1.0.view", @"/Views/Home/Subreddit.cshtml")]
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
#line 1 "C:\Users\forne\source\repos\CSHARP\PoorReddit2\PoorReddit2\Views\_ViewImports.cshtml"
using PoorReddit2;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\forne\source\repos\CSHARP\PoorReddit2\PoorReddit2\Views\_ViewImports.cshtml"
using PoorReddit2.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7bfb0db612b1c47f769ced33d452b5fed3bc2bec", @"/Views/Home/Subreddit.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a28632aa1746393765c6c51293bd64b0d1688425", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Subreddit : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<RedditPost>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("    <div>\r\n");
#nullable restore
#line 3 "C:\Users\forne\source\repos\CSHARP\PoorReddit2\PoorReddit2\Views\Home\Subreddit.cshtml"
         for (int i = 0; i < 10; i++)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <p>\r\n            <a");
            BeginWriteAttribute("href", " href=\"", 107, "\"", 146, 1);
#nullable restore
#line 6 "C:\Users\forne\source\repos\CSHARP\PoorReddit2\PoorReddit2\Views\Home\Subreddit.cshtml"
WriteAttributeValue("", 114, Model.data.children[i].data.url, 114, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 170, "\"", 214, 1);
#nullable restore
#line 7 "C:\Users\forne\source\repos\CSHARP\PoorReddit2\PoorReddit2\Views\Home\Subreddit.cshtml"
WriteAttributeValue("", 176, Model.data.children[i].data.thumbnail, 176, 38, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n                ");
#nullable restore
#line 8 "C:\Users\forne\source\repos\CSHARP\PoorReddit2\PoorReddit2\Views\Home\Subreddit.cshtml"
           Write(Model.data.children[i].data.title);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </a>\r\n        </p>\r\n        <p></p>\r\n");
#nullable restore
#line 12 "C:\Users\forne\source\repos\CSHARP\PoorReddit2\PoorReddit2\Views\Home\Subreddit.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<RedditPost> Html { get; private set; }
    }
}
#pragma warning restore 1591
