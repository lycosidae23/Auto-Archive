#pragma checksum "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "57da2e7c2fa5a3bc7bbf627d5a392c018869cf29"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Analytic_Index), @"mvc.1.0.view", @"/Views/Analytic/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Analytic/Index.cshtml", typeof(AspNetCore.Views_Analytic_Index))]
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
#line 1 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/_ViewImports.cshtml"
using AUTO_ARCHIVE;

#line default
#line hidden
#line 2 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/_ViewImports.cshtml"
using AUTO_ARCHIVE.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"57da2e7c2fa5a3bc7bbf627d5a392c018869cf29", @"/Views/Analytic/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8be20235d9c01195033de53bd77ca11ddd91709e", @"/Views/_ViewImports.cshtml")]
    public class Views_Analytic_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<AUTO_ARCHIVE.Models.AutoDetails>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "analytic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "postcomment", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        #line hidden
        #pragma warning disable 0169
        private string __tagHelperStringValueBuffer;
        #pragma warning restore 0169
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperExecutionContext __tagHelperExecutionContext;
        private global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner __tagHelperRunner = new global::Microsoft.AspNetCore.Razor.Runtime.TagHelpers.TagHelperRunner();
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
            BeginContext(40, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
  
    var XLabels = Newtonsoft.Json.JsonConvert.SerializeObject(Model.ListChart.Select(x => x.AuctDateX).ToList());
    var YValues = Newtonsoft.Json.JsonConvert.SerializeObject(Model.ListChart.Select(x => x.BidPriceY).ToList());
    ViewData["Title"] = "Analytics";

#line default
#line hidden
            BeginContext(317, 236, true);
            WriteLiteral("\r\n<button id=\"backAnalytik\" class=\"btn btn-light\" type=\"button\" onclick=\"window.history.back()\" style=\"float:left;\"><i class=\"fa fa-chevron-circle-left\"></i>&nbsp;Back</button>\r\n\r\n<h3 style=\"text-align:center;margin:0px 15px 0px 15px;\">");
            EndContext();
            BeginContext(554, 20, false);
#line 11 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
                                                   Write(ViewBag.YearAnalytic);

#line default
#line hidden
            EndContext();
            BeginContext(574, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(576, 21, false);
#line 11 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
                                                                         Write(ViewBag.ModelAnalytic);

#line default
#line hidden
            EndContext();
            BeginContext(597, 341, true);
            WriteLiteral(@" Analytics</h3>

<div class=""box-body"" style=""margin-top:20px;padding:0px 15px 0px 15px"">
    <div class=""chart-container"">
        <canvas id=""chart"" style=""width:100%; height:300px""></canvas>
    </div>
</div>

<div id=""webIndex"">

    <h4 style=""margin-top:10px;width:100%;text-align:center;"">Vehicle Detail History</h4>

    ");
            EndContext();
            BeginContext(939, 42, false);
#line 23 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
Write(await Html.PartialAsync("AnalyticResults"));

#line default
#line hidden
            EndContext();
            BeginContext(981, 600, true);
            WriteLiteral(@"

    <table id=""statsTable"" height=""180"" style=""background-color:rgba(255, 99, 132,0.3);border-radius:5px;margin-top:35px;box-shadow:0 4px 8px 0 rgba(0, 0, 0, 0.2), 0 6px 20px 0 rgba(0, 0, 0, 0.19);"" cellpadding=""2"">
        <tr>
            <td id=""statsTitle"" align=""center"" colspan=""2"" style=""border-bottom:1px solid red"">
                <h4 style=""text-align:center;width:100%"">Vehicle Statistics</h4>
            </td>
        </tr>
        <tr>
            <td style=""width:50%"">
                <h6 style=""float:left;width:50%;text-align:center;font-weight:normal"">Auctioned</h6>
");
            EndContext();
#line 34 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
                 if (Model.ListGarage.Any(a => a.BidAmountC == null))
                {
                    var times = Model.count - 1;

#line default
#line hidden
            BeginContext(1721, 72, true);
            WriteLiteral("                    <h6 style=\"float:right;width:50%;text-align:center\">");
            EndContext();
            BeginContext(1794, 5, false);
#line 37 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
                                                                   Write(times);

#line default
#line hidden
            EndContext();
            BeginContext(1799, 7, true);
            WriteLiteral("</h6>\r\n");
            EndContext();
#line 38 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(1866, 72, true);
            WriteLiteral("                    <h6 style=\"float:right;width:50%;text-align:center\">");
            EndContext();
            BeginContext(1939, 11, false);
#line 41 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
                                                                   Write(Model.count);

#line default
#line hidden
            EndContext();
            BeginContext(1950, 7, true);
            WriteLiteral("</h6>\r\n");
            EndContext();
#line 42 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
                }

#line default
#line hidden
            BeginContext(1976, 208, true);
            WriteLiteral("                <br /><br />\r\n\r\n                <h6 style=\"float:left;width:50%;text-align:center;font-weight:normal\">Min. Final Bid</h6>\r\n                <h6 style=\"float:right;width:50%;text-align:center;\">");
            EndContext();
            BeginContext(2185, 12, false);
#line 46 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
                                                                Write(Model.minBid);

#line default
#line hidden
            EndContext();
            BeginContext(2197, 217, true);
            WriteLiteral("</h6>\r\n\r\n                <br /><br />\r\n\r\n                <h6 style=\"float:left;width:50%;text-align:center;font-weight:normal\">Max. Final Bid</h6>\r\n                <h6 style=\"float:right;width:50%;text-align:center;\">");
            EndContext();
            BeginContext(2415, 12, false);
#line 51 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
                                                                Write(Model.maxBid);

#line default
#line hidden
            EndContext();
            BeginContext(2427, 256, true);
            WriteLiteral(@"</h6>
            </td>

            <td style=""border-left:1px solid red"">
                <h6 style=""float:left;width:50%;text-align:center;font-weight:normal"">Avg. Final Bid</h6>
                <h6 style=""float:right;width:50%;text-align:center;"">");
            EndContext();
            BeginContext(2684, 17, false);
#line 56 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
                                                                Write(Model.AvgBidPrice);

#line default
#line hidden
            EndContext();
            BeginContext(2701, 41, true);
            WriteLiteral("</h6>\r\n\r\n                <br /><br />\r\n\r\n");
            EndContext();
#line 60 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
                 if (Model.ListGarage.Any(a => a.BidAmountC == null))
                {

#line default
#line hidden
            BeginContext(2832, 184, true);
            WriteLiteral("                    <h6 style=\"float:left;width:50%;text-align:center;font-weight:normal\">Est. Final Bid</h6>\r\n                    <h6 style=\"float:right;width:50%;text-align:center;\">");
            EndContext();
            BeginContext(3017, 18, false);
#line 63 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
                                                                    Write(Model.AvgSalePrice);

#line default
#line hidden
            EndContext();
            BeginContext(3035, 7, true);
            WriteLiteral("</h6>\r\n");
            EndContext();
#line 64 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
                }
                else
                {

#line default
#line hidden
            BeginContext(3102, 194, true);
            WriteLiteral("                    <h6 style=\"float:left;width:50%;text-align:center;font-weight:normal;\">Avg. Related Final Bids</h6>\r\n                    <h6 style=\"float:right;width:50%;text-align:center;\">");
            EndContext();
            BeginContext(3297, 18, false);
#line 68 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
                                                                    Write(Model.AvgSalePrice);

#line default
#line hidden
            EndContext();
            BeginContext(3315, 7, true);
            WriteLiteral("</h6>\r\n");
            EndContext();
#line 69 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
                }

#line default
#line hidden
            BeginContext(3341, 222, true);
            WriteLiteral("\r\n                <br /><br />\r\n\r\n                <h6 style=\"float:left;width:50%;text-align:center;font-weight:normal\">Value Profit</h6>\r\n\r\n                <h6 style=\"float:right;width:50%;text-align:center;color:green;\">");
            EndContext();
            BeginContext(3564, 16, false);
#line 75 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
                                                                            Write(Model.KijijiData);

#line default
#line hidden
            EndContext();
            BeginContext(3580, 135, true);
            WriteLiteral("</h6>\r\n            </td>\r\n        </tr>\r\n    </table>\r\n\r\n    <h4 style=\"width:100%;margin-top:50px;text-align:center\">Comments</h4>\r\n\r\n");
            EndContext();
#line 82 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
     if (Model.ListComment == null)
    {

#line default
#line hidden
            BeginContext(3759, 111, true);
            WriteLiteral("        <h6  style=\"width:100%;margin-top:10px;text-align:center\">There are no comments for this vehicle</h6>\r\n");
            EndContext();
#line 85 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
    }
    else
    {

#line default
#line hidden
            BeginContext(3894, 50, true);
            WriteLiteral("        <hr />\r\n        <div style=\"width:100%\">\r\n");
            EndContext();
#line 90 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
             foreach (var item in Model.ListComment)
            {

#line default
#line hidden
            BeginContext(4013, 87, true);
            WriteLiteral("                <div style=\"width:100%\">\r\n                    <p style=\"float:left\"><b>");
            EndContext();
            BeginContext(4101, 16, false);
#line 93 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
                                        Write(item.UserComment);

#line default
#line hidden
            EndContext();
            BeginContext(4117, 20, true);
            WriteLiteral("</b> -</p> <label>- ");
            EndContext();
            BeginContext(4138, 16, false);
#line 93 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
                                                                             Write(item.DisplayName);

#line default
#line hidden
            EndContext();
            BeginContext(4154, 42, true);
            WriteLiteral(" <span style=\"color:gray;font-size:small\">");
            EndContext();
            BeginContext(4197, 14, false);
#line 93 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
                                                                                                                                        Write(item.timeStamp);

#line default
#line hidden
            EndContext();
            BeginContext(4211, 65, true);
            WriteLiteral("</span></label>\r\n                </div>\r\n                <hr />\r\n");
            EndContext();
#line 96 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
            }

#line default
#line hidden
            BeginContext(4291, 16, true);
            WriteLiteral("        </div>\r\n");
            EndContext();
#line 98 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
    }

#line default
#line hidden
            BeginContext(4314, 330, true);
            WriteLiteral(@"
    <table style=""width:100%"">
        <tr>
            <td align=""center"">
                <button id=""commentBtn"" class=""btn btn-dark"" type=""button"" style=""border-radius:25px;margin-top:10px"">Add Comment<i class=""fas fa-comments"" style=""margin-left:5px""></i></button>
            </td>
        </tr>
    </table>

    ");
            EndContext();
            BeginContext(4644, 584, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "57da2e7c2fa5a3bc7bbf627d5a392c018869cf2917774", async() => {
                BeginContext(4714, 114, true);
                WriteLiteral("\r\n        <div id=\"comment\" style=\"display:none;padding-left:5%;padding-right:5%;\">\r\n            <input name=\"vin\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4828, "\"", 4856, 1);
#line 110 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
WriteAttributeValue("", 4836, ViewBag.VinAnalytic, 4836, 20, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(4857, 118, true);
                WriteLiteral(" hidden />\r\n            <div style=\"width:100%;margin-top:20px\">\r\n                <textarea type=\"text\" name=\"comment\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 4975, "\"", 4999, 1);
#line 112 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
WriteAttributeValue("", 4983, ViewBag.Comment, 4983, 16, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(5000, 221, true);
                WriteLiteral(" class=\"form-control\" rows=\"4\" placeholder=\"Comment on this Vehicle....\"></textarea>\r\n            </div>\r\n            <button class=\"btn btn-success\" style=\"float:right;margin-top:10px\">Post</button>\r\n        </div>\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(5228, 422, true);
            WriteLiteral(@"

    <table height=""50"" style=""width:100%""></table>
</div>

<script src=""https://cdnjs.cloudflare.com/ajax/libs/Chart.js/2.7.2/Chart.bundle.min.js""></script>
<script src=""https://code.jquery.com/jquery-3.3.1.min.js""></script>

<script type=""text/javascript"">
    $(function () {
    var chartName = ""chart"";
    var ctx = document.getElementById(chartName).getContext('2d');
    var data = {
        labels: ");
            EndContext();
            BeginContext(5651, 17, false);
#line 129 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
           Write(Html.Raw(XLabels));

#line default
#line hidden
            EndContext();
            BeginContext(5668, 1036, true);
            WriteLiteral(@",
    datasets: [{
        label: ""Bidding History"",
        backgroundColor: [
            'rgba(255, 99, 132, 0.2)',
            'rgba(54, 162, 235, 0.2)',
            'rgba(255, 206, 86, 0.2)',
            'rgba(75, 192, 192, 0.2)',
            'rgba(153, 102, 255, 0.2)',
            'rgba(255, 159, 64, 0.2)',
            'rgba(255, 0, 0)',
            'rgba(0, 255, 0)',
            'rgba(0, 0, 255)',
            'rgba(192, 192, 192)',
            'rgba(255, 255, 0)',
            'rgba(255, 0, 255)'
        ],
        borderColor: [
            'rgba(255,99,132,1)',
            'rgba(54, 162, 235, 1)',
            'rgba(255, 206, 86, 1)',
            'rgba(75, 192, 192, 1)',
            'rgba(153, 102, 255, 1)',
            'rgba(255, 159, 64, 1)',
            'rgba(255, 0, 0)',
            'rgba(0, 255, 0)',
            'rgba(0, 0, 255)',
            'rgba(192, 192, 192)',
            'rgba(255, 255, 0)',
            'rgba(255, 0, 255)'
        ],
        borderWidth: 1,
  ");
            WriteLiteral("      data: ");
            EndContext();
            BeginContext(6705, 17, false);
#line 161 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Analytic/Index.cshtml"
         Write(Html.Raw(YValues));

#line default
#line hidden
            EndContext();
            BeginContext(6722, 673, true);
            WriteLiteral(@"
}]
            };

var options = {
    maintainAspectRatio: false,
    scales: {
        yAxes: [{
            ticks: {
                min: 0,
                beginAtZero: true
            },
            gridLines: {
                display: true,
                color: ""rgba(255,99,164,0.2)""
            }
        }],
        xAxes: [{
            ticks: {
                min: 0,
                beginAtZero: true
            },
            gridLines: {
                display: false
            }
        }]
    }
};

var myChart = new Chart(ctx, {
    options: options,
    data: data,
    type: 'line'
});
        });
</script>
");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<AUTO_ARCHIVE.Models.AutoDetails> Html { get; private set; }
    }
}
#pragma warning restore 1591
