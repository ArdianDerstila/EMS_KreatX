#pragma checksum "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Administration\ListRoles.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "4e1bc86c77c440326fda76a060f522736897f674"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Administration_ListRoles), @"mvc.1.0.view", @"/Views/Administration/ListRoles.cshtml")]
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
#nullable restore
#line 3 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Administration\ListRoles.cshtml"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"4e1bc86c77c440326fda76a060f522736897f674", @"/Views/Administration/ListRoles.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4fa6f9f695df7b94c736277654979c16dec287f", @"/Views/_ViewImports.cshtml")]
    public class Views_Administration_ListRoles : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<IdentityRole>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary mb-3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Administration", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "DeleteRole", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
            WriteLiteral("\n");
            WriteLiteral("\n");
#nullable restore
#line 7 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Administration\ListRoles.cshtml"
   ViewData["Title"] = "ListRoles"; 

#line default
#line hidden
#nullable disable
            WriteLiteral(@"




<!-- start page content -->

<div class=""page-content-wrapper"">
    <div class=""page-content"">
        <div class=""page-bar"">
            <div class=""page-title-breadcrumb"">
                <div class="" pull-left"">
                    <div class=""page-title"">List Roles</div>
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
                                            <header>User Roles</header>
                                            <div class=""tools"">
                                                <a class=""fa fa-repeat btn-color box-");
            WriteLiteral(@"refresh"" href=""javascript:;""></a>
                                                <a class=""t-collapse btn-color fa fa-chevron-down"" href=""javascript:;""></a>
                                                <a class=""t-close btn-color fa fa-times"" href=""javascript:;""></a>
                                            </div>
                                        </div>

                                        <div class=""card-body "">
                                            <div class=""row"">
                                                <div class=""col-md-6 col-sm-6 col-6"">
                                                    <div class=""btn-group"">
                                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e1bc86c77c440326fda76a060f522736897f6748668", async() => {
                WriteLiteral("Create New Role");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
                                                </div>
                                            </div>
                                            <table class=""table table-striped table-bordered table-hover table-checkable order-column valign-middle"" id=""example4"">
                                                <thead>
                                                    <tr>
                                                        <th></th>
                                                        <th>
                                                            ");
#nullable restore
#line 56 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Administration\ListRoles.cshtml"
                                                       Write(Html.DisplayNameFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
                                                        </th>
                                                        <th></th>
                                                    </tr>
                                                </thead>
                                                <tbody>
");
#nullable restore
#line 62 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Administration\ListRoles.cshtml"
                                                     if (Model.Any())
                                                    {
                                                        foreach (var item in Model)
                                                        {


#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                    <tr class=""odd gradeX"">
                                                        <td>
                                                        
                                                        </td>

                                                        <td>
                                                            ");
#nullable restore
#line 73 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Administration\ListRoles.cshtml"
                                                       Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\n                                                        </td>\n\n\n                                                        <td>\n                                                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e1bc86c77c440326fda76a060f522736897f67412629", async() => {
                WriteLiteral("\n");
#nullable restore
#line 79 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Administration\ListRoles.cshtml"
                                                                 if ((await authorizationService.AuthorizeAsync(User, "EditRolePolicy")).Succeeded)
                                                                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                                    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "4e1bc86c77c440326fda76a060f522736897f67413373", async() => {
                    WriteLiteral("Edit");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_4.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
                if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
                {
                    throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
                }
                BeginWriteTagHelperAttribute();
#nullable restore
#line 81 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Administration\ListRoles.cshtml"
                                                                                                                                       WriteLiteral(item.Id);

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
#nullable restore
#line 81 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Administration\ListRoles.cshtml"
                                                                                                                                                                     }

#line default
#line hidden
#nullable disable
                WriteLiteral("\n                                                                <button type=\"submit\" class=\"btn btn-danger\"");
                BeginWriteAttribute("onclick", "\n                                                                        onclick=\"", 4434, "\"", 4583, 12);
                WriteAttributeValue("", 4516, "return", 4516, 6, true);
                WriteAttributeValue(" ", 4522, "confirm(\'Are", 4523, 13, true);
                WriteAttributeValue(" ", 4535, "you", 4536, 4, true);
                WriteAttributeValue(" ", 4539, "sure", 4540, 5, true);
                WriteAttributeValue(" ", 4544, "you", 4545, 4, true);
                WriteAttributeValue(" ", 4548, "want", 4549, 5, true);
                WriteAttributeValue(" ", 4553, "to", 4554, 3, true);
                WriteAttributeValue(" ", 4556, "delete", 4557, 7, true);
                WriteAttributeValue(" ", 4563, "user", 4564, 5, true);
                WriteAttributeValue(" ", 4568, ":", 4569, 2, true);
#nullable restore
#line 84 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Administration\ListRoles.cshtml"
WriteAttributeValue(" ", 4570, item.Name, 4571, 10, false);

#line default
#line hidden
#nullable disable
                WriteAttributeValue("", 4581, "\')", 4581, 2, true);
                EndWriteAttribute();
                WriteLiteral(">\n                                                                    Delete\n                                                                </button>\n                                                            ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 78 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Administration\ListRoles.cshtml"
                                                                                                                            WriteLiteral(item.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\n                                                        </td>\n                                                    </tr> ");
#nullable restore
#line 89 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Administration\ListRoles.cshtml"
                                                          }
                                                            }
                                                            else
                                                            {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                                                <tr>
                                                    <td>
                                                        <h2>No Roles Created yet</h2>
                                                    </td>
                                                </tr>");
#nullable restore
#line 97 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Administration\ListRoles.cshtml"
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
</div> <!-- end page content -->
");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public IAuthorizationService authorizationService { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<IdentityRole>> Html { get; private set; }
    }
}
#pragma warning restore 1591
