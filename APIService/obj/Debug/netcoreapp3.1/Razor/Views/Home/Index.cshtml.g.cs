#pragma checksum "C:\Users\kayleigh\source\repos\WebService\APIService\Views\Home\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "7748ac1616e86010b2acf5bbb48869d1d6e662aa"
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"7748ac1616e86010b2acf5bbb48869d1d6e662aa", @"/Views/Home/Index.cshtml")]
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7748ac1616e86010b2acf5bbb48869d1d6e662aa2641", async() => {
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
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("body", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "7748ac1616e86010b2acf5bbb48869d1d6e662aa3828", async() => {
                WriteLiteral("\r\n\t<div class=\"container\">\r\n");
                WriteLiteral(@"		<h2 style=""text-align:center;"">API Commands</h2>
		<div class=""row"">
			<div class=""col-md-4"">
				<h3>Return all products</h3>
				<p>/Home/ReturnProduct?identifier=null</p>
				<h4>Example</h4>
				<a href=""Home/ReturnProduct?Identifier="">Click Here...</a>

				<h3>Return product byId</h3>
				<p>/ReturnProduct?identifier={Product.Id}</p>
				<h4>Example</h4>
				<a href=""Home/ReturnProduct?Identifier=8"">Click Here...</a>

				<h3>Return Product By Name</h3>
				<p>/ReturnProduct?identifier={Product.Name}</p>
				<h4>Example</h4>
				<a href=""Home/ReturnProduct?Identifier=Lamp"">Click Here...</a>

			</div>
			<div class=""col-md-4"">
				<h3>Return Featured Producty</h3>
				<p>/ReturnFeaturedProducts?SKU1={Product.SKU}&SKU1={Product.SKU}&SKU1{Product.SKU}</p>
				<h4>Example</h4>
				<a href=""Home/ReturnFeaturedProducts?SKU1=1&SKU2=2&SKU3=3"">Click Here...</a>

				<h3>Return Product By Category</h3>
				<p>/ReturnCategory?Identifier={Category.CategoryId}</p>
				<h4>Example</h4>");
                WriteLiteral(@"
				<a href=""Home/ReturnCategory?Identifier=1"">Click Here...</a>
			</div>
			<div class=""col-md-4"">
				<h3>Return Categories</h3>
				<p>/ReturnCategory?identifier=null</p>
				<h4>Example</h4>
				<a href=""Home/ReturnCategory?Identifier="">Click Here...</a>

				<h3>Return Categories by Id</h3>
				<p>/ReturnCategory?identifier={Category.Id}</p>
				<h4>Example</h4>
				<a href=""Home/ReturnCategory?Identifier=1"">Click Here...</a>

				<h3>Return Category By Name</h3>
				<p>/Home/ReturnCategory?identifier={Category.Name}</p>
				<h4>Example</h4>
				<a href=""Home/ReturnCategory?Identifier=Electronics"">Click Here...</a>

");
                WriteLiteral(@"			</div>
		</div>
	</div>
	<style>
		.mini-container 
		{
			height:250px;
			overflow-y:scroll;
		}
	</style>
	<script>
		//$(document).ready(function () {
		//	$.ajax({
		//		url: """",
		//		contentType: ""application/json"",
		//		dataType: 'json',
		//		success: function (result) {
		//			console.log(result);
		//		}
		//	})
		//});
	</script>
");
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
