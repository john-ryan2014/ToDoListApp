#pragma checksum "C:\Users\John.Ryan\Desktop\ToDoListApp\ToDoListApp\Views\ToDoList\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "19eab7e4b716164fb31832cad982a3e58e23c766"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ToDoList_Index), @"mvc.1.0.view", @"/Views/ToDoList/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/ToDoList/Index.cshtml", typeof(AspNetCore.Views_ToDoList_Index))]
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
#line 1 "C:\Users\John.Ryan\Desktop\ToDoListApp\ToDoListApp\Views\_ViewImports.cshtml"
using ToDoListApp;

#line default
#line hidden
#line 2 "C:\Users\John.Ryan\Desktop\ToDoListApp\ToDoListApp\Views\_ViewImports.cshtml"
using ToDoListApp.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"19eab7e4b716164fb31832cad982a3e58e23c766", @"/Views/ToDoList/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"52f945efe976b1d64c78b43e826c929a1c767a43", @"/Views/_ViewImports.cshtml")]
    public class Views_ToDoList_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ToDoListViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "MarkDone", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "POST", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            BeginContext(26, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 3 "C:\Users\John.Ryan\Desktop\ToDoListApp\ToDoListApp\Views\ToDoList\Index.cshtml"
  
    ViewData["Title"] = "Your ToDo list: ";

#line default
#line hidden
            BeginContext(80, 79, true);
            WriteLiteral("\r\n<div class=\"panel panel-default todo-panel\">\r\n    <div class=\"panel-heading\">");
            EndContext();
            BeginContext(160, 17, false);
#line 8 "C:\Users\John.Ryan\Desktop\ToDoListApp\ToDoListApp\Views\ToDoList\Index.cshtml"
                          Write(ViewData["Title"]);

#line default
#line hidden
            EndContext();
            BeginContext(177, 304, true);
            WriteLiteral(@"</div>

    <table class=""table table-hover table-light table-striped"">
        <thead class=""thead-dark"">
            <tr>
                <th>Done</th>
                <th>Task</th>
                <th>Details</th>
                <th>Last Modified</th>
            </tr>
        </thead>

");
            EndContext();
#line 20 "C:\Users\John.Ryan\Desktop\ToDoListApp\ToDoListApp\Views\ToDoList\Index.cshtml"
         foreach (var task in Model.Tasks)
      {

#line default
#line hidden
            BeginContext(534, 48, true);
            WriteLiteral("        <tr>\r\n            <td>\r\n                ");
            EndContext();
            BeginContext(582, 204, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "19eab7e4b716164fb31832cad982a3e58e23c7665284", async() => {
                BeginContext(624, 119, true);
                WriteLiteral("\r\n                    <input type=\"checkbox\" class=\"done-checkbox\">\r\n                    <input type=\"hidden\" name=\"id\"");
                EndContext();
                BeginWriteAttribute("value", " value=\"", 743, "\"", 759, 1);
#line 26 "C:\Users\John.Ryan\Desktop\ToDoListApp\ToDoListApp\Views\ToDoList\Index.cshtml"
WriteAttributeValue("", 751, task.Id, 751, 8, false);

#line default
#line hidden
                EndWriteAttribute();
                BeginContext(760, 19, true);
                WriteLiteral(">\r\n                ");
                EndContext();
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(786, 37, true);
            WriteLiteral("\r\n            </td>\r\n            <td>");
            EndContext();
            BeginContext(824, 10, false);
#line 29 "C:\Users\John.Ryan\Desktop\ToDoListApp\ToDoListApp\Views\ToDoList\Index.cshtml"
           Write(task.Title);

#line default
#line hidden
            EndContext();
            BeginContext(834, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(858, 12, false);
#line 30 "C:\Users\John.Ryan\Desktop\ToDoListApp\ToDoListApp\Views\ToDoList\Index.cshtml"
           Write(task.Details);

#line default
#line hidden
            EndContext();
            BeginContext(870, 23, true);
            WriteLiteral("</td>\r\n            <td>");
            EndContext();
            BeginContext(894, 17, false);
#line 31 "C:\Users\John.Ryan\Desktop\ToDoListApp\ToDoListApp\Views\ToDoList\Index.cshtml"
           Write(task.DateModified);

#line default
#line hidden
            EndContext();
            BeginContext(911, 22, true);
            WriteLiteral("</td>\r\n        </tr>\r\n");
            EndContext();
#line 33 "C:\Users\John.Ryan\Desktop\ToDoListApp\ToDoListApp\Views\ToDoList\Index.cshtml"
      }

#line default
#line hidden
            BeginContext(942, 71, true);
            WriteLiteral("    </table>\r\n\r\n    <div class=\"panel-footer add-item-form \">\r\n        ");
            EndContext();
            BeginContext(1014, 61, false);
#line 37 "C:\Users\John.Ryan\Desktop\ToDoListApp\ToDoListApp\Views\ToDoList\Index.cshtml"
   Write(await Html.PartialAsync("AddTaskPartial", new ToDoListTask()));

#line default
#line hidden
            EndContext();
            BeginContext(1075, 20, true);
            WriteLiteral("\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ToDoListViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591