#pragma checksum "C:\Users\utyum\source\repos\WebApplication4\Views\Pagamento\PagamentoPDF.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "5cbb38b860c7082e26e1e448cc59f3d8c936c102"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pagamento_PagamentoPDF), @"mvc.1.0.view", @"/Views/Pagamento/PagamentoPDF.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Pagamento/PagamentoPDF.cshtml", typeof(AspNetCore.Views_Pagamento_PagamentoPDF))]
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
#line 1 "C:\Users\utyum\source\repos\WebApplication4\Views\_ViewImports.cshtml"
using WebApplication4;

#line default
#line hidden
#line 2 "C:\Users\utyum\source\repos\WebApplication4\Views\_ViewImports.cshtml"
using WebApplication4.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"5cbb38b860c7082e26e1e448cc59f3d8c936c102", @"/Views/Pagamento/PagamentoPDF.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9fff4eb847734ec2c3f91807e9b1a08bbda85e45", @"/Views/_ViewImports.cshtml")]
    public class Views_Pagamento_PagamentoPDF : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Pagamento>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/lib/bootstrap/dist/css/bootstrap.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/site.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/images/generic-logo.png"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(31, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\utyum\source\repos\WebApplication4\Views\Pagamento\PagamentoPDF.cshtml"
  
  ViewData["Title"] = "ContactPDF";

#line default
#line hidden
#line 6 "C:\Users\utyum\source\repos\WebApplication4\Views\Pagamento\PagamentoPDF.cshtml"
  
  Layout = null;

#line default
#line hidden
            BeginContext(102, 29, true);
            WriteLiteral("\r\n<!DOCTYPE html>\r\n\r\n<html>\r\n");
            EndContext();
            BeginContext(131, 227, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cbb38b860c7082e26e1e448cc59f3d8c936c1025438", async() => {
                BeginContext(137, 90, true);
                WriteLiteral("\r\n  <meta name=\"viewport\" content=\"width=device-width\" />\r\n  <title>Grupo Aval</title>\r\n  ");
                EndContext();
                BeginContext(227, 71, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5cbb38b860c7082e26e1e448cc59f3d8c936c1025916", async() => {
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
                EndContext();
                BeginContext(298, 4, true);
                WriteLiteral("\r\n  ");
                EndContext();
                BeginContext(302, 47, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5cbb38b860c7082e26e1e448cc59f3d8c936c1027246", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(349, 2, true);
                WriteLiteral("\r\n");
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
            BeginContext(358, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(360, 1109, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "5cbb38b860c7082e26e1e448cc59f3d8c936c1029375", async() => {
                BeginContext(366, 59, true);
                WriteLiteral("\r\n\r\n  <div class=\"row\">\r\n    <div class=\"col-sm-4\">\r\n      ");
                EndContext();
                BeginContext(425, 39, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "5cbb38b860c7082e26e1e448cc59f3d8c936c1029824", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(464, 440, true);
                WriteLiteral(@"
    </div>
    <div class=""col-sm-8 text-left"">
      <h2>Lista Debitos/Pagamentos</h2>
    </div>
  </div>

  <table class=""table"">
    <thead>
      <tr>
        <th>
          Cpf
        </th>
        <th>
          Contrato
        </th>
        <th>
          Data
        </th>
        <th>
          Valor
        </th>
        <th>
          Situação
        </th>
      </tr>
    </thead>
    <tbody>
");
                EndContext();
#line 51 "C:\Users\utyum\source\repos\WebApplication4\Views\Pagamento\PagamentoPDF.cshtml"
       foreach (var item in Model)
      {

#line default
#line hidden
                BeginContext(949, 42, true);
                WriteLiteral("        <tr>\r\n          <td>\r\n            ");
                EndContext();
                BeginContext(992, 38, false);
#line 55 "C:\Users\utyum\source\repos\WebApplication4\Views\Pagamento\PagamentoPDF.cshtml"
       Write(Html.DisplayFor(modelItem => item.Cpf));

#line default
#line hidden
                EndContext();
                BeginContext(1030, 47, true);
                WriteLiteral("\r\n          </td>\r\n          <td>\r\n            ");
                EndContext();
                BeginContext(1078, 43, false);
#line 58 "C:\Users\utyum\source\repos\WebApplication4\Views\Pagamento\PagamentoPDF.cshtml"
       Write(Html.DisplayFor(modelItem => item.Contrato));

#line default
#line hidden
                EndContext();
                BeginContext(1121, 47, true);
                WriteLiteral("\r\n          </td>\r\n          <td>\r\n            ");
                EndContext();
                BeginContext(1169, 39, false);
#line 61 "C:\Users\utyum\source\repos\WebApplication4\Views\Pagamento\PagamentoPDF.cshtml"
       Write(Html.DisplayFor(modelItem => item.Data));

#line default
#line hidden
                EndContext();
                BeginContext(1208, 47, true);
                WriteLiteral("\r\n          </td>\r\n          <td>\r\n            ");
                EndContext();
                BeginContext(1256, 40, false);
#line 64 "C:\Users\utyum\source\repos\WebApplication4\Views\Pagamento\PagamentoPDF.cshtml"
       Write(Html.DisplayFor(modelItem => item.Valor));

#line default
#line hidden
                EndContext();
                BeginContext(1296, 47, true);
                WriteLiteral("\r\n          </td>\r\n          <td>\r\n            ");
                EndContext();
                BeginContext(1344, 43, false);
#line 67 "C:\Users\utyum\source\repos\WebApplication4\Views\Pagamento\PagamentoPDF.cshtml"
       Write(Html.DisplayFor(modelItem => item.Situacao));

#line default
#line hidden
                EndContext();
                BeginContext(1387, 36, true);
                WriteLiteral("\r\n          </td>\r\n\r\n        </tr>\r\n");
                EndContext();
#line 71 "C:\Users\utyum\source\repos\WebApplication4\Views\Pagamento\PagamentoPDF.cshtml"
      }

#line default
#line hidden
                BeginContext(1432, 30, true);
                WriteLiteral("    </tbody>\r\n  </table>\r\n\r\n\r\n");
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
            BeginContext(1469, 11, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Pagamento>> Html { get; private set; }
    }
}
#pragma warning restore 1591
