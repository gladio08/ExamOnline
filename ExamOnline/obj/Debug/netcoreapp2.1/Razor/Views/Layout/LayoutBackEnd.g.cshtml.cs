#pragma checksum "D:\GitHUb\sangatBaru\ExamOnline\ExamOnline\Views\Layout\LayoutBackEnd.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "cbff222b0e1e84b309b9562c4a6882c7b86bcc82"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Layout_LayoutBackEnd), @"mvc.1.0.view", @"/Views/Layout/LayoutBackEnd.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Layout/LayoutBackEnd.cshtml", typeof(AspNetCore.Views_Layout_LayoutBackEnd))]
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
#line 1 "D:\GitHUb\sangatBaru\ExamOnline\ExamOnline\Views\_ViewImports.cshtml"
using ExamOnline;

#line default
#line hidden
#line 2 "D:\GitHUb\sangatBaru\ExamOnline\ExamOnline\Views\_ViewImports.cshtml"
using ExamOnline.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"cbff222b0e1e84b309b9562c4a6882c7b86bcc82", @"/Views/Layout/LayoutBackEnd.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b06b308882244da779d917bc5f737a017d1ff44f", @"/Views/_ViewImports.cshtml")]
    public class Views_Layout_LayoutBackEnd : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("background-color: #2780E3;"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "D:\GitHUb\sangatBaru\ExamOnline\ExamOnline\Views\Layout\LayoutBackEnd.cshtml"
  
    Layout = null;

#line default
#line hidden
            BeginContext(29, 25, true);
            WriteLiteral("<!DOCTYPE html>\r\n<html>\r\n");
            EndContext();
            BeginContext(54, 452, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9be11df7ad074fd788c56008a6016734", async() => {
                BeginContext(60, 439, true);
                WriteLiteral(@"
    <title>Bootstrap Example</title>
    <meta charset=""utf-8"">
    <meta name=""viewport"" content=""width=device-width, initial-scale=1"">
    <link rel=""stylesheet"" href=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css"">
    <script src=""https://ajax.googleapis.com/ajax/libs/jquery/3.4.1/jquery.min.js""></script>
    <script src=""https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/js/bootstrap.min.js""></script>
");
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
            BeginContext(506, 2, true);
            WriteLiteral("\r\n");
            EndContext();
            BeginContext(508, 754, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "75c420a071d14ddf852814605090654c", async() => {
                BeginContext(549, 555, true);
                WriteLiteral(@"
    <div>
        <!--Header Konten-->
        <div class=""rowmargin"" style=""padding: 20px; background-color:  mediumblue"">
            <div style=""font-weight: bold;font-family: Bahnschrift SemiBold;color: white; font-size: 12px"">
                <label> &nbsp;&nbsp;&nbsp;Exam Online &nbsp;&nbsp;&nbsp; </label>
                <label id=""watch""></label>
            </div>
        </div>
        <!-- Halaman Isi -->
        <div class=""content-wrapper"">
            <div class=""contet-header"">
                <div >
                    ");
                EndContext();
                BeginContext(1105, 12, false);
#line 28 "D:\GitHUb\sangatBaru\ExamOnline\ExamOnline\Views\Layout\LayoutBackEnd.cshtml"
               Write(RenderBody());

#line default
#line hidden
                EndContext();
                BeginContext(1117, 94, true);
                WriteLiteral("\r\n                </div>\r\n            </div>\r\n        </div>\r\n        <br>\r\n\r\n    </div>\r\n    ");
                EndContext();
                BeginContext(1212, 41, false);
#line 35 "D:\GitHUb\sangatBaru\ExamOnline\ExamOnline\Views\Layout\LayoutBackEnd.cshtml"
Write(RenderSection("Scripts", required: false));

#line default
#line hidden
                EndContext();
                BeginContext(1253, 2, true);
                WriteLiteral("\r\n");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1262, 541, true);
            WriteLiteral(@"

</html>

<script type=""text/javascript"">
    $(document).ready(function () {
        function clock() {
            var now = new Date();
            var secs = ('0' + now.getSeconds()).slice(-2);
            var mins = ('0' + now.getMinutes()).slice(-2);
            var hr = now.getHours();
            var Time = hr + "":"" + mins + "":"" + secs;
            document.getElementById(""watch"").innerHTML = Time;
            requestAnimationFrame(clock);
        }

        requestAnimationFrame(clock);
    });
</script>

");
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