#pragma checksum "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\Generators\CreateProfile.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "e1c23bed60f052a8063b50a313dde9a1051fd4d6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Generators_CreateProfile), @"mvc.1.0.view", @"/Views/Generators/CreateProfile.cshtml")]
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
#line 1 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\_ViewImports.cshtml"
using MenuGenerator;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\_ViewImports.cshtml"
using MenuGenerator.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"e1c23bed60f052a8063b50a313dde9a1051fd4d6", @"/Views/Generators/CreateProfile.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0ff138705816ab9847b162ac8e9399f03ddfd931", @"/Views/_ViewImports.cshtml")]
    public class Views_Generators_CreateProfile : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<MealKindsAndWeekDaysViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "SaveProfile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n<h1>Vytvoriť profil</h1>\r\n\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1c23bed60f052a8063b50a313dde9a1051fd4d64041", async() => {
                WriteLiteral("\r\n    <div class=\"row\">\r\n        <div class=\"col-lg\">\r\n            <input type=\"text\" name=\"profileName\" />\r\n            <input type=\"number\" name=\"uniqueMeals\" />\r\n            <input type=\"submit\" />\r\n        </div>\r\n    </div>\r\n");
#nullable restore
#line 13 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\Generators\CreateProfile.cshtml"
     foreach (var day in Model.Tyzden)
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <div class=\"row\">\r\n            <div class=\"col-lg font-weight-bold\">\r\n                ");
#nullable restore
#line 17 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\Generators\CreateProfile.cshtml"
           Write(day.Nazov);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n            </div>\r\n        </div>\r\n        <div class=\"row\">\r\n");
#nullable restore
#line 21 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\Generators\CreateProfile.cshtml"
             if (day.Nazov != "Sobota" && day.Nazov != "Nedeľa")
            {
                //dni okrem soboty a nedele
                for (int i = 1; i < 5; i++)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <div class=\"col-lg-2 mr-2\">\r\n                        <select class=\"selectpicker mb-2\"");
                BeginWriteAttribute("name", " name=\"", 855, "\"", 876, 3);
                WriteAttributeValue("", 862, "p_", 862, 2, true);
#nullable restore
#line 27 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\Generators\CreateProfile.cshtml"
WriteAttributeValue("", 864, day.Nazov, 864, 10, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 27 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\Generators\CreateProfile.cshtml"
WriteAttributeValue("", 874, i, 874, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 28 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\Generators\CreateProfile.cshtml"
                             foreach (var pop in Model.Oblubenost)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1c23bed60f052a8063b50a313dde9a1051fd4d66683", async() => {
#nullable restore
#line 30 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\Generators\CreateProfile.cshtml"
                                                   Write(pop.Nazov);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\Generators\CreateProfile.cshtml"
                                   WriteLiteral(pop.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 31 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\Generators\CreateProfile.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </select>\r\n                        <select class=\"selectpicker\" multiple");
                BeginWriteAttribute("name", " name=\"", 1183, "\"", 1202, 2);
#nullable restore
#line 33 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\Generators\CreateProfile.cshtml"
WriteAttributeValue("", 1190, day.Nazov, 1190, 10, false);

#line default
#line hidden
#nullable disable
#nullable restore
#line 33 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\Generators\CreateProfile.cshtml"
WriteAttributeValue("", 1200, i, 1200, 2, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 34 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\Generators\CreateProfile.cshtml"
                             foreach (var kind in Model.DruhJedla)
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1c23bed60f052a8063b50a313dde9a1051fd4d69810", async() => {
#nullable restore
#line 36 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\Generators\CreateProfile.cshtml"
                                                    Write(kind.Nazov);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 36 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\Generators\CreateProfile.cshtml"
                                   WriteLiteral(kind.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\Generators\CreateProfile.cshtml"
                            }

#line default
#line hidden
#nullable disable
                WriteLiteral("                        </select>\r\n                    </div>\r\n");
#nullable restore
#line 40 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\Generators\CreateProfile.cshtml"
                }
            }
            else
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <div class=\"col-lg-2\">\r\n                    <select class=\"selectpicker mb-2\"");
                BeginWriteAttribute("name", " name=\"", 1638, "\"", 1657, 2);
                WriteAttributeValue("", 1645, "p_", 1645, 2, true);
#nullable restore
#line 45 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\Generators\CreateProfile.cshtml"
WriteAttributeValue("", 1647, day.Nazov, 1647, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 46 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\Generators\CreateProfile.cshtml"
                         foreach (var pop in Model.Oblubenost)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1c23bed60f052a8063b50a313dde9a1051fd4d613114", async() => {
#nullable restore
#line 48 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\Generators\CreateProfile.cshtml"
                                               Write(pop.Nazov);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 48 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\Generators\CreateProfile.cshtml"
                               WriteLiteral(pop.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 49 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\Generators\CreateProfile.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </select>\r\n                    <select class=\"selectpicker\" multiple");
                BeginWriteAttribute("name", " name=\"", 1940, "\"", 1957, 1);
#nullable restore
#line 51 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\Generators\CreateProfile.cshtml"
WriteAttributeValue("", 1947, day.Nazov, 1947, 10, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(">\r\n");
#nullable restore
#line 52 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\Generators\CreateProfile.cshtml"
                         foreach (var kind in Model.DruhJedla)
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "e1c23bed60f052a8063b50a313dde9a1051fd4d615997", async() => {
#nullable restore
#line 54 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\Generators\CreateProfile.cshtml"
                                                Write(kind.Nazov);

#line default
#line hidden
#nullable disable
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\Generators\CreateProfile.cshtml"
                               WriteLiteral(kind.ID);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("value", __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
#nullable restore
#line 55 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\Generators\CreateProfile.cshtml"
                        }

#line default
#line hidden
#nullable disable
                WriteLiteral("                    </select>\r\n                </div>\r\n");
#nullable restore
#line 58 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\Generators\CreateProfile.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </div>\r\n");
#nullable restore
#line 60 "C:\Users\Simon\Documents\GIT\MenuGenerator\Views\Generators\CreateProfile.cshtml"

    }

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<MealKindsAndWeekDaysViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
