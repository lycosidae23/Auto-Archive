#pragma checksum "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Garage/Compare.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "807b397b99ef987d69d3d19b2c619aa1c687aa84"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Garage_Compare), @"mvc.1.0.view", @"/Views/Garage/Compare.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Garage/Compare.cshtml", typeof(AspNetCore.Views_Garage_Compare))]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"807b397b99ef987d69d3d19b2c619aa1c687aa84", @"/Views/Garage/Compare.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8be20235d9c01195033de53bd77ca11ddd91709e", @"/Views/_ViewImports.cshtml")]
    public class Views_Garage_Compare : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Analytic", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Garage", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-route-type", "compare", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(120, 4, true);
            WriteLiteral("\r\n\r\n");
            EndContext();
#line 5 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Garage/Compare.cshtml"
 if (ViewBag.compCount > 0)
{

#line default
#line hidden
            BeginContext(156, 2688, true);
            WriteLiteral(@"    <table style=""float:left;font-size:13px;margin-top:127px;"" width=""140"" height=""211"" border=""0"">
        <tr style=""border-bottom:1px solid black;font-weight:bold;"">
            <td align=""center"">
                <span id=""makeKey""><i id=""makeRem"" class=""fa fa-remove"" style=""color:red""></i> Make <i id=""makeChk"" class=""fa fa-check"" style=""color:green;display:none;""></i></span>
            </td>
        </tr>
        <tr style=""border-bottom:1px solid black;font-weight:bold;"">
            <td align=""center"">
                <span id=""yearKey""><i id=""yearRem"" class=""fa fa-remove"" style=""color:red""></i> Year <i id=""yearChk"" class=""fa fa-check"" style=""color:green;display:none;""></i></span>
            </td>
        </tr>
        <tr style=""border-bottom:1px solid black;font-weight:bold;"">
            <td align=""center"">
                <span id=""vinKey""><i id=""vinRem"" class=""fa fa-remove"" style=""color:red""></i> Vin <i id=""vinChk"" class=""fa fa-check"" style=""color:green;display:none;""></i></span>
 ");
            WriteLiteral(@"           </td>
        </tr>
        <tr style=""border-bottom:1px solid black;font-weight:bold;"">
            <td align=""center"">
                <span id=""cylKey""><i id=""cylRem"" class=""fa fa-remove"" style=""color:red""></i> Cyl <i id=""cylChk"" class=""fa fa-check"" style=""color:green;display:none;""></i></span>
            </td>
        </tr>
        <tr style=""border-bottom:1px solid black;font-weight:bold;"">
            <td align=""center"">
                <span id=""statusKey""><i id=""statusRem"" class=""fa fa-remove"" style=""color:red""></i> Status <i id=""statusChk"" class=""fa fa-check"" style=""color:green;display:none;""></i></span>
            </td>
        </tr>
        <tr style=""border-bottom:1px solid black;font-weight:bold;"">
            <td align=""center"">
                <span id=""mileKey""><i id=""mileRem"" class=""fa fa-remove"" style=""color:red""></i> Mileage <i id=""mileChk"" class=""fa fa-check"" style=""color:green;display:none;""></i></span>
            </td>
        </tr>
        <tr style=""borde");
            WriteLiteral(@"r-bottom:1px solid black;font-weight:bold;"">
            <td align=""center"">
                <span id=""dateKey""><i id=""dateRem"" class=""fa fa-remove"" style=""color:red""></i> Auction Date <i id=""dateChk"" class=""fa fa-check"" style=""color:green;display:none;""></i></span>
            </td>
        </tr>
        <tr style=""border-bottom:1px solid black;font-weight:bold;"">
            <td align=""center"">
                <span id=""bidKey""><i id=""bidRem"" class=""fa fa-remove"" style=""color:red""></i> Final Bid <i id=""bidChk"" class=""fa fa-check"" style=""color:green;display:none;""></i></span>
            </td>
        </tr>
    </table>
");
            EndContext();
#line 50 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Garage/Compare.cshtml"
     foreach (var item in Model.Compare)
    {

#line default
#line hidden
            BeginContext(2895, 158, true);
            WriteLiteral("        <table style=\"float:left;font-size:13px\" width=\"155\" height=\"300\" border=\"0\" cellpadding=\"3\">\r\n            <tr>\r\n                <td align=\"center\">\r\n");
            EndContext();
#line 55 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Garage/Compare.cshtml"
                     if (item.FirstImage != null)
                    {

#line default
#line hidden
            BeginContext(3127, 24, true);
            WriteLiteral("                        ");
            EndContext();
            BeginContext(3151, 419, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "807b397b99ef987d69d3d19b2c619aa1c687aa849095", async() => {
                BeginContext(3283, 53, true);
                WriteLiteral("\r\n                            <img class=\"responsive\"");
                EndContext();
                BeginWriteAttribute("src", "\r\n                                 src=\"", 3336, "\"", 3440, 2);
                WriteAttributeValue("", 3376, "data:image/jpg;base64,", 3376, 22, true);
#line 59 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Garage/Compare.cshtml"
WriteAttributeValue("", 3398, Convert.ToBase64String(item.FirstImage), 3398, 42, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(3441, 125, true);
                WriteLiteral("\r\n                                 style=\"width:100%;height:120px;background-color:transparent;\" />\r\n                        ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-vin", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 57 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Garage/Compare.cshtml"
                                                                           WriteLiteral(item.Vin);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["vin"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-vin", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["vin"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 57 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Garage/Compare.cshtml"
                                                                                                       WriteLiteral(item.Model);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["model"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-model", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["model"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 57 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Garage/Compare.cshtml"
                                                                                                                                    WriteLiteral(item.Year);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["year"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-year", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["year"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3570, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 62 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Garage/Compare.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(3644, 225, true);
            WriteLiteral("                        <img class=\"responsive\"\r\n                             src=\"https://upload.wikimedia.org/wikipedia/commons/a/ac/No_image_available.svg\"\r\n                             style=\"width:75%;height:120px;\" />\r\n");
            EndContext();
#line 68 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Garage/Compare.cshtml"
                    }

#line default
#line hidden
            BeginContext(3892, 287, true);
            WriteLiteral(@"                </td>
            </tr>
            <tr style=""border-bottom:1px solid black;"">
                <td align=""center"">
                    <div style=""white-space:nowrap;overflow:hidden;text-overflow:ellipsis;width:155px"">
                        <span class=""makeVal"">");
            EndContext();
            BeginContext(4180, 10, false);
#line 74 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Garage/Compare.cshtml"
                                         Write(item.Model);

#line default
#line hidden
            EndContext();
            BeginContext(4190, 215, true);
            WriteLiteral("</span>\r\n                    </div>\r\n                </td>\r\n            </tr>\r\n            <tr style=\"border-bottom:1px solid black;\">\r\n                <td align=\"center\">\r\n                    <span class=\"yearVal\">");
            EndContext();
            BeginContext(4406, 9, false);
#line 80 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Garage/Compare.cshtml"
                                     Write(item.Year);

#line default
#line hidden
            EndContext();
            BeginContext(4415, 186, true);
            WriteLiteral("</span>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td align=\"center\" style=\"border-bottom:1px solid black;\">\r\n                    <span class=\"vinVal\">");
            EndContext();
            BeginContext(4602, 8, false);
#line 85 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Garage/Compare.cshtml"
                                    Write(item.Vin);

#line default
#line hidden
            EndContext();
            BeginContext(4610, 186, true);
            WriteLiteral("</span>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td align=\"center\" style=\"border-bottom:1px solid black;\">\r\n                    <span class=\"cylVal\">");
            EndContext();
            BeginContext(4797, 8, false);
#line 90 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Garage/Compare.cshtml"
                                    Write(item.Cyl);

#line default
#line hidden
            EndContext();
            BeginContext(4805, 189, true);
            WriteLiteral("</span>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td align=\"center\" style=\"border-bottom:1px solid black;\">\r\n                    <span class=\"statusVal\">");
            EndContext();
            BeginContext(4995, 11, false);
#line 95 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Garage/Compare.cshtml"
                                       Write(item.Status);

#line default
#line hidden
            EndContext();
            BeginContext(5006, 187, true);
            WriteLiteral("</span>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td align=\"center\" style=\"border-bottom:1px solid black;\">\r\n                    <span class=\"mileVal\">");
            EndContext();
            BeginContext(5194, 14, false);
#line 100 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Garage/Compare.cshtml"
                                     Write(item.MileageKm);

#line default
#line hidden
            EndContext();
            BeginContext(5208, 190, true);
            WriteLiteral(" km</span>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td align=\"center\" style=\"border-bottom:1px solid black;\">\r\n                    <span class=\"dateVal\">");
            EndContext();
            BeginContext(5399, 16, false);
#line 105 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Garage/Compare.cshtml"
                                     Write(item.AuctionDate);

#line default
#line hidden
            EndContext();
            BeginContext(5415, 145, true);
            WriteLiteral("</span>\r\n                </td>\r\n            </tr>\r\n            <tr>\r\n                <td align=\"center\" style=\"border-bottom:1px solid black;\">\r\n");
            EndContext();
#line 110 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Garage/Compare.cshtml"
                     if (item.BidAmountC != null)
                    {

#line default
#line hidden
            BeginContext(5634, 68, true);
            WriteLiteral("                        <span class=\"bidVal\" style=\"color:green;\">C$");
            EndContext();
            BeginContext(5703, 15, false);
#line 112 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Garage/Compare.cshtml"
                                                               Write(item.BidAmountC);

#line default
#line hidden
            EndContext();
            BeginContext(5718, 9, true);
            WriteLiteral("</span>\r\n");
            EndContext();
#line 113 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Garage/Compare.cshtml"
                    }
                    else
                    {

#line default
#line hidden
            BeginContext(5799, 61, true);
            WriteLiteral("                        <span class=\"bidVal\">Pending</span>\r\n");
            EndContext();
#line 117 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Garage/Compare.cshtml"
                    }

#line default
#line hidden
            BeginContext(5883, 102, true);
            WriteLiteral("                </td>\r\n            </tr>\r\n            <tr>\r\n                <td>\r\n                    ");
            EndContext();
            BeginContext(5985, 231, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "807b397b99ef987d69d3d19b2c619aa1c687aa8420853", async() => {
                BeginContext(6093, 119, true);
                WriteLiteral("<button class=\"btn btn-sm btn-light\" style=\"outline:none;width:100%;\"><i class=\"fa fa-remove\"></i>&nbsp;Remove</button>");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 122 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Garage/Compare.cshtml"
                                                                                 WriteLiteral(item.Id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-type", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["type"] = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(6216, 62, true);
            WriteLiteral("\r\n                </td>\r\n            </tr>\r\n        </table>\r\n");
            EndContext();
#line 126 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Garage/Compare.cshtml"
    }

#line default
#line hidden
#line 126 "/mnt/c/Users/ayode/Dropbox/myProjects/APPS/SCARF/PROJECT_BUILDS/HYBRID/v1.0.1/AUTO_ARCHIVE/Views/Garage/Compare.cshtml"
     
}

#line default
#line hidden
            BeginContext(6288, 35, true);
            WriteLiteral("<table style=\"width:100%;\"></table>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
