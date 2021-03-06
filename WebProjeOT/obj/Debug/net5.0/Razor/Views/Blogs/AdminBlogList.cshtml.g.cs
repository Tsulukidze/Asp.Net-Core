#pragma checksum "C:\Users\TSULUKIDZE\Desktop\WebProjeOT\Views\Blogs\AdminBlogList.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "3fd320067865b0d7dd6667ea79cf50693d8dd49c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Blogs_AdminBlogList), @"mvc.1.0.view", @"/Views/Blogs/AdminBlogList.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"3fd320067865b0d7dd6667ea79cf50693d8dd49c", @"/Views/Blogs/AdminBlogList.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"46ce36cab82935b6a56bef9003a52d85ea3d4686", @"/Views/_ViewImports.cshtml")]
    public class Views_Blogs_AdminBlogList : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<WebProjeOT.Models.Blog>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\TSULUKIDZE\Desktop\WebProjeOT\Views\Blogs\AdminBlogList.cshtml"
  
    ViewData["Title"] = "AdminBlogList";
    Layout = "~/Views/Shared/_AdminLayout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<h2>List of Blogs</h2>
<br />
<table class=""table table-bordered table-primary"">
    <tr>
        <th>ID</th>
        <th>Title</th>
        <th>Category</th>
        <th>Date</th>
        <th>Delete</th>
        <th>Update</th>
        <th>Details</th>
");
            WriteLiteral("    </tr>\r\n");
#nullable restore
#line 20 "C:\Users\TSULUKIDZE\Desktop\WebProjeOT\Views\Blogs\AdminBlogList.cshtml"
     foreach (var item in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n            <td>");
#nullable restore
#line 23 "C:\Users\TSULUKIDZE\Desktop\WebProjeOT\Views\Blogs\AdminBlogList.cshtml"
           Write(item.BlogID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 24 "C:\Users\TSULUKIDZE\Desktop\WebProjeOT\Views\Blogs\AdminBlogList.cshtml"
           Write(item.BlogHeader);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 25 "C:\Users\TSULUKIDZE\Desktop\WebProjeOT\Views\Blogs\AdminBlogList.cshtml"
           Write(item.Categories.CategoriesName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 26 "C:\Users\TSULUKIDZE\Desktop\WebProjeOT\Views\Blogs\AdminBlogList.cshtml"
           Write(item.BlogDate.ToShortDateString());

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 712, "\"", 745, 2);
            WriteAttributeValue("", 719, "/Blogs/Delete/", 719, 14, true);
#nullable restore
#line 27 "C:\Users\TSULUKIDZE\Desktop\WebProjeOT\Views\Blogs\AdminBlogList.cshtml"
WriteAttributeValue("", 733, item.BlogID, 733, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-danger\">Delete</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 805, "\"", 836, 2);
            WriteAttributeValue("", 812, "/Blogs/Edit/", 812, 12, true);
#nullable restore
#line 28 "C:\Users\TSULUKIDZE\Desktop\WebProjeOT\Views\Blogs\AdminBlogList.cshtml"
WriteAttributeValue("", 824, item.BlogID, 824, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-success\">Edit</a></td>\r\n            <td><a");
            BeginWriteAttribute("href", " href=\"", 895, "\"", 929, 2);
            WriteAttributeValue("", 902, "/Blogs/Details/", 902, 15, true);
#nullable restore
#line 29 "C:\Users\TSULUKIDZE\Desktop\WebProjeOT\Views\Blogs\AdminBlogList.cshtml"
WriteAttributeValue("", 917, item.BlogID, 917, 12, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"btn btn-warning\">Details</a></td>\r\n");
            WriteLiteral("        </tr>\r\n");
#nullable restore
#line 32 "C:\Users\TSULUKIDZE\Desktop\WebProjeOT\Views\Blogs\AdminBlogList.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("</table>\r\n\r\n<a href=\"/Blogs/Create/\" class=\"btn btn-primary\">Add New Blog</a>\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<WebProjeOT.Models.Blog>> Html { get; private set; }
    }
}
#pragma warning restore 1591
