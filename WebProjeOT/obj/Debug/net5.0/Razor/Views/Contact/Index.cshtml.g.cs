#pragma checksum "C:\Users\TSULUKIDZE\Desktop\WebProjeOT\Views\Contact\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f545e2af4d68fa9da61d3d1f4600de1e24d11475"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Contact_Index), @"mvc.1.0.view", @"/Views/Contact/Index.cshtml")]
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
#line 1 "C:\Users\TSULUKIDZE\Desktop\WebProjeOT\Views\_ViewImports.cshtml"
using WebProjeOT;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\TSULUKIDZE\Desktop\WebProjeOT\Views\_ViewImports.cshtml"
using WebProjeOT.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f545e2af4d68fa9da61d3d1f4600de1e24d11475", @"/Views/Contact/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46ce36cab82935b6a56bef9003a52d85ea3d4686", @"/Views/_ViewImports.cshtml")]
    public class Views_Contact_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebProjeOT.Models.Contact>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString("#"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("p-5 bg-white"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\TSULUKIDZE\Desktop\WebProjeOT\Views\Contact\Index.cshtml"
  
    ViewData["Title"] = "Index";
    Layout = "~/Views/Shared/LayoutProje.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral(@"
<div class=""site-cover site-cover-sm same-height overlay single-page"" style=""background-image: url('/miniblog/images/img_4.jpg');"">
    <div class=""container"">
        <div class=""row same-height justify-content-center"">
            <div class=""col-md-12 col-lg-10"">
                <div class=""post-entry text-center"">
                    <h1");
            BeginWriteAttribute("class", " class=\"", 2232, "\"", 2240, 0);
            EndWriteAttribute();
            WriteLiteral(@">Contact Us</h1>
                    <p class=""lead mb-4 text-white"">Lorem ipsum dolor sit amet, consectetur adipisicing elit. Dolorem, adipisci?</p>
                </div>
            </div>
        </div>
    </div>
</div>

<div class=""site-section bg-light"">
    <div class=""container"">
        <div class=""row"">
            <div class=""col-md-7 mb-5"">



                ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "f545e2af4d68fa9da61d3d1f4600de1e24d114755113", async() => {
                WriteLiteral(@"


                    <div class=""row form-group"">
                        <div class=""col-md-6 mb-3 mb-md-0"">
                            <label class=""text-black"" for=""fname"">First Name</label>
                            <input type=""text"" id=""fname"" class=""form-control"">
                        </div>
                        <div class=""col-md-6"">
                            <label class=""text-black"" for=""lname"">Last Name</label>
                            <input type=""text"" id=""lname"" class=""form-control"">
                        </div>
                    </div>

                    <div class=""row form-group"">

                        <div class=""col-md-12"">
                            <label class=""text-black"" for=""email"">Email</label>
                            <input type=""email"" id=""email"" class=""form-control"">
                        </div>
                    </div>

                    <div class=""row form-group"">

                        <div class=""col-md-12"">
     ");
                WriteLiteral(@"                       <label class=""text-black"" for=""subject"">Subject</label>
                            <input type=""text"" id=""subject"" class=""form-control"">
                        </div>
                    </div>

                    <div class=""row form-group"">
                        <div class=""col-md-12"">
                            <label class=""text-black"" for=""message"">Message</label>
                            <textarea name=""message"" id=""message"" cols=""30"" rows=""7"" class=""form-control"" placeholder=""Write your notes or questions here...""></textarea>
                        </div>
                    </div>

                    <div class=""row form-group"">
                        <div class=""col-md-12"">
                            <input type=""submit"" value=""Send Message"" class=""btn btn-primary py-2 px-4 text-white"">
                        </div>
                    </div>


                ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
            </div>
            <div class=""col-md-5"">

                <div class=""p-4 mb-3 bg-white"">
                    <p class=""mb-0 font-weight-bold"">Address</p>
                    <p class=""mb-4"">Sakarya University, Turkey</p>

                    <p class=""mb-0 font-weight-bold"">Phone</p>
                    <p class=""mb-4""><a href=""#"">+90 530 626 32 41</a></p>

                    <p class=""mb-0 font-weight-bold"">Email Address</p>
                    <p class=""mb-0""><a href=""#"">osmanpampal@gmail.com</a></p>

                </div>

            </div>
        </div>
    </div>
</div>

");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebProjeOT.Models.Contact>> Html { get; private set; }
    }
}
#pragma warning restore 1591
