#pragma checksum "E:\Documentos\Facultad\UCP\OcupacionH\OcupacionH\WebApp\SistemaReservas\Views\Alojamientos\Delete.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "fe39b8c95e693bc5460a6396a5ec17902d09e7a6"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Alojamientos_Delete), @"mvc.1.0.view", @"/Views/Alojamientos/Delete.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Alojamientos/Delete.cshtml", typeof(AspNetCore.Views_Alojamientos_Delete))]
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
#line 1 "E:\Documentos\Facultad\UCP\OcupacionH\OcupacionH\WebApp\SistemaReservas\Views\_ViewImports.cshtml"
using SistemaReservas;

#line default
#line hidden
#line 2 "E:\Documentos\Facultad\UCP\OcupacionH\OcupacionH\WebApp\SistemaReservas\Views\_ViewImports.cshtml"
using SistemaReservas.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"fe39b8c95e693bc5460a6396a5ec17902d09e7a6", @"/Views/Alojamientos/Delete.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7363a1da460d59abec3b7fcb2715e2dfa65c7885", @"/Views/_ViewImports.cshtml")]
    public class Views_Alojamientos_Delete : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Data.Alojamientos>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", "hidden", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "E:\Documentos\Facultad\UCP\OcupacionH\OcupacionH\WebApp\SistemaReservas\Views\Alojamientos\Delete.cshtml"
  
    ViewData["Title"] = "Delete";

#line default
#line hidden
            BeginContext(70, 173, true);
            WriteLiteral("\r\n<h2>Delete</h2>\r\n\r\n<h3>Are you sure you want to delete this?</h3>\r\n<div>\r\n    <h4>Alojamientos</h4>\r\n    <hr />\r\n    <dl class=\"dl-horizontal\">\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(244, 42, false);
#line 15 "E:\Documentos\Facultad\UCP\OcupacionH\OcupacionH\WebApp\SistemaReservas\Views\Alojamientos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(286, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(330, 38, false);
#line 18 "E:\Documentos\Facultad\UCP\OcupacionH\OcupacionH\WebApp\SistemaReservas\Views\Alojamientos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Nombre));

#line default
#line hidden
            EndContext();
            BeginContext(368, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(412, 45, false);
#line 21 "E:\Documentos\Facultad\UCP\OcupacionH\OcupacionH\WebApp\SistemaReservas\Views\Alojamientos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Localidad));

#line default
#line hidden
            EndContext();
            BeginContext(457, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(501, 41, false);
#line 24 "E:\Documentos\Facultad\UCP\OcupacionH\OcupacionH\WebApp\SistemaReservas\Views\Alojamientos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Localidad));

#line default
#line hidden
            EndContext();
            BeginContext(542, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(586, 41, false);
#line 27 "E:\Documentos\Facultad\UCP\OcupacionH\OcupacionH\WebApp\SistemaReservas\Views\Alojamientos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Clase));

#line default
#line hidden
            EndContext();
            BeginContext(627, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(671, 37, false);
#line 30 "E:\Documentos\Facultad\UCP\OcupacionH\OcupacionH\WebApp\SistemaReservas\Views\Alojamientos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Clase));

#line default
#line hidden
            EndContext();
            BeginContext(708, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(752, 42, false);
#line 33 "E:\Documentos\Facultad\UCP\OcupacionH\OcupacionH\WebApp\SistemaReservas\Views\Alojamientos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NroHab));

#line default
#line hidden
            EndContext();
            BeginContext(794, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(838, 38, false);
#line 36 "E:\Documentos\Facultad\UCP\OcupacionH\OcupacionH\WebApp\SistemaReservas\Views\Alojamientos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NroHab));

#line default
#line hidden
            EndContext();
            BeginContext(876, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(920, 50, false);
#line 39 "E:\Documentos\Facultad\UCP\OcupacionH\OcupacionH\WebApp\SistemaReservas\Views\Alojamientos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.NroHabOcupadas));

#line default
#line hidden
            EndContext();
            BeginContext(970, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1014, 46, false);
#line 42 "E:\Documentos\Facultad\UCP\OcupacionH\OcupacionH\WebApp\SistemaReservas\Views\Alojamientos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.NroHabOcupadas));

#line default
#line hidden
            EndContext();
            BeginContext(1060, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1104, 42, false);
#line 45 "E:\Documentos\Facultad\UCP\OcupacionH\OcupacionH\WebApp\SistemaReservas\Views\Alojamientos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Plazas));

#line default
#line hidden
            EndContext();
            BeginContext(1146, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1190, 38, false);
#line 48 "E:\Documentos\Facultad\UCP\OcupacionH\OcupacionH\WebApp\SistemaReservas\Views\Alojamientos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Plazas));

#line default
#line hidden
            EndContext();
            BeginContext(1228, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1272, 50, false);
#line 51 "E:\Documentos\Facultad\UCP\OcupacionH\OcupacionH\WebApp\SistemaReservas\Views\Alojamientos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.PlazasOcupadas));

#line default
#line hidden
            EndContext();
            BeginContext(1322, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1366, 46, false);
#line 54 "E:\Documentos\Facultad\UCP\OcupacionH\OcupacionH\WebApp\SistemaReservas\Views\Alojamientos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.PlazasOcupadas));

#line default
#line hidden
            EndContext();
            BeginContext(1412, 43, true);
            WriteLiteral("\r\n        </dd>\r\n        <dt>\r\n            ");
            EndContext();
            BeginContext(1456, 44, false);
#line 57 "E:\Documentos\Facultad\UCP\OcupacionH\OcupacionH\WebApp\SistemaReservas\Views\Alojamientos\Delete.cshtml"
       Write(Html.DisplayNameFor(model => model.Reservas));

#line default
#line hidden
            EndContext();
            BeginContext(1500, 43, true);
            WriteLiteral("\r\n        </dt>\r\n        <dd>\r\n            ");
            EndContext();
            BeginContext(1544, 40, false);
#line 60 "E:\Documentos\Facultad\UCP\OcupacionH\OcupacionH\WebApp\SistemaReservas\Views\Alojamientos\Delete.cshtml"
       Write(Html.DisplayFor(model => model.Reservas));

#line default
#line hidden
            EndContext();
            BeginContext(1584, 38, true);
            WriteLiteral("\r\n        </dd>\r\n    </dl>\r\n    \r\n    ");
            EndContext();
            BeginContext(1622, 207, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "db0469ba1c634c2e8138733db5c438e1", async() => {
                BeginContext(1648, 10, true);
                WriteLiteral("\r\n        ");
                EndContext();
                BeginContext(1658, 36, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "d3e69c6839554b469dda841b005723ba", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.InputTypeName = (string)__tagHelperAttribute_0.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 65 "E:\Documentos\Facultad\UCP\OcupacionH\OcupacionH\WebApp\SistemaReservas\Views\Alojamientos\Delete.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.Id);

#line default
#line hidden
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(1694, 84, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Delete\" class=\"btn btn-default\" /> |\r\n        ");
                EndContext();
                BeginContext(1778, 38, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "92361ba9cb82429db1e6697b288057e9", async() => {
                    BeginContext(1800, 12, true);
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
                BeginContext(1816, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
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
            BeginContext(1829, 10, true);
            WriteLiteral("\r\n</div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Data.Alojamientos> Html { get; private set; }
    }
}
#pragma warning restore 1591