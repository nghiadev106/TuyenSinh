#pragma checksum "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b2426744b0ac666856a517c29525ead80a5c88ee"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Question_Index), @"mvc.1.0.view", @"/Views/Question/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b2426744b0ac666856a517c29525ead80a5c88ee", @"/Views/Question/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfa8aae2442e2c3c567698bd322f2c8b9a318836", @"/Views/_ViewImports.cshtml")]
    public class Views_Question_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TuyenSinh.Models.PaginationSet<TuyenSinh.Model.Question>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
  
    ViewData["Title"] = "Câu hỏi";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""bodycontent"" style=""background-color: whitesmoke;"">
    <div class=""container"">
        <div class=""div-breadcrumb"">
            <nav aria-label=""breadcrumb"">
                <ol class=""breadcrumb"" style=""padding:16px 0;"">
                    <li class=""breadcrumb-item""><a href=""/"">Trang chủ</a></li>
                    <li class=""breadcrumb-item active"" aria-current=""page"">Câu hỏi</li>
                </ol>
            </nav>
        </div>
        <div class=""row"">
            <div class=""col-sm-12"">
                <div id=""toTop""></div>
                <a href=""/dat-cau-hoi"" style=""text-align:right;color:blue;"">
                    <h4>ĐẶT CÂU HỎI</h4>
                </a>

            </div>
        </div>

        <div class=""row"">
            <div class=""col-lg-12 col-sm-12"">
                <div id=""divListNews"">
");
#nullable restore
#line 28 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
                     if (Model.Items.Count() > 0)
                    {
                        foreach (var item in Model.Items)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <div class=\"row\" style=\'margin-bottom: 16px;\'>\r\n                                <div class=\"col-sm-4\">\r\n                                    <img");
            BeginWriteAttribute("src", " src=\"", 1308, "\"", 1325, 1);
#nullable restore
#line 34 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
WriteAttributeValue("", 1314, item.Image, 1314, 11, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1326, "\"", 1342, 1);
#nullable restore
#line 34 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
WriteAttributeValue("", 1332, item.Name, 1332, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" class=""img-fullwidth"" style=""height:150px;object-fit:cover;"" />
                                </div>
                                <div class=""col-sm-8"">
                                    <div style=""padding: 0px 10px 10px 10px;"">
                                        <h4 class=""text-uppercase font-weight-600"">
                                            <a");
            BeginWriteAttribute("href", " href=\"", 1716, "\"", 1759, 4);
            WriteAttributeValue("", 1723, "/cau-hoi/chi-tiet/", 1723, 18, true);
#nullable restore
#line 39 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
WriteAttributeValue("", 1741, item.Url, 1741, 9, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 1750, "/", 1750, 1, true);
#nullable restore
#line 39 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
WriteAttributeValue("", 1751, item.Id, 1751, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("alt", " alt=\"", 1760, "\"", 1776, 1);
#nullable restore
#line 39 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
WriteAttributeValue("", 1766, item.Name, 1766, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 1777, "\"", 1795, 1);
#nullable restore
#line 39 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
WriteAttributeValue("", 1785, item.Name, 1785, 10, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n                                                ");
#nullable restore
#line 40 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                            </a>
                                        </h4>
                                        <div style='margin-bottom: 8px;'>
                                            <span><i class=""fa fa-calendar"" aria-hidden=""true""></i></span>
                                            <span>");
#nullable restore
#line 45 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
                                             Write(item.CreateDate.Value.ToString("dd/MM/yyyy"));

#line default
#line hidden
#nullable disable
            WriteLiteral("</span>\r\n                                        </div>\r\n                                        <div>\r\n                                            <p>");
#nullable restore
#line 48 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
                                          Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</p>\r\n                                        </div>\r\n                                    </div>\r\n                                </div>\r\n                            </div>\r\n");
#nullable restore
#line 53 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
                        }
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                </div>\r\n                <div class=\"row\">\r\n                    <div class=\"col-sm-12\">\r\n                        <div class=\"pagination\" id=\"paginationListNews\">\r\n");
#nullable restore
#line 60 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
                             if (Model.TotalPages > 1)
                            {
                                // Create numeric links
                                var startPageIndex = Math.Max(1, Model.Page - Model.MaxPage / 2);
                                var endPageIndex = Math.Min(Model.TotalPages, Model.Page + Model.MaxPage / 2);


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <nav>\r\n                                    <ul class=\"pagination\">\r\n");
#nullable restore
#line 68 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
                                         if (Model.Page > 1)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                            <li class=""page-item"">
                                                <a class=""page-link"" href=""?page=1"" aria-label=""First"">
                                                    <i class=""fa fa-angle-double-left""></i>
                                                </a>
                                            </li>
                                            <li class=""page-item"">
                                                <a class=""page-link""");
            BeginWriteAttribute("href", " href=\"", 3875, "\"", 3903, 2);
            WriteAttributeValue("", 3882, "?page=", 3882, 6, true);
#nullable restore
#line 76 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
WriteAttributeValue("", 3888, Model.Page-1, 3888, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Previous\">\r\n                                                    <i class=\"fa fa-angle-double-left\"></i>\r\n                                                </a>\r\n                                            </li>\r\n");
#nullable restore
#line 80 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 81 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
                                         for (int i = startPageIndex; i <= endPageIndex; i++)
                                        {
                                            if (Model.Page == i)
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li class=\"active page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4518, "\"", 4533, 2);
            WriteAttributeValue("", 4525, "?page=", 4525, 6, true);
#nullable restore
#line 85 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
WriteAttributeValue("", 4531, i, 4531, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 4534, "\"", 4550, 2);
            WriteAttributeValue("", 4542, "Trang", 4542, 5, true);
#nullable restore
#line 85 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
WriteAttributeValue(" ", 4547, i, 4548, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 85 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
                                                                                                                              Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 86 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
                                            }
                                            else
                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <li class=\"page-item\"><a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 4799, "\"", 4814, 2);
            WriteAttributeValue("", 4806, "?page=", 4806, 6, true);
#nullable restore
#line 89 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
WriteAttributeValue("", 4812, i, 4812, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            BeginWriteAttribute("title", " title=\"", 4815, "\"", 4831, 2);
            WriteAttributeValue("", 4823, "Trang", 4823, 5, true);
#nullable restore
#line 89 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
WriteAttributeValue(" ", 4828, i, 4829, 2, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 89 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
                                                                                                                       Write(i);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a></li>\r\n");
#nullable restore
#line 90 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
                                            }
                                        }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
                                         if (Model.Page < Model.TotalPages)
                                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                            <li class=\"page-item\">\r\n                                                <a class=\"page-link\"");
            BeginWriteAttribute("href", " href=\"", 5192, "\"", 5220, 2);
            WriteAttributeValue("", 5199, "?page=", 5199, 6, true);
#nullable restore
#line 95 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
WriteAttributeValue("", 5205, Model.Page+1, 5205, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" aria-label=""Next"">
                                                    <i class=""fa fa-angle-double-right""></i>
                                                </a>
                                            </li>
                                            <li class=""page-item"">
                                                <a class=""page-link""");
            BeginWriteAttribute("href", " href=\"", 5577, "\"", 5607, 2);
            WriteAttributeValue("", 5584, "?page=", 5584, 6, true);
#nullable restore
#line 100 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
WriteAttributeValue("", 5590, Model.TotalPages, 5590, 17, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" aria-label=\"Last\">\r\n                                                    <i class=\"fa fa-angle-double-right\"></i>\r\n                                                </a>\r\n                                            </li>\r\n");
#nullable restore
#line 104 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
                                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    </ul>\r\n                                </nav>\r\n");
#nullable restore
#line 107 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Question\Index.cshtml"
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n        </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TuyenSinh.Models.PaginationSet<TuyenSinh.Model.Question>> Html { get; private set; }
    }
}
#pragma warning restore 1591
