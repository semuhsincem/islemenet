#pragma checksum "C:\Users\ASUS\source\repos\CNC\MvcWebUI\Views\Shared\Components\SearchRFQ\Default.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "71774c15967818c420c966f94fd1195fd7617e06"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Shared_Components_SearchRFQ_Default), @"mvc.1.0.view", @"/Views/Shared/Components/SearchRFQ/Default.cshtml")]
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
#line 1 "C:\Users\ASUS\source\repos\CNC\MvcWebUI\Views\_ViewImports.cshtml"
using MvcWebUI;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ASUS\source\repos\CNC\MvcWebUI\Views\_ViewImports.cshtml"
using MvcWebUI.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"71774c15967818c420c966f94fd1195fd7617e06", @"/Views/Shared/Components/SearchRFQ/Default.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8b224d3e456fd8e45284d76ffdf4cbd655be97fe", @"/Views/_ViewImports.cshtml")]
    public class Views_Shared_Components_SearchRFQ_Default : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "1", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "2", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("value", "3", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral(@"<div class=""filter-div"">
    <div class=""filter-header"">
        <h6>Filter search results</h6>
    </div>
    <div class=""accordion"" id=""accordionExample"">
        <div class=""card"">
            <div class=""card-header"" id=""headingOne"">
                <button class=""btn btn-block"" type=""button"" data-toggle=""collapse""
                        data-target=""#collapseOne"" aria-expanded=""true"" aria-controls=""collapseOne"">
                    <p>Filter search results </p>
                    <i class=""fas fa-chevron-down""></i>
                </button>

            </div>

            <div id=""collapseOne"" class=""collapse"" aria-labelledby=""headingOne""
                 data-parent=""#accordionExample"">
                <div class=""card-body"">

                    <div class=""input-group"">
                        <select class=""custom-select"" id=""inputGroupSelect02"">
                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71774c15967818c420c966f94fd1195fd7617e064974", async() => {
                WriteLiteral("Newest RFQs");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            BeginWriteTagHelperAttribute();
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __tagHelperExecutionContext.AddHtmlAttribute("selected", Html.Raw(__tagHelperStringValueBuffer), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.Minimized);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71774c15967818c420c966f94fd1195fd7617e066276", async() => {
                WriteLiteral("One");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71774c15967818c420c966f94fd1195fd7617e067460", async() => {
                WriteLiteral("Two");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                            ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("option", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "71774c15967818c420c966f94fd1195fd7617e068644", async() => {
                WriteLiteral("Three");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.OptionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_OptionTagHelper.Value = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                        </select>
                    </div>

                </div>
            </div>
        </div>
        <div class=""card"">
            <div class=""card-header"" id=""headingTwo"">
                <button class=""btn btn-block collapsed"" type=""button"" data-toggle=""collapse""
                        data-target=""#collapseTwo"" aria-expanded=""false""
                        aria-controls=""collapseTwo"">
                    <p> Workpiece size (mm)</p>
                    <i class=""fas fa-chevron-down""></i>
                </button>
            </div>
            <div id=""collapseTwo"" class=""collapse"" aria-labelledby=""headingTwo""
                 data-parent=""#accordionExample"">
                <div class=""card-body"">
                    <div class=""form-group form-check"">
                        <input type=""checkbox"" class=""form-check-input"" id=""exampleCheck1"">
                        <label class=""form-check-label"" for=""exampleCheck1"">CNC Metalworking</label>
              ");
            WriteLiteral(@"      </div>
                    <div class=""form-group form-check"">
                        <input type=""checkbox"" class=""form-check-input"" id=""exampleCheck2"">
                        <label class=""form-check-label"" for=""exampleCheck2"">CNC Woodworking</label>
                    </div>
                    <div class=""form-group form-check"">
                        <input type=""checkbox"" class=""form-check-input"" id=""exampleCheck3"">
                        <label class=""form-check-label"" for=""exampleCheck3"">3D Printing</label>
                    </div>
                </div>
            </div>
        </div>
        <div class=""card"">
            <div class=""card-header"" id=""headingThree"">
                <button class=""btn btn-block collapsed"" type=""button"" data-toggle=""collapse""
                        data-target=""#collapseThree"" aria-expanded=""false""
                        aria-controls=""collapseThree"">
                    <p>Quantity</p>
                    <i class=""fas fa-chevron-dow");
            WriteLiteral(@"n""></i>
                </button>
            </div>
            <div id=""collapseThree"" class=""collapse"" aria-labelledby=""headingThree""
                 data-parent=""#accordionExample"">
                <div class=""card-body"">
                    Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry
                    richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard
                    dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon
                    tempor, sunt aliqua put a bird on it squid single-origin coffee nulla
                    assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore
                    wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher
                    vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic
                    synth nesciunt you probably haven't heard of them accusamus labore
                    sustainable VHS.
            WriteLiteral(@"
                </div>
            </div>
        </div>
        <div class=""card"">
            <div class=""card-header"" id=""headingFour"">
                <button class=""btn btn-block"" type=""button"" data-toggle=""collapse""
                        data-target=""#collapseFour"" aria-expanded=""true""
                        aria-controls=""collapseFour"">
                    <p>Technologies</p>
                    <i class=""fas fa-chevron-down""></i>
                </button>
            </div>

            <div id=""collapseFour"" class=""collapse"" aria-labelledby=""headingFour""
                 data-parent=""#accordionExample"">
                <div class=""card-body"">
                    Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry
                    richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard
                    dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon
                    tempor, sunt aliqua put a bird on it ");
            WriteLiteral(@"squid single-origin coffee nulla
                    assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore
                </div>
            </div>
        </div>
        <div class=""card"">
            <div class=""card-header"" id=""headingFive"">
                <button class=""btn btn-block collapsed"" type=""button"" data-toggle=""collapse""
                        data-target=""#collapseFive"" aria-expanded=""false""
                        aria-controls=""collapseFive"">
                    <p>Material</p>
                    <i class=""fas fa-chevron-down""></i>
                </button>
            </div>
            <div id=""collapseFive"" class=""collapse"" aria-labelledby=""headingFive""
                 data-parent=""#accordionExample"">
                <div class=""card-body"">
                    Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry
                    richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard
                    do");
            WriteLiteral(@"lor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon
                    tempor, sunt aliqua put a bird on it squid single-origin coffee nulla
                    assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore
                    wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher
                    vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic
                    synth nesciunt you probably haven't heard of them accusamus labore
                    sustainable VHS.
                </div>
            </div>
        </div>
        <div class=""card"">
            <div class=""card-header"" id=""headingSix"">
                <button class=""btn btn-block collapsed"" type=""button"" data-toggle=""collapse""
                        data-target=""#collapseSix"" aria-expanded=""false""
                        aria-controls=""collapseSix"">
                    <p>Certification</p>
                    <i class=""fas fa");
            WriteLiteral(@"-chevron-down""></i>
                </button>
            </div>
            <div id=""collapseSix"" class=""collapse"" aria-labelledby=""headingSix""
                 data-parent=""#accordionExample"">
                <div class=""card-body"">
                    Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry
                    richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard
                    dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon
                    tempor, sunt aliqua put a bird on it squid single-origin coffee nulla
                    assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore
                    wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher
                    vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic
                    synth nesciunt you probably haven't heard of them accusamus labore
                    sustainab");
            WriteLiteral(@"le VHS.
                </div>
            </div>
        </div>
        <div class=""card"">
            <div class=""card-header"" id=""headingSeven"">
                <button class=""btn btn-block"" type=""button"" data-toggle=""collapse""
                        data-target=""#collapseSeven"" aria-expanded=""true""
                        aria-controls=""collapseOne"">
                    <p>Distance</p>
                    <i class=""fas fa-chevron-down""></i>
                </button>

            </div>

            <div id=""collapseSeven"" class=""collapse"" aria-labelledby=""headingSeven""
                 data-parent=""#accordionExample"">
                <div class=""card-body"">
                    Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry
                    richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard
                    dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon
                    tempor, sunt aliqua put a bi");
            WriteLiteral(@"rd on it squid single-origin coffee nulla
                    assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore
                </div>
            </div>
        </div>
        <div class=""card"">
            <div class=""card-header"" id=""headingEight"">
                <button class=""btn btn-block collapsed"" type=""button"" data-toggle=""collapse""
                        data-target=""#collapseEight"" aria-expanded=""false""
                        aria-controls=""collapseEight"">
                    <p>RFQ origin country</p>
                    <i class=""fas fa-chevron-down""></i>
                </button>
            </div>
            <div id=""collapseEight"" class=""collapse"" aria-labelledby=""headingEight""
                 data-parent=""#accordionExample"">
                <div class=""card-body"">
                    Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry
                    richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard");
            WriteLiteral(@"
                    dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon
                    tempor, sunt aliqua put a bird on it squid single-origin coffee nulla
                    assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore
                    wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher
                    vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic
                    synth nesciunt you probably haven't heard of them accusamus labore
                    sustainable VHS.
                </div>
            </div>
        </div>
        <div class=""card"">
            <div class=""card-header"" id=""headingNine"">
                <button class=""btn btn-block collapsed"" type=""button"" data-toggle=""collapse""
                        data-target=""#collapseNine"" aria-expanded=""false""
                        aria-controls=""collapseNine"">
                    <p>Status</p>
                ");
            WriteLiteral(@"    <i class=""fas fa-chevron-down""></i>
                </button>
            </div>
            <div id=""collapseNine"" class=""collapse"" aria-labelledby=""headingNine""
                 data-parent=""#accordionExample"">
                <div class=""card-body"">
                    Anim pariatur cliche reprehenderit, enim eiusmod high life accusamus terry
                    richardson ad squid. 3 wolf moon officia aute, non cupidatat skateboard
                    dolor brunch. Food truck quinoa nesciunt laborum eiusmod. Brunch 3 wolf moon
                    tempor, sunt aliqua put a bird on it squid single-origin coffee nulla
                    assumenda shoreditch et. Nihil anim keffiyeh helvetica, craft beer labore
                    wes anderson cred nesciunt sapiente ea proident. Ad vegan excepteur butcher
                    vice lomo. Leggings occaecat craft beer farm-to-table, raw denim aesthetic
                    synth nesciunt you probably haven't heard of them accusamus labore
       ");
            WriteLiteral(@"             sustainable VHS.
                </div>
            </div>
        </div>
    </div>
    <button class=""btn btn-search-filter btn-block"">
        <i class=""fas fa-search""></i> &nbsp;SEARCH
    </button>

    <button class=""btn btn-reset-filter btn-block"">
        Reset All Filters
    </button>
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; }
    }
}
#pragma warning restore 1591