#pragma checksum "C:\Users\maria\Documents\CosmosWholesale Github\CosmosWholesaleProject\CosmosWholesaleProject\Views\Cart\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "2ed861ec59829dac503925ab67c8aa8ec520b49f"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Cart_Index), @"mvc.1.0.view", @"/Views/Cart/Index.cshtml")]
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
#line 1 "C:\Users\maria\Documents\CosmosWholesale Github\CosmosWholesaleProject\CosmosWholesaleProject\Views\_ViewImports.cshtml"
using CosmosWholesaleProject.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2ed861ec59829dac503925ab67c8aa8ec520b49f", @"/Views/Cart/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"2be501dc90560936c93533a0c037f27ff1785aaf", @"/Views/_ViewImports.cshtml")]
    public class Views_Cart_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\maria\Documents\CosmosWholesale Github\CosmosWholesaleProject\CosmosWholesaleProject\Views\Cart\Index.cshtml"
  
    ViewBag.Title = "Food";
    Layout = "~/Pages/Shared/_Layout.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral("<h2>Index</h2>\r\n<table cellpadding=\"2\" cellspacing=\"2\" border=\"1\">\r\n    <tr>\r\n        <th>ID</th>\r\n        <th>Price</th>\r\n        <th>Quantity</th>\r\n        <th>Sub Total</th>\r\n    </tr>\r\n");
#nullable restore
#line 13 "C:\Users\maria\Documents\CosmosWholesale Github\CosmosWholesaleProject\CosmosWholesaleProject\Views\Cart\Index.cshtml"
     foreach (var cart in ViewBag.Cart)
    {

#line default
#line hidden
#nullable disable
            WriteLiteral("        <tr>\r\n");
            WriteLiteral("            <td>");
#nullable restore
#line 17 "C:\Users\maria\Documents\CosmosWholesale Github\CosmosWholesaleProject\CosmosWholesaleProject\Views\Cart\Index.cshtml"
           Write(cart.Product.ProductID);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 18 "C:\Users\maria\Documents\CosmosWholesale Github\CosmosWholesaleProject\CosmosWholesaleProject\Views\Cart\Index.cshtml"
           Write(cart.Product.Price);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 19 "C:\Users\maria\Documents\CosmosWholesale Github\CosmosWholesaleProject\CosmosWholesaleProject\Views\Cart\Index.cshtml"
           Write(cart.Product.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n            <td>");
#nullable restore
#line 20 "C:\Users\maria\Documents\CosmosWholesale Github\CosmosWholesaleProject\CosmosWholesaleProject\Views\Cart\Index.cshtml"
            Write(cart.Product.Price * cart.Product.Quantity);

#line default
#line hidden
#nullable disable
            WriteLiteral("</td>\r\n        </tr>\r\n");
#nullable restore
#line 22 "C:\Users\maria\Documents\CosmosWholesale Github\CosmosWholesaleProject\CosmosWholesaleProject\Views\Cart\Index.cshtml"
    }

#line default
#line hidden
#nullable disable
            WriteLiteral("    <tr>\r\n        <td align=\"right\" colspan=\"6\">Sum</td>\r\n        <td>\r\n            ");
#nullable restore
#line 26 "C:\Users\maria\Documents\CosmosWholesale Github\CosmosWholesaleProject\CosmosWholesaleProject\Views\Cart\Index.cshtml"
       Write(ViewBag.total);

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n        </td>\r\n    </tr>\r\n</table>\r\n\r\n");
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
