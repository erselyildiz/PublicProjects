#pragma checksum "C:\Users\ersel\source\repos\Imdb\Presantaion\Views\Movies\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "6642e186e166c6de963a191b3647b9e0226243cf"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_Movies_Index), @"mvc.1.0.view", @"/Views/Movies/Index.cshtml")]
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
#line 1 "C:\Users\ersel\source\repos\Imdb\Presantaion\Views\_ViewImports.cshtml"
using Imdb;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\ersel\source\repos\Imdb\Presantaion\Views\_ViewImports.cshtml"
using Entities.Abstract;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"6642e186e166c6de963a191b3647b9e0226243cf", @"/Views/Movies/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b706bf089aae0f703ff4ea5b64b9a60152a26e21", @"/Views/_ViewImports.cshtml")]
    public class Views_Movies_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<List<Entities.Concrete.Movie>>
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
            WriteLiteral("\r\n");
#nullable restore
#line 3 "C:\Users\ersel\source\repos\Imdb\Presantaion\Views\Movies\Index.cshtml"
  
    ViewData["Title"] = "Movies";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"
<a role=""button"" class=""btn btn-success"" href=""/Movies/CreateEdit"">Create</a>

<div class=""row"">
    <div class=""col-12"">
        <table class=""table table-sm table-striped table-hover border-bottom"">
            <thead>
                <tr>
                    <th class=""d-none d-lg-table-cell"">
                        ");
#nullable restore
#line 15 "C:\Users\ersel\source\repos\Imdb\Presantaion\Views\Movies\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model[0].Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 18 "C:\Users\ersel\source\repos\Imdb\Presantaion\Views\Movies\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model[0].ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        ");
#nullable restore
#line 21 "C:\Users\ersel\source\repos\Imdb\Presantaion\Views\Movies\Index.cshtml"
                   Write(Html.DisplayNameFor(model => model[0].Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                    </th>\r\n                    <th>\r\n                        Detail\r\n                    </th>\r\n                </tr>\r\n            </thead>\r\n            <tbody>\r\n");
#nullable restore
#line 29 "C:\Users\ersel\source\repos\Imdb\Presantaion\Views\Movies\Index.cshtml"
                 if (Model.Count > 0)
                {
                    foreach (var item in Model)
                    {

#line default
#line hidden
#nullable disable
            WriteLiteral("                        <tr>\r\n                            <td class=\"d-none d-lg-table-cell\">\r\n                                ");
#nullable restore
#line 35 "C:\Users\ersel\source\repos\Imdb\Presantaion\Views\Movies\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Name));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 38 "C:\Users\ersel\source\repos\Imdb\Presantaion\Views\Movies\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.ReleaseDate));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                ");
#nullable restore
#line 41 "C:\Users\ersel\source\repos\Imdb\Presantaion\Views\Movies\Index.cshtml"
                           Write(Html.DisplayFor(modelItem => item.Genre));

#line default
#line hidden
#nullable disable
            WriteLiteral("\r\n                            </td>\r\n                            <td>\r\n                                <a role=\"button\" class=\"btn btn-sm btn-primary\"");
            BeginWriteAttribute("href", " href=\"", 1633, "\"", 1670, 2);
            WriteAttributeValue("", 1640, "/Movies/CreateEdit?id=", 1640, 22, true);
#nullable restore
#line 44 "C:\Users\ersel\source\repos\Imdb\Presantaion\Views\Movies\Index.cshtml"
WriteAttributeValue("", 1662, item.Id, 1662, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Edit</a>\r\n                                <a role=\"button\" class=\"btn btn-sm btn-danger\"");
            BeginWriteAttribute("href", " href=\"", 1760, "\"", 1793, 2);
            WriteAttributeValue("", 1767, "/Movies/Delete?id=", 1767, 18, true);
#nullable restore
#line 45 "C:\Users\ersel\source\repos\Imdb\Presantaion\Views\Movies\Index.cshtml"
WriteAttributeValue("", 1785, item.Id, 1785, 8, false);

#line default
#line hidden
#nullable disable
            EndWriteAttribute();
            WriteLiteral(">Delete</a>\r\n                            </td>\r\n                        </tr>\r\n");
#nullable restore
#line 48 "C:\Users\ersel\source\repos\Imdb\Presantaion\Views\Movies\Index.cshtml"
                    }
                }
                else
                {

#line default
#line hidden
#nullable disable
            WriteLiteral("                    <tr>\r\n                        <td colspan=\"5\" class=\"text-center\">\r\n                            No Records Found\r\n                        </td>\r\n                    </tr>\r\n");
#nullable restore
#line 57 "C:\Users\ersel\source\repos\Imdb\Presantaion\Views\Movies\Index.cshtml"
                }

#line default
#line hidden
#nullable disable
            WriteLiteral("            </tbody>\r\n        </table>\r\n    </div>\r\n</div>");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<List<Entities.Concrete.Movie>> Html { get; private set; }
    }
}
#pragma warning restore 1591
