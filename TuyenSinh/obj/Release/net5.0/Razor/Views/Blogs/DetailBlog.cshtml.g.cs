#pragma checksum "D:\Outsource\flower\WebsiteBanHang\Views\Blogs\DetailBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bcff70b5080a0684c42ab339c136a8a10c6a5c7e"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blogs_DetailBlog), @"mvc.1.0.view", @"/Views/Blogs/DetailBlog.cshtml")]
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
#line 1 "D:\Outsource\flower\WebsiteBanHang\Views\_ViewImports.cshtml"
using WebsiteBanHang;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Outsource\flower\WebsiteBanHang\Views\_ViewImports.cshtml"
using WebsiteBanHang.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bcff70b5080a0684c42ab339c136a8a10c6a5c7e", @"/Views/Blogs/DetailBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ea9d782b3b6a4d4d62df034c111d3c646244e96", @"/Views/_ViewImports.cshtml")]
    public class Views_Blogs_DetailBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<WebsiteBanHang.Data.News>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<div id=\"content\">\r\n    <div class=\"wrapper\">\r\n        <div class=\"lf\">\r\n");
            WriteLiteral("            <div class=\"cms_topic mt_10\">\r\n                <h1 style=\"color: #3de627\">\r\n                    ");
#nullable restore
#line 20 "D:\Outsource\flower\WebsiteBanHang\Views\Blogs\DetailBlog.cshtml"
               Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </h1>\r\n                ");
#nullable restore
#line 22 "D:\Outsource\flower\WebsiteBanHang\Views\Blogs\DetailBlog.cshtml"
           Write(Html.Raw(Model.Detail));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"rt\">\r\n            ");
#nullable restore
#line 26 "D:\Outsource\flower\WebsiteBanHang\Views\Blogs\DetailBlog.cshtml"
       Write(await Html.PartialAsync("_BannerTab"));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </div>\r\n    </div>\r\n</div>\r\n<div class=\"line-b padding_top_20\">\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<WebsiteBanHang.Data.News> Html { get; private set; }
    }
}
#pragma warning restore 1591