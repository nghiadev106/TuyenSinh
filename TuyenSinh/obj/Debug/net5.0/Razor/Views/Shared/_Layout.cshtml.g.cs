#pragma checksum "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Shared\_Layout.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "93f8915efd50a223df108efd72cca798605d5b29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared__Layout), @"mvc.1.0.view", @"/Views/Shared/_Layout.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"93f8915efd50a223df108efd72cca798605d5b29", @"/Views/Shared/_Layout.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"bfa8aae2442e2c3c567698bd322f2c8b9a318836", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared__Layout : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("no-trans"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93f8915efd50a223df108efd72cca798605d5b293603", async() => {
                WriteLiteral(@"
    <meta charset=""utf-8"" />
    <title>Tuyển sinh - Trường ĐHSPKT Hưng Y&#234;n</title>
    <link href=""/Images/logo.png"" rel=""shortcut icon"" type=""image/x-icon"" />
    <meta name=""viewport"" content=""width=device-width"" />
    <meta name=""author"" content=""htmlcoder.me"">

    <!-- Mobile Meta -->
    <meta name=""viewport"" content=""width=device-width, initial-scale=1.0"">

    <!-- Favicon -->
    <link rel=""shortcut icon"" href=""/Images/logo.png"">

    <!-- Web Fonts -->
    <link href='https://fonts.googleapis.com/css?family=Open+Sans:400italic,700italic,400,700,300&amp;subset=latin,latin-ext' rel='stylesheet' type='text/css'>
    <link href='https://fonts.googleapis.com/css?family=Raleway:700,400,300' rel='stylesheet' type='text/css'>
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"">
    <link href=""https://fonts.googleapis.com/css2?family=Roboto+Slab:wght@600&family=Roboto:wght@700&display=swap"" rel=""stylesheet"">
    <link rel=""preconnect"" href=""https://fonts.gstatic.com"">
    ");
                WriteLiteral("<link href=\"https://fonts.googleapis.com/css2?family=Open+Sans:wght@300;400&display=swap\" rel=\"stylesheet\">\r\n\r\n");
                WriteLiteral(@"
    <!-- Font Awesome CSS -->
    <link href=""/assets/css/font-awesome.css"" rel=""stylesheet"">
    <link href=""/assets/css/font.css"" rel=""stylesheet"" />
    <!-- Plugins -->
    <link href=""/assets/css/animations.css"" rel=""stylesheet"">

    <!-- Worthy core CSS file -->
    <link href=""/assets/css/style.css"" rel=""stylesheet"">

    <!-- Custom css -->
    <link href=""/assets/css/custom.css"" rel=""stylesheet"">

    <link href=""/assets/css/bootstrap-datetimepicker.css"" rel=""stylesheet"" />
    <link href=""/assets/css/select2.min.css"" rel=""stylesheet"" />
    <!-- Jquery and Bootstap core js files -->
    <script type=""text/javascript"" src=""/assets/js/jquery.min.js""></script>
    <script type=""text/javascript"" src=""/assets/js/bootstrap.min.js""></script>

    <!-- Modernizr javascript -->
    <script type=""text/javascript"" src=""/assets/js/modernizr.js""></script>

    <!-- Isotope javascript -->
    <script type=""text/javascript"" src=""/assets/js/isotope.pkgd.min.js""></script>

    <!-- Backstr");
                WriteLiteral(@"etch javascript -->
    <script type=""text/javascript"" src=""/assets/js/jquery.backstretch.min.js""></script>

    <!-- Appear javascript -->
    <script type=""text/javascript"" src=""/assets/js/jquery.appear.js""></script>
    <script src=""/assets/js/jquery.validate.min.js""></script>


    <!-- Initialization of Plugins -->
    <script type=""text/javascript"" src=""/assets/js/template.js""></script>

    <!-- Custom Scripts -->
    <script type=""text/javascript"" src=""/assets/js/custom.js""></script>

    <style type=""text/css"">
        .main-navigation .navbar-default .navbar-nav > li.active > a {
            background-color: transparent;
            color: #f1d500;
        }

            .main-navigation .navbar-default .navbar-nav > li > a:hover, .main-navigation .navbar-default .navbar-nav > li.active > a:hover {
                color: #f1d500;
            }

        .row {
            margin-right: -15px;
            margin-left: -15px;
        }

        .carousel-indicators li {
 ");
                WriteLiteral(@"           border: 1px solid #2196F3;
        }

        .noborder {
            border: 0 !important;
            border-bottom: 1px solid gainsboro !important;
            border-radius: 0px !important;
            box-shadow: none !important;
        }

        .noboder:focus {
            box-shadow: none !important;
        }

        .noborder_dot {
            border: 0 !important;
            border-bottom: 1px dotted gainsboro !important;
            border-radius: 0px !important;
            box-shadow: none !important;
        }

            .noborder_dot:focus {
                box-shadow: none !important;
            }

        .uppercase {
            text-transform: uppercase;
        }

        .borderClass {
            border: 1px solid #ddd;
        }
        /*Tin tức*/
        .bg-silver-light {
            background-color: #F3F3F5 !important;
        }

        .double-line-bottom-theme-colored-2 {
            margin-bottom: 20px;
            margi");
                WriteLiteral(@"n-top: 8px;
            padding-bottom: 5px;
            position: relative;
        }

            .double-line-bottom-theme-colored-2:before {
                border-radius: 8px;
                bottom: -1px;
                content: """";
                height: 6px;
                left: 10px;
                position: absolute;
                width: 24px;
            }

            .double-line-bottom-theme-colored-2:after {
                border-radius: 8px;
                bottom: 1px;
                content: """";
                height: 2px;
                left: 0;
                position: absolute;
                width: 64px;
            }

            .team-block .team-thumb .styled-icons a:hover,
            .work-gallery .gallery-thumb .styled-icons a:hover,
            .work-gallery:hover .gallery-bottom-part,
            .double-line-bottom-theme-colored-2:after,
            .double-line-bottom-theme-colored-2:before,
            .double-line-bottom-centered-them");
                WriteLiteral(@"e-colored-2:after,
            .double-line-bottom-centered-theme-colored-2:before,
            .line-bottom-theme-colored-2:after,
            .line-bottom-centered::after,
            .event-block .event-date,
            .team-social,
            .event-small .event-date,
            .portfolio-filter a.active,
            .title-border::after,
            .search-menu {
                background: #43B14B;
            }

        .testimonial-content::after .event-list .thumb {
            position: relative;
            overflow: hidden;
        }

        .event-list .thumb img {
            transition: all 500ms ease 0s;
        }

        .mb-10 {
            margin-bottom: 10px !important;
        }

        .img-fullwidth {
            width: 100% !important;
        }

        img {
            max-width: 100%;
        }

        img {
            vertical-align: middle;
        }

        .bg-white {
            background-color: #fff !important;
        }

                WriteLiteral(@"
        .border-1px {
            border: 1px solid #eeeeee !important;
        }

        .font-weight-600 {
            font-weight: 600 !important;
        }

        .text-uppercase {
            text-transform: uppercase;
        }

        .pb-10 {
            padding-bottom: 10px !important;
        }

        .pt-10 {
            padding-top: 10px !important;
        }

        .p-20 {
            padding: 0px 20px !important;
        }

        .text-uppercase {
            text-transform: uppercase;
        }
        /*Chi tiet tin tuc*/
        .blog-posts .post {
            position: relative;
        }

        .single-post article {
            border-bottom: 1px solid #d3d3d3;
            margin-bottom: 20px;
            padding-bottom: 30px;
        }

        .mb-0 {
            margin-bottom: 0 !important;
        }

        .blog-posts.single-post .post .entry-content {
            border: medium none;
        }

        .blog-posts .post .ent");
                WriteLiteral(@"ry-content {
            border: 1px solid transparent;
            position: relative;
        }

        .post .entry-content {
            border: 1px solid #f7f8f7;
            transition: all 300ms ease-in-out 0s;
        }

        .single-post .entry-content {
            border: none;
        }

        .media:first-child {
            margin-top: 0;
        }

        .media-body {
            width: 10000px;
        }

        .pull-left {
            float: left !important;
        }

        .single-post article .entry-title {
            font-family: ""Open Sans"", sans-serif;
            padding: 15px 0 0;
            text-transform: capitalize;
        }

        .text-gray-darkgray {
            color: #a9a9a9 !important;
        }

        .blog-posts .post .entry-meta span i {
            margin-right: 5px;
            color: #43B14B;
        }

        .pb-20 {
            padding-bottom: 20px !important;
        }

        .font-13 {
            ");
                WriteLiteral(@"font-size: 13px !important;
        }

        .mb-10 {
            margin-bottom: 10px !important;
        }

        .mr-10 {
            margin-right: 10px !important;
        }

        .media .fa {
            font-size: 24px;
            line-height: 25px;
            padding: 0 5px;
            text-align: center;
        }

        /*Thong bao*/
        .mb-30 {
            margin-bottom: 30px !important;
        }

        .line-bottom {
            position: relative;
            margin-bottom: 30px;
            padding-bottom: 10px;
        }

            .line-bottom:after, .widget .line-bottom:after, .widget .line-bottom:after, .pager.theme-colored a, .owl-carousel.owl-nav-top .owl-controls .owl-nav .owl-prev, .owl-carousel.owl-nav-top .owl-controls .owl-nav .owl-next {
                border: 1px solid #1E3148;
            }

            .line-bottom:after {
                bottom: -1px;
                content: """";
                height: 2px;
              ");
                WriteLiteral(@"  left: 0;
                position: absolute;
                width: 50px;
            }

        article, aside, details, figcaption, figure, footer, header, hgroup, main, menu, nav, section, summary {
            display: block;
        }

        .pb-15 {
            padding-bottom: 15px !important;
        }

        .media, .media-body {
            overflow: hidden;
            zoom: 1;
        }

        .text-white {
            color: #fff !important;
        }

        .border-bottom {
            border-bottom: 1px solid #eeeeee !important;
        }

        .media-heading {
            margin-top: 0;
            margin-bottom: 5px;
        }

        .event-small .event-date {
            float: left;
            margin-right: 20px;
            padding: 3px 16px 10px 20px;
            text-align: center;
        }

        .font-16 {
            font-size: 16px !important;
        }

        .pt-5 {
            padding-top: 5px !important;
        }

                WriteLiteral(@"
        .mb-5 {
            margin-bottom: 5px !important;
        }

        .font-18 {
            font-size: 18px !important;
        }

        .font-weight-700 {
            font-weight: 700 !important;
        }

        .mt-5 {
            margin-top: 5px !important;
        }

        .font-14 {
            font-size: 14px !important;
        }
    </style>

    <!-- Devextreme-->
    <link href=""/Images/logo.png"" rel=""shortcut icon"" type=""image/x-icon"" />

    <link href=""/assets/css/bundle.css"" rel=""stylesheet"" />

    <link href=""/assets/css/DevExtremeBundle.css"" rel=""stylesheet"" />

    <script src=""/assets/js/bundle.js""></script>

    <script src=""/assets/js/DevExtremeBundle.js""></script>

    <!-- Bootstrap core CSS -->

    <script type=""text/javascript"" src=""/assets/js/bootstrap.min.js""></script>
    <script src=""/assets/js/ckeditor.js""></script>
    <script src=""/assets/js/moment.js""></script>
    <script src=""/assets/js/bootstrap-datetimepicker.js""></scr");
                WriteLiteral("ipt>\r\n    <script src=\"/assets/js/bootstrap-datetimepicker.min.js\"></script>\r\n    <script src=\"/assets/js/jquery.twbsPagination.js\"></script>\r\n    <script src=\"/assets/js/select2-4.1.0-rc.0/dist/js/select2.min.js\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "93f8915efd50a223df108efd72cca798605d5b2916754", async() => {
                WriteLiteral(@"


    <div id=""dxPopupChangePassword""></div>
    <script>jQuery(function($){$(""#dxPopupChangePassword"").dxPopup({""elementAttr"":{""class"":""popup""},""showTitle"":true,""visible"":false,""dragEnabled"":false,""closeOnOutsideClick"":true});});</script>
    <!-- scrollToTop -->
    <!-- ================ -->
    <div class=""scrollToTop""><i class=""icon-up-open-big""></i></div>

    <!-- header start -->
    <!-- ================ -->
    <div class=""header-middle p-0 bg-lightest xs-text-center pb-30"">
        <div class=""container pt-10 pb-10"">
            <div class=""row"">
                <div class=""col-xs-12 col-sm-12 col-md-12"">
                    <div class=""row"" style=""background-image: url('/assets/assets/images/logo-wide1.png'); background-size: contain;background-repeat: no-repeat"">
                        <div class=""col-xs-12 col-sm-12 col-md-5 pt-20"">
                            <a");
                BeginWriteAttribute("class", " class=\"", 12692, "\"", 12700, 0);
                EndWriteAttribute();
                WriteLiteral(" href=\"#/\">\r\n                                <img");
                BeginWriteAttribute("alt", " alt=\"", 12750, "\"", 12756, 0);
                EndWriteAttribute();
                WriteLiteral(@" src=""/assets/images/logo-wide.png"">
                            </a>
                        </div>
                        <div class=""col-xs-12 col-sm-12 col-md-3"">
                        </div>
                        <div class=""col-xs-12 col-sm-12 col-md-4"" style=""text-align: right;"">
                            <a class=""flip sm-pull-none"" href=""#/""><img");
                BeginWriteAttribute("alt", " alt=\"", 13127, "\"", 13133, 0);
                EndWriteAttribute();
                WriteLiteral(@" src=""/assets/images/upm.png""></a>
                        </div>
                    </div>
                </div>
            </div>
        </div>
    </div>
    <header class=""header fixed clearfix navbar"" style=""background-color:#43B14B !important"">
        <div class=""container"">
            <div class=""row"">
                <div class=""col-md-12"">

                    <!-- header-right start -->
                    <!-- ================ -->
                    <div class=""header-right clearfix"">

                        <!-- main-navigation start -->
                        <!-- ================ -->
                        <div class=""main-navigation animated"">

                            <!-- navbar start -->
                            <!-- ================ -->
                            <nav class=""navbar navbar-default"" role=""navigation"">
                                <div class=""container-fluid"">

                                    <!-- Toggle get grouped for better m");
                WriteLiteral(@"obile display -->
                                    <div class=""navbar-header"" style=""float:left"">
                                        <button type=""button"" class=""navbar-toggle"" data-toggle=""collapse"" data-target=""#navbar-collapse-1"">
                                            <span class=""sr-only"">Toggle navigation</span>
                                            <span class=""icon-bar""></span>
                                            <span class=""icon-bar""></span>
                                            <span class=""icon-bar""></span>
                                        </button>
                                    </div>

                                    <!-- Collect the nav links, forms, and other content for toggling -->
                                    <div class=""collapse navbar-collapse scrollspy smooth-scroll"" id=""navbar-collapse-1"">
                                        <ul class=""nav navbar-nav navbar-right"">
                                            <li cl");
                WriteLiteral(@"ass=""dropdown"">
                                                <a href=""javasript:void(0)"" class=""dropdown-toggle"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""true"" id=""txtFullName"">Đăng ký nguyện vọng<span class=""caret""></span></a>
                                                <ul class=""dropdown-menu"">
                                                    <li><a href=""/DangKy/DangKyHocBa"">Đăng k&#253; theo x&#233;t học bạ</a></li>
                                                    <li><a href=""/DangKy/DangKyTHPT"">Đăng k&#253; theo kết quả thi THPT</a></li>           
                                                    <li><a href=""../TraCuuTrungTuyen/Index"">Tra cứu trúng tuyển</a></li>
                                                </ul>
                                            </li>
                                            <li><a href=""/Blogs/Index"" id=""hportfolio"">Tin tức</a></li>
                                            <li class=""dropdown"">
            ");
                WriteLiteral(@"                                    <a href=""javasript:void(0)"" class=""dropdown-toggle"" style=""background-color:darkgreen"" data-toggle=""dropdown"" role=""button"" aria-haspopup=""true"" aria-expanded=""true"" id=""txtFullName"">Nhập học<span class=""caret""></span></a>
                                                <ul class=""dropdown-menu"">
                                                    <li><a href=""../NhapHoc/WelCome"">Thủ tục nhập học</a></li>
                                                    <li><a href=""../TraCuuKetQuaNhapHoc/Index"">Tra cứu kết quả nhập học</a></li>
                                                    <li><a href=""https://www.youtube.com/watch?v=zKE7IM7_3yQ"" target=""_blank""");
                BeginWriteAttribute("id", " id=\"", 16909, "\"", 16914, 0);
                EndWriteAttribute();
                WriteLiteral(@">Hướng dẫn nhập học</a></li>
                                                </ul>
                                            </li>
                                            <li><a href=""http://tuyensinhskh.utehy.edu.vn:85/""><i class=""fa fa-graduation-cap""></i> TUYỂN SINH SĐH</a></li>
                                        </ul>
                                    </div>

                                </div>
                            </nav>

                            <!-- navbar end -->

                        </div>
                        <!-- main-navigation end -->

                    </div>
                    <!-- header-right end -->


                </div>
            </div>
        </div>
    </header>
    <!-- header end -->
    <div class=""bodycontent"" style=""background-color: whitesmoke;"">
        <!-- banner start -->
        <!-- ================ -->
        <!-- banner end -->
        <!-- section start -->
        <!-- ================ -->
        ");
#nullable restore
#line 514 "D:\nghia\DoAnTotNghiep2022\Mai\TuyenSinh\TuyenSinh\Views\Shared\_Layout.cshtml"
   Write(RenderBody());

#line default
#line hidden
#nullable disable
                WriteLiteral(@"  
        <!-- section end -->

        <div class=""section"">
            <div class=""container"">

            </div>
        </div>
        <!-- section end -->
        <!-- section start -->
        <!-- ================ -->
        <!-- section end -->

        <script>DevExpress.config({ ""serverDecimalSeparator"": ""."" });</script>
        <script>DevExpress.aspnet.setTemplateEngine();</script><div id=""dxPopup""></div>
        <script type=""text/html"" id=""dxPopup-contentTemplate"">
            <a href=""../TinTuc/ChiTiet?ID_tin_tuc=0"">
                <img style=""background-size:cover; width:100%; height:100%"" />
            </a>
        </script>
        <script>jQuery(function ($) { $(""#dxPopup"").dxPopup({ ""elementAttr"": { ""class"": ""popup"" }, ""showTitle"": true, ""visible"": false, ""dragEnabled"": false, ""closeOnOutsideClick"": true, ""contentTemplate"": $(""#dxPopup-contentTemplate"") }); });</script>

        <script type=""text/javascript"">
            $(document).ready(function () {
      ");
                WriteLiteral(@"          if (parseInt('0') > 0) {
                    setTimeout(function () {
                        var popup = $('#dxPopup').dxPopup('instance')
                        console.log(popup)
                        popup.show()
                    }, 4000);
                }
            })

            $('.he').click(function () {
                var _id_bai_viet = $(this).prop('id');
                $.ajax({
                    type: 'POST',
                    dataType: 'HTML',
                    url: '../../BaiViet/GetHtml',
                    data: { ID_bai_viet: _id_bai_viet },
                    success: function (val) {
                        $('#mdHecontent').html(val)
                    },
                    error: function (val) {
                        $('#mdHecontent').html('Có lỗi: ' + val.status.toString())
                    }
                })
            })
        </script>


        <!-- Messenger Plugin chat Code -->
        <div id=""fb-root""></div>
");
                WriteLiteral(@"
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
                js.src = 'https://connect.facebook.net/vi_VN/sdk/xfbml.customerchat.js';
                fjs.parentNode.insertBefore(js, fjs);
            }(document, 'script', 'facebook-jssdk'));
        </script>

        <div id=""dxPopupLoading""></div>
        <script type=""text/html""");
                WriteLiteral(@" id=""dxPopupLoading-contentTemplate"">
            <h2 style=""text-align:center"">Hệ thống đang xử lý.<br />Vui lòng đợi trong giây lát</h2>
            <div id=""loader"" class=""loader""></div>
        </script>
        <script>jQuery(function ($) { $(""#dxPopupLoading"").dxPopup({ ""elementAttr"": { ""class"": ""popup"" }, ""width"": 600.0, ""height"": 225.0, ""showTitle"": false, ""visible"": false, ""dragEnabled"": false, ""closeOnOutsideClick"": false, ""contentTemplate"": $(""#dxPopupLoading-contentTemplate"") }); });</script>
    </div>
    <!-- footer start -->
    <!-- ================ -->
    <footer id=""footer"">

        <!-- .footer start -->
        <!-- ================ -->

        <div class=""footer section translucent-bg bg-image-2 pb-clear"">
            <div class=""container object-non-visible"" data-animation-effect=""fadeIn"">

                <div class=""row"">
                    <div class=""col-md-12"">
                        <div class=""footer-content"" style=""text-align:center"">
                    ");
                WriteLiteral(@"        <div>
                                <p style=""text-align:center""><span style=""font-size:28px"">Liên hệ</span></p>

                                <p style=""text-align:center""><span style=""font-size:28px"">Chúng tôi luôn sẵn sàng tư vấn và hỗ trợ !</span></p>

                                <p style=""text-align:center""><span style=""font-size:28px"">Trung tâm Tuyển sinh và Truyền thông</span></p>

                                <p style=""text-align:center""><span style=""font-size:16px"">• Giám đốc: Đặng Vân Anh</span></p>

                                <p style=""text-align:center""><span style=""font-size:16px"">• Trường ĐHSPKT Hưng Yên - HUNG YEN UNIVERSITY OF TECHNOLOGY AND EDUCATION</span></p>

                                <p style=""text-align:center""><span style=""font-size:16px"">• QL39A, Dân Tiến, Khoái Châu, Hưng Yên - 0221.3689.888</span></p>

                                <p style=""text-align:center""><span style=""font-size:16px"">• Thị xã Mỹ Hào, Hưng Yên - 0221.3689.555</span></p");
                WriteLiteral(@">

                                <p style=""text-align:center""><span style=""font-size:16px"">• Số 189 Nguyễn Lương Bằng, Thành phố Hải Dương, Hải Dương - 0221.3689.333</span></p>

                                <p style=""text-align:center""><span style=""font-size:16px"">• Email: tuyensinhskh@gmail.com</span></p>
                            </div>
                        </div>
                        <div style=""text-align:center"">
                            <div style=""font-size:18px"">
                                Thông tin chi tiết xin vui lòng truy cập:
                            </div>
                            <ul class=""social-links"" style=""margin:0px"">
                                <li style=""margin-top:0px""><a href=""http://www.utehy.edu.vn/"" target=""_blank""><img src=""/Content/icons/globe.svg"" style=""width:30px;height:30px;margin-left:auto; margin-right:auto"" /></a></li>
                                <li style=""margin-top:0px""><a href=""https://www.facebook.com/DaiHocSuPhamKyThuat");
                WriteLiteral(@"HungYen/?ti=as"" target=""_blank""><img src=""/Content/icons/facebook.svg"" style=""width:30px;height:30px;margin-left:auto; margin-right:auto"" /></a></li>
                                <li style=""margin-top:0px""><a href=""https://www.youtube.com/channel/UCVy9p7eBCMmHVEITk4yPZjg"" target=""_blank""><img src=""/Content/icons/youtube.svg"" style=""width:30px;height:30px;margin-left:auto; margin-right:auto"" /></a></li>
                            </ul>
                        </div>
                    </div>
                    <div style=""text-align:center"">
                        <iframe src=""https://www.google.com/maps/embed?pb=!1m18!1m12!1m3!1d3728.67976745721!2d106.00657571492954!3d20.844633986098366!2m3!1f0!2f0!3f0!3m2!1i1024!2i768!4f13.1!3m3!1m2!1s0x3135ba51eaaaaaab%3A0x5a470f4187994f17!2sHung%20Yen%20University%20of%20Technology%20and%20Education!5e0!3m2!1sen!2s!4v1608976218510!5m2!1sen!2s"" width=""100%"" height=""450"" frameborder=""0"" style=""border:0;""");
                BeginWriteAttribute("allowfullscreen", " allowfullscreen=\"", 25058, "\"", 25076, 0);
                EndWriteAttribute();
                WriteLiteral(@" aria-hidden=""false"" tabindex=""0""></iframe>
                    </div>
                </div>
            </div>
        </div>
        <!-- .footer end -->
        <!-- .subfooter start -->
        <!-- ================ -->
        <div class=""subfooter"">
            <div class=""container"">
                <div class=""row"">
                    <div class=""col-md-12"">
                        <p class=""text-center"">Bản quyền 2020 thuộc Trường ĐHSPKT Hưng Y&#234;n.</p>
                        <p class=""text-center"">Phát triển bởi <a href=""http://namvietjsc.edu.vn/"">Công ty cổ phần Giải pháp Giáo dục - Y tế Nam Việt</a>.</p>
                    </div>
                </div>
            </div>
        </div>
        <!-- .subfooter end -->

    </footer>
    <!-- footer end -->
    <!-- JavaScript files placed at the end of the document so the pages load faster
    ================================================== -->


");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
</html>

<script>

    function btnChangePasswordView_Click(ID_cb) {
        var popup = $(""#dxPopupChangePassword"").dxPopup(""instance"");
        popup.option('height', 250)
        popup.option('width', 500)
        popup.option('title', 'Thay đổi mật khẩu')
        $.ajax({
            type: 'POST',
            dataType: 'HTML',
            url: '../QuanLyNguoiDung/_ChangePasswordView',
            data: {
                ID_cb: ID_cb
            },
            success: function (val) {
                popup.option(""contentTemplate"", '');
                popup.option(""contentTemplate"", val);
                popup.show();
            },
            error: function () {
                popup.option(""contentTemplate"", 'Có lỗi');
            }
        })
    }
    function btnChangePassword_Click() {

        var dxForm = $('#frmChangePassword').dxForm('instance')
        var ID_cb = dxForm.getEditor('ID_cb').option('value')
        var Password = dxForm.getEditor('Password').opt");
            WriteLiteral(@"ion('value')
        var PasswordConfirm = dxForm.getEditor('PasswordConfirm').option('value')

        console.log(ID_cb)
        console.log(Password)
        console.log(PasswordConfirm)
        if (Password.length < 3) {
            var type = ""warning"", text = ""Mật khẩu phải tối thiểu 3 ký tự"";
            DevExpress.ui.notify(text, type, 1000);
            return
        }
        if (Password != PasswordConfirm) {
            var type = ""warning"", text = ""Mật khẩu không khớp"";
            DevExpress.ui.notify(text, type, 1000);
            return
        }
        $.ajax({
            type: 'POST',
            dataType: 'JSON',
            url: '../QuanLyNguoiDung/_ChangePasswod',
            data: {
                ID_cb: ID_cb,
                Password: Password,
            },
            success: function (val) {
                DevExpress.ui.notify(val.msg, val.type, 1000);
                var popup = $(""#dxPopupChangePassword"").dxPopup(""instance"");
                popup");
            WriteLiteral(".hide();\r\n            },\r\n            error: function () {\r\n                var type = \"warning\", text = \"Thất bại\";\r\n                DevExpress.ui.notify(text, type, 1000);\r\n            }\r\n        });\r\n    }\r\n\r\n</script>\r\n");
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