#pragma checksum "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Dashboard\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6989454cc1de31df5cf523427ec2345ce52574af"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Dashboard_Index), @"mvc.1.0.view", @"/Views/Dashboard/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6989454cc1de31df5cf523427ec2345ce52574af", @"/Views/Dashboard/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a4fa6f9f695df7b94c736277654979c16dec287f", @"/Views/_ViewImports.cshtml")]
    public class Views_Dashboard_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dashboardClass>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Home", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("btn btn-primary"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:auto;position:center"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Projectt", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("style", new global::Microsoft.AspNetCore.Html.HtmlString("width:auto"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Position", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#nullable restore
#line 3 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Dashboard\Index.cshtml"
  
    ViewData["Title"] = "Index";

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
                    <div class=""page-title"">Welcome <a style=""color:blue"">");
#nullable restore
#line 13 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Dashboard\Index.cshtml"
                                                                     Write(User.Identity.Name);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</a> to Dashboard</div>
                </div>
               
            </div>
        </div>
        <!-- start widget -->
        <div class=""state-overview"">
            <div class=""row"">



                <div class=""col-xl-3 col-md-6 col-12"">
                    <div class=""info-box bg-b-yellow"">
                        <span class=""info-box-icon push-bottom""><i data-feather=""users""></i></span>
                        <div class=""info-box-content"">
                            <span class=""info-box-text"">Total Employees</span>
                            <span class=""info-box-number""><strong style=""color:black;font-size:30px"">");
#nullable restore
#line 29 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Dashboard\Index.cshtml"
                                                                                                Write(Model.EmployeeList.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</strong></span>
                            <div class=""progress"">
                                <div class=""progress-bar"" style=""width: 80%""></div>
                            </div>
                            <span class=""progress-description"">
                                48% Increase in 28 Days
                            </span>
                        </div>
                        <div class=""card-footer text-secondary"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6989454cc1de31df5cf523427ec2345ce52574af7991", async() => {
                WriteLiteral("Employee List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_3);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </div>

                        <!-- /.info-box-content -->
                    </div>
                    <!-- /.info-box -->
                </div>





                <div class=""col-xl-3 col-md-6 col-12"">
                    <div class=""info-box bg-b-green"">
                        <span class=""info-box-icon push-bottom""><i data-feather=""users""></i></span>
                        <div class=""info-box-content"">
                            <span class=""info-box-text"">Total Students</span>
                            <span class=""info-box-number"">");
#nullable restore
#line 55 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Dashboard\Index.cshtml"
                                                     Write(Model.ProjecttList.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                            <div class=""progress"">
                                <div class=""progress-bar"" style=""width: 45%""></div>
                            </div>
                            <span class=""progress-description"">
                                45% Increase in 28 Days
                            </span>
                        </div>
                        <div class=""card-footer text-secondary"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6989454cc1de31df5cf523427ec2345ce52574af10908", async() => {
                WriteLiteral("Projectt List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                        </div>\r\n\r\n                        <!-- /.info-box-content -->\r\n                    </div>\r\n                    <!-- /.info-box -->\r\n                </div>\r\n                <!-- /.col -->\r\n\r\n");
#nullable restore
#line 73 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Dashboard\Index.cshtml"
                 if (signInManager.IsSignedIn(User) && User.IsInRole("Admin"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"                    <div class=""col-xl-3 col-md-6 col-12"">
                        <div class=""info-box bg-b-blue"">
                            <span class=""info-box-icon push-bottom""><i data-feather=""users""></i></span>
                            <div class=""info-box-content"">
                                <span class=""info-box-text"">Total Students</span>
                                <span class=""info-box-number"">");
#nullable restore
#line 80 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Dashboard\Index.cshtml"
                                                         Write(Model.PositionList.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                <div class=""progress"">
                                    <div class=""progress-bar"" style=""width: 45%""></div>
                                </div>
                                <span class=""progress-description"">
                                    45% Increase in 28 Days
                                </span>
                            </div>
                            <div class=""card-footer text-secondary"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6989454cc1de31df5cf523427ec2345ce52574af14238", async() => {
                WriteLiteral("Position List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            </div>\r\n\r\n                            <!-- /.info-box-content -->\r\n                        </div>\r\n                        <!-- /.info-box -->\r\n                    </div>\r\n");
#nullable restore
#line 96 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Dashboard\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"



                    <div class=""col-xl-3 col-md-6 col-12"">
                        <div class=""info-box bg-b-pink"">
                            <span class=""info-box-icon push-bottom""><i data-feather=""users""></i></span>
                            <div class=""info-box-content"">
                                <span class=""info-box-text"">Total Students</span>
                                <span class=""info-box-number"">");
#nullable restore
#line 106 "C:\Users\Anonymous\Desktop\Employee Management\Employee Management\Views\Dashboard\Index.cshtml"
                                                         Write(Model.ScheduleList.Count());

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</span>
                                <div class=""progress"">
                                    <div class=""progress-bar"" style=""width: 45%""></div>
                                </div>
                                <span class=""progress-description"">
                                    45% Increase in 28 Days
                                </span>
                            </div>
                            <div class=""card-footer text-secondary"">
                                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "6989454cc1de31df5cf523427ec2345ce52574af17479", async() => {
                WriteLiteral("Position List");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                            </div>

                            <!-- /.info-box-content -->
                        </div>
                        <!-- /.info-box -->
                    </div>

                </div>

        </div>
        <!-- end widget -->
        <!-- start new student list -->
        <div class=""row"">
            <div class=""col-md-12 col-sm-12"">
                <div class=""card  card-box"">
                    <div class=""card-head"">
                        <header>New Employee List</header>
                        <div class=""tools"">
                            <a class=""fa fa-repeat btn-color box-refresh"" href=""javascript:;""></a>
                            <a class=""t-collapse btn-color fa fa-chevron-down"" href=""javascript:;""></a>
                            <a class=""t-close btn-color fa fa-times"" href=""javascript:;""></a>
                        </div>
                    </div>
                    <div class=""card-body "">
                        <div cla");
            WriteLiteral(@"ss=""table-wrap"">
                            <div class=""table-responsive"">
                                <table class=""table display product-overview mb-30"" id=""support_table"">
                                    <thead>
                                        <tr>
                                            <th>No</th>
                                            <th>Name</th>
                                            <th>Assigned Professor</th>
                                            <th>Date Of Admit</th>
                                            <th>Fees</th>
                                            <th>Branch</th>
                                            <th>Edit</th>
                                        </tr>
                                    </thead>
                                    <tbody>
                                        <tr>
                                            <td>1</td>
                                            <td>Jens Brincker</td>
      ");
            WriteLiteral(@"                                      <td>Kenny Josh</td>
                                            <td>27/05/2016</td>
                                            <td>
                                                <span class=""label label-sm label-success"">paid</span>
                                            </td>
                                            <td>Mechanical</td>
                                            <td>
                                                <a href=""javascript:void(0)"" class=""tblEditBtn"">
                                                    <i class=""fa fa-pencil""></i>
                                                </a>
                                                <a href=""javascript:void(0)"" class=""tblDelBtn"">
                                                    <i class=""fa fa-trash-o""></i>
                                                </a>
                                            </td>
                                        </tr>
              ");
            WriteLiteral(@"                          <tr>
                                            <td>2</td>
                                            <td>Mark Hay</td>
                                            <td> Mark</td>
                                            <td>26/05/2017</td>
                                            <td>
                                                <span class=""label label-sm label-warning"">
                                                    unpaid
                                                </span>
                                            </td>
                                            <td>Science</td>
                                            <td>
                                                <a href=""javascript:void(0)"" class=""tblEditBtn"">
                                                    <i class=""fa fa-pencil""></i>
                                                </a>
                                                <a href=""javascript:void(0)"" class=""tblDelB");
            WriteLiteral(@"tn"">
                                                    <i class=""fa fa-trash-o""></i>
                                                </a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>3</td>
                                            <td>Anthony Davie</td>
                                            <td>Cinnabar</td>
                                            <td>21/05/2016</td>
                                            <td>
                                                <span class=""label label-sm label-success "">paid</span>
                                            </td>
                                            <td>Commerce</td>
                                            <td>
                                                <a href=""javascript:void(0)"" class=""tblEditBtn"">
                                                    <i class=""fa fa-");
            WriteLiteral(@"pencil""></i>
                                                </a>
                                                <a href=""javascript:void(0)"" class=""tblDelBtn"">
                                                    <i class=""fa fa-trash-o""></i>
                                                </a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>4</td>
                                            <td>David Perry</td>
                                            <td>Felix </td>
                                            <td>20/04/2016</td>
                                            <td>
                                                <span class=""label label-sm label-danger"">unpaid</span>
                                            </td>
                                            <td>Mechanical</td>
                                            <td>
         ");
            WriteLiteral(@"                                       <a href=""javascript:void(0)"" class=""tblEditBtn"">
                                                    <i class=""fa fa-pencil""></i>
                                                </a>
                                                <a href=""javascript:void(0)"" class=""tblDelBtn"">
                                                    <i class=""fa fa-trash-o""></i>
                                                </a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>5</td>
                                            <td>Anthony Davie</td>
                                            <td>Beryl</td>
                                            <td>24/05/2016</td>
                                            <td>
                                                <span class=""label label-sm label-success "">paid</span>
                 ");
            WriteLiteral(@"                           </td>
                                            <td>M.B.A.</td>
                                            <td>
                                                <a href=""javascript:void(0)"" class=""tblEditBtn"">
                                                    <i class=""fa fa-pencil""></i>
                                                </a>
                                                <a href=""javascript:void(0)"" class=""tblDelBtn"">
                                                    <i class=""fa fa-trash-o""></i>
                                                </a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>6</td>
                                            <td>Alan Gilchrist</td>
                                            <td>Joshep</td>
                                            <td>22/05/2016</td>
                ");
            WriteLiteral(@"                            <td>
                                                <span class=""label label-sm label-warning "">unpaid</span>
                                            </td>
                                            <td>Science</td>
                                            <td>
                                                <a href=""javascript:void(0)"" class=""tblEditBtn"">
                                                    <i class=""fa fa-pencil""></i>
                                                </a>
                                                <a href=""javascript:void(0)"" class=""tblDelBtn"">
                                                    <i class=""fa fa-trash-o""></i>
                                                </a>
                                            </td>
                                        </tr>
                                        <tr>
                                            <td>7</td>
                                            <td>Mark");
            WriteLiteral(@" Hay</td>
                                            <td>Jayesh</td>
                                            <td>18/06/2016</td>
                                            <td>
                                                <span class=""label label-sm label-success "">paid</span>
                                            </td>
                                            <td>Commerce</td>
                                            <td>
                                                <a href=""javascript:void(0)"" class=""tblEditBtn"">
                                                    <i class=""fa fa-pencil""></i>
                                                </a>
                                                <a href=""javascript:void(0)"" class=""tblDelBtn"">
                                                    <i class=""fa fa-trash-o""></i>
                                                </a>
                                            </td>
                                        </tr>
  ");
            WriteLiteral(@"                                      <tr>
                                            <td>8</td>
                                            <td>Sue Woodger</td>
                                            <td>Sharma</td>
                                            <td>17/05/2016</td>
                                            <td>
                                                <span class=""label label-sm label-danger"">unpaid</span>
                                            </td>
                                            <td>Mechanical</td>
                                            <td>
                                                <a href=""javascript:void(0)"" class=""tblEditBtn"">
                                                    <i class=""fa fa-pencil""></i>
                                                </a>
                                                <a href=""javascript:void(0)"" class=""tblDelBtn"">
                                                    <i class=""fa fa-trash-o""></i");
            WriteLiteral(@">
                                                </a>
                                            </td>
                                        </tr>
                                    </tbody>
                                </table>
                            </div>
                        </div>
                    </div>
                </div>
            </div>
        </div>
        <!-- end new student list -->
    </div>
</div>
<!-- end page content -->");
        }
        #pragma warning restore 1998
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public SignInManager<ApplicationUser> signInManager { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; }
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dashboardClass> Html { get; private set; }
    }
}
#pragma warning restore 1591
