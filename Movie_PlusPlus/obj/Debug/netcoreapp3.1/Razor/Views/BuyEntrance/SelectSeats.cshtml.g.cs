#pragma checksum "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\BuyEntrance\SelectSeats.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a0d298f7ee265c277d7fa6ccc977368a7ee0f7a2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_BuyEntrance_SelectSeats), @"mvc.1.0.view", @"/Views/BuyEntrance/SelectSeats.cshtml")]
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
#line 1 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\BuyEntrance\SelectSeats.cshtml"
using Movie_PlusPlus.Roles;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a0d298f7ee265c277d7fa6ccc977368a7ee0f7a2", @"/Views/BuyEntrance/SelectSeats.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"23c0bf5f0f935230d2e2f053df093359262d302e", @"/Views/_ViewImports.cshtml")]
    public class Views_BuyEntrance_SelectSeats : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<bool[,]>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("form-check-input"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("checked", new global::Microsoft.AspNetCore.Html.HtmlString("checked"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Horaries", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Index", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n\r\n<table>\r\n    <tr>\r\n        <th>\r\n            TOTAL :\r\n        </th>\r\n        <th>\r\n            ");
#nullable restore
#line 11 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\BuyEntrance\SelectSeats.cshtml"
       Write(ViewBag.Total);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </th>\r\n    </tr>\r\n</table>\r\n<br/>\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0d298f7ee265c277d7fa6ccc977368a7ee0f7a26103", async() => {
                WriteLiteral("\r\n    <table class=\"table\">\r\n        <thead>\r\n            <tr>\r\n                <th>\r\n                    Rows/Columns\r\n                </th>\r\n");
#nullable restore
#line 23 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\BuyEntrance\SelectSeats.cshtml"
                 for (int i = 0; i < Model.GetLength(1); i++)
                {

#line default
#line hidden
#nullable disable
                WriteLiteral("                    <th>\r\n                        ");
#nullable restore
#line 26 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\BuyEntrance\SelectSeats.cshtml"
                    Write(i+1);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </th>\r\n");
#nullable restore
#line 28 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\BuyEntrance\SelectSeats.cshtml"
                }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n                <th></th>\r\n            </tr>\r\n        </thead>\r\n        <tbody>\r\n");
#nullable restore
#line 35 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\BuyEntrance\SelectSeats.cshtml"
              int noEnt = ViewBag.noEnt; 

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 37 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\BuyEntrance\SelectSeats.cshtml"
             for (int i = 0; i < Model.GetLength(0); i++)
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                <tr>\r\n                    <td>\r\n                        ");
#nullable restore
#line 41 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\BuyEntrance\SelectSeats.cshtml"
                    Write(i+1);

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n                    </td>\r\n\r\n");
#nullable restore
#line 44 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\BuyEntrance\SelectSeats.cshtml"
                     for (int j = 0; j < Model.GetLength(1); j++)
                    {
                        if (!Model[i, j])
                        {
                            if (noEnt > 0)
                            {
                                noEnt--;

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td>\r\n                                    <div class=\"form-group form-check\">\r\n                                        <label class=\"form-check-label\">\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a0d298f7ee265c277d7fa6ccc977368a7ee0f7a29078", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 54 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\BuyEntrance\SelectSeats.cshtml"
                                             WriteLiteral(i);

#line default
#line hidden
#nullable disable
                WriteLiteral(",");
#nullable restore
#line 54 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\BuyEntrance\SelectSeats.cshtml"
                                                WriteLiteral(j);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("name", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 54 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\BuyEntrance\SelectSeats.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IsReadOnly);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        </label>\r\n                                    </div>\r\n                                </td>\r\n");
#nullable restore
#line 58 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\BuyEntrance\SelectSeats.cshtml"
                            }
                            else
                            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                                <td>\r\n                                    <div class=\"form-group form-check\">\r\n                                        <label class=\"form-check-label\">\r\n                                            ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("input", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "a0d298f7ee265c277d7fa6ccc977368a7ee0f7a212403", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.InputTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper);
                BeginWriteTagHelperAttribute();
#nullable restore
#line 64 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\BuyEntrance\SelectSeats.cshtml"
                                             WriteLiteral(i);

#line default
#line hidden
#nullable disable
                WriteLiteral(",");
#nullable restore
#line 64 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\BuyEntrance\SelectSeats.cshtml"
                                                WriteLiteral(j);

#line default
#line hidden
#nullable disable
                __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
                __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name = __tagHelperStringValueBuffer;
                __tagHelperExecutionContext.AddTagHelperAttribute("name", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.Name, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
#nullable restore
#line 64 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\BuyEntrance\SelectSeats.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => __model.IsReadOnly);

#line default
#line hidden
#nullable disable
                __tagHelperExecutionContext.AddTagHelperAttribute("asp-for", __Microsoft_AspNetCore_Mvc_TagHelpers_InputTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n                                        </label>\r\n                                    </div>\r\n                                </td>\r\n");
#nullable restore
#line 68 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\BuyEntrance\SelectSeats.cshtml"
                            }
                        }
                        else
                        {

#line default
#line hidden
#nullable disable
                WriteLiteral("                            <td>\r\n                                Reserved\r\n                            </td>\r\n");
#nullable restore
#line 75 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\BuyEntrance\SelectSeats.cshtml"
                        }


                    }

#line default
#line hidden
#nullable disable
                WriteLiteral("                </tr>\r\n");
#nullable restore
#line 80 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\BuyEntrance\SelectSeats.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n");
#nullable restore
#line 82 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\BuyEntrance\SelectSeats.cshtml"
             if (ViewData.ContainsKey("Error"))
            {

#line default
#line hidden
#nullable disable
                WriteLiteral("                ");
                WriteLiteral("<script>alert(\'");
#nullable restore
#line 84 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\BuyEntrance\SelectSeats.cshtml"
                            Write(ViewData["Error"]);

#line default
#line hidden
#nullable disable
                WriteLiteral("\');</script>\r\n");
#nullable restore
#line 85 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\BuyEntrance\SelectSeats.cshtml"
            }

#line default
#line hidden
#nullable disable
                WriteLiteral("        </tbody>\r\n    </table>\r\n");
#nullable restore
#line 88 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\BuyEntrance\SelectSeats.cshtml"
     if (User.IsInRole(Roles.Basic_User.ToString()))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"submit\" name=\"Buy\" value=\"Pay With Credit Card\" />\r\n");
#nullable restore
#line 91 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\BuyEntrance\SelectSeats.cshtml"
    }

#line default
#line hidden
#nullable disable
#nullable restore
#line 92 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\BuyEntrance\SelectSeats.cshtml"
     if(User.IsInRole(Roles.Ticket_Agent.ToString()))
    {

#line default
#line hidden
#nullable disable
                WriteLiteral("        <input type=\"submit\" name=\"PayInTicketOffice\" value=\"Pay In Ticket Office\" />\r\n");
#nullable restore
#line 95 "C:\Users\Ale\source\repos\Movie_PlusPlus\Movie_PlusPlus\Views\BuyEntrance\SelectSeats.cshtml"
    }

#line default
#line hidden
#nullable disable
                WriteLiteral("\r\n\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a0d298f7ee265c277d7fa6ccc977368a7ee0f7a218062", async() => {
                    WriteLiteral("Cancel");
                }
                );
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_2.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
                __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_3.Value;
                __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
                await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
                if (!__tagHelperExecutionContext.Output.IsContentModified)
                {
                    await __tagHelperExecutionContext.SetOutputContentAsync();
                }
                Write(__tagHelperExecutionContext.Output);
                __tagHelperExecutionContext = __tagHelperScopeManager.End();
                WriteLiteral("\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<bool[,]> Html { get; private set; }
    }
}
#pragma warning restore 1591
