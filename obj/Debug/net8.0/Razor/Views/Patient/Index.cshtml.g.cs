#pragma checksum "C:\Users\Amal\Downloads\ClinicManagmentSystem\ClinicManagmentSystem\Clinic_Managment_System\Views\Patient\Index.cshtml" "{8829d00f-11b8-4213-878b-770e8597ac16}" "e6cbe79f73e32cb4cd444025a2cacbd71f9bc574f0240ccf81491c3ed67e5774"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Patient_Index), @"mvc.1.0.view", @"/Views/Patient/Index.cshtml")]
namespace AspNetCore
{
    #line default
    using global::System;
    using global::System.Collections.Generic;
    using global::System.Linq;
    using global::System.Threading.Tasks;
    using global::Microsoft.AspNetCore.Mvc;
    using global::Microsoft.AspNetCore.Mvc.Rendering;
    using global::Microsoft.AspNetCore.Mvc.ViewFeatures;
#nullable restore
#line (1,2)-(2,1) "C:\Users\Amal\Downloads\ClinicManagmentSystem\ClinicManagmentSystem\Clinic_Managment_System\Views\_ViewImports.cshtml"
using Clinic_Managment_System

#nullable disable
    ;
#nullable restore
#line (2,2)-(3,1) "C:\Users\Amal\Downloads\ClinicManagmentSystem\ClinicManagmentSystem\Clinic_Managment_System\Views\_ViewImports.cshtml"
using Clinic_Managment_System.Models

#line default
#line hidden
#nullable disable
    ;
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"e6cbe79f73e32cb4cd444025a2cacbd71f9bc574f0240ccf81491c3ed67e5774", @"/Views/Patient/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"Sha256", @"b1f34a7ea5ffb339b1ca6d8c2242ddc0ff455249c817b007690f270b6f9a7319", @"/Views/_ViewImports.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemMetadataAttribute("Identifier", "/Views/Patient/Index.cshtml")]
    [global::System.Runtime.CompilerServices.CreateNewOnMetadataUpdateAttribute]
    #nullable restore
    public class Views_Patient_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Clinic_Managment_System.Viewmodel.PatientAppointmentOverviewViewModel>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.min.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", "~/css/site.css", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/cliniclay.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/doctor2.jpg"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Doctors"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/appointments.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_8 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString("Staff"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_9 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/jquery/dist/jquery.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_10 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/js/bootstrap.bundle.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line (2,3)-(4,1) "C:\Users\Amal\Downloads\ClinicManagmentSystem\ClinicManagmentSystem\Clinic_Managment_System\Views\Patient\Index.cshtml"

    ViewData["Title"] = "Patient Dashboard";

#line default
#line hidden
#nullable disable

#nullable restore
#line (5,3)-(7,1) "C:\Users\Amal\Downloads\ClinicManagmentSystem\ClinicManagmentSystem\Clinic_Managment_System\Views\Patient\Index.cshtml"

    Layout = "_LayoutAuthenticated";

#line default
#line hidden
#nullable disable

            WriteLiteral("\r\n\r\n<!DOCTYPE html>\r\n<html lang=\"en\">\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6cbe79f73e32cb4cd444025a2cacbd71f9bc574f0240ccf81491c3ed67e57748564", async() => {
                WriteLiteral("\r\n    <meta charset=\"utf-8\" />\r\n    <meta name=\"viewport\" content=\"width=device-width, initial-scale=1.0\" />\r\n    <title>Clinic Dashboard - Clinic Management System</title>\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e6cbe79f73e32cb4cd444025a2cacbd71f9bc574f0240ccf81491c3ed67e57749034", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e6cbe79f73e32cb4cd444025a2cacbd71f9bc574f0240ccf81491c3ed67e577410236", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.LinkTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.Href = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion = 
#nullable restore
#line (17,70)-(17,74) "C:\Users\Amal\Downloads\ClinicManagmentSystem\ClinicManagmentSystem\Clinic_Managment_System\Views\Patient\Index.cshtml"
true

#line default
#line hidden
#nullable disable
                ;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_LinkTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    <link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/font-awesome/6.0.0-beta3/css/all.min.css\" />\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "e6cbe79f73e32cb4cd444025a2cacbd71f9bc574f0240ccf81491c3ed67e577412499", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6cbe79f73e32cb4cd444025a2cacbd71f9bc574f0240ccf81491c3ed67e577414406", async() => {
                WriteLiteral("\r\n    <!-- Carousel Section -->\r\n    <div id=\"AllCarousel\" class=\"carousel slide mb-5\" data-bs-ride=\"carousel\">\r\n        <div class=\"carousel-inner\">\r\n            <div class=\"carousel-item active\"");
                BeginWriteAttribute("style", " style=\"", 942, "\"", 1014, 4);
                WriteAttributeValue("", 950, "background-image:", 950, 17, true);
                WriteAttributeValue(" ", 967, "url(\'", 968, 6, true);
                WriteAttributeValue("", 973, 
#nullable restore
#line (25,78)-(25,115) "C:\Users\Amal\Downloads\ClinicManagmentSystem\ClinicManagmentSystem\Clinic_Managment_System\Views\Patient\Index.cshtml"
Url.Content("~/images/hospital1.jpg")

#line default
#line hidden
#nullable disable
                , 973, 38, false);
                WriteAttributeValue("", 1011, "\');", 1011, 3, true);
                EndWriteAttribute();
                WriteLiteral(@">
                <div class=""carousel-caption d-none d-md-block"">
                    <h5>Make an Appointment</h5>
                    <p>You could choose the doctor and the Date you want for the Appointment .</p>
                </div>
            </div>
            <div class=""carousel-item""");
                BeginWriteAttribute("style", " style=\"", 1316, "\"", 1388, 4);
                WriteAttributeValue("", 1324, "background-image:", 1324, 17, true);
                WriteAttributeValue(" ", 1341, "url(\'", 1342, 6, true);
                WriteAttributeValue("", 1347, 
#nullable restore
#line (31,71)-(31,108) "C:\Users\Amal\Downloads\ClinicManagmentSystem\ClinicManagmentSystem\Clinic_Managment_System\Views\Patient\Index.cshtml"
Url.Content("~/images/hospital2.jpg")

#line default
#line hidden
#nullable disable
                , 1347, 38, false);
                WriteAttributeValue("", 1385, "\');", 1385, 3, true);
                EndWriteAttribute();
                WriteLiteral(@">
                <div class=""carousel-caption d-none d-md-block"">
                    <h5>View Your Appointments</h5>
                    <p>Keep track of your  appointments.</p>
                </div>
            </div>
            <div class=""carousel-item""");
                BeginWriteAttribute("style", " style=\"", 1655, "\"", 1727, 4);
                WriteAttributeValue("", 1663, "background-image:", 1663, 17, true);
                WriteAttributeValue(" ", 1680, "url(\'", 1681, 6, true);
                WriteAttributeValue("", 1686, 
#nullable restore
#line (37,71)-(37,108) "C:\Users\Amal\Downloads\ClinicManagmentSystem\ClinicManagmentSystem\Clinic_Managment_System\Views\Patient\Index.cshtml"
Url.Content("~/images/hospital3.jpg")

#line default
#line hidden
#nullable disable
                , 1686, 38, false);
                WriteAttributeValue("", 1724, "\');", 1724, 3, true);
                EndWriteAttribute();
                WriteLiteral(@">
                <div class=""carousel-caption d-none d-md-block"">
                    <h5>Track Appointment Status</h5>
                    <p>You could Track the status of your appointments - Scheduled, Missed, or Completed.</p>
                </div>
            </div>
        </div>
        <button class=""carousel-control-prev"" type=""button"" data-bs-target=""#AllCarousel"" data-bs-slide=""prev"">
            <span class=""carousel-control-prev-icon"" aria-hidden=""true""></span>
            <span class=""visually-hidden"">Previous</span>
        </button>
        <button class=""carousel-control-next"" type=""button"" data-bs-target=""#AllCarousel"" data-bs-slide=""next"">
            <span class=""carousel-control-next-icon"" aria-hidden=""true""></span>
            <span class=""visually-hidden"">Next</span>
        </button>
    </div>

<!-- Use  at the top of your Razor view -->
<section class=""container"">
    <div class=""row text-center mb-5"">
        <div class=""col-md-4"">
            <div class=""overv");
                WriteLiteral("iew-card\">\r\n                <i class=\"fas fa-calendar-alt\"></i>\r\n                <h4>Total Appointments</h4>\r\n                <p>");
                Write(
#nullable restore
#line (61,21)-(61,44) "C:\Users\Amal\Downloads\ClinicManagmentSystem\ClinicManagmentSystem\Clinic_Managment_System\Views\Patient\Index.cshtml"
Model.TotalAppointments

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-4\">\r\n            <div class=\"overview-card\">\r\n                <i class=\"fas fa-check-circle\"></i>\r\n                <h4>Completed Appointments</h4>\r\n                <p>");
                Write(
#nullable restore
#line (68,21)-(68,48) "C:\Users\Amal\Downloads\ClinicManagmentSystem\ClinicManagmentSystem\Clinic_Managment_System\Views\Patient\Index.cshtml"
Model.CompletedAppointments

#line default
#line hidden
#nullable disable
                );
                WriteLiteral("</p>\r\n            </div>\r\n        </div>\r\n        <div class=\"col-md-4\">\r\n            <div class=\"overview-card\">\r\n                <i class=\"fas fa-times-circle\"></i>\r\n                <h4>Missed Appointments</h4>\r\n                <p>");
                Write(
#nullable restore
#line (75,21)-(75,45) "C:\Users\Amal\Downloads\ClinicManagmentSystem\ClinicManagmentSystem\Clinic_Managment_System\Views\Patient\Index.cshtml"
Model.MissedAppointments

#line default
#line hidden
#nullable disable
                );
                WriteLiteral(@"</p>
            </div>
        </div>
    </div>
</section>




    <section class=""container mb-5"">
        <div class=""row align-items-center"">
            <div class=""col-md-6"">
                <div class=""text-center mb-4"">
                    <h2>Patient Appointments</h2>
                    <p>View your Appointments and track the Status of your appointments.</p>
                    <a");
                BeginWriteAttribute("href", " href=\"", 3836, "\"", 3876, 1);
                WriteAttributeValue("", 3843, 
#nullable restore
#line (90,31)-(90,63) "C:\Users\Amal\Downloads\ClinicManagmentSystem\ClinicManagmentSystem\Clinic_Managment_System\Views\Patient\Index.cshtml"
Url.Action("Details", "Patient")

#line default
#line hidden
#nullable disable
                , 3843, 33, false);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-primary\">View Appointments</a>\r\n                </div>\r\n            </div>\r\n            <div class=\"col-md-6\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e6cbe79f73e32cb4cd444025a2cacbd71f9bc574f0240ccf81491c3ed67e577421393", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n    <section class=\"container mb-5\">\r\n        <div class=\"row align-items-center\">\r\n            <div class=\"col-md-6\">\r\n                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "e6cbe79f73e32cb4cd444025a2cacbd71f9bc574f0240ccf81491c3ed67e577422889", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_8);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral(@"
            </div>
            <div class=""col-md-6"">
                <div class=""text-center mb-4"">
                    <h2>Make an Appointment</h2>
                    <p>You could choose the doctor and the Date you want for the Appointment.</p>
                    <a");
                BeginWriteAttribute("href", " href=\"", 4621, "\"", 4664, 1);
                WriteAttributeValue("", 4628, 
#nullable restore
#line (108,31)-(108,66) "C:\Users\Amal\Downloads\ClinicManagmentSystem\ClinicManagmentSystem\Clinic_Managment_System\Views\Patient\Index.cshtml"
Url.Action("Appoitment", "Patient")

#line default
#line hidden
#nullable disable
                , 4628, 36, false);
                EndWriteAttribute();
                WriteLiteral(" class=\"btn btn-secondary\">Make an Appointment</a>\r\n                </div>\r\n            </div>\r\n        </div>\r\n    </section>\r\n\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6cbe79f73e32cb4cd444025a2cacbd71f9bc574f0240ccf81491c3ed67e577425094", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_9);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e6cbe79f73e32cb4cd444025a2cacbd71f9bc574f0240ccf81491c3ed67e577426218", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_10);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</html>");
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Clinic_Managment_System.Viewmodel.PatientAppointmentOverviewViewModel> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591