#pragma checksum "H:\APK Kerjaan\ExamOnline\ExamOnline\Views\Roles\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "d6cb40a745f113d7cdd5b57088eea123c604d188"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Roles_Index), @"mvc.1.0.view", @"/Views/Roles/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Roles/Index.cshtml", typeof(AspNetCore.Views_Roles_Index))]
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
#line 1 "H:\APK Kerjaan\ExamOnline\ExamOnline\Views\_ViewImports.cshtml"
using ExamOnline;

#line default
#line hidden
#line 2 "H:\APK Kerjaan\ExamOnline\ExamOnline\Views\_ViewImports.cshtml"
using ExamOnline.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"d6cb40a745f113d7cdd5b57088eea123c604d188", @"/Views/Roles/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b06b308882244da779d917bc5f737a017d1ff44f", @"/Views/_ViewImports.cshtml")]
    public class Views_Roles_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("enctype", new global::Microsoft.AspNetCore.Html.HtmlString("multipart/form-data"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Asset/DataTables/DataTables-1.10.18/js/jquery.dataTables.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("text/javascript"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Asset/DataTables/DataTables-1.10.18/js/dataTables.bootstrap4.min.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "H:\APK Kerjaan\ExamOnline\ExamOnline\Views\Roles\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Layout/Layout.cshtml";

#line default
#line hidden
            BeginContext(89, 1466, true);
            WriteLiteral(@"<div style=""padding: 25px;"" class=""animated fadeIn"">
    <div class=""row"">
        <div class=""col-md-6"">
            <h5 style=""font-size: 25px;"">Role</h5>
        </div>
        <div class=""col-md-6"">
            <button style=""float: right; margin:5px"" type=""button"" class=""btn btn-primary"" data-toggle=""modal"" data-target=""#myModal"" data-backdrop=""static"" data-keyboard=""false"" onclick=""ClearScreen();""><i class=""fa fa-plus""></i>&nbsp;Add Data</button>
        </div>
    </div>
    <hr>
    <table id=""table"" align=""center"" class=""table table-hover table-bordered table-responsive-sm table-striped"">
        <thead class=""thead-light"" style=""text-align: center;"">
            <tr>
                <th>Name</th>
                <th>Action</th>
            </tr>
        </thead>
    </table>
</div>

<div class=""modal fade"" id=""myModal"" tabindex=""-1"" role=""dialog"" aria-labelledby=""exampleModalCenterTitle"" aria-hidden=""true"">
    <div class=""modal-dialog modal-lg modal-dialog-centered"" role=""docum");
            WriteLiteral(@"ent"">
        <div class=""modal-content"">
            <div class=""modal-header"">
                <h5 class=""modal-title"" id=""exampleModalLongTitle"" onclick=""ClearScreen();"">Add</h5>
                <button type=""button"" class=""close"" data-dismiss=""modal"" aria-label=""Close"">
                    <span aria-hidden=""true"">&times;</span>
                </button>
            </div>
            <div class=""modal-body"">
                ");
            EndContext();
            BeginContext(1555, 1900, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1003b43e91244fd8b25f7589217af9c7", async() => {
                BeginContext(1605, 181, true);
                WriteLiteral("\r\n                    <div class=\"row\">\r\n                        <div class=\"col-md-12\" style=\"border-right: 1px #eee solid\">\r\n                            <div class=\"form-group\">\r\n");
                EndContext();
                BeginContext(1850, 106, true);
                WriteLiteral("                                <input type=\"hidden\" class=\"form-control\" id=\"idtext\" placeholder=\"Id\" /> ");
                EndContext();
                BeginContext(2079, 1369, true);
                WriteLiteral(@"
                            </div>
                            <label for=""name"">Role Name</label>
                            <div class=""input-group mb-3"">
                                <div class=""input-group-prepend"">
                                    <span class=""input-group-text"" id=""basic-addon1""><i class=""fa fa-user""></i></span>
                                </div>
                                <input id=""nametext"" type=""text"" class=""form-control"" required="""" placeholder=""Name"">
                            </div>
                            <div class=""padding-top: 60px"">
                                <hr>
                                <div class=""form-group"" align=""right"">
                                    <button type=""button"" class=""btn btn-success"" id=""Save"" onclick=""Validation();""><i class=""fa fa-check""></i>&nbsp;&nbsp;Save</button>
                                    <button type=""button"" class=""btn btn-primary"" id=""Update"" onclick=""Validation();""><i class=""fa fa-edit");
                WriteLiteral(@"""></i>&nbsp;&nbsp;Update</button>
                                    <button type=""button"" class=""btn btn-danger"" data-dismiss=""modal""><i class=""fa fa-close""></i>&nbsp;&nbsp;Cancel</button>
                                </div>
                            </div>
                        </div>
                    </div>
                ");
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
            BeginContext(3455, 202, true);
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n<link rel=\"stylesheet\" href=\"https://cdnjs.cloudflare.com/ajax/libs/malihu-custom-scrollbar-plugin/3.1.5/jquery.mCustomScrollbar.min.css\">\r\n\r\n");
            EndContext();
            DefineSection("Scripts", async() => {
                BeginContext(3674, 149, true);
                WriteLiteral("\r\n    <script src=\"https://cdnjs.cloudflare.com/ajax/libs/malihu-custom-scrollbar-plugin/3.1.5/jquery.mCustomScrollbar.concat.min.js\"></script>\r\n    ");
                EndContext();
                BeginContext(3823, 112, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "00dade853ab249d49f072f6f09aec080", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(3935, 6, true);
                WriteLiteral("\r\n    ");
                EndContext();
                BeginContext(3941, 116, false);
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "b57d3ec7ad6b456591ae9265b761d3df", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                EndContext();
                BeginContext(4057, 6397, true);
                WriteLiteral(@"
    <script type=""text/javascript"">
        $(document).ready(function () {
            $(""#sidebar"").mCustomScrollbar({
                theme: ""minimal""
            });

            $('#sidebarCollapse').on('click', function () {
                $('#sidebar, #content').toggleClass('active');
                $('.collapse.in').toggleClass('in');
                $('a[aria-expanded=true]').attr('aria-expanded', 'false');
            });
        });
    </script>
    <script>
        $(document).ready(function () {
            debugger;
            $(""#table"").DataTable({
                ""ajax"": {
                    ""url"": ""/Roles/List"",
                    ""type"": ""GET"",
                    ""datatype"": ""json""
                },
                ""columns"": [
                    { ""data"": ""name"" },
                    {
                        ""render"": function (data, type, row, meta) {
                            return ""<a class='btn btn-warning' onclick = GetById('"" + row.id + ""');>");
                WriteLiteral(@"Edit</a> "" +
                                "" <a class='btn btn-danger' onclick = Delete('"" + row.id + ""');>Delete</a>"";
                        }
                    }
                ]
            });
        });

        function Delete(Id) {
            Swal.fire({
                title: 'Are you sure?',
                text: ""You won't be able to revert this!"",
                icon: 'warning',
                showCancelButton: true,
                confirmButtonColor: '#3085d6',
                cancelButtonColor: '#d33',
                confirmButtonText: 'Yes, delete it!'
            }).then((result) => {
                debugger;
                if (result.value) {
                    $.ajax({
                        ""url"": ""/Roles/Delete"",
                        ""datatype"": ""json"",
                        ""data"": { Id: Id }
                    }).then((hasil) => {
                        if (hasil.data != 0) {
                            Swal.fire(
                        ");
                WriteLiteral(@"        'Success!',
                                'Your file has been Deleted.',
                                'success'
                            ).then(() => {
                                $('#table').DataTable().ajax.reload();
                            })
                        }
                        else {
                            Swal.fire(
                                'Failed!',
                                'Your file has not Deleted.',
                                'Failed'
                            ).then(() => {
                                $('#table').DataTable().ajax.reload();
                            })
                        }
                    })
                }
            })
        }
        function Edit(id) {
            debugger;
            var role = new Object();
            role.id = $(""#idtext"").val();
            role.name = $(""#nametext"").val();
            $.ajax({
                ""url"": ""/Roles/Edit"",
              ");
                WriteLiteral(@"  ""type"": ""POST"",
                ""datatype"": ""json"",
                ""data"": role
            }).then((result) => {
                debugger;
                if (result.data != null) {
                    Swal.fire(
                        'Success!',
                        'Your file has been Updated.',
                        'success'
                    ).then(() => {
                        $('#table').DataTable().ajax.reload();
                    })
                }
                else {
                    Swal.fire(
                        'Failed!',
                        'Your file has not Updated.',
                        'Failed'
                    ).then(() => {
                        $('#table').DataTable().ajax.reload();
                    })
                }
                $(""#myModal"").modal('hide');
                $('#table').DataTable().ajax.reload();
            })
        }
        function Save() {
            debugger;
            var role = new");
                WriteLiteral(@" Object();
            role.name = $(""#nametext"").val();
            $.ajax({
                ""url"": ""/Roles/Create"",
                ""type"": ""POST"",
                ""datatype"": ""json"",
                ""data"": role
            }).then((result) => {
                debugger;
                if (result.statusCode == 200) {
                    Swal.fire({
                        text: 'Success!',
                        title: 'Your file has been Create.',
                        icon: 'success'
                    }).then((hasil) => {
                        $(""#table"").DataTable().ajax.reload();
                    });
                    $(""#myModal"").modal(""hide"");
                }
                else {
                    Swal.fire(
                        'Failed!',
                        'Your file has not Save.',
                        'Failed'
                    )
                }
            })
        }
        function ClearScreen() {
            document.getElement");
                WriteLiteral(@"ById(""idtext"").disabled = true;
            $(""#idtext"").val('');
            $(""#nametext"").val('');
            $(""#Update"").hide();
            $(""#Save"").show();
        }
        function GetById(id) {
            $.ajax({
                ""url"": ""/Roles/Details"",
                ""type"": ""GET"",
                ""datatype"": ""json"",
                ""data"": { id: id }
            }).then((result) => {
                debugger;
                if (result.data != null) {
                    document.getElementById(""idtext"").disabled = true;
                    $(""#idtext"").val(result.data.id);
                    $(""#nametext"").val(result.data.name);

                    $(""#myModal"").modal('show');
                    $(""#Update"").show();
                    $(""#Save"").hide();
                }
            })
        }
        function Validation() {
            debugger;
            if ($(""#nametext"").val() == """" || $(""#nametext"").val() == "" "") {
                Swal.fire('Please F");
                WriteLiteral("ill Name\');\r\n            }\r\n            else if ($(\"#idtext\").val() == \"\" || $(\"#idtext\").val() == \" \") {\r\n                Save();\r\n            }\r\n            else {\r\n                Edit($(\"#idtext\").val());\r\n            }\r\n\r\n        }\r\n    </script>\r\n");
                EndContext();
            }
            );
            BeginContext(10457, 4, true);
            WriteLiteral("\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591
