#pragma checksum "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d1c6102628e6438fe14187f0da04ce9e48aee898"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(Przychodnia.Pages.Pages_Lekarz), @"mvc.1.0.razor-page", @"/Pages/Lekarz.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Pages/Lekarz.cshtml", typeof(Przychodnia.Pages.Pages_Lekarz), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d1c6102628e6438fe14187f0da04ce9e48aee898", @"/Pages/Lekarz.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a872b964efec98a4663c0627828e782b95e2fa36", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Lekarz : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
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
#line 3 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
  
    ViewData["Title"] = "Lekarz";

#line default
#line hidden
            BeginContext(87, 23, true);
            WriteLiteral("\r\n<h2>Lekarz</h2>\r\n<h3>");
            EndContext();
            BeginContext(111, 17, false);
#line 8 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
Write(Model.lekarz.imie);

#line default
#line hidden
            EndContext();
            BeginContext(128, 1, true);
            WriteLiteral(" ");
            EndContext();
            BeginContext(130, 21, false);
#line 8 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
                  Write(Model.lekarz.nazwisko);

#line default
#line hidden
            EndContext();
            BeginContext(151, 10, true);
            WriteLiteral("</h3>\r\n<p>");
            EndContext();
            BeginContext(162, 33, false);
#line 9 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
Write(Model.dateTime.ToLongDateString());

#line default
#line hidden
            EndContext();
            BeginContext(195, 146, true);
            WriteLiteral("</p>\r\n<table>\r\n    <tr>\r\n        <td>Lp</td>\r\n        <td>Godzina</td>\r\n        <td>Pesel Pacjenta</td>\r\n        <td>Cel wizyty:</td>\r\n    </tr>\r\n");
            EndContext();
#line 17 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
     for (int i = 0; i < 10; i++)
    {

#line default
#line hidden
            BeginContext(383, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(407, 5, false);
#line 20 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
        Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(413, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(433, 90, false);
#line 21 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
       Write(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.Date).wizyty[i].godzina.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(523, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(543, 85, false);
#line 22 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
       Write(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.Date).wizyty[i].pacjent.pesel);

#line default
#line hidden
            EndContext();
            BeginContext(628, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(648, 79, false);
#line 23 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
       Write(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.Date).wizyty[i].choroba);

#line default
#line hidden
            EndContext();
            BeginContext(727, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(746, 491, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "371ffba3b8a24b179782de6a97a63006", async() => {
                BeginContext(1227, 6, true);
                WriteLiteral("Wizyta");
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
#line 24 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
                                                      WriteLiteral(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.Date).wizyty[i].choroba);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["opisChoroby"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-opisChoroby", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["opisChoroby"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
                                                                                                                                                        WriteLiteral(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.Date).dzien.Date);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["data"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["data"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
                                                                                                                                                                                                                                                    WriteLiteral(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.Date).wizyty[i].godzina.ToString());

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dzien"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-dzien", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dzien"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
                                                                                                                                                                                                                                                                                                                                                                      WriteLiteral(Model.lekarz.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idLekarza"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idLekarza", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idLekarza"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 24 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                         WriteLiteral(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.Date).wizyty[i].pacjent.pesel);

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
            BeginContext(1237, 20, true);
            WriteLiteral("</td>\r\n\r\n    </tr>\r\n");
            EndContext();
#line 27 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
    }

#line default
#line hidden
            BeginContext(1264, 13, true);
            WriteLiteral("</table>\r\n<p>");
            EndContext();
            BeginContext(1278, 44, false);
#line 29 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
Write(Model.dateTime.AddDays(1).ToLongDateString());

#line default
#line hidden
            EndContext();
            BeginContext(1322, 146, true);
            WriteLiteral("</p>\r\n<table>\r\n    <tr>\r\n        <td>Lp</td>\r\n        <td>Godzina</td>\r\n        <td>Pesel Pacjenta</td>\r\n        <td>Cel wizyty:</td>\r\n    </tr>\r\n");
            EndContext();
#line 37 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
     for (int i = 0; i < 10; i++)
    {

#line default
#line hidden
            BeginContext(1510, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(1534, 5, false);
#line 40 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
        Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(1540, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1560, 101, false);
#line 41 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
       Write(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.AddDays(1).Date).wizyty[i].godzina.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(1661, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1681, 96, false);
#line 42 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
       Write(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.AddDays(1).Date).wizyty[i].pacjent.pesel);

#line default
#line hidden
            EndContext();
            BeginContext(1777, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1797, 90, false);
#line 43 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
       Write(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.AddDays(1).Date).wizyty[i].choroba);

#line default
#line hidden
            EndContext();
            BeginContext(1887, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(1906, 491, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8cb76f566c0f4c5b9e674b43458a78a9", async() => {
                BeginContext(2387, 6, true);
                WriteLiteral("Wizyta");
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
#line 44 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
                                                      WriteLiteral(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.Date).wizyty[i].choroba);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["opisChoroby"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-opisChoroby", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["opisChoroby"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 44 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
                                                                                                                                                        WriteLiteral(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.Date).dzien.Date);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["data"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["data"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 44 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
                                                                                                                                                                                                                                                    WriteLiteral(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.Date).wizyty[i].godzina.ToString());

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dzien"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-dzien", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dzien"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 44 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
                                                                                                                                                                                                                                                                                                                                                                      WriteLiteral(Model.lekarz.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idLekarza"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idLekarza", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idLekarza"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 44 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                         WriteLiteral(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.Date).wizyty[i].pacjent.pesel);

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
            BeginContext(2397, 20, true);
            WriteLiteral("</td>\r\n\r\n    </tr>\r\n");
            EndContext();
#line 47 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
    }

#line default
#line hidden
            BeginContext(2424, 13, true);
            WriteLiteral("</table>\r\n<p>");
            EndContext();
            BeginContext(2438, 44, false);
#line 49 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
Write(Model.dateTime.AddDays(2).ToLongDateString());

#line default
#line hidden
            EndContext();
            BeginContext(2482, 146, true);
            WriteLiteral("</p>\r\n<table>\r\n    <tr>\r\n        <td>Lp</td>\r\n        <td>Godzina</td>\r\n        <td>Pesel Pacjenta</td>\r\n        <td>Cel wizyty:</td>\r\n    </tr>\r\n");
            EndContext();
#line 57 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
     for (int i = 0; i < 10; i++)
    {

#line default
#line hidden
            BeginContext(2670, 22, true);
            WriteLiteral("    <tr>\r\n        <td>");
            EndContext();
            BeginContext(2694, 5, false);
#line 60 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
        Write(i + 1);

#line default
#line hidden
            EndContext();
            BeginContext(2700, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(2720, 101, false);
#line 61 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
       Write(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.AddDays(2).Date).wizyty[i].godzina.ToString());

#line default
#line hidden
            EndContext();
            BeginContext(2821, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(2841, 96, false);
#line 62 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
       Write(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.AddDays(2).Date).wizyty[i].pacjent.pesel);

#line default
#line hidden
            EndContext();
            BeginContext(2937, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(2957, 90, false);
#line 63 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
       Write(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.AddDays(2).Date).wizyty[i].choroba);

#line default
#line hidden
            EndContext();
            BeginContext(3047, 19, true);
            WriteLiteral("</td>\r\n        <td>");
            EndContext();
            BeginContext(3066, 491, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "90c28dbbbf794aa0a5b6acb80d37c528", async() => {
                BeginContext(3547, 6, true);
                WriteLiteral("Wizyta");
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
#line 64 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
                                                      WriteLiteral(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.Date).wizyty[i].choroba);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["opisChoroby"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-opisChoroby", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["opisChoroby"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
                                                                                                                                                        WriteLiteral(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.Date).dzien.Date);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["data"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-data", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["data"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
                                                                                                                                                                                                                                                    WriteLiteral(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.Date).wizyty[i].godzina.ToString());

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dzien"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-dzien", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["dzien"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
                                                                                                                                                                                                                                                                                                                                                                      WriteLiteral(Model.lekarz.id);

#line default
#line hidden
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idLekarza"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-idLekarza", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["idLekarza"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            BeginWriteTagHelperAttribute();
#line 64 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
                                                                                                                                                                                                                                                                                                                                                                                                         WriteLiteral(Model.dniPracy.Find(d => d.dzien.Date == Model.dateTime.Date).wizyty[i].pacjent.pesel);

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
            BeginContext(3557, 20, true);
            WriteLiteral("</td>\r\n\r\n    </tr>\r\n");
            EndContext();
#line 67 "C:\Users\Karol\source\repos\Przychodnia\Przychodnia\Pages\Lekarz.cshtml"
    }

#line default
#line hidden
            BeginContext(3584, 12, true);
            WriteLiteral("</table>\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Przychodnia.Pages.LekarzModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Przychodnia.Pages.LekarzModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<Przychodnia.Pages.LekarzModel>)PageContext?.ViewData;
        public Przychodnia.Pages.LekarzModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
