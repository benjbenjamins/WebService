#pragma checksum "C:\Users\kayleigh\source\repos\WebService\APIService\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9e98fee1242d70151c429f8bf8c93cfb3d4b0fd2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Home_Index), @"mvc.1.0.razor-page", @"/Views/Home/Index.cshtml")]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9e98fee1242d70151c429f8bf8c93cfb3d4b0fd2", @"/Views/Home/Index.cshtml")]
    public class Views_Home_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e98fee1242d70151c429f8bf8c93cfb3d4b0fd22641", async() => {
                WriteLiteral("\r\n\t<link rel=\"stylesheet\" href=\"https://maxcdn.bootstrapcdn.com/bootstrap/3.4.1/css/bootstrap.min.css\">\r\n\t<script src=\"https://ajax.aspnetcdn.com/ajax/jQuery/jquery-3.6.0.js\" type=\"text/javascript\"></script>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9e98fee1242d70151c429f8bf8c93cfb3d4b0fd23828", async() => {
                WriteLiteral(@"
	<div>
		<h1 style=""text-align:center;"">
			API Example
		</h1>
		<div class=""row"">
			<div class=""col-md-4"">
				<button id=""Featured"">Recall Featured Products</button>
				<div class=""mini-container""></div>
			</div>
			<div class=""col-md-4"">
				<button id=""Category"">Recall Category Name</button>
				<div class=""mini-container""></div>
			</div>
			<div class=""col-md-4"">
				<button id=""Products"">Recall Products By Category</button>
				<div class=""mini-container""></div>
			</div>
		</div>
		<h2 style=""text-align:center;"">API Commands</h2>
		<div class=""row"">
			<div class=""col-md-4"">
				<h3>Return all products</h3>
				<p>/Home/ReturnProduct?identifier=null</p>
				<h4>Example</h4>
				<a href=""Home/ReturnCategory?Identifier="">Click Here...</a>

				<h3>Return product byId</h3>
				<p>/Home/ReturnProduct?identifier={Product.Id}</p>
				<h4>Example</h4>
				<a href=""Home/ReturnCategory?Identifier=1"">Click Here...</a>

				<h3>Return Product By Name</h3>
				<p>/Home/Return");
                WriteLiteral(@"Product?identifier={Product.Name}</p>
				<h4>Example</h4>
				<a href=""Home/ReturnProduct?Identifier=Lamp"">Click Here...</a>

			</div>
			<div class=""col-md-4"">
				<h3>Return Product By Category</h3>
				<p>/Home/ReturnCategory?identifier={Category.Name}</p>
				<h4>Example</h4>
				<a href=""Home/ReturnCategory?Identifier=Electronics"">Click Here...</a>

				<h3>Return Categories</h3>
				<p>/Home/ReturnCategory?identifier=null</p>
				<h4>Example</h4>
				<a href=""Home/ReturnProduct?Identifier="">Click Here...</a>

				<h3>Return Categories by Id</h3>
				<p>/Home/ReturnCategory?identifier={Category.Id}</p>
				<h4>Example</h4>
				<a href=""Home/ReturnCategory?Identifier=1"">Click Here...</a>
			</div>
			<div class=""col-md-4"">
				<h3>Return Category By Name</h3>
				<p>/Home/ReturnCategory?identifier={Category.Name}</p>
				<h4>Example</h4>
				<a href=""Home/ReturnCategory?Identifier=Electronics"">Click Here...</a>

				<h3>Return Category By Sku</h3>
				<p>/Home/ReturnCategory?");
                WriteLiteral("identifier={Product.SKU}</p>\r\n\t\t\t\t<h4>Example</h4>\r\n\t\t\t\t<ah href=\"/ReturnCategory?Identifier=11111\"></ah>\r\n\t\t\t</div>\r\n\t\t</div>\r\n\t</div>\r\n\t<style>\r\n\t\t.mini-container \r\n\t\t{\r\n\t\t\theight:250px;\r\n\t\t\toverflow-y:scroll;\r\n\t\t}\r\n\t</style>\r\n");
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.BodyTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_BodyTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<APIService.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<APIService.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<APIService.IndexModel>)PageContext?.ViewData;
        public APIService.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591
