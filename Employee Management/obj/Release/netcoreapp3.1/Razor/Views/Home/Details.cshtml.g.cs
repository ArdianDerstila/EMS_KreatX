#pragma checksum "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Home\Details.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "51af0af124032a89dc6696982cd0f1be8d4d6fdf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Details), @"mvc.1.0.view", @"/Views/Home/Details.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"51af0af124032a89dc6696982cd0f1be8d4d6fdf", @"/Views/Home/Details.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4fa6f9f695df7b94c736277654979c16dec287f", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Details : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Employee>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("image"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\n");
#nullable restore
#line 3 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Home\Details.cshtml"
   ViewData["Title"] = "Details";
                var photoPath = "~/images/" + (Model.PhotoPath ?? null); 

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
                    <div class=""page-title"">Your Profile ");
#nullable restore
#line 15 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Home\Details.cshtml"
                                                    Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</div>
                </div>
                
            </div>
        </div>
        <div class=""row"">
            <div class=""col-md-12"">
                <!-- BEGIN PROFILE SIDEBAR -->
                <div class=""profile-sidebar"">
                    <div class=""card"">
                        <div class=""card-body no-padding height-9"">
                            <div class=""image"">
                                <div class=""profile-content"">
                                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "51af0af124032a89dc6696982cd0f1be8d4d6fdf5081", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.ImageTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper);
            BeginWriteTagHelperAttribute();
#nullable restore
#line 28 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Home\Details.cshtml"
                                  WriteLiteral(photoPath);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("src", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.Src, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 28 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Home\Details.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion = true;

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-append-version", __Microsoft_AspNetCore_Mvc_TagHelpers_ImageTagHelper.AppendVersion, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(" \n                                </div>\n                            </div>\n                            <div class=\"profile-usertitle\">\n                                <div class=\"profile-usertitle-name\">  ");
#nullable restore
#line 32 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Home\Details.cshtml"
                                                                 Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("</div>\n                            </div>\n\n                            <ul class=\"list-group list-group-unbordered\">\n                                <li class=\"list-group-item\">\n                                    <b>");
#nullable restore
#line 37 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Home\Details.cshtml"
                                  Write(Html.DisplayNameFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> <a class=\"pull-right\"> ");
#nullable restore
#line 37 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Home\Details.cshtml"
                                                                                                     Write(Html.DisplayFor(model => model.ID));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                </li>\n                                <li class=\"list-group-item\">\n                                    <b>");
#nullable restore
#line 40 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Home\Details.cshtml"
                                  Write(Html.DisplayNameFor(model => model.Projectt));

#line default
#line hidden
#nullable disable
            WriteLiteral("</b> <a class=\"pull-right\"> ");
#nullable restore
#line 40 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Home\Details.cshtml"
                                                                                                           Write(Html.DisplayFor(model => model.Projectt));

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\n                                </li>\n                                <li class=\"list-group-item\">\n                                    <b>First Name</b> <a class=\"pull-right\">");
#nullable restore
#line 43 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Home\Details.cshtml"
                                                                       Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                </li>
                                <li class=""list-group-item"">
                                    <b>Last Name</b> <a class=""pull-right"">test</a>
                                </li>
                                <li class=""list-group-item"">
                                    <b>Email</b> <a class=""pull-right""> ");
#nullable restore
#line 49 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Home\Details.cshtml"
                                                                   Write(Html.DisplayFor(model => model.Email));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a>
                                </li>
                            </ul>
                            <!-- END SIDEBAR USER TITLE -->
                          
                        </div>
                    </div>
                    
                   
                   
                </div>
                <!-- END BEGIN PROFILE SIDEBAR -->
                <!-- BEGIN PROFILE CONTENT -->
                <div class=""profile-content"">
                    <div class=""row"">
                        <div class=""card"">
                            <div class=""card-topline-aqua"">
                                <header></header>
                            </div>
                            <div class=""white-box"">
                                <!-- Nav tabs -->
                                <div class=""p-rl-20"">
                                    <ul class=""nav customtab nav-tabs"" role=""tablist"">
                                        <li class=""nav-item""><a href=""#tab1"" class=""nav-link active"" data");
            WriteLiteral(@"-bs-toggle=""tab"">About Me</a></li>
                                        <li class=""nav-item""><a href=""#tab2"" class=""nav-link"" data-bs-toggle=""tab"">Activity</a></li>
                                    </ul>
                                </div>
                                <!-- Tab panes -->
                                <div class=""tab-content"">
                                    <div class=""tab-pane active fontawesome-demo"" id=""tab1"">
                                        <div id=""biography"">
                                            <div class=""row"">
                                                <div class=""col-md-3 col-6 b-r"">
                                                    <strong>Full Name</strong>
                                                    <br>
                                                    <p class=""text-muted"">");
#nullable restore
#line 84 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Home\Details.cshtml"
                                                                     Write(Html.DisplayFor(model => model.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</p>
                                                </div>
                                                <div class=""col-md-3 col-6 b-r"">
                                                    <strong>Mobile</strong>
                                                    <br>
                                                    <p class=""text-muted"">(123) 456 7890</p>
                                                </div>
                                                <div class=""col-md-3 col-6 b-r"">
                                                    <strong>Email</strong>
                                                    <br>
                                                    <p class=""text-muted"">test@example.com</p>
                                                </div>
                                                <div class=""col-md-3 col-6"">
                                                    <strong>Location</strong>
                                                    <br>
                           ");
            WriteLiteral(@"                         <p class=""text-muted"">India</p>
                                                </div>
                                            </div>
                                            <hr>
                                            <p>
                                               testfsddgsg
                                            </p>
                                            <p>
                                                Years living creepeth. Form them yielding behold greater
                                                divided void was fowl earth in. Spirit Bring
                                                grass they're you have shall years so morning. Grass
                                                gathering won't heaven set greater darkness forth
                                                abundantly he.
                                            </p>
                                            
                                            <br>
     ");
            WriteLiteral(@"                                      
                                        </div>
                                    </div>
                                   
                                </div>
                            </div>
                        </div>
                    </div>
                </div>
                <!-- END PROFILE CONTENT -->
            </div>
        </div>
    </div>
    <!-- end page content -->
    </div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Employee> Html { get; private set; }
    }
}
#pragma warning restore 1591
