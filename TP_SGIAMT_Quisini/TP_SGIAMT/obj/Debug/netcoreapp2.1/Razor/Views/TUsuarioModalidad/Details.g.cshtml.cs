#pragma checksum "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarioModalidad\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9ea1f38f0d667a44618d7e2db454fcd4cc724b83"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_TUsuarioModalidad_Details), @"mvc.1.0.view", @"/Views/TUsuarioModalidad/Details.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/TUsuarioModalidad/Details.cshtml", typeof(AspNetCore.Views_TUsuarioModalidad_Details))]
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
#line 1 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\_ViewImports.cshtml"
using TP_SGIAMT;

#line default
#line hidden
#line 2 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\_ViewImports.cshtml"
using TP_SGIAMT.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9ea1f38f0d667a44618d7e2db454fcd4cc724b83", @"/Views/TUsuarioModalidad/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1ca981b27afbd8e7d4aba29c8ce9b9955aebba5b", @"/Views/_ViewImports.cshtml")]
    public class Views_TUsuarioModalidad_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<TP_SGIAMT.Models.TUsuarioModalidad>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(43, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarioModalidad\Details.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(72, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(101, 102, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "50cca157736744a59116c2ba12be8194", async() => {
                BeginContext(107, 89, true);
                WriteLiteral("\r\n    <meta name=\"viewport\" content=\"width=device-width\" />\r\n    <title>Details</title>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(203, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(205, 1975, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "3ee8ce5ac049471fba391fc192fb9276", async() => {
                BeginContext(211, 113, true);
                WriteLiteral("\r\n\r\n<div>\r\n    <h4>TUsuarioModalidad</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(325, 43, false);
#line 21 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FkIuDni));

#line default
#line hidden
                EndContext();
                BeginContext(368, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(412, 39, false);
#line 24 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayFor(model => model.FkIuDni));

#line default
#line hidden
                EndContext();
                BeginContext(451, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(495, 43, false);
#line 27 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.IumFase));

#line default
#line hidden
                EndContext();
                BeginContext(538, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(582, 39, false);
#line 30 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayFor(model => model.IumFase));

#line default
#line hidden
                EndContext();
                BeginContext(621, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(665, 47, false);
#line 33 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.DumFechaIns));

#line default
#line hidden
                EndContext();
                BeginContext(712, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(756, 43, false);
#line 36 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayFor(model => model.DumFechaIns));

#line default
#line hidden
                EndContext();
                BeginContext(799, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(843, 50, false);
#line 39 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VmUmArchivoDni));

#line default
#line hidden
                EndContext();
                BeginContext(893, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(937, 46, false);
#line 42 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayFor(model => model.VmUmArchivoDni));

#line default
#line hidden
                EndContext();
                BeginContext(983, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1027, 48, false);
#line 45 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.VmUmArchivoB));

#line default
#line hidden
                EndContext();
                BeginContext(1075, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1119, 44, false);
#line 48 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayFor(model => model.VmUmArchivoB));

#line default
#line hidden
                EndContext();
                BeginContext(1163, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1207, 51, false);
#line 51 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FkIcIdConcurso1));

#line default
#line hidden
                EndContext();
                BeginContext(1258, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1302, 55, false);
#line 54 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayFor(model => model.FkIcIdConcurso1.PkIuDni));

#line default
#line hidden
                EndContext();
                BeginContext(1357, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1401, 60, false);
#line 57 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FkIcIdConcursoNavigation));

#line default
#line hidden
                EndContext();
                BeginContext(1461, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1505, 71, false);
#line 60 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayFor(model => model.FkIcIdConcursoNavigation.PkIcIdConcurso));

#line default
#line hidden
                EndContext();
                BeginContext(1576, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1620, 61, false);
#line 63 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FkImIdModalidadNavigation));

#line default
#line hidden
                EndContext();
                BeginContext(1681, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1725, 73, false);
#line 66 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayFor(model => model.FkImIdModalidadNavigation.PkImIdModalidad));

#line default
#line hidden
                EndContext();
                BeginContext(1798, 43, true);
                WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
                EndContext();
                BeginContext(1842, 59, false);
#line 69 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayNameFor(model => model.FkIuDniParejaNavigation));

#line default
#line hidden
                EndContext();
                BeginContext(1901, 43, true);
                WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
                EndContext();
                BeginContext(1945, 63, false);
#line 72 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarioModalidad\Details.cshtml"
       Write(Html.DisplayFor(model => model.FkIuDniParejaNavigation.PkIuDni));

#line default
#line hidden
                EndContext();
                BeginContext(2008, 47, true);
                WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n</div>\r\n<div>\r\n    ");
                EndContext();
                BeginContext(2055, 62, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6a64ecbf6054e568253ec8db0c48470", async() => {
                    BeginContext(2109, 4, true);
                    WriteLiteral("Edit");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#line 77 "D:\quisini\SGIAMT-\TP_SGIAMT_Quisini\TP_SGIAMT\Views\TUsuarioModalidad\Details.cshtml"
                           WriteLiteral(Model.PkIumCodUm);

#line default
#line hidden
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2117, 8, true);
                WriteLiteral(" |\r\n    ");
                EndContext();
                BeginContext(2125, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5a5130e537144d0d8998af9355bc0a5c", async() => {
                    BeginContext(2147, 12, true);
                    WriteLiteral("Back to List");
                    EndContext();
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(2163, 10, true);
                WriteLiteral("\r\n</div>\r\n");
                EndContext();
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
            EndContext();
            BeginContext(2180, 11, true);
            WriteLiteral("\r\n</html>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<TP_SGIAMT.Models.TUsuarioModalidad> Html { get; private set; }
    }
}
#pragma warning restore 1591
