#pragma checksum "C:\Users\Евгений\source\repos\InstagramAspCore\InstagramAspCore\Views\Posts\Index2.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "1d3df75fb5a9107590b46f1c0837f8b8674c573c"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Posts_Index2), @"mvc.1.0.view", @"/Views/Posts/Index2.cshtml")]
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
#line 1 "C:\Users\Евгений\source\repos\InstagramAspCore\InstagramAspCore\Views\_ViewImports.cshtml"
using InstagramAspCore;

#line default
#line hidden
#line 2 "C:\Users\Евгений\source\repos\InstagramAspCore\InstagramAspCore\Views\_ViewImports.cshtml"
using InstagramAspCore.Models;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"1d3df75fb5a9107590b46f1c0837f8b8674c573c", @"/Views/Posts/Index2.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b1f6b4ff5413d74e53f27978b2d6a0102e42e5f8", @"/Views/_ViewImports.cshtml")]
    public class Views_Posts_Index2 : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<IEnumerable<InstagramAspCore.Models.DbPost>>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "CreateDbPost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
            WriteLiteral("\r\n");
#line 3 "C:\Users\Евгений\source\repos\InstagramAspCore\InstagramAspCore\Views\Posts\Index2.cshtml"
  
    ViewData["Title"] = "Index2";

#line default
#line hidden
            WriteLiteral("\r\n<h1>Index2</h1>\r\n\r\n");
            WriteLiteral("\r\n\r\n\r\n\r\n<p>\r\n    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "1d3df75fb5a9107590b46f1c0837f8b8674c573c3667", async() => {
                WriteLiteral("New Post");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n</p>\r\n\r\n\r\n<div class=\"align-content-center\">\r\n");
#line 70 "C:\Users\Евгений\source\repos\InstagramAspCore\InstagramAspCore\Views\Posts\Index2.cshtml"
     foreach (var post in Model)
    {

#line default
#line hidden
            WriteLiteral("        <div class=\"card\" style=\"width: 500px !important; margin: 0 auto;\">\r\n            <h6 class=\"card-header\">");
#line 73 "C:\Users\Евгений\source\repos\InstagramAspCore\InstagramAspCore\Views\Posts\Index2.cshtml"
                               Write(post.User.Email.Substring(0, post.User.Email.IndexOf('@')));

#line default
#line hidden
            WriteLiteral("</h6>\r\n            <img class=\"card-img-top\"");
            BeginWriteAttribute("src", " src=\"", 2195, "\"", 2261, 2);
            WriteAttributeValue("", 2201, "data:image/jpeg;base64,", 2201, 23, true);
#line 74 "C:\Users\Евгений\source\repos\InstagramAspCore\InstagramAspCore\Views\Posts\Index2.cshtml"
WriteAttributeValue("", 2224, Convert.ToBase64String(post.Photo), 2224, 37, false);

#line default
#line hidden
            EndWriteAttribute();
            WriteLiteral(" alt=\"another image\" />\r\n            <div class=\"card-body\">\r\n                <div style=\"margin-bottom: 5px;\">\r\n                    <img class=\"likeBtn\" style=\"cursor: pointer;\" src=\"/images/like.png\" width=\"27\" alt=\"Like\" data-id=\"");
#line 77 "C:\Users\Евгений\source\repos\InstagramAspCore\InstagramAspCore\Views\Posts\Index2.cshtml"
                                                                                                                   Write(post.Id);

#line default
#line hidden
            WriteLiteral("\" />\r\n                    <span class=\"likesCount\">");
#line 78 "C:\Users\Евгений\source\repos\InstagramAspCore\InstagramAspCore\Views\Posts\Index2.cshtml"
                                        Write(post.Likes);

#line default
#line hidden
            WriteLiteral("</span><span> likes</span>\r\n                </div>\r\n                <p class=\"card-text\"><strong>");
#line 80 "C:\Users\Евгений\source\repos\InstagramAspCore\InstagramAspCore\Views\Posts\Index2.cshtml"
                                        Write(post.User.Email.Substring(0, post.User.Email.IndexOf('@')));

#line default
#line hidden
            WriteLiteral(" </strong>");
#line 80 "C:\Users\Евгений\source\repos\InstagramAspCore\InstagramAspCore\Views\Posts\Index2.cshtml"
                                                                                                             Write(post.Description);

#line default
#line hidden
            WriteLiteral("</p>\r\n                <p class=\"card-text\"><small class=\"text-muted\">");
#line 81 "C:\Users\Евгений\source\repos\InstagramAspCore\InstagramAspCore\Views\Posts\Index2.cshtml"
                                                          Write(post.CreatedDate.ToString("MMMM dd"));

#line default
#line hidden
            WriteLiteral("</small></p>\r\n            </div>\r\n        </div>\r\n        <br />\r\n");
#line 85 "C:\Users\Евгений\source\repos\InstagramAspCore\InstagramAspCore\Views\Posts\Index2.cshtml"
    }

#line default
#line hidden
            WriteLiteral("</div>\r\n\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        $("".likeBtn"").on(""click"",
            function(e) {
                console.log($(this).attr(""data-id""));

                var currentElement = $(this);

                var dataId = $(this).attr(""data-id"");

                $.ajax({
                    type: ""POST"",
                    url: ""/Posts/Like"",
                    contentType: ""application/x-www-form-urlencoded; charset=UTF-8"",
                    data: {postId: parseInt(dataId)},
                    success: function(data) {
                        //console.log(data.likes);
                        //$(this).closest('span').text(data.likes);
                        console.log();
                        currentElement.next().html(data.likes);

                    },
                    error: function (jqXHR, textStatus, errorThrown) {

                        console.log(jqXHR.responseText);
                        console.log(textStatus);
                        console.log(errorThrown);
        ");
                WriteLiteral("            }\r\n                });\r\n            });\r\n    </script>\r\n");
            }
            );
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IEnumerable<InstagramAspCore.Models.DbPost>> Html { get; private set; }
    }
}
#pragma warning restore 1591
