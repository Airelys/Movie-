#pragma checksum "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ccbb7f848e9a256f15ca6c53726b3d41a30f3c3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
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
#line 1 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\_ViewImports.cshtml"
using Movie_PlusPlus;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\_ViewImports.cshtml"
using Movie_PlusPlus.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
using Movie_PlusPlus.Roles;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ccbb7f848e9a256f15ca6c53726b3d41a30f3c3", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23c0bf5f0f935230d2e2f053df093359262d302e", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<Movie_Plus.Services.Pager.GenericPager<Movie_Plus.Data.Movie>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "get", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Create", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "RateMovie", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Horaries", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Edit", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Delete", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 4 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n<h1>Movies</h1>\r\n\r\n");
            WriteLiteral("<div class=\"text-right form-inline\">\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ccbb7f848e9a256f15ca6c53726b3d41a30f3c36355", async() => {
                WriteLiteral("\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 14 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
       Write(Html.TextBox("_title", null, new
            {
                placeholder = "Title",
                @class = "form-control"
            }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 20 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
       Write(Html.TextBox("_country", null, new
            {
                placeholder = "Country",
                @class = "form-control "
            }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 26 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
       Write(Html.TextBox("_kindOfMovie", null, new
            {
                placeholder = "KindOfMovie",
                @class = "form-control "
            }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n        <div class=\"form-group\">\r\n            ");
#nullable restore
#line 34 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
       Write(Html.TextBox("_duration", null, new
            {
            placeholder = "Duration",
            @class = "form-control numbers",
            @oninput = "this.value=this.value.replace(/[^0-9]/g,'')"
            }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 41 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
       Write(Html.TextBox("_ranking", null, new
            {
            placeholder = "Ranking",
            @class = "form-control numbers",
            @oninput = "this.value=this.value.replace(/[^0-9]/g,'')"
            }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n            ");
#nullable restore
#line 48 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
       Write(Html.TextBox("_actor", null, new
            {
                placeholder = "Actor",
                @class = "form-control "
            }));

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n        </div>\r\n        <button class=\"btn btn-default\" type=\"submit\">Search</button>\r\n    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 1, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
#nullable restore
#line 12 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
AddHtmlAttributeValue("", 271, Url.Action("Index", "Movies" ), 271, 31, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</div>\r\n\r\n");
#nullable restore
#line 59 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
 if (User.IsInRole(Roles.Manager.ToString()) || User.IsInRole(Roles.Admin.ToString()))
{

#line default
#line hidden
#nullable disable
            WriteLiteral("    <p>\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ccbb7f848e9a256f15ca6c53726b3d41a30f3c311223", async() => {
                WriteLiteral("Create New");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </p>\r\n");
#nullable restore
#line 64 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
 }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"    <table class=""table"">
        <thead>
            <tr>
                <th>
                    Title
                </th>
                <th>
                    Duration
                </th>
                <th>
                    Kind Of Movie
                </th>
                <th>
                    Country
                </th>
                <th>
                    Actors
                </th>
                <th>
                    Ranking
                </th>
                <th>
                    Rate
                </th>
                <th>
                    Select Movie
                </th>
                <th></th>
            </tr>
        </thead>
        <tbody>
");
#nullable restore
#line 96 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
             foreach (var item in Model.Result)
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 100 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Title));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 103 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Duration));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 106 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.KindOfMovie));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 109 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Country));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 112 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Actors));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
#nullable restore
#line 115 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
                   Write(Html.DisplayFor(modelItem => item.Ranking));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </td>\r\n\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ccbb7f848e9a256f15ca6c53726b3d41a30f3c315783", async() => {
                WriteLiteral("Rate Movie");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 119 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
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
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ccbb7f848e9a256f15ca6c53726b3d41a30f3c318034", async() => {
                WriteLiteral("Select");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 122 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
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
            WriteLiteral("\r\n                    </td>\r\n                    <td>\r\n");
#nullable restore
#line 125 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
                         if (User.IsInRole(Roles.Manager.ToString()) || User.IsInRole(Roles.Admin.ToString()))
                        {

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ccbb7f848e9a256f15ca6c53726b3d41a30f3c320847", async() => {
                WriteLiteral("Edit");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 127 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
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
            WriteLiteral(" ");
#nullable restore
#line 127 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
                                                                             Write(Html.Display("|"));

#line default
#line hidden
#nullable disable
            WriteLiteral("                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ccbb7f848e9a256f15ca6c53726b3d41a30f3c323334", async() => {
                WriteLiteral("Delete");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 128 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
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
            WriteLiteral(" ");
#nullable restore
#line 128 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
                                                                                 Write(Html.Display("|"));

#line default
#line hidden
#nullable disable
#nullable restore
#line 128 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
                                                                                                        
                        }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "2ccbb7f848e9a256f15ca6c53726b3d41a30f3c326122", async() => {
                WriteLiteral("Details");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_7.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_7);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 130 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
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
            WriteLiteral("\r\n                    </td>\r\n                </tr>\r\n");
#nullable restore
#line 133 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
#nullable restore
#line 134 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
             if (TempData.ContainsKey("Error"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            WriteLiteral("<script>alert(\'");
#nullable restore
#line 136 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
                            Write(TempData["Error"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');</script>\r\n");
#nullable restore
#line 137 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 139 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
             if (TempData.ContainsKey("Success"))
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                ");
            WriteLiteral("<script>alert(\'");
#nullable restore
#line 141 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
                            Write(TempData["Success"]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\');</script>\r\n");
#nullable restore
#line 142 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral("        </tbody>\r\n    </table>\r\n\r\n");
            WriteLiteral("\r\n");
#nullable restore
#line 148 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
     if (Model.Result.Count() > 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>\r\n            <strong>");
#nullable restore
#line 151 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
               Write(Model.TotalRegisters);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> Registers found\r\n        </span>\r\n        <span>&nbsp;|&nbsp;</span>\r\n        <span>\r\n            Page <strong>");
#nullable restore
#line 155 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
                     Write(Model.ActualPage);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong> of\r\n            <strong>");
#nullable restore
#line 156 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
               Write(Model.TotalPages);

#line default
#line hidden
#nullable disable
            WriteLiteral("</strong>\r\n        </span>\r\n        <span>&nbsp;|&nbsp;</span>\r\n");
#nullable restore
#line 159 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
    }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span>No results</span>\r\n        <span>&nbsp;|&nbsp;</span>\r\n");
#nullable restore
#line 164 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
#nullable restore
#line 166 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
     if (Model.ActualPage > 1)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 168 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
   Write(Html.ActionLink("<<", "Index", new { page = 1 },
                        new { @class = "btn btn-sm btn-default" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span></span>\r\n");
#nullable restore
#line 171 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
   Write(Html.ActionLink("Previous", "Index", new { page = Model.ActualPage - 1 },
                        new { @class = "btn btn-sm btn-default" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 172 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
                                                                  
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 176 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
   Write(Html.ActionLink("<<", "Index", new { page = 1 },
                        new { @class = "btn btn-sm btn-default disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span></span>\r\n");
#nullable restore
#line 179 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
   Write(Html.ActionLink("Previous", "Index", new { page = 1 },
                        new { @class = "btn btn-sm btn-default disabled" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 180 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
                                                                           
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <span></span>\r\n");
#nullable restore
#line 183 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
     if (Model.ActualPage < Model.TotalPages)
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 185 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
   Write(Html.ActionLink("Next", "Index", new { page = Model.ActualPage + 1 },
                        new { @class = "btn btn-sm btn-default" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span></span>\r\n");
#nullable restore
#line 188 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
   Write(Html.ActionLink(">>", "Index", new { page = Model.TotalPages },
                        new { @class = "btn btn-sm btn-default" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 189 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
                                                                  
    }
    else
    {
        

#line default
#line hidden
#nullable disable
#nullable restore
#line 193 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
   Write(Html.ActionLink("Next", "Index", new { page = Model.TotalPages - 1 },
                        new { @class = "btn btn-sm btn-default disabled" }));

#line default
#line hidden
#nullable disable
            WriteLiteral("        <span></span>\r\n");
#nullable restore
#line 196 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
   Write(Html.ActionLink(">>", "Index", new { page = Model.TotalPages },
                        new { @class = "btn btn-sm btn-default disabled" }));

#line default
#line hidden
#nullable disable
#nullable restore
#line 197 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\Movies\Index.cshtml"
                                                                           
    }

#line default
#line hidden
#nullable disable
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<Movie_Plus.Services.Pager.GenericPager<Movie_Plus.Data.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
