#pragma checksum "D:\DA\TuyenSinh\TuyenSinh\Views\Blogs\ListBlogs.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b78f0368d0481b67a12bbb1596a7bc2b9e9fd87a"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blogs_ListBlogs), @"mvc.1.0.view", @"/Views/Blogs/ListBlogs.cshtml")]
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
#line 1 "D:\DA\TuyenSinh\TuyenSinh\Views\_ViewImports.cshtml"
using TuyenSinh;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\DA\TuyenSinh\TuyenSinh\Views\_ViewImports.cshtml"
using TuyenSinh.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b78f0368d0481b67a12bbb1596a7bc2b9e9fd87a", @"/Views/Blogs/ListBlogs.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfa8aae2442e2c3c567698bd322f2c8b9a318836", @"/Views/_ViewImports.cshtml")]
    public class Views_Blogs_ListBlogs : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TuyenSinh.Models.PaginationSet<TuyenSinh.Model.News>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("searchform"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("http://dongho.giaodienwebmau.com/"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("role", new global::Microsoft.AspNetCore.Html.HtmlString("search"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\DA\TuyenSinh\TuyenSinh\Views\Blogs\ListBlogs.cshtml"
  
    ViewData["Title"] = "Danh mục tin tức";
    var ListCate = (List<TuyenSinh.Model.Category>)ViewBag.ListCate;
    var ListNews = (List<TuyenSinh.Model.News>)ViewBag.ListNews;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n<main id=\"main\"");
            BeginWriteAttribute("class", " class=\"", 268, "\"", 276, 0);
            EndWriteAttribute();
            WriteLiteral(">\r\n    <div id=\"content\" class=\"blog-wrapper blog-archive page-wrapper\">\r\n        <div class=\"row row-large row-divided \">\r\n            <div class=\"large-9 col\">\r\n                <div class=\"row large-columns-1 medium-columns- small-columns-1\">\r\n");
#nullable restore
#line 14 "D:\DA\TuyenSinh\TuyenSinh\Views\Blogs\ListBlogs.cshtml"
                     if (ListNews.Count() > 0)
                    {
                        foreach (var item in ListNews)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"col post-item\">\r\n                                <div class=\"col-inner\">\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 829, "\"", 868, 4);
            WriteAttributeValue("", 836, "/chi-tiet-tin/", 836, 14, true);
#nullable restore
#line 20 "D:\DA\TuyenSinh\TuyenSinh\Views\Blogs\ListBlogs.cshtml"
WriteAttributeValue("", 850, item.Url, 850, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 859, "/", 859, 1, true);
#nullable restore
#line 20 "D:\DA\TuyenSinh\TuyenSinh\Views\Blogs\ListBlogs.cshtml"
WriteAttributeValue("", 860, item.Id, 860, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""plain"">
                                        <div class=""box box-vertical box-text-bottom box-blog-post has-hover"">
                                            <div class=""box-image"" style=""width:40%;"">
                                                <div class=""image-cover"" style=""padding-top:56%;"">
                                                    <img width=""600"" height=""400""");
            BeginWriteAttribute("src", " src=\"", 1267, "\"", 1284, 1);
#nullable restore
#line 24 "D:\DA\TuyenSinh\TuyenSinh\Views\Blogs\ListBlogs.cshtml"
WriteAttributeValue("", 1273, item.Image, 1273, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"attachment-medium size-medium wp-post-image\"");
            BeginWriteAttribute("alt", " alt=\"", 1337, "\"", 1353, 1);
#nullable restore
#line 24 "D:\DA\TuyenSinh\TuyenSinh\Views\Blogs\ListBlogs.cshtml"
WriteAttributeValue("", 1343, item.Name, 1343, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" sizes=""(max-width: 600px) 100vw, 600px"" />
                                                </div>
                                            </div><!-- .box-image -->
                                            <div class=""box-text text-left"">
                                                <div class=""box-text-inner blog-post-inner"">
                                                    <h5 class=""post-title is-large "">");
#nullable restore
#line 29 "D:\DA\TuyenSinh\TuyenSinh\Views\Blogs\ListBlogs.cshtml"
                                                                                Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h5>\r\n                                                    <div class=\"is-divider\"></div>\r\n");
#nullable restore
#line 31 "D:\DA\TuyenSinh\TuyenSinh\Views\Blogs\ListBlogs.cshtml"
                                                     if (item.Description.Length > 120)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <p class=\"from_the_blog_excerpt \">\r\n                                                            ");
#nullable restore
#line 34 "D:\DA\TuyenSinh\TuyenSinh\Views\Blogs\ListBlogs.cshtml"
                                                       Write(item.Description.Substring(0, 120));

#line default
#line hidden
#nullable disable
            WriteLiteral("...\r\n                                                        </p>\r\n");
#nullable restore
#line 36 "D:\DA\TuyenSinh\TuyenSinh\Views\Blogs\ListBlogs.cshtml"
                                                    }
                                                    else
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                        <p class=\"from_the_blog_excerpt \"> ");
#nullable restore
#line 39 "D:\DA\TuyenSinh\TuyenSinh\Views\Blogs\ListBlogs.cshtml"
                                                                                      Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n");
#nullable restore
#line 40 "D:\DA\TuyenSinh\TuyenSinh\Views\Blogs\ListBlogs.cshtml"
                                                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                </div><!-- .box-text-inner -->
                                            </div><!-- .box-text -->                                   
                                        </div><!-- .box -->
                                    </a><!-- .link -->
                                </div><!-- .col-inner -->
                            </div><!-- .col -->
");
#nullable restore
#line 47 "D:\DA\TuyenSinh\TuyenSinh\Views\Blogs\ListBlogs.cshtml"

                        }

                    }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                </div>

            </div> <!-- .large-9 -->

            <div class=""post-sidebar large-3 col"">
                <div id=""secondary"" class=""widget-area "" role=""complementary"">
                    <aside id=""search-2"" class=""widget widget_search"">
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b78f0368d0481b67a12bbb1596a7bc2b9e9fd87a11064", async() => {
                WriteLiteral("\r\n                            <div class=\"flex-row relative\">\r\n                                <div class=\"flex-col flex-grow\">\r\n                                    <input type=\"search\" class=\"search-field mb-0\" name=\"s\"");
                BeginWriteAttribute("value", " value=\"", 3692, "\"", 3700, 0);
                EndWriteAttribute();
                WriteLiteral(@" id=""s"" placeholder=""Tìm kiếm&hellip;"" />
                                </div><!-- .flex-col -->
                                <div class=""flex-col"">
                                    <button type=""submit"" class=""ux-search-submit submit-button secondary button icon mb-0"" aria-label=""Submit"">
                                        <i class=""icon-search""></i>
                                    </button>
                                </div><!-- .flex-col -->
                            </div><!-- .flex-row -->
                            <div class=""live-search-results text-left z-top""></div>
                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                    </aside>\t\t<aside id=\"recent-posts-2\" class=\"widget widget_recent_entries\">\r\n                        <span class=\"widget-title \"><span>Bài viết mới</span></span><div class=\"is-divider small\"></div><ul>\r\n");
#nullable restore
#line 73 "D:\DA\TuyenSinh\TuyenSinh\Views\Blogs\ListBlogs.cshtml"
     if (ListNews.Count() > 0)
    {
        foreach (var item in ListNews)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li>\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 4698, "\"", 4737, 4);
            WriteAttributeValue("", 4705, "/chi-tiet-tin/", 4705, 14, true);
#nullable restore
#line 78 "D:\DA\TuyenSinh\TuyenSinh\Views\Blogs\ListBlogs.cshtml"
WriteAttributeValue("", 4719, item.Url, 4719, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 4728, "/", 4728, 1, true);
#nullable restore
#line 78 "D:\DA\TuyenSinh\TuyenSinh\Views\Blogs\ListBlogs.cshtml"
WriteAttributeValue("", 4729, item.Id, 4729, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 78 "D:\DA\TuyenSinh\TuyenSinh\Views\Blogs\ListBlogs.cshtml"
                                                      Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n");
#nullable restore
#line 80 "D:\DA\TuyenSinh\TuyenSinh\Views\Blogs\ListBlogs.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</ul>\r\n                <aside id=\"categories-2\" class=\"widget widget_categories\">\r\n                        <span class=\"widget-title \"><span>Chuyên mục</span></span><div class=\"is-divider small\"></div>\t\t<ul>\r\n");
#nullable restore
#line 85 "D:\DA\TuyenSinh\TuyenSinh\Views\Blogs\ListBlogs.cshtml"
     if (ListCate.Count() > 0)
    {
foreach(var item in ListCate)
        {

#line default
#line hidden
#nullable disable
            WriteLiteral("            <li class=\"cat-item cat-item-17 current-cat\">\r\n                <a");
            BeginWriteAttribute("href", " href=\"", 5159, "\"", 5193, 4);
            WriteAttributeValue("", 5166, "/tin-tuc/", 5166, 9, true);
#nullable restore
#line 90 "D:\DA\TuyenSinh\TuyenSinh\Views\Blogs\ListBlogs.cshtml"
WriteAttributeValue("", 5175, item.Url, 5175, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 5184, "/", 5184, 1, true);
#nullable restore
#line 90 "D:\DA\TuyenSinh\TuyenSinh\Views\Blogs\ListBlogs.cshtml"
WriteAttributeValue("", 5185, item.Id, 5185, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 90 "D:\DA\TuyenSinh\TuyenSinh\Views\Blogs\ListBlogs.cshtml"
                                                 Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </li>\r\n");
#nullable restore
#line 92 "D:\DA\TuyenSinh\TuyenSinh\Views\Blogs\ListBlogs.cshtml"
        }
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n</ul>\r\n                    </aside>\r\n                </div><!-- #secondary -->\r\n            </div><!-- .post-sidebar -->\r\n\r\n        </div><!-- .row -->\r\n\r\n    </div><!-- .page-wrapper .blog-wrapper -->\r\n\r\n\r\n</main><!-- #main -->\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TuyenSinh.Models.PaginationSet<TuyenSinh.Model.News>> Html { get; private set; }
    }
}
#pragma warning restore 1591
