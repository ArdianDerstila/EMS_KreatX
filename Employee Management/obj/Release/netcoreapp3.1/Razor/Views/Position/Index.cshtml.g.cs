#pragma checksum "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Position\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "ed0ac38b74e00867e1d555996e63c028a6684479"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Position_Index), @"mvc.1.0.view", @"/Views/Position/Index.cshtml")]
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
#line 1 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\_ViewImports.cshtml"
using Employee_Management.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\_ViewImports.cshtml"
using Employee_Management.ViewModel;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\_ViewImports.cshtml"
using Microsoft.AspNetCore.Identity;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"ed0ac38b74e00867e1d555996e63c028a6684479", @"/Views/Position/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4fa6f9f695df7b94c736277654979c16dec287f", @"/Views/_ViewImports.cshtml")]
    public class Views_Position_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<Position>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/js/customScript.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Position", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Position\Index.cshtml"
   ViewBag.Title = "Position List"; 

#line default
#line hidden
#nullable disable
            WriteLiteral("\n\n<div id=\"PlaceHolderHere\"></div>\n\n\n\n");
            DefineSection("scripts", async() => {
                WriteLiteral("\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed0ac38b74e00867e1d555996e63c028a66844795326", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\n");
            }
            );
            WriteLiteral(@"
<!-- start page content -->
<div class=""page-content-wrapper"">
    <div class=""page-content"">
        <div class=""page-bar"">
            <div class=""page-title-breadcrumb"">
                <div class="" pull-left"">
                    <div class=""page-title"">Task List</div>
                </div>

            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12"">
                <div class=""tabbable-line"">

                    <div class=""tab-content"">
                        <div class=""tab-pane active fontawesome-demo"" id=""tab1"">
                            <div class=""row"">
                                <div class=""col-md-12"">
                                    <div class=""card card-box"">
                                        <div class=""card-head"">
                                            <header>Create Task</header>
                                            <div class=""tools"">
                                                <a class=""fa fa-repeat btn-color box-refre");
            WriteLiteral(@"sh"" href=""javascript:;""></a>
                                                <a class=""t-collapse btn-color fa fa-chevron-down"" href=""javascript:;""></a>
                                                <a class=""t-close btn-color fa fa-times"" href=""javascript:;""></a>
                                            </div>
                                        </div>
                                        <div class=""card-body "">
                                            <div class=""row"">
                                                <button type=""button"" class=""btn btn-primary m-1"" style=""width:auto"" data-toggle=""ajax-modal"" data-target=""#addModal""
                                                        data-url=""");
#nullable restore
#line 45 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Position\Index.cshtml"
                                                             Write(Url.Action("Create"));

#line default
#line hidden
#nullable disable
            WriteLiteral(@""">
                                                    Create New
                                                </button>
                                            </div>
                                            <table class=""table table-striped table-bordered table-hover table-checkable order-column valign-middle"" id=""example4"">
                                                <thead>
                                                    <tr>
                                                        <th>Task No:</th>
                                                        <th>Title_Task:</th>
                                                        <th>Description</th>
                                                        <th>Status</th>
                                                        <th>Priority</th>
                                                        <th>%Completed</th>
                                                        <th>AssingTask</th>
                                              ");
            WriteLiteral("          <th>Action</th>\n                                                    </tr>\n                                                </thead>\n                                                <tbody>\n");
#nullable restore
#line 63 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Position\Index.cshtml"
                                                     foreach (var position in Model)
                                                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                                <tr></tr>\n                                                <tr class=\"odd gradeX\">\n\n                                                    <td>");
#nullable restore
#line 68 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Position\Index.cshtml"
                                                   Write(position.PositionID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                    <td>");
#nullable restore
#line 69 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Position\Index.cshtml"
                                                   Write(position.Title);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                    <td>");
#nullable restore
#line 70 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Position\Index.cshtml"
                                                   Write(position.PositionName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                                                    <td>");
#nullable restore
#line 72 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Position\Index.cshtml"
                                                   Write(position.Status);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                    <td>");
#nullable restore
#line 73 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Position\Index.cshtml"
                                                   Write(position.Priority);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                    <td>");
#nullable restore
#line 74 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Position\Index.cshtml"
                                                   Write(position.Completed);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n                                                    <td>");
#nullable restore
#line 75 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Position\Index.cshtml"
                                                   Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\n\n                                                    <td>\n                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "ed0ac38b74e00867e1d555996e63c028a668447912918", async() => {
                WriteLiteral(@"

                                                            <button type=""button"" class=""btn btn-primary m-1"" style=""width:auto"" data-toggle=""ajax-modal"" data-target=""#addModal""
                                                                    data-url=""");
#nullable restore
#line 81 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Position\Index.cshtml"
                                                                         Write(Url.Action($"Edit/{position.PositionID}"));

#line default
#line hidden
#nullable disable
                WriteLiteral("\">\n                                                                Edit\n                                                            </button>\n                                                            <button type=\"submit\" class=\"btn btn-danger\"");
                BeginWriteAttribute("onclick", " onclick=\"", 4761, "\"", 4848, 11);
                WriteAttributeValue("", 4771, "return", 4771, 6, true);
                WriteAttributeValue(" ", 4777, "confirm(\'Are", 4778, 13, true);
                WriteAttributeValue(" ", 4790, "you", 4791, 4, true);
                WriteAttributeValue(" ", 4794, "sure", 4795, 5, true);
                WriteAttributeValue(" ", 4799, "you", 4800, 4, true);
                WriteAttributeValue(" ", 4803, "want", 4804, 5, true);
                WriteAttributeValue(" ", 4808, "to", 4809, 3, true);
                WriteAttributeValue(" ", 4811, "Delete", 4812, 7, true);
                WriteAttributeValue(" ", 4818, "this", 4819, 5, true);
#nullable restore
#line 84 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Position\Index.cshtml"
WriteAttributeValue(" ", 4823, position.PositionName, 4824, 22, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4846, "\')", 4846, 2, true);
                EndWriteAttribute();
                WriteLiteral(">Delete</button>\n                                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Position\Index.cshtml"
                                                                                                              WriteLiteral(position.PositionID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                                    </td>\n\n\n\n                                                </tr>\n");
#nullable restore
#line 91 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Position\Index.cshtml"
}

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                </tbody>
                                            </table>
                                        </div>
                                    </div>
                                </div>
                            </div>
                        </div>

                    </div>
                </div>
            </div>
        </div>
    </div>
</div>
<!-- end page content -->");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<Position>> Html { get; private set; }
    }
}
#pragma warning restore 1591