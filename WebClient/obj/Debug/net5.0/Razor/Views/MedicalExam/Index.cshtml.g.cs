#pragma checksum "G:\PRN231\GITHUB\ProjectPrn231\WebClient\Views\MedicalExam\Index.cshtml" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "8ab1e29621a4f64d15406dcc6c188cfb8da0036d"
// <auto-generated/>
#pragma warning disable 1591
[assembly: global::Microsoft.AspNetCore.Razor.Hosting.RazorCompiledItemAttribute(typeof(AspNetCore.Views_MedicalExam_Index), @"mvc.1.0.view", @"/Views/MedicalExam/Index.cshtml")]
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
#line 1 "G:\PRN231\GITHUB\ProjectPrn231\WebClient\Views\_ViewImports.cshtml"
using WebClient;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "G:\PRN231\GITHUB\ProjectPrn231\WebClient\Views\_ViewImports.cshtml"
using WebClient.Models;

#line default
#line hidden
#nullable disable
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"8ab1e29621a4f64d15406dcc6c188cfb8da0036d", @"/Views/MedicalExam/Index.cshtml")]
    [global::Microsoft.AspNetCore.Razor.Hosting.RazorSourceChecksumAttribute(@"SHA1", @"74eabcf7e030352eff2473b217adffa5ad5752fa", @"/Views/_ViewImports.cshtml")]
    #nullable restore
    public class Views_MedicalExam_Index : global::Microsoft.AspNetCore.Mvc.Razor.RazorPage<dynamic>
    #nullable disable
    {
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_0 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("action", new global::Microsoft.AspNetCore.Html.HtmlString(""), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
        private static readonly global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute __tagHelperAttribute_1 = new global::Microsoft.AspNetCore.Razor.TagHelpers.TagHelperAttribute("src", new global::Microsoft.AspNetCore.Html.HtmlString("~/microsoft/signalr/dist/browser/signalr.js"), global::Microsoft.AspNetCore.Razor.TagHelpers.HtmlAttributeValueStyle.DoubleQuotes);
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
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper;
        private global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper;
        #pragma warning disable 1998
        public async override global::System.Threading.Tasks.Task ExecuteAsync()
        {
#nullable restore
#line 1 "G:\PRN231\GITHUB\ProjectPrn231\WebClient\Views\MedicalExam\Index.cshtml"
  
    Layout = "~/Views/Shared/_LayoutDoctor.cshtml";

#line default
#line hidden
#nullable disable
            WriteLiteral(@"<div class=""container d-flex"">
    <div class=""col-md-2"" style=""margin-right:5px;"">
        <table class=""table table-bordered border-secondary"" style=""max-height:300px;"">
            <thead>
                <tr>
                    <th class=""table-danger"">
                        <h5 style=""color:#525252;"">Queue</h5>
                    </th>

                </tr>
                <tr>
                    <th>
                        ");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("form", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ab1e29621a4f64d15406dcc6c188cfb8da0036d4803", async() => {
                WriteLiteral("\r\n                            <input class=\"form-control\" type=\"text\" placeholder=\"Find Patient\"\r\n                                   style=\"text-align:center;\">\r\n                        ");
            }
            );
            __Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.FormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_FormTagHelper);
            __Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.TagHelpers.RenderAtEndOfFormTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_TagHelpers_RenderAtEndOfFormTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_0);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral(@"
                    </th>

                </tr>
            </thead>
            <!-- chỗ này cần sroll box -->
            <tbody style=""text-align:center;"" id=""patientBody"">
            </tbody>

        </table>
        <table class=""table table-bordered border-secondary"">
            <thead class=""table-danger"">
                <tr>
                    <th>
                        <h5 style=""color:#525252"">Previous prescription</h5>
                    </th>
                </tr>
            </thead>
            <!-- chỗ này cần sroll box -->
            <tbody style=""height:200px;"">
                <tr>
                    <td><a");
            BeginWriteAttribute("href", " href=\"", 1386, "\"", 1393, 0);
            EndWriteAttribute();
            WriteLiteral(@" style=""text-decoration:none;"">List các toa thuốc cũ của bệnh nhân</a></td>
                </tr>

            </tbody>
        </table>
        <div style=""align-items:center; flex-direction: column; justify-content: space-around; display: flex;"">
            <button class=""btn btn-success"" style=""margin-bottom:20px;"">Save and Print</button>
            <button class=""btn btn-warning"" style=""color:#fff;"">Create a new Presciption</button>
        </div>
    </div>
    <div class=""col-md-10"">

        <table class=""table table-bordered border-secondary"">
            <thead>
                <tr class=""table-danger"">
                    <th>
                        <h5 style=""color:#525252"">Patient Infomation</h5>
                    </th>
                </tr>
            </thead>
            <tbody>
                <tr>
                    <td class=""d-flex justify-content-between"">
                        Full Name: <input name=""FullName"" id=""Account_FullName"" type=""text"" class=""form-co");
            WriteLiteral(@"ntrol""
                                          style=""width:500px;"" readonly />
                        DoB: <input name=""Birthday"" id=""Account_Birthday"" type=""text"" class=""form-control""
                                    style=""width:200px;"" readonly />
                        Gender: <input type=""text"" name=""Gender"" id=""Account_Gender"" class=""form-control"" style=""width:80px"" readonly />
                    </td>
                    <td class=""d-flex justify-content-between"">
                        Address: <input name=""Address"" id=""Account_Address"" type=""text"" class=""form-control""
                                        style=""width:300px;"" readonly />
                        City: <input type=""text"" class=""form-control""
                                     style=""width:200px;"" readonly />
                        Phone Number: <input name=""PhoneNumber"" id=""Account_PhoneNumber"" type=""text"" class=""form-control""
                                             style=""width:200px;"" readonly />

  ");
            WriteLiteral(@"                  </td>
                    <td class=""d-flex justify-content-between"">
                        Pulse: <input type=""number"" name=""Pulse"" id=""Pulse"" placeholder=""bpm"" class=""form-control"" style=""width:80px;"" readonly>
                        Blood Pressure: <input type=""number"" name=""BloodPressure"" id=""BloodPressure"" placeholder=""mmHg"" class=""form-control""
                                               style=""width:100px;"" readonly>
                        Temperature: <input type=""number"" name=""Temperature"" id=""Temperature"" placeholder=""°C"" class=""form-control"" style=""width:80px;"" readonly>
                        Weight: <input type=""number"" name=""Weight"" id=""Weight"" placeholder=""Kg"" class=""form-control"" style=""width:80px;"" readonly>
                        Height: <input type=""number"" name=""Height"" id=""Height"" placeholder=""Cm"" class=""form-control"" style=""width:80px;"" readonly>
                    </td>
                </tr>
            </tbody>
        </table>
        <table cla");
            WriteLiteral(@"ss=""table table-bordered border-secondary"">
            <thead>
                <tr>
                    <th colspan=""4"" class=""table-danger"">
                        <div class=""d-flex justify-content-between"">
                            <p style=""color:#525252;"">Medicine List And Using</p>
                            <button class=""btn btn-success"">Clear Presciption</button>
                            <p style=""color:#525252;"">Using Day:</p><input type=""number"" placeholder=""Day""
                                                                           class=""form-control"" style=""width:80px;"">
                            <p style=""color:#525252;"">Re-examination:</p> <input type=""checkbox""
                                                                                 class=""form-check-input"">
                            <p style=""color:#525252;"">Re-examination day:</p><input type=""date"">
                        </div>

                    </th>
                </tr>
                <tr>
");
            WriteLiteral(@"                    <th>Medicine Name</th>
                    <th>Using/day</th>
                    <th>Using/times</th>
                    <th>Method</th>
                </tr>
            </thead>
            <tbody style=""height: 170px;"">
                <tr>
                    <td style=""text-align:center"">
                        <input name=""med_Name"" id=""medName"" type=""text"" class=""form-control""
                               style=""width:200px;"" readonly />
                    </td>
                    <td></td>
                    <td></td>
                    <td></td>
                </tr>
            </tbody>
            <tfoot>
                <tr>
                    <td colspan=""4"" style=""text-align:right;"">Total:</td>
                </tr>
            </tfoot>
        </table>
        <table id=""medicineTable"" class=""table table-sm table-bordered table-striped"" style=""width:100%"">
            <thead>
                <tr>
                    <th colspan=""4"">
     ");
            WriteLiteral(@"                   <button class=""btn btn-warning"" style=""height:40px; color:#fff;""
                                data-bind=""click : addMedicine"">
                            Add Medicine
                        </button>
                    </th>
                </tr>
                <tr>
                    <th>Medicine Name</th>
                    <th>Amount</th>
                    <th>Expiration Date</th>
                    <th>Price</th>
                </tr>
            </thead>
        </table>
    </div>
</div>
<!-- SignalR -->
");
            __tagHelperExecutionContext = __tagHelperScopeManager.Begin("script", global::Microsoft.AspNetCore.Razor.TagHelpers.TagMode.StartTagAndEndTag, "8ab1e29621a4f64d15406dcc6c188cfb8da0036d13178", async() => {
            }
            );
            __Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper = CreateTagHelper<global::Microsoft.AspNetCore.Mvc.Razor.TagHelpers.UrlResolutionTagHelper>();
            __tagHelperExecutionContext.Add(__Microsoft_AspNetCore_Mvc_Razor_TagHelpers_UrlResolutionTagHelper);
            __tagHelperExecutionContext.AddHtmlAttribute(__tagHelperAttribute_1);
            await __tagHelperRunner.RunAsync(__tagHelperExecutionContext);
            if (!__tagHelperExecutionContext.Output.IsContentModified)
            {
                await __tagHelperExecutionContext.SetOutputContentAsync();
            }
            Write(__tagHelperExecutionContext.Output);
            __tagHelperExecutionContext = __tagHelperScopeManager.End();
            WriteLiteral("\r\n<script src=\"https://code.jquery.com/jquery-3.5.1.js\"></script>\r\n<script src=\"https://cdn.datatables.net/1.12.1/js/jquery.dataTables.min.js\"></script>\r\n<script src=\"https://cdn.datatables.net/1.12.1/js/dataTables.bootstrap5.min.js\"></script>\r\n");
            DefineSection("Scripts", async() => {
                WriteLiteral(@"
    <script>
        LoadPatient();
        var patientList = [];
        var connection = new signalR.HubConnectionBuilder().withUrl(""/SignalRServer"").build();
        connection.start();
        connection.on(""LoadPatients"", function () {
            LoadPatient();
        });


        function LoadPatient() {
            var tr = ``;
            $.ajax({
                url: ""https://localhost:5008/api/Queue?docID=1"",
                type: 'GET',
                dataType: 'json', // added data type
                success: (result) => {
                    patientList = result
                    $.each(result, (k, v) => {
                        tr +=
                            `<tr>
                                                                        <td>
                                                                            <button value=""${k}"" name=""patient"" style=""background: none; color: inherit; border: none; padding: 0; font: inherit; cursor: pointer; outline: inhe");
                WriteLiteral(@"rit;""> ${v.patientFullName} </button>
                                                                        </td>
                                                                    </tr>`
                    })
                    $(""#patientBody"").html(tr);
                    assignClickEvent();
                },
                error: (error) => {
                    console.log(error)
                }
            });
        };

        function assignClickEvent() {
            $(""button[name='patient']"").click((e) => {
                let index = e.currentTarget.value;
                //console.log(index);
                let item = patientList[index];
                //console.log(item);
                const patientFullName = document.querySelector(""#Account_FullName"");
                const patientBirthDay = document.querySelector(""#Account_Birthday"");
                const patientGender = document.querySelector(""#Account_Gender"");
                const address = document.qu");
                WriteLiteral(@"erySelector(""#Account_Address"");
                const phoneNumber = document.querySelector(""#Account_PhoneNumber"");
                const pulse = document.querySelector(""#Pulse"");
                const bloodPressure = document.querySelector(""#BloodPressure"");
                const temperature = document.querySelector(""#Temperature"");
                const weight = document.querySelector(""#Weight"");
                const height = document.querySelector(""#Height"");
                patientFullName.value = item.patientFullName;
                patientBirthDay.value = item.patientBirthDay;
                patientGender.value = item.patientGender;
                address.value = item.address;
                phoneNumber.value = item.phoneNumber;
                pulse.value = item.pusle;
                bloodPressure.value = item.bloodPressure;
                temperature.value = item.temperature;
                weight.value = item.weight;
                height.value = item.height;
            })");
                WriteLiteral(@"
        }

        $(document).ready(function () {
            var table = $('#medicineTable').DataTable({
                ajax: ""https://localhost:5001/api/Medicine/DataTableMedicine"",
                columns: [
                    { data: 'medicineName' },
                    { data: 'amount' },
                    { data: 'expiration' },
                    { data: 'price' },
                ],
                columnDefs: [
                    {
                        ""targets"": [0],
                        ""visible"": true,
                        ""searchable"": true
                    },
                    {
                        ""targets"": [1],
                        ""visible"": true,
                        ""searchable"": false,
                    },
                    {
                        ""targets"": [2],
                        ""visible"": true,
                        ""searchable"": false,
                    },
                    {
                        ""targe");
                WriteLiteral(@"ts"": [3],
                        ""visible"": false,
                        ""searchable"": false,
                    },
                ],
            });
            $('#medicineTable tbody').on('click', 'tr', function () {
                if ($(this).hasClass('selected')) {
                    $(this).removeClass('selected');
                    console.log(""if"");
                }
                else {
                    table.$('tr.selected').removeClass('selected');
                    $(this).addClass('selected');
                    console.log(""else"");
                }

            });
            $('#AddMedBtn').click(function () {
                var selectedData = table.row('.selected').data();
                const medicineName = document.querySelector(""#medName"");
                medicineName.value = selectedData.medicineName;
                table.row.add(medicineName.value);
                console.log(medicineName.value);
            });
        });
    </script>
");
            }
            );
        }
        #pragma warning restore 1998
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.ViewFeatures.IModelExpressionProvider ModelExpressionProvider { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IUrlHelper Url { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.IViewComponentHelper Component { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IJsonHelper Json { get; private set; } = default!;
        #nullable disable
        #nullable restore
        [global::Microsoft.AspNetCore.Mvc.Razor.Internal.RazorInjectAttribute]
        public global::Microsoft.AspNetCore.Mvc.Rendering.IHtmlHelper<dynamic> Html { get; private set; } = default!;
        #nullable disable
    }
}
#pragma warning restore 1591
