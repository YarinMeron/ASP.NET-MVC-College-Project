#pragma checksum "C:\Users\yarinmeron\source\repos\ShenkinStore\ShenkinStore\Views\ShoppingCart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9c46b30a1d98811eef097f29116525ca386f5873"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_ShoppingCart_Index), @"mvc.1.0.view", @"/Views/ShoppingCart/Index.cshtml")]
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
#line 1 "C:\Users\yarinmeron\source\repos\ShenkinStore\ShenkinStore\Views\_ViewImports.cshtml"
using ShenkinStore;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\yarinmeron\source\repos\ShenkinStore\ShenkinStore\Views\_ViewImports.cshtml"
using ShenkinStore.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9c46b30a1d98811eef097f29116525ca386f5873", @"/Views/ShoppingCart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"878522bbb99fe5cc18380b941aef29d870928c4d", @"/Views/_ViewImports.cshtml")]
    public class Views_ShoppingCart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<ShenkinStore.ViewModels.ShoppingCartViewModel>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("rel", new global::Microsoft.AspNetCore.Html.HtmlString("stylesheet"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("href", new global::Microsoft.AspNetCore.Html.HtmlString("~/css/cartCss.css"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\yarinmeron\source\repos\ShenkinStore\ShenkinStore\Views\ShoppingCart\Index.cshtml"
   ViewBag.Title = "Store Checkout";
    Layout = "~/Views/Shared/_Layout.cshtml"; 

#line default
#line hidden
#nullable disable
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("head", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "9c46b30a1d98811eef097f29116525ca386f58734285", async() => {
                WriteLiteral("\r\n    ");
                __tagHelperExecutionContext = __tagHelperScopeManager.Begin("link", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "9c46b30a1d98811eef097f29116525ca386f58734547", async() => {
                }
                );
                __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
                __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
                __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
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
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.HeadTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_HeadTagHelper);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
<div class=""containerNew"">

    <div class=""heading"">
        <h1>
            <span class=""shopper align-center""></span>Your Shopping Cart
        </h1>

        <a href=""https://localhost:44397/Products"" class=""visibility-cart transition is-open"">X</a>
    </div>



");
#nullable restore
#line 20 "C:\Users\yarinmeron\source\repos\ShenkinStore\ShenkinStore\Views\ShoppingCart\Index.cshtml"
     if (Model.CartItems.Count == 0)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <a class=\"btn btn-danger text-right middle-block\"");
            BeginWriteAttribute("href", " href=\'", 599, "\'", 638, 1);
#nullable restore
#line 22 "C:\Users\yarinmeron\source\repos\ShenkinStore\ShenkinStore\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 606, Url.Action("Index", "Products"), 606, 32, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Your Cart is empty continue buy</a> ");
#nullable restore
#line 22 "C:\Users\yarinmeron\source\repos\ShenkinStore\ShenkinStore\Views\ShoppingCart\Index.cshtml"
                                                                                                                                      }
    else
    {

#line default
#line hidden
#nullable disable
            WriteLiteral(@"        <table class=""table align-center"">
            <tr class=""align-center"">
                <th class=""th"">
                    Product Name
                </th>

                <th class=""th"">
                    Price
                </th>
                <th class=""th tuck "">
                    Amount
                </th>

                <th class=""th"">
                    Photo
                </th>

                <th class=""th"">
                    Total per amounts
                </th>


            </tr>

");
#nullable restore
#line 49 "C:\Users\yarinmeron\source\repos\ShenkinStore\ShenkinStore\Views\ShoppingCart\Index.cshtml"
             foreach (var item in Model.CartItems)
            {
                

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr");
            BeginWriteAttribute("id", " id=\"", 1347, "\"", 1371, 2);
            WriteAttributeValue("", 1352, "row-", 1352, 4, true);
#nullable restore
#line 52 "C:\Users\yarinmeron\source\repos\ShenkinStore\ShenkinStore\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 1356, item.ProductId, 1356, 15, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">\r\n            <td class=\" fonts\">\r\n");
            WriteLiteral("                <a class=\"fonts links\"");
            BeginWriteAttribute("href", " href=\'", 1560, "\'", 1637, 1);
#nullable restore
#line 55 "C:\Users\yarinmeron\source\repos\ShenkinStore\ShenkinStore\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 1567, Url.Action( "Details", "Products", new { id = item.ProductId }, null), 1567, 70, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">");
#nullable restore
#line 55 "C:\Users\yarinmeron\source\repos\ShenkinStore\ShenkinStore\Views\ShoppingCart\Index.cshtml"
                                                                                                                Write(item.ProductName);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </td>\r\n            <td class=\" fonts\">\r\n                ");
#nullable restore
#line 58 "C:\Users\yarinmeron\source\repos\ShenkinStore\ShenkinStore\Views\ShoppingCart\Index.cshtml"
           Write(item.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₪\r\n            </td>\r\n            <td   >\r\n\r\n         \r\n\r\n                <div class=\"col col-qty tuck layout-inline align-center\" >\r\n                    <section c width=\"100px\">\r\n\r\n                        <a");
            BeginWriteAttribute("href", " href=\'", 1951, "\'", 2045, 1);
#nullable restore
#line 67 "C:\Users\yarinmeron\source\repos\ShenkinStore\ShenkinStore\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 1958, Url.Action("IncreaseProductAmount", "ShoppingCart", new { id = item.ProductId }, null), 1958, 87, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"qty qty-plus\">+</a>\r\n\r\n                        <input type=\"numeric\"");
            BeginWriteAttribute("value", " value=\"", 2122, "\"", 2160, 1);
#nullable restore
#line 69 "C:\Users\yarinmeron\source\repos\ShenkinStore\ShenkinStore\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 2130, Model.Amounts[item.ProductId], 2130, 30, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" size=\"1\" class=\"align-center\" />\r\n\r\n                        <a");
            BeginWriteAttribute("href", " href=\'", 2224, "\'", 2318, 1);
#nullable restore
#line 71 "C:\Users\yarinmeron\source\repos\ShenkinStore\ShenkinStore\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 2231, Url.Action("DecreaseProductAmount", "ShoppingCart", new { id = item.ProductId }, null), 2231, 87, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"qty qty-minus\">-</a>\r\n                    </section>\r\n                </div>\r\n\r\n            </td>\r\n\r\n\r\n            <td class=\" fonts links\">\r\n                <img");
            BeginWriteAttribute("src", " src=\"", 2489, "\"", 2522, 1);
#nullable restore
#line 79 "C:\Users\yarinmeron\source\repos\ShenkinStore\ShenkinStore\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 2495, Url.Content(item.ImageUrl), 2495, 27, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" alt=\"cant display\" width=\"180px\" height=\"180px\" />\r\n            </td>\r\n           \r\n            <td class=\"fonts\">\r\n\r\n\r\n                ");
#nullable restore
#line 85 "C:\Users\yarinmeron\source\repos\ShenkinStore\ShenkinStore\Views\ShoppingCart\Index.cshtml"
           Write(Model.TotalPricePerProduct[item.ProductId]);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n            </td>\r\n\r\n\r\n\r\n            <td class=\" fonts text-right\">\r\n\r\n       \r\n                <a");
            BeginWriteAttribute("href", " href=\'", 2805, "\'", 2892, 1);
#nullable restore
#line 94 "C:\Users\yarinmeron\source\repos\ShenkinStore\ShenkinStore\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 2812, Url.Action("removefromcart", "ShoppingCart", new { id = item.ProductId }, null), 2812, 80, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" class=\"remove\">x</a>\r\n            </td>\r\n\r\n\r\n        </tr>\r\n");
#nullable restore
#line 99 "C:\Users\yarinmeron\source\repos\ShenkinStore\ShenkinStore\Views\ShoppingCart\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            \r\n            <tr class=\"text-right\">\r\n                <td class=\"fonts\">\r\n                    Total:\r\n                </td>\r\n                <td></td>\r\n                <td id=\"cart-total\" class=\"text-right\">\r\n                    <b>");
#nullable restore
#line 107 "C:\Users\yarinmeron\source\repos\ShenkinStore\ShenkinStore\Views\ShoppingCart\Index.cshtml"
                  Write(Model.CartTotal.ToString());

#line default
#line hidden
#nullable disable
            WriteLiteral(" ₪</b>\r\n                </td>\r\n            </tr>\r\n        </table>\r\n        <table>\r\n            <tr>\r\n                <td>\r\n                    <a class=\"btn \"");
            BeginWriteAttribute("href", " href=\'", 3405, "\'", 3440, 1);
#nullable restore
#line 114 "C:\Users\yarinmeron\source\repos\ShenkinStore\ShenkinStore\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 3412, Url.Action("Index", "Home"), 3412, 28, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Continue Buy</a>\r\n                </td>\r\n                <td>\r\n                    <a class=\"btn \"");
            BeginWriteAttribute("href", " href=\'", 3540, "\'", 3595, 1);
#nullable restore
#line 117 "C:\Users\yarinmeron\source\repos\ShenkinStore\ShenkinStore\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 3547, Url.Action("AddressAndPayment", "Transactions"), 3547, 48, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Proceed To Pay</a>\r\n                </td>\r\n                <td>          </td>\r\n\r\n            </tr>\r\n\r\n\r\n\r\n        </table>\r\n        <a class=\"btn-red\"");
            BeginWriteAttribute("href", " href=\'", 3748, "\'", 3795, 1);
#nullable restore
#line 126 "C:\Users\yarinmeron\source\repos\ShenkinStore\ShenkinStore\Views\ShoppingCart\Index.cshtml"
WriteAttributeValue("", 3755, Url.Action("emptyCart", "ShoppingCart"), 3755, 40, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral("> Empty Cart</a>\r\n");
#nullable restore
#line 127 "C:\Users\yarinmeron\source\repos\ShenkinStore\ShenkinStore\Views\ShoppingCart\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ShenkinStore.ViewModels.ShoppingCartViewModel> Html { get; private set; }
    }
}
#pragma warning restore 1591
