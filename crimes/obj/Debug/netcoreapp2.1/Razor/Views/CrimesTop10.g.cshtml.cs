#pragma checksum "/home/codio/workspace/crimes/Views/CrimesTop10.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "0286f4522282670034d3c61295c3fef32af7c6a4"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(crimes.Pages.Views_CrimesTop10), @"mvc.1.0.razor-page", @"/Views/CrimesTop10.cshtml")]
[assembly:global::Microsoft.AspNetCore.Mvc.RazorPages.Infrastructure.RazorPageAttribute(@"/Views/CrimesTop10.cshtml", typeof(crimes.Pages.Views_CrimesTop10), null)]
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
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"0286f4522282670034d3c61295c3fef32af7c6a4", @"/Views/CrimesTop10.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"f842f8255da31aa43ed40deaf7f18adbc89934f4", @"/Views/_ViewImports.cshtml")]
    public class Views_CrimesTop10 : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#line 3 "/home/codio/workspace/crimes/Views/CrimesTop10.cshtml"
  
  ViewData["Title"] = "Top-10 Crimes";

#line default
#line hidden
            BeginContext(74, 27, true);
            WriteLiteral("\n<h2>Top-10 Crimes</h2>  \n\n");
            EndContext();
#line 9 "/home/codio/workspace/crimes/Views/CrimesTop10.cshtml"
  
   if (@Model.EX != null)
	 {

#line default
#line hidden
            BeginContext(134, 37, true);
            WriteLiteral("\t   <br />\n\t\t <br />\n\t\t <h3>**ERROR: ");
            EndContext();
            BeginContext(172, 16, false);
#line 14 "/home/codio/workspace/crimes/Views/CrimesTop10.cshtml"
                 Write(Model.EX.Message);

#line default
#line hidden
            EndContext();
            BeginContext(188, 46, true);
            WriteLiteral("</h3>\n\t\t <br />\n\t\t <hr />\n\t\t <br />\n\t\t <br />\n");
            EndContext();
#line 19 "/home/codio/workspace/crimes/Views/CrimesTop10.cshtml"
	 }

#line default
#line hidden
            BeginContext(240, 483, true);
            WriteLiteral(@"
<table class=""table"">  
    <thead>  
        <tr>  
            <th>  
                Rank
            </th>  
            <th>  
                CrimeCode  
            </th>  
            <th>  
                Description
            </th>  
            <th>    
                Occurence
            </th>  
            <th>  
                PercentageTotal
            </th>  
            <th>
                PercentageArrested
        </tr>  
    </thead>  
    <tbody>  
");
            EndContext();
#line 45 "/home/codio/workspace/crimes/Views/CrimesTop10.cshtml"
                  
				   int rank = 1;
				 

#line default
#line hidden
            BeginContext(758, 5, true);
            WriteLiteral("\t\t\t\t\n");
            EndContext();
#line 49 "/home/codio/workspace/crimes/Views/CrimesTop10.cshtml"
         foreach (var item in Model.CrimesList)  
        {  

#line default
#line hidden
            BeginContext(825, 52, true);
            WriteLiteral("            <tr>  \n                <td>  \n\t\t\t\t\t\t\t\t\t\t");
            EndContext();
            BeginContext(878, 4, false);
#line 53 "/home/codio/workspace/crimes/Views/CrimesTop10.cshtml"
                                   Write(rank);

#line default
#line hidden
            EndContext();
            BeginContext(882, 68, true);
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
            EndContext();
            BeginContext(951, 14, false);
#line 56 "/home/codio/workspace/crimes/Views/CrimesTop10.cshtml"
               Write(item.CrimeCode);

#line default
#line hidden
            EndContext();
            BeginContext(965, 68, true);
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
            EndContext();
            BeginContext(1034, 16, false);
#line 59 "/home/codio/workspace/crimes/Views/CrimesTop10.cshtml"
               Write(item.Description);

#line default
#line hidden
            EndContext();
            BeginContext(1050, 68, true);
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
            EndContext();
            BeginContext(1119, 14, false);
#line 62 "/home/codio/workspace/crimes/Views/CrimesTop10.cshtml"
               Write(item.Occurence);

#line default
#line hidden
            EndContext();
            BeginContext(1133, 68, true);
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
            EndContext();
            BeginContext(1202, 20, false);
#line 65 "/home/codio/workspace/crimes/Views/CrimesTop10.cshtml"
               Write(item.PercentageTotal);

#line default
#line hidden
            EndContext();
            BeginContext(1222, 68, true);
            WriteLiteral("\n                </td>  \n                <td>  \n                    ");
            EndContext();
            BeginContext(1291, 23, false);
#line 68 "/home/codio/workspace/crimes/Views/CrimesTop10.cshtml"
               Write(item.PercentageArrested);

#line default
#line hidden
            EndContext();
            BeginContext(1314, 45, true);
            WriteLiteral("\n                </td>  \n            </tr>  \n");
            EndContext();
#line 71 "/home/codio/workspace/crimes/Views/CrimesTop10.cshtml"
						
						rank++;
        }  

#line default
#line hidden
            BeginContext(1392, 24, true);
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<CrimesTop10Model> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CrimesTop10Model> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<CrimesTop10Model>)PageContext?.ViewData;
        public CrimesTop10Model Model => ViewData.Model;
    }
}
#pragma warning restore 1591
