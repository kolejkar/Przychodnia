#pragma checksum "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "94654ae78a7276bb9a0ea21f04e4ea6d985763d4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Przychodnia.Pages.Pages_Rezerwacja), @"mvc.1.0.razor-page", @"/Pages/Rezerwacja.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Rezerwacja.cshtml", typeof(Przychodnia.Pages.Pages_Rezerwacja), null)]
namespace Przychodnia.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\_ViewImports.cshtml"
using Przychodnia;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"94654ae78a7276bb9a0ea21f04e4ea6d985763d4", @"/Pages/Rezerwacja.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a872b964efec98a4663c0627828e782b95e2fa36", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Rezerwacja : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page-handler", "Register", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
  
    ViewData["Title"] = "Rezerwacja";

#line default
#line hidden
            BeginContext(95, 26, true);
            WriteLiteral("\r\n<h2>Rezerwacja</h2>\r\n<p>");
            EndContext();
            BeginContext(122, 33, false);
#line 8 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
Write(Model.dateTime.ToLongDateString());

#line default
#line hidden
            EndContext();
            BeginContext(155, 137, true);
            WriteLiteral("</p>\r\n<table>\r\n    <tr>\r\n        <td>Lp</td>\r\n        <td>Godzina</td>\r\n        <td>Lekarz</td>\r\n        <td>Rezerwacja</td>\r\n    </tr>\r\n");
            EndContext();
#line 16 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
     for (int i = 0; i < 10; i++)
    {

#line default
#line hidden
            BeginContext(334, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(366, 5, false);
#line 19 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
            Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(372, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(396, 90, false);
#line 20 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
           Write(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.Date).wizyty[i].godzina.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(486, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(510, 73, false);
#line 21 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
           Write(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.Date).lekarz.imie);

#line default
#line hidden
            EndContext();
            BeginContext(583, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(585, 77, false);
#line 21 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
                                                                                      Write(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.Date).lekarz.nazwisko);

#line default
#line hidden
            EndContext();
            BeginContext(662, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 22 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
             if (!Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.Date).wizyty[i].rezerwacja)
            {

#line default
#line hidden
            BeginContext(787, 16, true);
            WriteLiteral("            <td>");
            EndContext();
            BeginContext(803, 215, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "99757e344f204ab19e2239b60db6fc7c", async() => {
                BeginContext(1004, 10, true);
                WriteLiteral("Rezerwacja");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-opisChoroby", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
                                                          WriteLiteral(Model.OpisChoroby);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["opisChoroby"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-opisChoroby", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["opisChoroby"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
                                                                                            WriteLiteral(i);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
                                                                                                                 WriteLiteral(Model.dateTime.Date);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dzien"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-dzien", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dzien"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
                                                                                                                                                            WriteLiteral(Model.IdLekarza);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idLekarza"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idLekarza", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idLekarza"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
                                                                                                                                                                                               WriteLiteral(Model.Pesel);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pesel"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pesel", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pesel"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1018, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 25 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
            }

#line default
#line hidden
            BeginContext(1040, 17, true);
            WriteLiteral("\r\n        </tr>\r\n");
            EndContext();
#line 28 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
    }

#line default
#line hidden
            BeginContext(1064, 13, true);
            WriteLiteral("</table>\r\n<p>");
            EndContext();
            BeginContext(1078, 44, false);
#line 30 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
Write(Model.dateTime.AddDays(1).ToLongDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1122, 137, true);
            WriteLiteral("</p>\r\n<table>\r\n    <tr>\r\n        <td>Lp</td>\r\n        <td>Godzina</td>\r\n        <td>Lekarz</td>\r\n        <td>Rezerwacja</td>\r\n    </tr>\r\n");
            EndContext();
#line 38 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
     for (int i = 0; i < 10; i++)
    {

#line default
#line hidden
            BeginContext(1301, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(1333, 5, false);
#line 41 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
            Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(1339, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1363, 101, false);
#line 42 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
           Write(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.AddDays(1).Date).wizyty[i].godzina.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1464, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(1488, 84, false);
#line 43 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
           Write(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.AddDays(1).Date).lekarz.imie);

#line default
#line hidden
            EndContext();
            BeginContext(1572, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(1574, 88, false);
#line 43 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
                                                                                                 Write(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.AddDays(1).Date).lekarz.nazwisko);

#line default
#line hidden
            EndContext();
            BeginContext(1662, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 44 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
             if (!Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.AddDays(1).Date).wizyty[i].rezerwacja)
            {

#line default
#line hidden
            BeginContext(1798, 16, true);
            WriteLiteral("            <td>");
            EndContext();
            BeginContext(1814, 226, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "641a3e427b5e4f388183687997fe20aa", async() => {
                BeginContext(2026, 10, true);
                WriteLiteral("Rezerwacja");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-opisChoroby", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
                                                          WriteLiteral(Model.OpisChoroby);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["opisChoroby"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-opisChoroby", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["opisChoroby"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
                                                                                            WriteLiteral(i);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
                                                                                                                 WriteLiteral(Model.dateTime.AddDays(1).Date);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dzien"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-dzien", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dzien"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
                                                                                                                                                                       WriteLiteral(Model.IdLekarza);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idLekarza"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idLekarza", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idLekarza"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 46 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
                                                                                                                                                                                                          WriteLiteral(Model.Pesel);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pesel"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pesel", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pesel"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2040, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 47 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
            }

#line default
#line hidden
            BeginContext(2062, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 49 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
    }

#line default
#line hidden
            BeginContext(2084, 13, true);
            WriteLiteral("</table>\r\n<p>");
            EndContext();
            BeginContext(2098, 44, false);
#line 51 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
Write(Model.dateTime.AddDays(2).ToLongDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2142, 137, true);
            WriteLiteral("</p>\r\n<table>\r\n    <tr>\r\n        <td>Lp</td>\r\n        <td>Godzina</td>\r\n        <td>Lekarz</td>\r\n        <td>Rezerwacja</td>\r\n    </tr>\r\n");
            EndContext();
#line 59 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
     for (int i = 0; i < 10; i++)
    {

#line default
#line hidden
            BeginContext(2321, 30, true);
            WriteLiteral("        <tr>\r\n            <td>");
            EndContext();
            BeginContext(2353, 5, false);
#line 62 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
            Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(2359, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2383, 101, false);
#line 63 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
           Write(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.AddDays(2).Date).wizyty[i].godzina.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(2484, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(2508, 84, false);
#line 64 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
           Write(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.AddDays(2).Date).lekarz.imie);

#line default
#line hidden
            EndContext();
            BeginContext(2592, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(2594, 88, false);
#line 64 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
                                                                                                 Write(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.AddDays(2).Date).lekarz.nazwisko);

#line default
#line hidden
            EndContext();
            BeginContext(2682, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 65 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
             if (!Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.AddDays(2).Date).wizyty[i].rezerwacja)
            {

#line default
#line hidden
            BeginContext(2818, 16, true);
            WriteLiteral("            <td>");
            EndContext();
            BeginContext(2834, 226, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2e01a8fcff7949b7946ea8f667a4187c", async() => {
                BeginContext(3046, 10, true);
                WriteLiteral("Rezerwacja");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.PageHandler = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-opisChoroby", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#line 67 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
                                                          WriteLiteral(Model.OpisChoroby);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["opisChoroby"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-opisChoroby", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["opisChoroby"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 67 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
                                                                                            WriteLiteral(i);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 67 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
                                                                                                                 WriteLiteral(Model.dateTime.AddDays(2).Date);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dzien"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-dzien", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dzien"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 67 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
                                                                                                                                                                       WriteLiteral(Model.IdLekarza);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idLekarza"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idLekarza", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idLekarza"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 67 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
                                                                                                                                                                                                          WriteLiteral(Model.Pesel);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pesel"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-pesel", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["pesel"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3060, 7, true);
            WriteLiteral("</td>\r\n");
            EndContext();
#line 68 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
            }

#line default
#line hidden
            BeginContext(3082, 15, true);
            WriteLiteral("        </tr>\r\n");
            EndContext();
#line 70 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Rezerwacja.cshtml"
    }

#line default
#line hidden
            BeginContext(3104, 10, true);
            WriteLiteral("</table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Przychodnia.Pages.RezerwacjaModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Przychodnia.Pages.RezerwacjaModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Przychodnia.Pages.RezerwacjaModel>)PageContext?.ViewData;
        public Przychodnia.Pages.RezerwacjaModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
