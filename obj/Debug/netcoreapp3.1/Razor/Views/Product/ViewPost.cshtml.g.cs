#pragma checksum "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "c7e9beedde93249e619f0f8b7b12eb3276204123"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Product_ViewPost), @"mvc.1.0.view", @"/Views/Product/ViewPost.cshtml")]
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
#line 1 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\_ViewImports.cshtml"
using BachelorsHome;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\_ViewImports.cshtml"
using BachelorsHome.Models;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
using Microsoft.AspNetCore.Http;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"c7e9beedde93249e619f0f8b7b12eb3276204123", @"/Views/Product/ViewPost.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"32d655ee3fec78871864b95e1918396a00e0c796", @"/Views/_ViewImports.cshtml")]
    public class Views_Product_ViewPost : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<BachelorsHome.Models.Product>
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("class", new global::Microsoft.AspNetCore.Html.HtmlString("imagebox3"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("method", "Post", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_2 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "Profile", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_3 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Account", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_4 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-controller", "Product", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_5 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("asp-action", "EditPost", global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_6 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/Images/add.mp4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_7 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("type", new global::Microsoft.AspNetCore.Html.HtmlString("video/mp4"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
  
    ViewData["Title"] = "View Post";

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n");
            WriteLiteral("\r\n<div class=\"row2\">\r\n    <div class=\"gap1\"></div>\r\n    <div class=\"image\">\r\n        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("img", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.SelfClosing, "c7e9beedde93249e619f0f8b7b12eb32762041236635", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "src", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 232, "~/", 232, 2, true);
#nullable restore
#line 11 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
AddHtmlAttributeValue("", 234, Model.Picture, 234, 14, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n    </div>\r\n    <div class=\"gap1\"></div>\r\n\r\n</div>\r\n\r\n<div class=\"row2\">\r\n    <div class=\"gap1\"></div>\r\n\r\n\r\n    <div class=\"advertise\">\r\n        <div class=\"space2\"></div>\r\n\r\n        <h3>");
#nullable restore
#line 24 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
       Write(Model.Heading);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"</h3>
        <div class=""space2""></div>
        <h4>Facilities</h4>
        <div class=""row1"">
            <span lazyload=""true"">
                <svg xmlns=""http://www.w3.org/2000/svg"" width=""22"" height=""18"" viewBox=""0 0 22 18"">
                    <path fill=""#000"" fill-rule=""evenodd"" d=""M18.67 9.038a10.705 10.705 0 0 0-15.388 0 .585.585 0 0 1-.86 0 .617.617 0 0 1 0-.88 11.917 11.917 0 0 1 17.108 0 .617.617 0 0 1 0 .88c-.099.125-.246.176-.418.176a.623.623 0 0 1-.443-.176zm-2.926 3.293a6.437 6.437 0 0 0-4.621-1.96c-1.745 0-3.368.703-4.621 1.96a.585.585 0 0 1-.86 0 .617.617 0 0 1 0-.88 7.65 7.65 0 0 1 5.48-2.313c2.066 0 4.008.83 5.482 2.313a.617.617 0 0 1 0 .88c-.098.126-.27.176-.417.176a.623.623 0 0 1-.443-.176zm5.187-6.888a13.859 13.859 0 0 0-19.886 0 .585.585 0 0 1-.86 0 .617.617 0 0 1 0-.88c5.948-6.084 15.657-6.084 21.63 0a.617.617 0 0 1-.442 1.056.623.623 0 0 1-.442-.176zM9.796 17.233a2.128 2.128 0 0 1 0-2.941c.762-.78 2.113-.78 2.876 0a2.128 2.128 0 0 1 0 2.941 2.006 2.006 0 0 1-1.426.604c-.541 0");
            WriteLiteral("-1.057-.227-1.45-.604zm.86-2.061a.848.848 0 0 0 0 1.181c.32.327.86.327 1.155 0a.848.848 0 0 0 0-1.181.705.705 0 0 0-.565-.252.79.79 0 0 0-.59.252z\"></path>\r\n                </svg>\r\n            </span>\r\n");
#nullable restore
#line 33 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
             if (Model.InternetFacility == "Yes")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label class=\"gap1\">Wifi</label>\r\n");
#nullable restore
#line 36 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label class=\"gap1\">No Wifi</label>\r\n");
#nullable restore
#line 40 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            <span lazyload=""true"">
                <svg xmlns=""http://www.w3.org/2000/svg"" width=""22"" height=""17"" viewBox=""0 0 22 17"">
                    <path fill=""#000"" fill-rule=""evenodd"" d=""M20.172 0H1.832C.823 0 0 .792 0 1.767v6.422c0 .971.823 1.763 1.832 1.763h18.336C21.177 9.952 22 9.16 22 8.189V1.767C22.004.792 21.181 0 20.172 0zm.712 8.277a.61.61 0 0 1-.617.604H1.737a.61.61 0 0 1-.617-.604V1.683a.61.61 0 0 1 .617-.604h18.526a.61.61 0 0 1 .617.604v6.594h.004zm-2.315-1.85H3.435c-.338 0-.61.218-.61.49 0 .27.272.49.61.49h15.13c.338 0 .61-.22.61-.49 0-.272-.272-.49-.606-.49zm-4.965-3.001H8.049c-.124 0-.224.219-.224.49 0 .27.1.49.224.49h5.553c.124 0 .224-.22.224-.49 0-.271-.1-.49-.222-.49zm-9.03 8.996a3.31 3.31 0 0 0-.291-.559c-.148-.213-.08-.495.154-.63a.529.529 0 0 1 .69.14c.1.145.242.392.38.72.488 1.153.55 2.383-.103 3.545a4.304 4.304 0 0 1-.666.885.534.534 0 0 1-.706.04.43.43 0 0 1-.044-.645 3.39 3.39 0 0 0 .526-.697c.503-.896.454-1.866.06-2.8zm3.599 0a3.31 3.31 0 0 0-.292-.559c-.148-.213-.079-.495");
            WriteLiteral(@".155-.63a.529.529 0 0 1 .69.14c.1.145.241.392.38.72.487 1.153.55 2.383-.103 3.545a4.304 4.304 0 0 1-.667.885.534.534 0 0 1-.706.04.43.43 0 0 1-.043-.645 3.39 3.39 0 0 0 .526-.697c.503-.896.454-1.866.06-2.8zm9.002 0c-.394.933-.443 1.903.06 2.8.135.24.309.472.525.696a.43.43 0 0 1-.043.645.534.534 0 0 1-.706-.04 4.304 4.304 0 0 1-.666-.885c-.653-1.162-.59-2.392-.104-3.545.14-.328.28-.575.38-.72a.529.529 0 0 1 .69-.14c.234.135.303.417.155.63a3.31 3.31 0 0 0-.291.559zm-3.603 0c-.395.933-.443 1.903.06 2.8.135.24.309.472.525.696a.43.43 0 0 1-.043.645.534.534 0 0 1-.706-.04 4.304 4.304 0 0 1-.666-.885c-.653-1.162-.59-2.392-.104-3.545.14-.328.28-.575.38-.72a.529.529 0 0 1 .69-.14c.234.135.303.417.155.63a3.31 3.31 0 0 0-.291.559z""></path>
                </svg>
            </span>
");
#nullable restore
#line 46 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
             if (Model.Type == "AC")
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label class=\"gap1\">AC</label>\r\n");
#nullable restore
#line 49 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
            }
            else
            {

#line default
#line hidden
#nullable disable
            WriteLiteral("                <label class=\"gap1\">Non-AC</label>\r\n");
#nullable restore
#line 53 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
            }

#line default
#line hidden
#nullable disable
            WriteLiteral(@"            

            <span lazyload=""true"">
                <svg xmlns=""http://www.w3.org/2000/svg"" width=""22"" height=""21"" viewBox=""0 0 22 21"">
                    <path fill=""#000"" fill-rule=""evenodd"" d=""M20.62 0H1.38C.619 0 0 .619 0 1.38V13.76c0 .761.619 1.38 1.38 1.38h9.131v1.97c-1.547.05-2.993.334-4.113.814-1.369.587-2.122 1.417-2.122 2.339 0 .27.219.489.489.489h12.47c.27 0 .49-.219.49-.489 0-.922-.755-1.752-2.123-2.339-1.12-.48-2.566-.764-4.113-.813v-1.97h9.131c.761 0 1.38-.62 1.38-1.38V1.38C22 .619 21.38 0 20.62 0zm-4.049 19.775H5.429c.238-.34.708-.674 1.354-.951 1.119-.48 2.616-.743 4.217-.743 1.6 0 3.098.264 4.217.743.646.277 1.116.612 1.354.951zm4.451-6.014c0 .222-.18.402-.402.402H1.38a.402.402 0 0 1-.402-.402V1.38c0-.222.18-.402.402-.402h19.24c.222 0 .402.18.402.402V13.76zM19.284 2.227H2.716a.489.489 0 0 0-.489.489v9.71c0 .27.219.488.489.488h16.568c.27 0 .49-.219.49-.489v-9.71a.489.489 0 0 0-.49-.488zm-.489 9.71H3.205V3.204h15.59v8.731z""></path>
                </svg>
            </span>
            WriteLiteral(@"
            <label class=""gap1"">TV</label>

        </div>
        <div class=""row1"">

            <span lazyload=""true"">
                <svg xmlns=""http://www.w3.org/2000/svg"" width=""22"" height=""18"" viewBox=""0 0 22 18"">
                    <path fill=""#000"" fill-rule=""evenodd"" d=""M13.177 1H2.537A1.54 1.54 0 0 0 1 2.537v13.95c.005.8.62 1.467 1.42 1.528v.483c0 .26.212.472.472.472s.473-.212.473-.472v-.473h8.985v.473c0 .26.213.472.473.472s.473-.212.473-.472v-.488a1.536 1.536 0 0 0 1.418-1.527V2.533c0-.843-.69-1.533-1.537-1.533zm.59 15.488a.59.59 0 0 1-.59.59H2.538a.59.59 0 0 1-.592-.59V2.538c0-.327.265-.592.59-.592h10.64c.328 0 .592.265.592.59v13.95zm-2.363-10.76a.474.474 0 0 0-.473.474V9.04c0 .26.214.472.474.472s.473-.212.473-.473V6.2a.474.474 0 0 0-.473-.473z""></path>
                </svg>
            </span>
            <label class=""gap1"">Mini Fridge</label>


            <span lazyload=""true"">
                <svg xmlns=""http://www.w3.org/2000/svg"" width=""22"" height=""17"" viewBox=""0 0 22 17""");
            WriteLiteral(@">
                    <path d=""M17.55 2.175H16.5v-.337C16.5.9 15.75.15 14.812.15c-.937 0-1.687.75-1.687 1.688v.337h-8.25v-.337C4.875.9 4.125.15 3.187.15 2.25.15 1.5.9 1.5 1.838v.337H.45c-.225 0-.375.15-.375.375v12.075c0 .225.15.375.375.375h17.063c.224 0 .374-.15.374-.375V2.55c.038-.225-.15-.375-.337-.375zm-3.675-.337c0-.526.412-.938.938-.938.524 0 .937.412.937.937v.338h-1.875v-.337zm-11.588 0c0-.526.413-.938.938-.938.525 0 .937.412.937.937v.338H2.288v-.337zM17.175 14.25H.825V2.925h16.313V14.25h.037z""></path>
                    <path d=""M7.088 9h2.887l-3.112 3.113c-.376.375.187.862.524.524l3.75-3.75c.263-.262.113-.637-.225-.637H8.025l3.15-3.15c.337-.337-.188-.9-.525-.525l-3.825 3.75C6.6 8.588 6.75 9 7.088 9z""></path>
                </svg>
            </span>
            <label class=""gap1"">Electricity</label>

            <span lazyload=""true"">
                <svg xmlns=""http://www.w3.org/2000/svg"" width=""22"" height=""21"" viewBox=""0 0 22 21"">
                    <path d=""M18.265 11.322c-.14-.833-.6-");
            WriteLiteral(@"3.383-1.096-4.348-.332-.642-1.18-1.134-2.524-1.46-1.09-.264-2.486-.41-3.927-.41-1.443 0-2.838.145-3.93.41-1.342.327-2.19.818-2.522 1.46-.496.964-.955 3.515-1.096 4.348-.758.505-1.13 1.234-1.13 2.204v2.632c0 .686.453 1.27 1.084 1.488v1.143c0 .58.487 1.052 1.085 1.052h1.085c.598 0 1.085-.473 1.085-1.053v-1.053h8.677v1.052c0 .58.487 1.052 1.085 1.052h1.084c.598 0 1.085-.473 1.085-1.053v-1.144a1.585 1.585 0 0 0 1.086-1.488v-2.632c0-.97-.373-1.7-1.13-2.204zm-7.542-5.39c3.247 0 5.352.706 5.686 1.373.322.645.68 2.352.903 3.572a5.8 5.8 0 0 0-.34-.09c-.3-.07-1.075-.148-1.42-.195l-2.86-2.165c-.252-.18-.547-.117-.728.135-.182.25-.135.45.117.63l1.763 1.26c-.957-.03-2.006-.03-3.123-.03-.132 0-.595.013-.726.013L7.03 8.427c-.26-.172-.51-.124-.68.135-.173.258-.137.47.122.643l1.85 1.23c-1.51.027-2.822.108-3.85.352a8.33 8.33 0 0 0-.34.09c.223-1.22.58-2.927.905-3.572.334-.666 2.44-1.374 5.686-1.374zM5.536 19.098H3.974v-1.363h1.562V19.1zm10.373 0v-1.363h1.56V19.1h-1.56zm2.64-2.755c0 .316-.25.572-.558.572H3.452a.566.566 0 0 1-.55");
            WriteLiteral(@"8-.572V13.48c0-1.058.543-1.623 1.876-1.948 1.404-.342 3.512-.342 5.953-.342 2.44 0 4.547 0 5.952.342 1.333.325 1.876.89 1.876 1.948v2.864zM5.84 15.295c.707 0 1.282-.557 1.282-1.243s-.575-1.244-1.282-1.244c-.707 0-1.282.558-1.282 1.244 0 .686.575 1.244 1.282 1.244zm0-1.658c.236 0 .427.186.427.415a.42.42 0 0 1-.427.415.42.42 0 0 1-.427-.415c0-.23.19-.415.428-.415zm9.76 1.66c.708 0 1.283-.56 1.283-1.245s-.574-1.244-1.28-1.244c-.707 0-1.282.558-1.282 1.244 0 .686.575 1.244 1.28 1.244zm0-1.66c.237 0 .43.186.43.415a.42.42 0 0 1-.43.415.42.42 0 0 1-.426-.415c0-.23.19-.415.427-.415zM21.51 2.882c.364.093.57.416.46.72l-.024.064c-.11.303-.5.475-.864.382L11.015 1.275.918 4.048c-.364.093-.753-.08-.864-.382L.03 3.6c-.11-.303.096-.626.46-.72L11.014 0 21.51 2.882z""></path>
                </svg>
            </span>

            <label class=""gap1"">Parking</label>




        </div>

        <div class=""space2""></div>
        <h6>Room Size: ");
#nullable restore
#line 96 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
                  Write(Model.RoomSize);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <h6>Available seat: ");
#nullable restore
#line 97 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
                       Write(Model.AvailableSeat);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <h6>Internet Facility: ");
#nullable restore
#line 98 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
                          Write(Model.InternetFacility);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <h6>Food Facility: ");
#nullable restore
#line 99 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
                      Write(Model.FoodFacility);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <h6>Attached Washroom: ");
#nullable restore
#line 100 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
                          Write(Model.AttachedWashroom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <h6>Attached Belcony: ");
#nullable restore
#line 101 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
                         Write(Model.AttachedBalcony);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <h6 class=\"blue\">Seat Rent: ");
#nullable restore
#line 102 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
                               Write(Model.SeatRent);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <h6 class=\"blue\">Total Rent: ");
#nullable restore
#line 103 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
                                Write(Model.TotalCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n        <div class=\"space2\"></div>\r\n        <div class=\"space2\"></div>\r\n        <h3>Room Details</h3>\r\n        <p class=\"details\">\r\n            ");
#nullable restore
#line 108 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
       Write(Model.Details);

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
        </p>
        <div class=""space2""></div>
        <div class=""space2""></div>
        <div class=""space2""></div>
        <div class=""space2""></div>
        <div class=""row1"">
            <div class=""comment"">
                <h4>Comments:</h4>
            </div>
        </div>
        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7e9beedde93249e619f0f8b7b12eb327620412321596", async() => {
                WriteLiteral("\r\n            <div class=\"row1\">\r\n\r\n                <div class=\"comment2\">\r\n                    <input class=\"textarea9\" type=\"text\" name=\"commenttext\"");
                BeginWriteAttribute("required", " required=\"", 10085, "\"", 10096, 0);
                EndWriteAttribute();
                WriteLiteral(" placeholder=\"Write your comment here\">\r\n                </div>\r\n                <button type=\"Submit\" class=\"btn loginbutton\" value=\"Submit\"");
                BeginWriteAttribute("name", " name=\"", 10238, "\"", 10245, 0);
                EndWriteAttribute();
                WriteLiteral(">Send</button>\r\n\r\n\r\n\r\n            </div>\r\n        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            BeginAddHtmlAttributeValues(__tagHelperExecutionContext, "action", 2, global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            AddHtmlAttributeValue("", 9888, "/Product/CommentDone/", 9888, 21, true);
#nullable restore
#line 119 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
AddHtmlAttributeValue("", 9909, Model.Id, 9909, 9, false);

#line default
#line hidden
#nullable disable
            EndAddHtmlAttributeValues(__tagHelperExecutionContext);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Method = (string)__tagHelperAttribute_1.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n        <div class=\"space2\"></div>\r\n        ");
#nullable restore
#line 132 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
    Write(await Component.InvokeAsync("Comment",new { postId = Model.Id}));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n\r\n        <div class=\"space2\"></div>\r\n\r\n\r\n\r\n    </div>\r\n\r\n\r\n    <div class=\"advertise2\">\r\n        <div class=\"row1\">\r\n            <div class=\"advertise3\">\r\n                <h4><i class=\"fa fa-user-circle\" aria-hidden=\"true\"></i>    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("a", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7e9beedde93249e619f0f8b7b12eb327620412324856", async() => {
#nullable restore
#line 144 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
                                                                                                                                                     Write(Model.UserName);

#line default
#line hidden
#nullable disable
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Action = (string)__tagHelperAttribute_2.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_2);
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.Controller = (string)__tagHelperAttribute_3.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_3);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.AnchorTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 144 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
                                                                                                                               WriteLiteral(Model.UserId);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_AnchorTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("</h4>\r\n                <br /><h4 class=\"taka\"><i class=\"fa fa-money\" aria-hidden=\"true\"></i>    ");
#nullable restore
#line 145 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
                                                                                    Write(Model.TotalCost);

#line default
#line hidden
#nullable disable
            WriteLiteral("  BDT</h4>\r\n                <h6 class=\"blue\"><i class=\"fa fa-map-marker\" aria-hidden=\"true\"></i>    ");
#nullable restore
#line 146 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
                                                                                   Write(Model.Thana);

#line default
#line hidden
#nullable disable
            WriteLiteral(",");
#nullable restore
#line 146 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
                                                                                                Write(Model.District);

#line default
#line hidden
#nullable disable
            WriteLiteral(",");
#nullable restore
#line 146 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
                                                                                                                Write(Model.Division);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <h6><i class=\"fa fa-home\" aria-hidden=\"true\"></i>    ");
#nullable restore
#line 147 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
                                                                Write(Model.HomeAddress);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n                <h6 class=\"blue\"><i class=\"fa fa-clock-o\" aria-hidden=\"true\"></i>    ");
#nullable restore
#line 148 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
                                                                                Write(Model.AvailableFrom);

#line default
#line hidden
#nullable disable
            WriteLiteral("</h6>\r\n");
#nullable restore
#line 149 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
                 if (Context.Session.GetString("username") != null && Model.UserId == Context.Session.GetInt32("userid"))
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <br/>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "c7e9beedde93249e619f0f8b7b12eb327620412330212", async() => {
                WriteLiteral("\r\n                        <input type=\"Submit\" class=\"btn loginbutton\" value=\"Edit Post\"");
                BeginWriteAttribute("name", " name=\"", 11570, "\"", 11577, 0);
                EndWriteAttribute();
                WriteLiteral(" />\r\n                    ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Controller = (string)__tagHelperAttribute_4.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_4);
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.Action = (string)__tagHelperAttribute_5.Value;
            __tagHelperExecutionContext.AddTagHelperAttribute(__tagHelperAttribute_5);
            if (__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues == null)
            {
                throw new InvalidOperationException(InvalidTagHelperIndexerAssignment("asp-route-id", "Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper", "RouteValues"));
            }
            BeginWriteTagHelperAttribute();
#nullable restore
#line 152 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
                                                                           WriteLiteral(Model.Id);

#line default
#line hidden
#nullable disable
            __tagHelperStringValueBuffer = EndWriteTagHelperAttribute();
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"] = __tagHelperStringValueBuffer;
            __tagHelperExecutionContext.AddTagHelperAttribute("asp-route-id", __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper.RouteValues["id"], global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n");
#nullable restore
#line 155 "C:\Users\Asus\Desktop\BachelorsHome\BachelorsHome\Views\Product\ViewPost.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </div>\r\n        </div>\r\n        <div class=\"row1\">\r\n            <div class=\"video-design\">\r\n                <video height=\"350\" width=\"350\" autoplay muted>\r\n                    ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("source", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagOnly, "c7e9beedde93249e619f0f8b7b12eb327620412333564", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_6);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_7);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n\r\n                </video>\r\n            </div>\r\n\r\n        </div>\r\n    </div>\r\n\r\n\r\n\r\n</div>\r\n\r\n\r\n\r\n");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<BachelorsHome.Models.Product> Html { get; private set; }
    }
}
#pragma warning restore 1591