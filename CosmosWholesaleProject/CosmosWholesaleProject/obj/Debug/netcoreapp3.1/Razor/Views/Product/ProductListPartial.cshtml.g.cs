#pragma checksum "C:\Users\maria\Documents\CosmosWholesale Github\CosmosWholesaleProject\CosmosWholesaleProject\Views\Product\ProductListPartial.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "32296f1faaea6a8834f927266ea27b51a793e4f2"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ProductListPartial), @"mvc.1.0.view", @"/Views/Product/ProductListPartial.cshtml")]
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
#line 1 "C:\Users\maria\Documents\CosmosWholesale Github\CosmosWholesaleProject\CosmosWholesaleProject\Views\Product\ProductListPartial.cshtml"
using CosmosWholesaleProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32296f1faaea6a8834f927266ea27b51a793e4f2", @"/Views/Product/ProductListPartial.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2be501dc90560936c93533a0c037f27ff1785aaf", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ProductListPartial : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 2 "C:\Users\maria\Documents\CosmosWholesale Github\CosmosWholesaleProject\CosmosWholesaleProject\Views\Product\ProductListPartial.cshtml"
  
    Layout = "~/Pages/Shared/Food.cshtml";

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\maria\Documents\CosmosWholesale Github\CosmosWholesaleProject\CosmosWholesaleProject\Views\Product\ProductListPartial.cshtml"
  

    foreach (var cart in Model)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <div class=\"main-content\">\r\n            <div class=\"content-image\">\r\n                <a href=\"#\"><img");
            BeginWriteAttribute("src", " src=\'", 245, "\'", 303, 1);
#nullable restore
#line 11 "C:\Users\maria\Documents\CosmosWholesale Github\CosmosWholesaleProject\CosmosWholesaleProject\Views\Product\ProductListPartial.cshtml"
WriteAttributeValue("", 251, Url.Content("~/images/FoodPageImages/" +cart.Image), 251, 52, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(" /></a>\r\n            </div>\r\n            <div class=\"content-title\">\r\n                <a href=\"#\">");
#nullable restore
#line 14 "C:\Users\maria\Documents\CosmosWholesale Github\CosmosWholesaleProject\CosmosWholesaleProject\Views\Product\ProductListPartial.cshtml"
                       Write(cart.ProductId);

#line default
#line hidden
#nullable disable
            WriteLiteral("</a>\r\n            </div>\r\n            <div class=\"content-price\">\r\n                Price:$");
#nullable restore
#line 17 "C:\Users\maria\Documents\CosmosWholesale Github\CosmosWholesaleProject\CosmosWholesaleProject\Views\Product\ProductListPartial.cshtml"
                  Write(cart.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n            <div class=\"content-price\">\r\n                ");
#nullable restore
#line 20 "C:\Users\maria\Documents\CosmosWholesale Github\CosmosWholesaleProject\CosmosWholesaleProject\Views\Product\ProductListPartial.cshtml"
           Write(Html.ActionLink("Add to Cart", "OrderNow", "ShoppingCart", new { id = cart.ProductID }, null));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n            </div>\r\n        </div>\r\n");
#nullable restore
#line 23 "C:\Users\maria\Documents\CosmosWholesale Github\CosmosWholesaleProject\CosmosWholesaleProject\Views\Product\ProductListPartial.cshtml"

    }

#line default
#line hidden
#nullable disable
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
