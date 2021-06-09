#pragma checksum "C:\Users\MIS\source\repos\Restaurant Reservation Website\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "a6d7319b8138f74be3c0576841e4dc12a33f2820"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(RestaurantReservation.Frontend.Pages.Pages_Index), @"mvc.1.0.razor-page", @"/Pages/Index.cshtml")]
namespace RestaurantReservation.Frontend.Pages
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
#line 1 "C:\Users\MIS\source\repos\Restaurant Reservation Website\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\_ViewImports.cshtml"
using RestaurantReservation.Frontend;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"a6d7319b8138f74be3c0576841e4dc12a33f2820", @"/Pages/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"84b41b0ade626802c01cc63d337bd45c82a8ad0e", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-page", "/Restaurants/Details", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
#line 3 "C:\Users\MIS\source\repos\Restaurant Reservation Website\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Index.cshtml"
  
    ViewData["Title"] = "Home Page";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<div class=""container-fluid"">
    <div class=""row"">
        <div class=""col-12"">
            <div class=""card card-primary"">
                <div class=""card-header"">
                    <h3 class=""card-title"">Restaurants</h3>
                </div>
                <div class=""card-body"">
");
#nullable restore
#line 15 "C:\Users\MIS\source\repos\Restaurant Reservation Website\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Index.cshtml"
                     if (Model.RestaurantList.Count() > 0)
                    {
                        int count = 0;


#line default
#line hidden
#nullable disable
            WriteLiteral("                        <div class=\"row mt-4\">\r\n");
#nullable restore
#line 20 "C:\Users\MIS\source\repos\Restaurant Reservation Website\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Index.cshtml"
                             foreach (var restaurant in Model.RestaurantList)
                            {
                                if (count != 0 && count % 3 == 0)
                                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                                ");
            WriteLiteral("</div>\r\n                                ");
            WriteLiteral("<div class=\"row mt-4\">\r\n");
#nullable restore
#line 26 "C:\Users\MIS\source\repos\Restaurant Reservation Website\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Index.cshtml"
                                }


#line default
#line hidden
#nullable disable
            WriteLiteral("                                <div class=\"col-sm-4\">\r\n                                    <div class=\"position-relative p-3 bg-gray\" style=\"height: 260px\">\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6d7319b8138f74be3c0576841e4dc12a33f28205482", async() => {
                WriteLiteral("\r\n                                            <h5>");
#nullable restore
#line 31 "C:\Users\MIS\source\repos\Restaurant Reservation Website\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Index.cshtml"
                                           Write(restaurant.Restaurant.Name);

#line default
#line hidden
#nullable disable
                WriteLiteral("</h5>\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 30 "C:\Users\MIS\source\repos\Restaurant Reservation Website\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Index.cshtml"
                                                                             WriteLiteral(restaurant.Restaurant.RestaurantID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "a6d7319b8138f74be3c0576841e4dc12a33f28208224", async() => {
                WriteLiteral("\r\n                                            <img");
                BeginWriteAttribute("src", " src=\"", 1486, "\"", 1536, 1);
#nullable restore
#line 35 "C:\Users\MIS\source\repos\Restaurant Reservation Website\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Index.cshtml"
WriteAttributeValue("", 1492, Url.Content(restaurant.Restaurant.ImageUrl), 1492, 44, false);

#line default
#line hidden
#nullable disable
                EndWriteAttribute();
                WriteLiteral(" alt=\"Restaurant Photo\" style=\"float: right; width: 355px; height: 180px;margin: 8px 1px 0px 0px;\">\r\n                                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Page = (string)__tagHelperAttribute_0.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_0);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-ID", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 34 "C:\Users\MIS\source\repos\Restaurant Reservation Website\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Index.cshtml"
                                                                             WriteLiteral(restaurant.Restaurant.RestaurantID);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-ID", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["ID"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n                                    </div>\r\n                                </div>\r\n");
#nullable restore
#line 39 "C:\Users\MIS\source\repos\Restaurant Reservation Website\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Index.cshtml"
                                count++;
                            }

#line default
#line hidden
#nullable disable
            WriteLiteral("                        </div>\r\n");
#nullable restore
#line 42 "C:\Users\MIS\source\repos\Restaurant Reservation Website\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Index.cshtml"
                    }
                    else
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <h2>No restaurant records here, please contact admin!</h2>\r\n");
#nullable restore
#line 46 "C:\Users\MIS\source\repos\Restaurant Reservation Website\RestaurantReservation.Frontend\RestaurantReservation.Frontend\Pages\Index.cshtml"
                    }

#line default
#line hidden
#nullable disable
            WriteLiteral("                </div>\r\n            </div>\r\n        </div>\r\n    </div>\r\n</div>\r\n\r\n");
            DefineSection("PageHeader", async() => {
                WriteLiteral("\r\n    <div class=\"col-sm-6\">\r\n        <h1 class=\"m-0\">T-Cube Home Page</h1>\r\n    </div>\r\n    <div class=\"col-sm-6\">\r\n        <ol class=\"breadcrumb float-sm-right\">\r\n            <li class=\"breadcrumb-item active\">Home</li>\r\n        </ol>\r\n    </div>\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<IndexModel>)PageContext?.ViewData;
        public IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591