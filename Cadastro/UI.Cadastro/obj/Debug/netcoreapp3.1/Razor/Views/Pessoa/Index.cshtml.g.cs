#pragma checksum "D:\Temp\AulaCs\Aula5\AulasCsharp\Cadastro\UI.Cadastro\Views\Pessoa\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4dd384dd8d89ab5b750b1ee153272a3bf0bc9ae4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Pessoa_Index), @"mvc.1.0.view", @"/Views/Pessoa/Index.cshtml")]
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
#line 1 "D:\Temp\AulaCs\Aula5\AulasCsharp\Cadastro\UI.Cadastro\Views\_ViewImports.cshtml"
using UI.Cadastro;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "D:\Temp\AulaCs\Aula5\AulasCsharp\Cadastro\UI.Cadastro\Views\_ViewImports.cshtml"
using UI.Cadastro.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4dd384dd8d89ab5b750b1ee153272a3bf0bc9ae4", @"/Views/Pessoa/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f9161b31832104af387e0bf084cd405c8be56dd1", @"/Views/_ViewImports.cshtml")]
    public class Views_Pessoa_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<UI.Cadastro.Models.PessoaViewModel>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-info"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Pessoa", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-area", "", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "D:\Temp\AulaCs\Aula5\AulasCsharp\Cadastro\UI.Cadastro\Views\Pessoa\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<section class=""container-fluid"">
    <h1>Listagem de Pessoas</h1>
</section>

<section class=""container-fluid"">
    <div class=""row"">
        <div class=""col-12"">
            <div class=""box-shadow"">
                <div class=""card-header"">
                    
                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4dd384dd8d89ab5b750b1ee153272a3bf0bc9ae45248", async() => {
                WriteLiteral("Criar nova pessoa");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"

                </div>
                
                <div class=""container-fluid table-responsive"">
                    <table class=""table table-bordered table-striped"">
                        <thead>
                        <tr>
                            <td>CÓDIGO</td>
                            <td>NOME</td>
                            <td>DT NASCIMENTO</td>
                            <td>CPF</td>
                            <td>SEXO</td>
                            <td>AÇÃO</td>
                        </tr>
                        </thead>
                        <tbody>
");
#nullable restore
#line 35 "D:\Temp\AulaCs\Aula5\AulasCsharp\Cadastro\UI.Cadastro\Views\Pessoa\Index.cshtml"
                         foreach (var item in Model)
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            <tr>\r\n                                <td>");
#nullable restore
#line 38 "D:\Temp\AulaCs\Aula5\AulasCsharp\Cadastro\UI.Cadastro\Views\Pessoa\Index.cshtml"
                               Write(Html.DisplayFor(mdeloItem => item.id));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 39 "D:\Temp\AulaCs\Aula5\AulasCsharp\Cadastro\UI.Cadastro\Views\Pessoa\Index.cshtml"
                               Write(Html.DisplayFor(mdeloItem => item.Nome));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 40 "D:\Temp\AulaCs\Aula5\AulasCsharp\Cadastro\UI.Cadastro\Views\Pessoa\Index.cshtml"
                               Write(String.Format("{0:dd/MM/yyyy}", item.Nascimento));

#line default
#line hidden
#nullable disable
            WriteLiteral(" </td>\r\n                                <td>");
#nullable restore
#line 41 "D:\Temp\AulaCs\Aula5\AulasCsharp\Cadastro\UI.Cadastro\Views\Pessoa\Index.cshtml"
                               Write(Html.DisplayFor(mdeloItem => item.Cpf));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>");
#nullable restore
#line 42 "D:\Temp\AulaCs\Aula5\AulasCsharp\Cadastro\UI.Cadastro\Views\Pessoa\Index.cshtml"
                               Write(Html.DisplayFor(mdeloItem => item.Sexo));

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n                                <td>\r\n                                    <a class=\"btn\"");
            BeginWriteAttribute("id", " id=\"", 1767, "\"", 1780, 1);
#nullable restore
#line 44 "D:\Temp\AulaCs\Aula5\AulasCsharp\Cadastro\UI.Cadastro\Views\Pessoa\Index.cshtml"
WriteAttributeValue("", 1772, item.id, 1772, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" onclick=\"ChamaModal(this.id)\">Detalhe</a> |\r\n                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4dd384dd8d89ab5b750b1ee153272a3bf0bc9ae49748", async() => {
                WriteLiteral("Editar");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Area = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 45 "D:\Temp\AulaCs\Aula5\AulasCsharp\Cadastro\UI.Cadastro\Views\Pessoa\Index.cshtml"
                                                                                               WriteLiteral(item.id);

#line default
#line hidden
#nullable disable
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
            WriteLiteral(" |\r\n                                    <a class=\"btn\"");
            BeginWriteAttribute("onclick", " onclick=\"", 2008, "\"", 2047, 3);
            WriteAttributeValue("", 2018, "DeletarUsandoAjax(\'", 2018, 19, true);
#nullable restore
#line 46 "D:\Temp\AulaCs\Aula5\AulasCsharp\Cadastro\UI.Cadastro\Views\Pessoa\Index.cshtml"
WriteAttributeValue("", 2037, item.id, 2037, 8, false);

#line default
#line hidden
#nullable disable
            WriteAttributeValue("", 2045, "\')", 2045, 2, true);
            EndWriteAttribute();
            WriteLiteral(">Deletar</a>\r\n                                </td>\r\n                            </tr>\r\n");
#nullable restore
#line 49 "D:\Temp\AulaCs\Aula5\AulasCsharp\Cadastro\UI.Cadastro\Views\Pessoa\Index.cshtml"
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                        </tbody>
                    </table> 
                </div>

            </div>
        </div>
    </div>
    <!-- Modal -->
    <div class=""modal fade"" id=""exampleModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalLabel"" aria-hidden=""true"">
        <div class=""modal-dialog"" role=""document"">
            <div class=""modal-content"">
                <div class=""modal-header"">
                    <h5 class=""modal-title"" id=""exampleModalLabel"">Detalhe</h5>
                    <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                        <span aria-hidden=""true"">&times;</span>
                    </button>
                </div>
                <div id=""corpo"" class=""modal-body"">

                </div>
                <div class=""modal-footer"">
                    <button type=""button"" class=""btn btn-secondary"" data-dismiss=""modal"">Fechar</button>
                </div>
            </div>
        </div>
    </div");
            WriteLiteral(@">
</section>




    <script type=""text/javascript"">


        function ChamaModal(id) {

            //alert(""aqui"");
            $(""#corpo"").load(""/Pessoa/Details/"" + id,
                function() {
                    //alert(""Dentro"");
                    $(""#exampleModal"").modal('show');
                });

        }


        function DeletarUsandoAjax(id) {
            var ret = confirm(""Você realmente deseja apagar esta pessoa definitivamente?"");

            if (ret == true) {
                $.ajax({
                    type: ""POST"",
                    url: '");
#nullable restore
#line 102 "D:\Temp\AulaCs\Aula5\AulasCsharp\Cadastro\UI.Cadastro\Views\Pessoa\Index.cshtml"
                     Write(Url.Action("Delete", "Pessoa"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
                    data: {
                        id: id
                    },
                    error: function(result) {
                        alert(result);
                    },
                    success: function(result) {
                        if (result == true) {
                            window.location.reload();
                        } else {
                            alert(""Erro inesperado"");
                        }
                    }
                });
            }
        }

    </script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<UI.Cadastro.Models.PessoaViewModel>> Html { get; private set; }
    }
}
#pragma warning restore 1591
