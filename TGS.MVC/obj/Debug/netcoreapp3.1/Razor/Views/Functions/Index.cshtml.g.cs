#pragma checksum "C:\Users\Heinz\Source\Repos\dotnet-assessment\TGS.MVC\Views\Functions\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8e621a3bf96963c4475c879fa3c39b80eb1f213b"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Functions_Index), @"mvc.1.0.view", @"/Views/Functions/Index.cshtml")]
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
#line 1 "C:\Users\Heinz\Source\Repos\dotnet-assessment\TGS.MVC\Views\_ViewImports.cshtml"
using TGS.MVC;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Heinz\Source\Repos\dotnet-assessment\TGS.MVC\Views\_ViewImports.cshtml"
using TGS.MVC.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8e621a3bf96963c4475c879fa3c39b80eb1f213b", @"/Views/Functions/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7cae428216fec32b7d626ea02657b260f5176fea", @"/Views/_ViewImports.cshtml")]
    public class Views_Functions_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 2 "C:\Users\Heinz\Source\Repos\dotnet-assessment\TGS.MVC\Views\Functions\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h1>TGS Functions</h1>

<div class=""row"">


    <div class=""card"">
        <div class=""card-body"">
            <h3>Vowel Count</h3>                      

            <p>Count the vowels in text.</p>

        </div>
    </div>

    <div class=""card"">
        <div class=""card-body"">
            <h3>Anagrams</h3>
            
            <p>Check to see if the words are anagrams.</p>
        </div>
    </div>

    <div class=""card"">
        <div class=""card-body"">
            <h3>Format Numbers</h3>

            <p>Format a number to more readable format.</p>
        </div>
    </div>

</div>");
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
