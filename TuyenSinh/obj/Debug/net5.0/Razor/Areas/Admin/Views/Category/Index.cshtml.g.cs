#pragma checksum "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Areas\Admin\Views\Category\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c10f0ad60ba6084d63116beaaadaef97501c31a7"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Areas_Admin_Views_Category_Index), @"mvc.1.0.view", @"/Areas/Admin/Views/Category/Index.cshtml")]
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
#line 1 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Areas\Admin\Views\_ViewImports.cshtml"
using TuyenSinh;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Areas\Admin\Views\_ViewImports.cshtml"
using TuyenSinh.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c10f0ad60ba6084d63116beaaadaef97501c31a7", @"/Areas/Admin/Views/Category/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8dcdf6b30b13447167270b3ce4919024db20f591", @"/Areas/Admin/Views/_ViewImports.cshtml")]
    public class Areas_Admin_Views_Category_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-success"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Category", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "admin", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Areas\Admin\Views\Category\Index.cshtml"
  
    Layout = "_LayoutAdmin";
    var lstCategories = (List<TuyenSinh.Models.CategoryViewModel>)ViewBag.lstCategories;

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<input type=\"hidden\" id=\"success\"");
            BeginWriteAttribute("value", " value=\"", 162, "\"", 190, 1);
#nullable restore
#line 6 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 170, TempData["success"], 170, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"warning\"");
            BeginWriteAttribute("value", " value=\"", 229, "\"", 257, 1);
#nullable restore
#line 7 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 237, TempData["warning"], 237, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"error\"");
            BeginWriteAttribute("value", " value=\"", 294, "\"", 320, 1);
#nullable restore
#line 8 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 302, TempData["error"], 302, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(@" />

<div class=""container-fluid"">
    <ol class=""breadcrumb mb-4"">
        <li class=""breadcrumb-item""><a href=""/"">Trang chủ</a></li>
        <li class=""breadcrumb-item active"">Danh sách danh mục</li>
    </ol>
    <div class=""card mb-12"">
        <div class=""card-header"">
            <div class=""row"">
                <div class=""col-md-6 col-xs-12"">
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c10f0ad60ba6084d63116beaaadaef97501c31a76384", async() => {
                WriteLiteral("Tạo mới");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n\r\n        <div class=\"card-body\">\r\n            <div class=\"table-responsive\">\r\n");
#nullable restore
#line 26 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Areas\Admin\Views\Category\Index.cshtml"
                 if (lstCategories.Count() > 0)
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <table class=""table table-bordered"" id=""dataTable"" width=""100%"" cellspacing=""0"">
                        <thead>
                            <tr>
                                <th>STT</th>
                                <th>Tên</th>
                                <th>Mô tả</th>
                                <th>Hiển thị</th>
                                <th>Trạng thái</th>
                                <th>#</th>
                            </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 40 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Areas\Admin\Views\Category\Index.cshtml"
                              
                                var stt = 0;
                                

#line default
#line hidden
#nullable disable
#nullable restore
#line 42 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Areas\Admin\Views\Category\Index.cshtml"
                                 foreach (var item in lstCategories)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 45 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Areas\Admin\Views\Category\Index.cshtml"
                               Write(Html.Raw(stt = stt + 1));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 46 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Areas\Admin\Views\Category\Index.cshtml"
                               Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 47 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Areas\Admin\Views\Category\Index.cshtml"
                               Write(item.Description);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n");
#nullable restore
#line 48 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Areas\Admin\Views\Category\Index.cshtml"
                                 if (item.ShowHome == true)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>Hiển thị</td>\r\n");
#nullable restore
#line 51 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Areas\Admin\Views\Category\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td>Ẩn</td>\r\n");
#nullable restore
#line 55 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Areas\Admin\Views\Category\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
#nullable restore
#line 56 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Areas\Admin\Views\Category\Index.cshtml"
                                 if (item.Status == 1)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td><span class=\"btn-success\">Hoạt động</span></td>\r\n");
#nullable restore
#line 59 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Areas\Admin\Views\Category\Index.cshtml"
                                }
                                else
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                    <td><span class=\"btn-danger\">Khóa</span></td>\r\n");
#nullable restore
#line 63 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Areas\Admin\Views\Category\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                                <td>\r\n                                    <a");
            BeginWriteAttribute("href", " href=\"", 2797, "\"", 2833, 2);
            WriteAttributeValue("", 2804, "/Admin/Category/Edit/", 2804, 21, true);
#nullable restore
#line 65 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 2825, item.Id, 2825, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-primary glyphicon glyphicon-pencilt\">Sửa</a>\r\n                                    <a class=\"btn btn-danger glyphicon glyphicon-trash\" onclick=\"return confirm(\'Bạn có muốn xóa không?\');\"");
            BeginWriteAttribute("href", " href=\"", 3035, "\"", 3083, 3);
#nullable restore
#line 66 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 3042, Url.Action("Delete","Category"), 3042, 32, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 3074, "/", 3074, 1, true);
#nullable restore
#line 66 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Areas\Admin\Views\Category\Index.cshtml"
WriteAttributeValue("", 3075, item.Id, 3075, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Xóa</a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 69 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Areas\Admin\Views\Category\Index.cshtml"
                                }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </tbody>\r\n                    </table>\r\n");
#nullable restore
#line 73 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Areas\Admin\Views\Category\Index.cshtml"
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <span>Không có danh mục nào</span>\r\n");
#nullable restore
#line 77 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Areas\Admin\Views\Category\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>");
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
