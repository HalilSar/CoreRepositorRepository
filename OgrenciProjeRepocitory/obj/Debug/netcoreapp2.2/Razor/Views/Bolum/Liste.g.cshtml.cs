#pragma checksum "C:\Users\iau\Desktop\OgrenciProjeRepocitory-6.11.19\OgrenciProjeRepocitory\Views\Bolum\Liste.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "95d75d696d7efdec5741b6cce38117090c330bf9"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Bolum_Liste), @"mvc.1.0.view", @"/Views/Bolum/Liste.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Bolum/Liste.cshtml", typeof(AspNetCore.Views_Bolum_Liste))]
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
#line 1 "C:\Users\iau\Desktop\OgrenciProjeRepocitory-6.11.19\OgrenciProjeRepocitory\Views\_ViewImports.cshtml"
using OgrenciProjeRepocitory;

#line default
#line hidden
#line 2 "C:\Users\iau\Desktop\OgrenciProjeRepocitory-6.11.19\OgrenciProjeRepocitory\Views\_ViewImports.cshtml"
using OgrenciProjeRepocitory.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"95d75d696d7efdec5741b6cce38117090c330bf9", @"/Views/Bolum/Liste.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"81106a4fbd6bddfd3faa7481ae401cd4290edae0", @"/Views/_ViewImports.cshtml")]
    public class Views_Bolum_Liste : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<OgrenciProjeRepocitory.Models.View.BolumModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("/Bolum/Giris"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 2 "C:\Users\iau\Desktop\OgrenciProjeRepocitory-6.11.19\OgrenciProjeRepocitory\Views\Bolum\Liste.cshtml"
  
    ViewData["Title"] = "Liste";

#line default
#line hidden
            BeginContext(95, 22, true);
            WriteLiteral("\r\n<h1>Liste</h1>\r\n    ");
            EndContext();
            BeginContext(117, 130, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "95d75d696d7efdec5741b6cce38117090c330bf94300", async() => {
                BeginContext(158, 82, true);
                WriteLiteral("\r\n        <input type=\"submit\" value=\"Yeni Giriş\" class=\"btn btn-primary\" />\r\n    ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(247, 217, true);
            WriteLiteral("\r\n    <table class=\"table table-striped\">\r\n        <tr>\r\n            <th>Id</th>\r\n            <th>Adı</th>\r\n            <th>Güncelle</th>\r\n            <th>Sil</th>\r\n            <th>Öğrenciler</th>\r\n\r\n        </tr>\r\n\r\n");
            EndContext();
#line 20 "C:\Users\iau\Desktop\OgrenciProjeRepocitory-6.11.19\OgrenciProjeRepocitory\Views\Bolum\Liste.cshtml"
         foreach (var item in Model.Blist)
        {

#line default
#line hidden
            BeginContext(519, 38, true);
            WriteLiteral("            <tr>\r\n                <td>");
            EndContext();
            BeginContext(558, 7, false);
#line 23 "C:\Users\iau\Desktop\OgrenciProjeRepocitory-6.11.19\OgrenciProjeRepocitory\Views\Bolum\Liste.cshtml"
               Write(item.Id);

#line default
#line hidden
            EndContext();
            BeginContext(565, 27, true);
            WriteLiteral("</td>\r\n                <td>");
            EndContext();
            BeginContext(593, 7, false);
#line 24 "C:\Users\iau\Desktop\OgrenciProjeRepocitory-6.11.19\OgrenciProjeRepocitory\Views\Bolum\Liste.cshtml"
               Write(item.Ad);

#line default
#line hidden
            EndContext();
            BeginContext(600, 29, true);
            WriteLiteral("</td>\r\n                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 629, "\"", 658, 2);
            WriteAttributeValue("", 636, "/Bolum/Guncel/", 636, 14, true);
#line 25 "C:\Users\iau\Desktop\OgrenciProjeRepocitory-6.11.19\OgrenciProjeRepocitory\Views\Bolum\Liste.cshtml"
WriteAttributeValue("", 650, item.Id, 650, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(659, 42, true);
            WriteLiteral(">Güncelle</a></td>\r\n                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 701, "\"", 727, 2);
            WriteAttributeValue("", 708, "/Bolum/Sil/", 708, 11, true);
#line 26 "C:\Users\iau\Desktop\OgrenciProjeRepocitory-6.11.19\OgrenciProjeRepocitory\Views\Bolum\Liste.cshtml"
WriteAttributeValue("", 719, item.Id, 719, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(728, 37, true);
            WriteLiteral(">Sil</a></td>\r\n                <td><a");
            EndContext();
            BeginWriteAttribute("href", " href=\"", 765, "\"", 798, 2);
            WriteAttributeValue("", 772, "/Ogrenci/ListById/", 772, 18, true);
#line 27 "C:\Users\iau\Desktop\OgrenciProjeRepocitory-6.11.19\OgrenciProjeRepocitory\Views\Bolum\Liste.cshtml"
WriteAttributeValue("", 790, item.Id, 790, 8, false);

#line default
#line hidden
            EndWriteAttribute();
            BeginContext(799, 94, true);
            WriteLiteral(" class=\"btn btn-success\">Öğrenciler</a></td>\r\n\r\n                <td></td>\r\n            </tr>\r\n");
            EndContext();
#line 31 "C:\Users\iau\Desktop\OgrenciProjeRepocitory-6.11.19\OgrenciProjeRepocitory\Views\Bolum\Liste.cshtml"

        }

#line default
#line hidden
            BeginContext(906, 22, true);
            WriteLiteral("\r\n\r\n\r\n\r\n    </table>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<OgrenciProjeRepocitory.Models.View.BolumModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
