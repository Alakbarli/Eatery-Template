#pragma checksum "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "060903975aad771b083b8df70ec4e1474164d5bd"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.view", @"/Views/Home/Index.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.Razor.Compilation.RazorViewAttribute(@"/Views/Home/Index.cshtml", typeof(AspNetCore.Views_Home_Index))]
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
#line 1 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\_ViewImports.cshtml"
using Eatery;

#line default
#line hidden
#line 2 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\_ViewImports.cshtml"
using Eatery.Models;

#line default
#line hidden
#line 6 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Index.cshtml"
using Eatery.DAL;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"060903975aad771b083b8df70ec4e1474164d5bd", @"/Views/Home/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1775fe8f68e1354639192164db2cbcd52964ed7", @"/Views/_ViewImports.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<VModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "/Views/Shared/EatingTypePartialView.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("alt", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("img-fluid"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "PartialViewOurMenu", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("mr-4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "ViewPartialBlog", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("name", "/Views/Shared/SubscribePartialView.cshtml", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            BeginContext(0, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 2 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Index.cshtml"
  
    ViewData["Title"] = "Index";

#line default
#line hidden
            BeginContext(77, 46, true);
            WriteLiteral("<section class=\"home-slider owl-carousel\">\r\n\r\n");
            EndContext();
#line 9 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Index.cshtml"
     foreach (var slide in Model.Sliders)
    {

#line default
#line hidden
            BeginContext(173, 32, true);
            WriteLiteral("        <div class=\"slider-item\"");
            EndContext();
            BeginWriteAttribute("style", " style=\"", 205, "\"", 262, 4);
            WriteAttributeValue("", 213, "background-image:", 213, 17, true);
            WriteAttributeValue(" ", 230, "url(\'/img/", 231, 11, true);
#line 11 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Index.cshtml"
WriteAttributeValue("", 241, slide.SliderImage, 241, 18, false);

#line default
#line hidden
            WriteAttributeValue("", 259, "\');", 259, 3, true);
            EndWriteAttribute();
            BeginContext(263, 241, true);
            WriteLiteral(">\r\n\r\n            <div class=\"container\">\r\n                <div class=\"row slider-text align-items-center justify-content-center\">\r\n                    <div class=\"col-md-8 text-center col-sm-12 element-animate\">\r\n                        <h1>");
            EndContext();
            BeginContext(505, 13, false);
#line 16 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Index.cshtml"
                       Write(slide.Heading);

#line default
#line hidden
            EndContext();
            BeginContext(518, 47, true);
            WriteLiteral("</h1>\r\n                        <p class=\"mb-5\">");
            EndContext();
            BeginContext(566, 13, false);
#line 17 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Index.cshtml"
                                   Write(slide.Content);

#line default
#line hidden
            EndContext();
            BeginContext(579, 197, true);
            WriteLiteral(".</p>\r\n                        <p><a href=\"#\" class=\"btn btn-white btn-outline-white\">Get Started</a></p>\r\n                    </div>\r\n                </div>\r\n            </div>\r\n\r\n        </div>\r\n");
            EndContext();
#line 24 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Index.cshtml"
    }

#line default
#line hidden
            BeginContext(783, 170, true);
            WriteLiteral("\r\n\r\n\r\n\r\n</section>\r\n<!-- END slider -->\r\n<!--Eating Types-->\r\n<section class=\"section bg-light element-animate\">\r\n    <div class=\"container\">\r\n        <div class=\"row\">\r\n");
            EndContext();
#line 35 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Index.cshtml"
             foreach (var Et in Model.EatingTypes.Take(4))
            {

#line default
#line hidden
            BeginContext(1028, 16, true);
            WriteLiteral("                ");
            EndContext();
            BeginContext(1044, 71, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "19d0c2d1f5e44d5390c8e0d12bf9a4e8", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
#line 37 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For = ModelExpressionProvider.CreateModelExpression(ViewData, __model => Et);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("for", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.For, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(1115, 2, true);
            WriteLiteral("\r\n");
            EndContext();
#line 38 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(1132, 537, true);
            WriteLiteral(@"

        </div>
    </div>
</section>

<!--Eating Types end-->
<!--Special Dishes-->
<section class=""section element-animate"">

    <div class=""clearfix mb-5 pb-5"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-12 text-center heading-wrap"">
                    <h2>Special Dishes</h2>
                    <span class=""back-text"">Dishes</span>
                </div>
            </div>
        </div>
    </div>

    <div class=""owl-carousel centernonloop"">
");
            EndContext();
#line 61 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Index.cshtml"
         foreach (var At in Model.SpecialDishes)
        {

#line default
#line hidden
            BeginContext(1730, 127, true);
            WriteLiteral("            <a href=\"#\" class=\"item-dishes\">\r\n                <div class=\"text\">\r\n                    <p class=\"dishes-price\">$");
            EndContext();
            BeginContext(1858, 8, false);
#line 65 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Index.cshtml"
                                        Write(At.Price);

#line default
#line hidden
            EndContext();
            BeginContext(1866, 53, true);
            WriteLiteral("</p>\r\n                    <h2 class=\"dishes-heading\">");
            EndContext();
            BeginContext(1920, 10, false);
#line 66 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Index.cshtml"
                                          Write(At.Heading);

#line default
#line hidden
            EndContext();
            BeginContext(1930, 47, true);
            WriteLiteral("</h2>\r\n                </div>\r\n                ");
            EndContext();
            BeginContext(1977, 52, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "25f6558b69b2417eadfa53ebcc688bcb", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 1987, "~/img/", 1987, 6, true);
#line 68 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 1993, At.Image, 1993, 9, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_2);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2029, 20, true);
            WriteLiteral("\r\n            </a>\r\n");
            EndContext();
#line 70 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Index.cshtml"
        }

#line default
#line hidden
            BeginContext(2060, 90, true);
            WriteLiteral("\r\n\r\n    </div>\r\n</section> <!-- .section -->\r\n<!--Special Dishes end-->\r\n<!--Our Menu-->\r\n");
            EndContext();
            BeginContext(2150, 59, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "b38c0b0a6377439aba74efd4e1cdab68", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
#line 77 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.OurMenus;

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(2209, 469, true);
            WriteLiteral(@"





<section class=""section element-animate"">


    <div class=""clearfix mb-5 pb-5"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-12 text-center heading-wrap"">
                    <h2>Testimonial</h2>
                    <span class=""back-text"">Testimonial</span>
                </div>
            </div>
        </div>
    </div>

    <div class=""container"">
        <div class=""row"">
");
            EndContext();
#line 99 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Index.cshtml"
             foreach (var diva in Model.Testimonials.Take(3))
            {

#line default
#line hidden
            BeginContext(2756, 129, true);
            WriteLiteral("                <div class=\"col-md-4\">\r\n                    <blockquote class=\"testimonial\">\r\n                        <p>&ldquo; ");
            EndContext();
            BeginContext(2886, 12, false);
#line 103 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Index.cshtml"
                              Write(diva.Content);

#line default
#line hidden
            EndContext();
            BeginContext(2898, 96, true);
            WriteLiteral(". &rdquo;</p>\r\n                        <div class=\"d-flex author\">\r\n                            ");
            EndContext();
            BeginContext(2994, 49, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "d229d4d2b7304cf48b955d7f5ea394c7", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 3004, "~/img/", 3004, 6, true);
#line 105 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Index.cshtml"
AddHtmlAttributeValue("", 3010, diva.Image, 3010, 11, false);

#line default
#line hidden
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_4);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3043, 93, true);
            WriteLiteral("\r\n                            <div class=\"author-info\">\r\n                                <h4>");
            EndContext();
            BeginContext(3137, 15, false);
#line 107 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Index.cshtml"
                               Write(diva.PersonName);

#line default
#line hidden
            EndContext();
            BeginContext(3152, 42, true);
            WriteLiteral("</h4>\r\n                                <p>");
            EndContext();
            BeginContext(3195, 19, false);
#line 108 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Index.cshtml"
                              Write(diva.PersonPosition);

#line default
#line hidden
            EndContext();
            BeginContext(3214, 133, true);
            WriteLiteral("</p>\r\n                            </div>\r\n                        </div>\r\n                    </blockquote>\r\n                </div>\r\n");
            EndContext();
#line 113 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Index.cshtml"
            }

#line default
#line hidden
            BeginContext(3362, 517, true);
            WriteLiteral(@"
        </div>
    </div>
</section> <!-- .section -->

<section class=""section element-animate"">
    <div class=""clearfix mb-5 pb-5"">
        <div class=""container-fluid"">
            <div class=""row"">
                <div class=""col-md-12 text-center heading-wrap"">
                    <h2>Blog</h2>
                    <span class=""back-text"">Our Blog</span>
                </div>
            </div>
        </div>
    </div>

    <div class=""container"">
        <div class=""row"">
            ");
            EndContext();
            BeginContext(3879, 63, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "fe05f551be6949069afb2b2bcf33f9cd", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
#line 133 "C:\Users\Ulvi\source\repos\Eatery\Eatery\Views\Home\Index.cshtml"
__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model = Model.Blogs.Take(2);

#line default
#line hidden
            __tagHelperExecutionContext.AddTagHelperAttribute("model", __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Model, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            EndContext();
            BeginContext(3942, 64, true);
            WriteLiteral("\r\n\r\n        </div>\r\n    </div>\r\n\r\n</section> <!-- .section -->\r\n");
            EndContext();
            BeginContext(4006, 60, false);
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("partial", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "292936b17b684900bd9d8f0b7e4b13c6", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.PartialTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_PartialTagHelper.Name = (string)__tagHelperAttribute_6.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_6);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<VModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
