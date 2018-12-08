#pragma checksum "/home/codio/workspace/crimes/Views/CrimeCodes.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "9bbda8d2ec01e87c388d9fe4941707e3ad5985b1"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(crimes.Pages.Views_CrimeCodes), @"mvc.1.0.razor-page", @"/Views/CrimeCodes.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Views/CrimeCodes.cshtml", typeof(crimes.Pages.Views_CrimeCodes), null)]
namespace crimes.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.AspNetCore.Mvc.Rendering;
    using Microsoft.AspNetCore.Mvc.ViewFeatures;
#line 1 "/home/codio/workspace/crimes/Views/_ViewImports.cshtml"
using crimes;

#line default
#line hidden
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"9bbda8d2ec01e87c388d9fe4941707e3ad5985b1", @"/Views/CrimeCodes.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f842f8255da31aa43ed40deaf7f18adbc89934f4", @"/Views/_ViewImports.cshtml")]
    public class Views_CrimeCodes : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/home/codio/workspace/crimes/Views/CrimeCodes.cshtml"
  
  ViewData["Title"] = "Info By Crime Code";

#line default
#line hidden
            BeginContext(78, 32, true);
            WriteLiteral("\n<h2>Info By Crime Code</h2>  \n\n");
            EndContext();
#line 9 "/home/codio/workspace/crimes/Views/CrimeCodes.cshtml"
  
   if (@Model.EX != null)
	 {

#line default
#line hidden
            BeginContext(143, 37, true);
            WriteLiteral("\t   <br />\n\t\t <br />\n\t\t <h3>**ERROR: ");
            EndContext();
            BeginContext(181, 16, false);
#line 14 "/home/codio/workspace/crimes/Views/CrimeCodes.cshtml"
                 Write(Model.EX.Message);

#line default
#line hidden
            EndContext();
            BeginContext(197, 46, true);
            WriteLiteral("</h3>\n\t\t <br />\n\t\t <hr />\n\t\t <br />\n\t\t <br />\n");
            EndContext();
#line 19 "/home/codio/workspace/crimes/Views/CrimeCodes.cshtml"
	 }

#line default
#line hidden
            BeginContext(249, 416, true);
            WriteLiteral(@"
<table class=""table"">  
    <thead>  
        <tr>  
            <th>  
                Rank
            </th>  
            <th>
                crimeCode 
            </th>  
            <th>  
                PrimaryDescription
            </th>  
            <th>
                SecondaryDescription
            </th>  
            <th>  
                Occurence
        </tr>  
    </thead>  
    <tbody>  
");
            EndContext();
#line 42 "/home/codio/workspace/crimes/Views/CrimeCodes.cshtml"
                  
				   int rank = 1;
				 

#line default
#line hidden
            BeginContext(700, 5, true);
            WriteLiteral("\t\t\t\t\n");
            EndContext();
#line 46 "/home/codio/workspace/crimes/Views/CrimeCodes.cshtml"
         foreach (var item in Model.CrimesList)  
        {  

#line default
#line hidden
            BeginContext(767, 52, true);
            WriteLiteral("            <tr>  \n                <td>  \n\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(820, 4, false);
#line 50 "/home/codio/workspace/crimes/Views/CrimeCodes.cshtml"
                                   Write(rank);

#line default
#line hidden
            EndContext();
            BeginContext(824, 68, true);
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
            EndContext();
            BeginContext(893, 14, false);
#line 53 "/home/codio/workspace/crimes/Views/CrimeCodes.cshtml"
               Write(item.crimeCode);

#line default
#line hidden
            EndContext();
            BeginContext(907, 68, true);
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
            EndContext();
            BeginContext(976, 23, false);
#line 56 "/home/codio/workspace/crimes/Views/CrimeCodes.cshtml"
               Write(item.PrimaryDescription);

#line default
#line hidden
            EndContext();
            BeginContext(999, 68, true);
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
            EndContext();
            BeginContext(1068, 25, false);
#line 59 "/home/codio/workspace/crimes/Views/CrimeCodes.cshtml"
               Write(item.SecondaryDescription);

#line default
#line hidden
            EndContext();
            BeginContext(1093, 68, true);
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
            EndContext();
            BeginContext(1162, 14, false);
#line 62 "/home/codio/workspace/crimes/Views/CrimeCodes.cshtml"
               Write(item.Occurence);

#line default
#line hidden
            EndContext();
            BeginContext(1176, 45, true);
            WriteLiteral("\n                </td>  \n            </tr>  \n");
            EndContext();
#line 65 "/home/codio/workspace/crimes/Views/CrimeCodes.cshtml"
						
						rank++;
        }  

#line default
#line hidden
            BeginContext(1254, 24, true);
            WriteLiteral("    </tbody>  \n</table> ");
            EndContext();
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CrimeCodesModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CrimeCodesModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CrimeCodesModel>)PageContext?.ViewData;
        public CrimeCodesModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591