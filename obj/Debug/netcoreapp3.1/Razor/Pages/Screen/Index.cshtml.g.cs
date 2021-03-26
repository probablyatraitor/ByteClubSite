#pragma checksum "D:\repos\probablyatraitor\ByteClubSite\Pages\Screen\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "009496c00bcaa5e3d16cf00d3c97b0bcce523db3"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(ByteClubSite.Pages.Screen.Pages_Screen_Index), @"mvc.1.0.razor-page", @"/Pages/Screen/Index.cshtml")]
namespace ByteClubSite.Pages.Screen
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
#line 1 "D:\repos\probablyatraitor\ByteClubSite\Pages\_ViewImports.cshtml"
using ByteClubSite;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"009496c00bcaa5e3d16cf00d3c97b0bcce523db3", @"/Pages/Screen/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"b60e6e9de91f1fb9599a81595a1dfeef4c6d5f1c", @"/Pages/_ViewImports.cshtml")]
    public class Pages_Screen_Index : global::Microsoft.AspNetCore.Mvc.RazorPages.Page
    {
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 3 "D:\repos\probablyatraitor\ByteClubSite\Pages\Screen\Index.cshtml"
  
    ViewData["Title"] = "Class Assignments";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<style>
    header, footer {
        display: none;
    }
    .classes {
        width: 100%;
        margin: 5vh 0 5vh 0;
    }
    .currentClass {
        width: 100%;
        display: flex;
        flex-direction: column;
    }
    .currentClass_header {
        width: 100%;
        display: flex;
        flex-direction: row;
        align-items: baseline;
        justify-content: space-between;

        border-bottom: 1px solid #FFF;
        margin-bottom: 2vh;
    }
    .currentClass_header h1 {
        font-size: 450%;
        padding-left: 20px;
    }
    .currentClass_header h4 {
        font-size: 170%;
        padding-right: 20px;
    }

</style>

<div class=""classes"">
    <div class=""currentClass text-light"">
        <div class=""currentClass_header"">
            <h1 id=""dataClass""></h1>
            <h4 id=""dataIndex""></h4>
        </div>
        <div class=""currentClass_body"" id=""dataBody""></div>
    </div>
");
            WriteLiteral("</div>\r\n\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral("\r\n");
                WriteLiteral("<script>\r\n    var startTimes = JSON.parse(\'");
#nullable restore
#line 60 "D:\repos\probablyatraitor\ByteClubSite\Pages\Screen\Index.cshtml"
                            Write(Html.Raw(Json.Serialize(Model.AgendasList)));

#line default
#line hidden
#nullable disable
                WriteLiteral("\'); //List of start times as milliseconds since EPOC\r\n    console.log(startTimes);\r\n    console.log(");
#nullable restore
#line 62 "D:\repos\probablyatraitor\ByteClubSite\Pages\Screen\Index.cshtml"
           Write(Model.ScheduleTimings);

#line default
#line hidden
#nullable disable
                WriteLiteral(@");
    var dateNow = new Date();
    var currentClass, nextClass; //Indexes of classes
    var currentData; //Data for current class
    for (var i = 0; i < startTimes.length; i++) {
        console.log(""loop"");
        if (dateNow.getTime() > startTimes[i] && i == 7) { //Current time is period 8 or after school
            currentClass = i;
            nextClass = 0;
            startTimes[0] += 86400000; //Start time is at period 1 time tomorrow
            break;
        }
        else if (dateNow.getTime() > startTimes[i] && dateNow.getTime() < startTimes[i + 1]) {
            currentClass = i;
            nextClass = i + 1;
            break;
        }
    }
    var dataString = '");
#nullable restore
#line 80 "D:\repos\probablyatraitor\ByteClubSite\Pages\Screen\Index.cshtml"
                 Write(Html.Raw(Json.Serialize(Model.Agendas)));

#line default
#line hidden
#nullable disable
                WriteLiteral(@"';
    // preserve newlines, etc - use valid JSON
    dataString = dataString.replace(/\\n/g, ""\\n"")
        .replace(/\\'/g, ""\\'"")
        .replace(/\\""/g, '\\""')
        .replace(/\\&/g, ""\\&"")
        .replace(/\\r/g, ""\\r"")
        .replace(/\\t/g, ""\\t"")
        .replace(/\\b/g, ""\\b"")
        .replace(/\\f/g, ""\\f"");
    // remove non-printable and other non-valid JSON chars
    dataString = dataString.replace(/[\u0000-\u0019]+/g, """");
    var currentData = JSON.parse(dataString)[currentClass]; //Get data for current class
    document.getElementById('dataClass').innerHTML = currentData.class;
    document.getElementById('dataIndex').innerHTML = ""Period "" + currentData.id;
    document.getElementById('dataBody').innerHTML = currentData.body;

    function refreshPage() {
        location.reload(true);
    }

    setTimeout(refreshPage, startTimes[nextClass] - Date.now()); //Refresh the page after the amount of time to get to next period start time

</script>
");
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
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<ByteClubSite.Pages.Screen.IndexModel> Html { get; private set; }
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ByteClubSite.Pages.Screen.IndexModel> ViewData => (global::Microsoft.AspNetCore.Mvc.ViewFeatures.ViewDataDictionary<ByteClubSite.Pages.Screen.IndexModel>)PageContext?.ViewData;
        public ByteClubSite.Pages.Screen.IndexModel Model => ViewData.Model;
    }
}
#pragma warning restore 1591