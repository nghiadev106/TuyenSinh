#pragma checksum "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Blogs\DetailBlog.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "bbb5761c91050789eb13b5b0c80789239ded90e0"
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
#line 1 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\_ViewImports.cshtml"
using TuyenSinh;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\_ViewImports.cshtml"
using TuyenSinh.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bbb5761c91050789eb13b5b0c80789239ded90e0", @"/Views/Blogs/DetailBlog.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfa8aae2442e2c3c567698bd322f2c8b9a318836", @"/Views/_ViewImports.cshtml")]
    public class Views_Blogs_DetailBlog : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TuyenSinh.Model.News>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Blogs\DetailBlog.cshtml"
  
    ViewData["Title"] = "Chi tiết tin";
    var categories = (List<TuyenSinh.Model.Category>)ViewBag.categories;
    var relatedNews = (List<TuyenSinh.Model.News>)ViewBag.relatedNews;
    var ListNews = (List<TuyenSinh.Model.News>)ViewBag.ListNews;

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""bodycontent"" style=""background-color: whitesmoke;"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-1""></div>
            <div class=""col-md-10"">
                <div class=""blog-posts single-post"">
                    <article class=""post clearfix mb-0"">
                        <div class=""entry-content"">
                            <div class=""entry-meta media no-bg no-border mt-15 pb-20"">
                                <div class=""media-body pl-15"">
                                    <div class=""event-content pull-left flip"">
                                        <h3 class=""entry-title text-white text-uppercase pt-0 mt-0"" style=""line-height: 1.42857143;"">
                                            <!----><!---->
                                            <a style=""color:black"">");
#nullable restore
#line 22 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Blogs\DetailBlog.cshtml"
                                                              Write(Model.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                        </h3>
                                        <!----><!---->
                                        <span class=""mb-10 text-gray-darkgray mr-10 font-13""><i class=""fa fa-calendar"" style=""font-size:13px; width:13px; height:13px; margin-right:10px""></i>ngày ");
#nullable restore
#line 25 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Blogs\DetailBlog.cshtml"
                                                                                                                                                                                              Write(Model.CreateDate.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@" </span>
                                    </div>
                                </div>
                            </div>
                            <div class=""entry"">
                                <div style=""text-align:justify"">
                                    <!----><!---->
                                  ");
#nullable restore
#line 32 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Blogs\DetailBlog.cshtml"
                             Write(Html.Raw(Model.Detail));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                </div>
                            </div>
                        </div>
                    </article>
                </div>
            </div>
            <div class=""col-md-1""></div>
        </div>
    </div>

    <!-- Messenger Plugin chat Code -->
    <div id=""fb-root""></div>

    <!-- Your Plugin chat code -->
    <div id=""fb-customer-chat"" class=""fb-customerchat"">
    </div>

    <script>
        var chatbox = document.getElementById('fb-customer-chat');
        chatbox.setAttribute(""page_id"", ""1759613197403378"");
        chatbox.setAttribute(""attribution"", ""biz_inbox"");

        window.fbAsyncInit = function () {
            FB.init({
                xfbml: true,
                version: 'v11.0'
            });
        };

        (function (d, s, id) {
            var js, fjs = d.getElementsByTagName(s)[0];
            if (d.getElementById(id)) return;
            js = d.createElement(s); js.id = id;
            js.src = 'https://con");
            WriteLiteral(@"nect.facebook.net/vi_VN/sdk/xfbml.customerchat.js';
            fjs.parentNode.insertBefore(js, fjs);
        }(document, 'script', 'facebook-jssdk'));
    </script>

    <script>DevExpress.aspnet.setTemplateEngine();</script><div id=""dxPopupLoading""></div>
    <script type=""text/html"" id=""dxPopupLoading-contentTemplate"">
        <h2 style=""text-align:center"">Hệ thống đang xử lý.<br />Vui lòng đợi trong giây lát</h2>
        <div id=""loader"" class=""loader""></div>
    </script>
    <script>jQuery(function ($) { $(""#dxPopupLoading"").dxPopup({ ""elementAttr"": { ""class"": ""popup"" }, ""width"": 600.0, ""height"": 225.0, ""showTitle"": false, ""visible"": false, ""dragEnabled"": false, ""closeOnOutsideClick"": false, ""contentTemplate"": $(""#dxPopupLoading-contentTemplate"") }); });</script>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TuyenSinh.Model.News> Html { get; private set; }
    }
}
#pragma warning restore 1591
