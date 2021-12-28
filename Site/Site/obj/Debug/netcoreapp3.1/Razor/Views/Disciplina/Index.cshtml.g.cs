#pragma checksum "C:\Users\mathe\Desktop\matheus\Site\Site\Views\Disciplina\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "02b4c42c2926768b366cd542585e3a4a8f606f53"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Disciplina_Index), @"mvc.1.0.view", @"/Views/Disciplina/Index.cshtml")]
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
#line 1 "C:\Users\mathe\Desktop\matheus\Site\Site\Views\_ViewImports.cshtml"
using Site;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\mathe\Desktop\matheus\Site\Site\Views\_ViewImports.cshtml"
using Site.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"02b4c42c2926768b366cd542585e3a4a8f606f53", @"/Views/Disciplina/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"70e3a3f90f6d4c226913e942091a3f82dd825d74", @"/Views/_ViewImports.cshtml")]
    public class Views_Disciplina_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\mathe\Desktop\matheus\Site\Site\Views\Disciplina\Index.cshtml"
  
    ViewBag.Title = "Index Disciplina";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"

<style>
    .modal-over {
        overflow-y: auto;
    }

    .pdfobject-container {
        height: 500px;
    }

    .form-horizontal .control-label {
        text-align: unset;
    }



    .btn-group btn-group-toggle {
        color: darkred;
    }

    .btn btn-secondary active {
        color: darkred;
    }

    .inputDnD .form-control-file {
        position: relative;
        width: 100%;
        height: 100%;
        min-height: 7em;
        outline: none;
        visibility: hidden;
        cursor: pointer;
        background-color: #c61c23;
        box-shadow: 0 0 5px solid currentColor;
    }

    .inputDnD .form-control-file:before {
        content: attr(data-title);
        position: absolute;
        top: 0.5em;
        left: 0;
        width: 100%;
        min-height: 6em;
        line-height: 2em;
        padding-top: 1.5em;
        opacity: 1;
        visibility: visible;
        text-align: center;
        border: 0.25em dashed currentCo");
            WriteLiteral(@"lor;
        -webkit-transition: all 0.3s cubic-bezier(0.25, 0.8, 0.25, 1);
        transition: all 0.3s cubic-bezier(0.25, 0.8, 0.25, 1);
        overflow-wrap: break-word;
        word-wrap: break-word;
        hyphens: auto;
    }

    .inputDnD .form-control-file:hover:before {
        border-style: solid;
        box-shadow: inset 0px 0px 0px 0.25em currentColor;
    }

    body {
        background-color: #f7f7f9;
    }

    ul.list-group:after {
        clear: both;
        display: block;
        content: """";
        display: flex;
    }

    li i {
        float: right;
    }

    .modal-scroll {
        overflow-y: auto;
    }
</style>

<div class=""container"">
    <header class=""text-center text-white"">
        <h1 class=""display-4"" style=""color: black"">Disciplina Cadastrados</h1>
    </header>

    <div class=""row "" id=""GridTable"">
        <div class=""card rounded shadow border-0"" style=""width:100%; height:100%"">
            <div class=""card-body "">
        ");
            WriteLiteral(@"        <div class=""table-responsive"">
                    <table style=""width:100%; height:100%"" class=""table table-striped table-bordered"" id=""gridDisciplina"">
                        <thead>
                            <tr>
                                <th scope=""col"">Código</th>
                                <th scope=""col"">Nome</th>
                                <th scope=""col"">Min. Aprovação</th>
                            </tr>
                        </thead>
                        <tbody>
                        </tbody>
                    </table>
                </div>
            </div>
        </div>
    </div>
</div>






<script type=""text/javascript"">


    $(document).ready(function () {

        var Disciplina = {
            ""language"": {
                ""lengthMenu"": ""Mostrar _MENU_ registros por página"",
                ""zeroRecords"": ""Nenhum registro econtrando"",
                ""info"": ""Monstrando página _PAGE_ de _PAGES_ </br> Total: _MAX_"",
");
            WriteLiteral(@"                ""infoEmpty"": ""Não foram encontrados registros"",
                ""infoFiltered"": ""(Filtro realizado em _MAX_ total usuários)"",
                ""search"": ""Pesquisar"",
                ""paging"": ""false"",
                ""order"": [[1, ""asc""]],
                ""searching"": ""false"",
                ""bDestroy"": ""true"",
                ""oPaginate"": {
                    ""sFirst"": ""Primeira página"",
                    ""sPrevious"": ""<<"",
                    ""sNext"": "">>"",
                    ""sLast"": ""Última página""
                }
            }
        };

        $.ajax({
            type: ""GET"",
            url: '");
#nullable restore
#line 145 "C:\Users\mathe\Desktop\matheus\Site\Site\Views\Disciplina\Index.cshtml"
             Write(Url.Action("ListaDisciplina", "Disciplina"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
            dataType: ""json"",
            success: function (dados) {

                var cont = 0;

                var dtable = $(""#gridDisciplina"");

                dtable.dataTable().fnClearTable();
                dtable.dataTable().fnDestroy();


                $.each(dados, function (i, item) {

                    var cols = """";
                    cols += ""<td id='Codigo"" + cont + ""'>"" + item.codigo + ""</td>"";
                    cols += ""<td id='nome"" + cont + ""'>"" + item.nome + ""</td>"";
                    cols += ""<td id='minAprovacao"" + cont + ""'>"" + item.minAprovacao + ""</td>"";
                    dtable.find('tbody')
                        .append($('<tr>')
                            .append($(cols)));

                    cont++;

                });

                dtable.dataTable(Disciplina);
            }
        });

    });



    function OpenModal(idBook) {
        $.ajax({
            type: ""POST"",
            url: '");
#nullable restore
#line 182 "C:\Users\mathe\Desktop\matheus\Site\Site\Views\Disciplina\Index.cshtml"
             Write(Url.Action("DetailsBook", "Book"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
             data: {
                 id: idBook,
             },
            dataType: ""json"",
            success: function (dados) {
                $.each(dados, function (i, item) {

                    $('#txtBkId').val(item.BkId);
                    $('#txtBkName').val(item.BkName);
                    $('#txtBkIndication').val(item.BkIndication);
                    $('#txtBkSaga').val(item.BkSaga);
                    $('#txtBkDate').val(item.BkDate);
                    $('#txtAutName').val(item.AutName);
                    $('#txtAutSaga').val(item.AutSaga);
                    $('#txtAutFavBook').val(item.AutFavBook);
                    $('#txtGenName').val(item.GenName);
                    $('#txtGenDes').val(item.GenDes);
                    $('#txtBkrResume').val(item.BkrResume);
                    $('#txtBkrDateStart').val(item.BkrDateStart);
                    $('#txtBkrDateEnd').val(item.BkrDateEnd);
                    if (item.BkFlag == 0) {
                 ");
            WriteLiteral(@"       $('#Reading').addClass('hide')
                    } else {
                        $('#Reading').removeClass('hide')
                    }
                    $(""#modalBook"").modal({
                        backdrop: 'static'
                    }, 'show');
                });


            }
        });


    };

    function AddBookRead() {
        var id = $('#txtIdBook').val();
        var resume = $('#txtResume').val();
        var dateStart = $('#txtDateStart').val();
        var dateEnd = $('#txtDateEnd').val();

         $.ajax({
            type: ""POST"",
            url: '");
#nullable restore
#line 228 "C:\Users\mathe\Desktop\matheus\Site\Site\Views\Disciplina\Index.cshtml"
             Write(Url.Action("AddBookRead", "Book"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
             data: {
                 id: id,
                 resume: resume,
                 start: dateStart,
                 end: dateEnd
             },
            dataType: ""json"",
            success: function (dados) {


            }
        });
    }

    function Open(idBook, name) {
        $('#txtIdBook').val(idBook.textContent);
        $('#txtName').val(name.textContent);

        $(""#modal"").modal({
            backdrop: 'static'
        }, 'show');
    };

    function Remove(idBook) {

         $.ajax({
            type: ""POST"",
            url: '");
#nullable restore
#line 256 "C:\Users\mathe\Desktop\matheus\Site\Site\Views\Disciplina\Index.cshtml"
             Write(Url.Action("RemoveBook", "Book"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
             data: {
                 id: idBook.textContent,
             },
            dataType: ""json"",
            success: function (dados) {


            }
        });
    }

    function Update() {

        var id = $('#txtBkId').val();
        var name = $('#txtBkName').val();
        var indication = $('#txtBkIndication').val();
        var saga = $('#txtBkSaga').val();

         $.ajax({
            type: ""POST"",
            url: '");
#nullable restore
#line 277 "C:\Users\mathe\Desktop\matheus\Site\Site\Views\Disciplina\Index.cshtml"
             Write(Url.Action("UpdBook", "Book"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"',
             data: {
                 id: id,
                 name: name,
                 indication: indication,
                 saga: saga
             },
            dataType: ""json"",
            success: function (dados) {

                console.log(""teste"");
            }
        });
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591