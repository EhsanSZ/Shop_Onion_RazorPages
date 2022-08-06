#pragma checksum "D:\MyProje\ASP.Net\Shop_Razor\LampShade\ServiceHost\Areas\Administration\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a1b38791f4c43f1d66e1e6e31f5166dbc7290977"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ServiceHost.Areas.Administration.Pages.Areas_Administration_Pages_Index), @"mvc.1.0.razor-page", @"/Areas/Administration/Pages/Index.cshtml")]
namespace ServiceHost.Areas.Administration.Pages
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
#line 2 "D:\MyProje\ASP.Net\Shop_Razor\LampShade\ServiceHost\Areas\Administration\Pages\Index.cshtml"
using Newtonsoft.Json;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a1b38791f4c43f1d66e1e6e31f5166dbc7290977", @"/Areas/Administration/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fb0e07ca471ffd6fceb9fb5a1272d30c7f92445d", @"/Areas/Administration/Pages/_ViewImports.cshtml")]
    public class Areas_Administration_Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 4 "D:\MyProje\ASP.Net\Shop_Razor\LampShade\ServiceHost\Areas\Administration\Pages\Index.cshtml"
  
    ViewData["Title"] = "صفحه اصلی";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""row"">
    <div class=""col-sm-12"">
        <h4 class=""page-title"">داشبورد گزارشات</h4>
    </div>
</div>

<div class=""row"">
    <div class=""col-md-6 col-sm-6 col-lg-3"">
        <div class=""mini-stat clearfix bx-shadow"">
            <span class=""mini-stat-icon bg-info"">
                <i class=""ion-social-usd""></i>
            </span>
            <div class=""mini-stat-info text-right text-muted"">
                <span class=""counter"">15852</span>
                Total Sales
            </div>
            <div class=""tiles-progress"">
                <div class=""m-t-20"">
                    <h5 class=""text-uppercase"">Sales <span class=""pull-right"">60%</span></h5>
                    <div class=""progress progress-sm m-0"">
                        <div class=""progress-bar progress-bar-info"" role=""progressbar"" aria-valuenow=""60"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 60%;"">
                            <span class=""sr-only"">60% Complete</span>
                        <");
            WriteLiteral(@"/div>
                    </div>
                </div>
            </div>
        </div>
    </div>

    <div class=""col-md-6 col-sm-6 col-lg-3"">
        <div class=""mini-stat clearfix bx-shadow"">
            <span class=""mini-stat-icon bg-purple"">
                <i class=""ion-ios7-cart""></i>
            </span>
            <div class=""mini-stat-info text-right text-muted"">
                <span class=""counter"">956</span>
                New Orders
            </div>
            <div class=""tiles-progress"">
                <div class=""m-t-20"">
                    <h5 class=""text-uppercase"">Orders <span class=""pull-right"">90%</span></h5>
                    <div class=""progress progress-sm m-0"">
                        <div class=""progress-bar progress-bar-purple"" role=""progressbar"" aria-valuenow=""90"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 90%;"">
                            <span class=""sr-only"">90% Complete</span>
                        </div>
                    </div>");
            WriteLiteral(@"
                </div>
            </div>
        </div>
    </div>

    <div class=""col-md-6 col-sm-6 col-lg-3"">
        <div class=""mini-stat clearfix bx-shadow"">
            <span class=""mini-stat-icon bg-success"">
                <i class=""ion-eye""></i>
            </span>
            <div class=""mini-stat-info text-right text-muted"">
                <span class=""counter"">20544</span>
                Unique Visitors
            </div>
            <div class=""tiles-progress"">
                <div class=""m-t-20"">
                    <h5 class=""text-uppercase"">Visitors <span class=""pull-right"">60%</span></h5>
                    <div class=""progress progress-sm m-0"">
                        <div class=""progress-bar progress-bar-success"" role=""progressbar"" aria-valuenow=""60"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 60%;"">
                            <span class=""sr-only"">60% Complete</span>
                        </div>
                    </div>
                </div>
    ");
            WriteLiteral(@"        </div>
        </div>
    </div>

    <div class=""col-md-6 col-sm-6 col-lg-3"">
        <div class=""mini-stat clearfix bx-shadow"">
            <span class=""mini-stat-icon bg-primary"">
                <i class=""ion-android-contacts""></i>
            </span>
            <div class=""mini-stat-info text-right text-muted"">
                <span class=""counter"">5210</span>
                New Users
            </div>
            <div class=""tiles-progress"">
                <div class=""m-t-20"">
                    <h5 class=""text-uppercase"">Users <span class=""pull-right"">57%</span></h5>
                    <div class=""progress progress-sm m-0"">
                        <div class=""progress-bar progress-bar-primary"" role=""progressbar"" aria-valuenow=""57"" aria-valuemin=""0"" aria-valuemax=""100"" style=""width: 57%;"">
                            <span class=""sr-only"">57% Complete</span>
                        </div>
                    </div>
                </div>
            </div>
        </");
            WriteLiteral(@"div>
    </div>
</div>

<div class=""row"">

    <div class=""col-sm-6"">
        <div class=""portlet"">

            <div class=""portlet-heading"">
                <h3 class=""portlet-title text-dark text-uppercase"">
                    Website Stats
                </h3>
                <canvas id=""line""></canvas>
            </div>

        </div>
    </div>

    <div class=""col-sm-6"">
        <div class=""portlet"">

            <div class=""portlet-heading"">
                <h3 class=""portlet-title text-dark text-uppercase"">
                    Website Stats
                </h3>
                <canvas id=""bar""></canvas>
            </div>

        </div>
    </div>
    
    <div class=""col-sm-6"">
        <div class=""portlet"">

            <div class=""portlet-heading"">
                <h3 class=""portlet-title text-dark text-uppercase"">
                    Website Stats
                </h3>
                <canvas width=""300"" id=""doughnut""></canvas>
            </div>

  ");
            WriteLiteral("      </div>\r\n    </div>\r\n\r\n</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n    <script>\r\n        const lineChartDiv = document.getElementById(\"line\");\r\n        const data = ");
#nullable restore
#line 150 "D:\MyProje\ASP.Net\Shop_Razor\LampShade\ServiceHost\Areas\Administration\Pages\Index.cshtml"
                Write(Html.Raw(JsonConvert.SerializeObject(Model.BarLineDataSet)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
        const lineChart = new Chart(lineChartDiv,
            {
                type: ""line"",
                data: {
                    labels: [""مهر"", ""آبان"", ""آذر"", "" دی"", ""بهمن""],
                    datasets: data
                },
                options: {
                    elements: {
                        bar: {
                            borderWidth: 1
                        }
                    }
                }
            });


        const barChartDiv = document.getElementById(""bar"");
        const barChart = new Chart(barChartDiv,
            {
                type: ""bar"",
                data: {
                    labels: [""مهر"", ""آبان"", ""آذر"", "" دی"", ""بهمن""],
                    datasets: data
                },
                options: {
                    elements: {
                        bar: {
                            borderWidth: 1
                        }
                    }
                }
            });


        const dou");
                WriteLiteral("ghnutChartDiv = document.getElementById(\"doughnut\");\r\n        const doughnutData = ");
#nullable restore
#line 187 "D:\MyProje\ASP.Net\Shop_Razor\LampShade\ServiceHost\Areas\Administration\Pages\Index.cshtml"
                        Write(Html.Raw(JsonConvert.SerializeObject(Model.DoughnutDataSet)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@";
        const doughnutChart = new Chart(doughnutChartDiv,
            {
                type: ""doughnut"",
                data: {
                    labels: [""Iphone 12"", ""Iphone 11"", ""Mac Book Pro"", ""IPad"", ""Apple Watch""],
                    datasets: [doughnutData]
                },
                options: {
                    elements: {
                        bar: {
                            borderWidth: 1
                        }
                    }
                }
            });
    </script>
");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Areas.Administration.Pages.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas.Administration.Pages.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Areas.Administration.Pages.IndexModel>)PageContext?.ViewData;
        public Areas.Administration.Pages.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
