#pragma checksum "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "b7740b00376717f8e90372b6319d0aef469c074f"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b7740b00376717f8e90372b6319d0aef469c074f", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfa8aae2442e2c3c567698bd322f2c8b9a318836", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Home\Index.cshtml"
  
    var majors = (List<TuyenSinh.Models.MajorViewModel>)ViewBag.majors;

#line default
#line hidden
#nullable disable
            WriteLiteral("<input type=\"hidden\" id=\"success\"");
            BeginWriteAttribute("value", " value=\"", 113, "\"", 141, 1);
#nullable restore
#line 4 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Home\Index.cshtml"
WriteAttributeValue("", 121, TempData["success"], 121, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"warning\"");
            BeginWriteAttribute("value", " value=\"", 180, "\"", 208, 1);
#nullable restore
#line 5 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Home\Index.cshtml"
WriteAttributeValue("", 188, TempData["warning"], 188, 20, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<input type=\"hidden\" id=\"error\"");
            BeginWriteAttribute("value", " value=\"", 245, "\"", 271, 1);
#nullable restore
#line 6 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Home\Index.cshtml"
WriteAttributeValue("", 253, TempData["error"], 253, 18, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" />\r\n<div class=\"section clearfix object-non-visible\" data-animation-effect=\"fadeIn\" style=\"padding-top:0px;\" id=\"about\">\r\n    <div class=\"container\"");
            BeginWriteAttribute("style", " style=\"", 421, "\"", 429, 0);
            EndWriteAttribute();
            WriteLiteral(@">
        <div class=""row"">
            <div class=""col-md-12"">
                <a href=""../DangKyXetHocBaTSDH/Index"">
                    <div class=""lead text-center"" style=""font-size: 30px;"">
                        <h1 style=""text-align:center""><span style=""font-size:36px"">THÔNG TIN TUYỂN SINH ĐẠI HỌC HỆ CHÍNH QUY 2022</span></h1>
                    </div>
                </a>
            </div>
        </div>
    </div>
</div>
<!-- section start -->
<!-- ================ --
<!-- section end -->
<!-- section start -->
<!-- ================ -->
<!-- section end -->
<!-- section start -->
<!-- ================translucent-bg bg-image-1 blue -->
<div class=""section "">
    <div class=""container object-non-visible"" data-animation-effect=""fadeIn"" id=""services"">
        <div>
            <p>
                <strong><span style=""font-size:15.0pt"">1. Đối tượng tuyển sinh:</span></strong><span style=""font-size:15.0pt"">
                    Tất cả thí sinh đã tốt nghiệp THPT hoặc tương đương.");
            WriteLiteral(@"<br />
                    <strong>2. Phạm vi tuyển sinh:</strong> Toàn quốc.<br />
                    <strong>3. Chỉ tiêu tuyển sinh: 3.100</strong><br />
                    <strong>4. Phương thức tuyển sinh:</strong><br />
                    <strong>Phương thức 1:</strong> Tuyển thẳng theo quy định của Bộ Giáo dục & Đào tạo;<br />
                    <strong>Phương thức 2:</strong> Xét tuyển dựa vào kết quả kỳ thi tốt nghiệp THPT 2022;<br />
                    <strong>Phương thức 3:</strong> Xét tuyển dựa vào kết quả học tập THPT hoặc tương đương.
                </span>
            </p>

            <p><strong><span style=""font-size:15.0pt"">Phương thức 4:</span></strong><span style=""font-size:15.0pt""> Xét tuyển dựa vào kết quả kỳ thi đánh giá năng lực, đánh giá tư duy năm 2022.</span></p>

            <p> </p>
        </div>

        <h1 class=""lead text-center"" style=""font-size: 40px;"">Danh mục các ngành/nhóm ngành xét tuyển theo học bạ THPT</h1>


        <table class=""table table-h");
            WriteLiteral(@"over table-bordered table-striped"">
            <tr>
                <th style=""vertical-align : middle;text-align:center"" rowspan=""1"">TT</th>
                <th style=""vertical-align : middle;text-align:center"" rowspan=""1"">Mã ngành</th>
                <th style=""vertical-align : middle;text-align:center; width:250px"" rowspan=""1"">Ngành học</th>
                <th style=""vertical-align : middle;text-align:center;"" colspan=""1"">Tổ hợp môn 1</th>
                <th style=""vertical-align : middle;text-align:center;"" colspan=""1"">Tổ hợp môn 2</th>
                <th style=""vertical-align : middle;text-align:center;"" colspan=""1"">Tổ hợp môn 3</th>
                <th style=""vertical-align : middle;text-align:center;"" colspan=""1"">Tổ hợp môn 4</th>
            </tr>

            <tbody>
");
#nullable restore
#line 63 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Home\Index.cshtml"
                 if (majors.Count() > 0)
                {
                    var i = 1;
                    foreach (var item in majors)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <th style=\"vertical-align : middle;text-align:center\">");
#nullable restore
#line 69 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Home\Index.cshtml"
                                                                              Write(i++);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th style=\"vertical-align : middle;text-align:center\">");
#nullable restore
#line 70 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Home\Index.cshtml"
                                                                             Write(item.Code);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th style=\"vertical-align : middle;text-align:left\">");
#nullable restore
#line 71 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Home\Index.cshtml"
                                                                           Write(item.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th style=\"vertical-align : middle;text-align:center;\" colspan=\"1\">");
#nullable restore
#line 72 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Home\Index.cshtml"
                                                                                          Write(item.Combination1Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th style=\"vertical-align : middle;text-align:center;\" colspan=\"1\">");
#nullable restore
#line 73 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Home\Index.cshtml"
                                                                                          Write(item.Combination2Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th style=\"vertical-align : middle;text-align:center;\" colspan=\"1\">");
#nullable restore
#line 74 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Home\Index.cshtml"
                                                                                          Write(item.Combination3Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                            <th style=\"vertical-align : middle;text-align:center;\" colspan=\"1\">");
#nullable restore
#line 75 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Home\Index.cshtml"
                                                                                          Write(item.Combination4Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</th>\r\n                        </tr>\r\n");
#nullable restore
#line 77 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Home\Index.cshtml"
                    }
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n\r\n    </div>\r\n</div>\r\n");
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
