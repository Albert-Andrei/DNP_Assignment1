#pragma checksum "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\Pages\AdultList.razor" "{ff1816ec-aa5e-4d10-87f7-6f4963833460}" "f115f627be0d023790da5ef6453dadf12aeff7df"
// <auto-generated/>
#pragma warning disable 1591
namespace Assignment.Pages
{
    #line hidden
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Threading.Tasks;
    using Microsoft.AspNetCore.Components;
#nullable restore
#line 1 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\_Imports.razor"
using System.Net.Http;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Authorization;

#line default
#line hidden
#nullable disable
#nullable restore
#line 4 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Forms;

#line default
#line hidden
#nullable disable
#nullable restore
#line 5 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Routing;

#line default
#line hidden
#nullable disable
#nullable restore
#line 6 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\_Imports.razor"
using Microsoft.AspNetCore.Components.Web;

#line default
#line hidden
#nullable disable
#nullable restore
#line 7 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\_Imports.razor"
using Microsoft.JSInterop;

#line default
#line hidden
#nullable disable
#nullable restore
#line 8 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\_Imports.razor"
using Assignment;

#line default
#line hidden
#nullable disable
#nullable restore
#line 9 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\_Imports.razor"
using Assignment.Shared;

#line default
#line hidden
#nullable disable
#nullable restore
#line 2 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\Pages\AdultList.razor"
using Assignment.Model;

#line default
#line hidden
#nullable disable
#nullable restore
#line 3 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\Pages\AdultList.razor"
using Assignment.Data;

#line default
#line hidden
#nullable disable
    [Microsoft.AspNetCore.Components.RouteAttribute("/adultList")]
    public partial class AdultList : Microsoft.AspNetCore.Components.ComponentBase
    {
        #pragma warning disable 1998
        protected override void BuildRenderTree(Microsoft.AspNetCore.Components.Rendering.RenderTreeBuilder __builder)
        {
            __builder.AddMarkupContent(0, "<h1 xmlns=\"http://www.w3.org/1999/html\">Adult list</h1>\r\n\r\n");
#nullable restore
#line 10 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\Pages\AdultList.razor"
 if (adultToShow == null)
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(1, "    ");
            __builder.AddMarkupContent(2, "<p>\r\n        <em>Loading...</em>\r\n    </p>\r\n");
#nullable restore
#line 15 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\Pages\AdultList.razor"
}
else if (!adultToShow.Any())
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(3, "    ");
            __builder.AddMarkupContent(4, "<p>\r\n        <em style=\"color: red\">Searched adult don`t exist.</em>\r\n        <h1 style=\"color: #3a0647 ;\">To continue please reload the page.</h1>\r\n    </p>\r\n");
#nullable restore
#line 22 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\Pages\AdultList.razor"
}
else
{

#line default
#line hidden
#nullable disable
            __builder.AddContent(5, "    ");
            __builder.OpenElement(6, "button");
            __builder.AddAttribute(7, "id", "searchbtn");
            __builder.AddAttribute(8, "class", "search");
            __builder.AddAttribute(9, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 25 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\Pages\AdultList.razor"
                                                      changeColor

#line default
#line hidden
#nullable disable
            ));
            __builder.AddContent(10, "Advanced search >");
            __builder.CloseElement();
            __builder.AddMarkupContent(11, "\r\n    ");
            __builder.OpenElement(12, "div");
            __builder.AddAttribute(13, "class", "drop-content");
            __builder.AddAttribute(14, "style", "display:" + " " + (
#nullable restore
#line 26 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\Pages\AdultList.razor"
                                               disply

#line default
#line hidden
#nullable disable
            ));
            __builder.AddMarkupContent(15, "\r\n        ");
            __builder.OpenElement(16, "div");
            __builder.AddAttribute(17, "class", "col");
            __builder.AddMarkupContent(18, "\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(19);
            __builder.AddAttribute(20, "Policy", "SecurityLevel3");
            __builder.AddAttribute(21, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((moreThan4) => (__builder2) => {
                __builder2.AddMarkupContent(22, "\r\n                        ");
                __builder2.OpenElement(23, "p");
                __builder2.AddAttribute(24, "class", "pc");
                __builder2.AddMarkupContent(25, "\r\n                            Filter by User Id: ");
                __builder2.OpenElement(26, "input");
                __builder2.AddAttribute(27, "type", "number");
                __builder2.AddAttribute(28, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 30 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\Pages\AdultList.razor"
                                                                                (arg) => FilterByUserId(arg)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddAttribute(29, "style", "width:50px");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(30, "\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(31, "\r\n                    ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(32, "\r\n            \r\n                    ");
            __builder.OpenElement(33, "p");
            __builder.AddAttribute(34, "class", "pc");
            __builder.AddMarkupContent(35, "\r\n                        Filter by Sex:\r\n                        ");
            __builder.OpenElement(36, "select");
            __builder.AddAttribute(37, "class", "form-control selectpicker");
            __builder.AddAttribute(38, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 36 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\Pages\AdultList.razor"
                                                                               (arg) => FilterBySex(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(39, "style", "width:70px");
            __builder.AddMarkupContent(40, "\r\n                            ");
            __builder.OpenElement(41, "option");
            __builder.AddContent(42, "All");
            __builder.CloseElement();
            __builder.AddMarkupContent(43, "\r\n                            ");
            __builder.OpenElement(44, "option");
            __builder.AddContent(45, "F");
            __builder.CloseElement();
            __builder.AddMarkupContent(46, "\r\n                            ");
            __builder.OpenElement(47, "option");
            __builder.AddContent(48, "M");
            __builder.CloseElement();
            __builder.AddMarkupContent(49, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(50, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(51, "\r\n            \r\n                    ");
            __builder.OpenElement(52, "p");
            __builder.AddAttribute(53, "class", "pc");
            __builder.AddMarkupContent(54, "\r\n                        Filter by Job Title: ");
            __builder.OpenElement(55, "input");
            __builder.AddAttribute(56, "type", "text");
            __builder.AddAttribute(57, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 44 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\Pages\AdultList.razor"
                                                                            (arg) => FilterByJobTitle(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(58, "style", "width:200px");
            __builder.CloseElement();
            __builder.AddMarkupContent(59, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(60, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(61, "\r\n        \r\n        ");
            __builder.OpenElement(62, "div");
            __builder.AddAttribute(63, "class", "col");
            __builder.AddMarkupContent(64, "\r\n            ");
            __builder.OpenElement(65, "p");
            __builder.AddAttribute(66, "class", "pc");
            __builder.AddMarkupContent(67, "\r\n                        Filter by Name: ");
            __builder.OpenElement(68, "input");
            __builder.AddAttribute(69, "type", "text");
            __builder.AddAttribute(70, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 50 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\Pages\AdultList.razor"
                                                                       (arg) => FilterByName(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(71, "style", "width:200px");
            __builder.CloseElement();
            __builder.AddMarkupContent(72, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(73, "\r\n            \r\n                    ");
            __builder.OpenElement(74, "p");
            __builder.AddAttribute(75, "class", "pc");
            __builder.AddMarkupContent(76, "\r\n                        Filter by Age: ");
            __builder.OpenElement(77, "input");
            __builder.AddAttribute(78, "type", "number");
            __builder.AddAttribute(79, "oninput", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 54 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\Pages\AdultList.razor"
                                                                        (arg) => FilterByAge(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(80, "style", "width:50px");
            __builder.CloseElement();
            __builder.AddMarkupContent(81, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(82, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(83, "\r\n        \r\n        ");
            __builder.OpenElement(84, "div");
            __builder.AddAttribute(85, "class", "col");
            __builder.AddMarkupContent(86, "\r\n            ");
            __builder.OpenElement(87, "p");
            __builder.AddAttribute(88, "class", "pc");
            __builder.AddMarkupContent(89, "\r\n                        Filter by Eye color:\r\n                        ");
            __builder.OpenElement(90, "select");
            __builder.AddAttribute(91, "class", "form-control selectpicker");
            __builder.AddAttribute(92, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 61 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\Pages\AdultList.razor"
                                                                               (arg) => FilterByEyeColor(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(93, "style", "width:100px");
            __builder.AddMarkupContent(94, "\r\n                            ");
            __builder.OpenElement(95, "option");
            __builder.AddContent(96, "All");
            __builder.CloseElement();
            __builder.AddMarkupContent(97, "\r\n                            ");
            __builder.OpenElement(98, "option");
            __builder.AddContent(99, "Brown");
            __builder.CloseElement();
            __builder.AddMarkupContent(100, "\r\n                            ");
            __builder.OpenElement(101, "option");
            __builder.AddContent(102, "Grey");
            __builder.CloseElement();
            __builder.AddMarkupContent(103, "\r\n                            ");
            __builder.OpenElement(104, "option");
            __builder.AddContent(105, "Green");
            __builder.CloseElement();
            __builder.AddMarkupContent(106, "\r\n                            ");
            __builder.OpenElement(107, "option");
            __builder.AddContent(108, "Blue");
            __builder.CloseElement();
            __builder.AddMarkupContent(109, "\r\n                            ");
            __builder.OpenElement(110, "option");
            __builder.AddContent(111, "Amber");
            __builder.CloseElement();
            __builder.AddMarkupContent(112, "\r\n                            ");
            __builder.OpenElement(113, "option");
            __builder.AddContent(114, "Hazel");
            __builder.CloseElement();
            __builder.AddMarkupContent(115, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(116, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(117, "\r\n            \r\n                    ");
            __builder.OpenElement(118, "p");
            __builder.AddAttribute(119, "class", "pc");
            __builder.AddMarkupContent(120, "\r\n                        Filter by Hair color:\r\n                        ");
            __builder.OpenElement(121, "select");
            __builder.AddAttribute(122, "class", "form-control selectpicker");
            __builder.AddAttribute(123, "onchange", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.ChangeEventArgs>(this, 
#nullable restore
#line 74 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\Pages\AdultList.razor"
                                                                               (arg) => FilterByHairColor(arg)

#line default
#line hidden
#nullable disable
            ));
            __builder.AddAttribute(124, "style", "width:100px");
            __builder.AddMarkupContent(125, "\r\n                            ");
            __builder.OpenElement(126, "option");
            __builder.AddContent(127, "All");
            __builder.CloseElement();
            __builder.AddMarkupContent(128, "\r\n                            ");
            __builder.OpenElement(129, "option");
            __builder.AddContent(130, "Blond");
            __builder.CloseElement();
            __builder.AddMarkupContent(131, "\r\n                            ");
            __builder.OpenElement(132, "option");
            __builder.AddContent(133, "Red");
            __builder.CloseElement();
            __builder.AddMarkupContent(134, "\r\n                            ");
            __builder.OpenElement(135, "option");
            __builder.AddContent(136, "Brown");
            __builder.CloseElement();
            __builder.AddMarkupContent(137, "\r\n                            ");
            __builder.OpenElement(138, "option");
            __builder.AddContent(139, "Black");
            __builder.CloseElement();
            __builder.AddMarkupContent(140, "\r\n                            ");
            __builder.OpenElement(141, "option");
            __builder.AddContent(142, "White");
            __builder.CloseElement();
            __builder.AddMarkupContent(143, "\r\n                            ");
            __builder.OpenElement(144, "option");
            __builder.AddContent(145, "Grey");
            __builder.CloseElement();
            __builder.AddMarkupContent(146, "\r\n                            ");
            __builder.OpenElement(147, "option");
            __builder.AddContent(148, "Blue");
            __builder.CloseElement();
            __builder.AddMarkupContent(149, "\r\n                            ");
            __builder.OpenElement(150, "option");
            __builder.AddContent(151, "Green");
            __builder.CloseElement();
            __builder.AddMarkupContent(152, "\r\n                            ");
            __builder.OpenElement(153, "option");
            __builder.AddContent(154, "Leverpostej");
            __builder.CloseElement();
            __builder.AddMarkupContent(155, "\r\n                        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(156, "\r\n                    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(157, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(158, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(159, "\r\n");
            __builder.AddContent(160, "    ");
            __builder.OpenElement(161, "table");
            __builder.AddAttribute(162, "class", "table");
            __builder.AddMarkupContent(163, "\r\n        ");
            __builder.OpenElement(164, "thead");
            __builder.AddMarkupContent(165, "\r\n        ");
            __builder.OpenElement(166, "tr");
            __builder.AddMarkupContent(167, "\r\n            ");
            __builder.AddMarkupContent(168, "<th>Name</th>\r\n            ");
            __builder.AddMarkupContent(169, "<th>Eye color</th>\r\n            ");
            __builder.AddMarkupContent(170, "<th>Age</th>\r\n            ");
            __builder.AddMarkupContent(171, "<th>Hair Color</th>\r\n            ");
            __builder.AddMarkupContent(172, "<th>Sex</th>\r\n            ");
            __builder.AddMarkupContent(173, "<th>Job</th>\r\n            ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(174);
            __builder.AddAttribute(175, "Policy", "SecurityLevel3");
            __builder.AddAttribute(176, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((moreThan3) => (__builder2) => {
                __builder2.AddMarkupContent(177, "\r\n                ");
                __builder2.AddMarkupContent(178, "<th>Remove</th>\r\n            ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(179, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(180, "\r\n        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(181, "\r\n        ");
            __builder.OpenElement(182, "tbody");
            __builder.AddMarkupContent(183, "\r\n");
#nullable restore
#line 106 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\Pages\AdultList.razor"
         foreach (var item in adultToShow)
        {

#line default
#line hidden
#nullable disable
            __builder.AddContent(184, "            ");
            __builder.OpenElement(185, "tr");
            __builder.AddMarkupContent(186, "\r\n                ");
            __builder.OpenElement(187, "td");
            __builder.AddContent(188, 
#nullable restore
#line 109 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\Pages\AdultList.razor"
                     item.FirstName

#line default
#line hidden
#nullable disable
            );
            __builder.AddContent(189, " ");
            __builder.AddContent(190, 
#nullable restore
#line 109 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\Pages\AdultList.razor"
                                     item.LastName

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(191, "\r\n                ");
            __builder.OpenElement(192, "td");
            __builder.AddContent(193, 
#nullable restore
#line 110 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\Pages\AdultList.razor"
                     item.EyeColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(194, "\r\n                ");
            __builder.OpenElement(195, "td");
            __builder.AddContent(196, 
#nullable restore
#line 111 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\Pages\AdultList.razor"
                     item.Age

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(197, "\r\n                ");
            __builder.OpenElement(198, "td");
            __builder.AddContent(199, 
#nullable restore
#line 112 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\Pages\AdultList.razor"
                     item.HairColor

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(200, "\r\n                ");
            __builder.OpenElement(201, "td");
            __builder.AddContent(202, 
#nullable restore
#line 113 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\Pages\AdultList.razor"
                     item.Sex

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(203, "\r\n");
#nullable restore
#line 114 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\Pages\AdultList.razor"
                 if (item.JobTitle != null)
                {

#line default
#line hidden
#nullable disable
            __builder.AddContent(204, "                    ");
            __builder.OpenElement(205, "td");
            __builder.AddContent(206, 
#nullable restore
#line 116 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\Pages\AdultList.razor"
                         item.JobTitle

#line default
#line hidden
#nullable disable
            );
            __builder.CloseElement();
            __builder.AddMarkupContent(207, "\r\n");
#nullable restore
#line 117 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\Pages\AdultList.razor"
                }

#line default
#line hidden
#nullable disable
            __builder.AddContent(208, "                ");
            __builder.OpenComponent<Microsoft.AspNetCore.Components.Authorization.AuthorizeView>(209);
            __builder.AddAttribute(210, "Policy", "SecurityLevel3");
            __builder.AddAttribute(211, "ChildContent", (Microsoft.AspNetCore.Components.RenderFragment<Microsoft.AspNetCore.Components.Authorization.AuthenticationState>)((moreThan3) => (__builder2) => {
                __builder2.AddMarkupContent(212, "\r\n                    ");
                __builder2.OpenElement(213, "td");
                __builder2.AddMarkupContent(214, "\r\n                        ");
                __builder2.OpenElement(215, "button");
                __builder2.AddAttribute(216, "onclick", Microsoft.AspNetCore.Components.EventCallback.Factory.Create<Microsoft.AspNetCore.Components.Web.MouseEventArgs>(this, 
#nullable restore
#line 120 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\Pages\AdultList.razor"
                                            () => RemovePerson(item.Id)

#line default
#line hidden
#nullable disable
                ));
                __builder2.AddMarkupContent(217, "\r\n                            <i class=\"oi oi-trash\" style=\"color:red\"></i>\r\n                        ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(218, "\r\n                    ");
                __builder2.CloseElement();
                __builder2.AddMarkupContent(219, "\r\n                ");
            }
            ));
            __builder.CloseComponent();
            __builder.AddMarkupContent(220, "\r\n            ");
            __builder.CloseElement();
            __builder.AddMarkupContent(221, "\r\n");
#nullable restore
#line 126 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\Pages\AdultList.razor"
        }

#line default
#line hidden
#nullable disable
            __builder.AddContent(222, "        ");
            __builder.CloseElement();
            __builder.AddMarkupContent(223, "\r\n    ");
            __builder.CloseElement();
            __builder.AddMarkupContent(224, "\r\n");
#nullable restore
#line 129 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\Pages\AdultList.razor"
}

#line default
#line hidden
#nullable disable
        }
        #pragma warning restore 1998
#nullable restore
#line 131 "C:\Users\User\RiderProjects\Assignmetn_1\Assignment_1\Assignment\Pages\AdultList.razor"
       
    private IList<Adult> adultToShow;
    private IList<Adult> allAdults;


    protected override async Task OnInitializedAsync()
    {
        allAdults = AdultService.GetAdults();
        adultToShow = allAdults;
    }

    private void RemovePerson(int personId)
    {
        Adult adultToRemove = adultToShow.First(t => t.Id == personId);
        AdultService.RemoveAdult(personId);
        adultToShow.Remove(adultToRemove);
    }
    
    private int? filterById;
    private int? filterByAge;
    private string jobTitel;
    private string filterBySex;
    private string filterHairColor;
    private string filterEyeColor;
    private string filterByName;

    private void FilterByUserId(ChangeEventArgs changeEventArgs) {
        filterById = null;
        try {
            filterById = int.Parse(changeEventArgs.Value.ToString());
        } catch (Exception e) { }
        
        adultToShow = allAdults.Where(t => 
            (filterById != null && t.Id == filterById || filterById == null) 
            ).ToList();
    }
    
    private void FilterByAge(ChangeEventArgs changeEventArgs) {
        filterByAge = null;
        try {
            filterByAge = int.Parse(changeEventArgs.Value.ToString());
        } catch (Exception e) { }
        ExecuteFilter();
    }
    
    private void FilterByJobTitle(ChangeEventArgs args) {
        jobTitel = null;
        try {
            jobTitel = args.Value.ToString();
        } catch (Exception e) { }
        ExecuteFilter();
    }
    private void FilterByName(ChangeEventArgs args) {
        filterByName = null;
        try {
            filterByName = args.Value.ToString();
        } catch (Exception e) { }
        ExecuteFilter();
    }
    
    private void FilterBySex(ChangeEventArgs args) {
        filterBySex = null;
        try {
            if (args.Value.ToString() == "All")
            {
                filterBySex = null;
            } else
            filterBySex = args.Value.ToString();
        } catch (Exception e) { }
        ExecuteFilter();
    }
    
    private void FilterByEyeColor(ChangeEventArgs args) {
        filterEyeColor = null;
        try {
            if (args.Value.ToString() == "All")
            {
                filterEyeColor = null;
            } else
                filterEyeColor = args.Value.ToString();
        } catch (Exception e) { }
        ExecuteFilter();
    }
    
    private void FilterByHairColor(ChangeEventArgs args) {
        filterHairColor = null;
        try {
            if (args.Value.ToString() == "All")
            {
                filterHairColor = null;
            } else
                filterHairColor = args.Value.ToString();
        } catch (Exception e) { }
        ExecuteFilter();
    }

    private void ExecuteFilter() {
        adultToShow = allAdults.Where(t => 
            (filterBySex != null && t.Sex.Contains(filterBySex) || filterBySex == null) &&
            (jobTitel != null && t.JobTitle.Contains(jobTitel) || jobTitel == null) &&
            (filterByName != null && t.FirstName.Contains(filterByName) || filterByName != null && t.LastName.Contains(filterByName) || filterByName == null) &&
            (filterByAge != null && t.Age.ToString().Contains(filterByAge.ToString()) || filterByAge == null) &&
            (filterEyeColor != null && t.EyeColor.Contains(filterEyeColor) || filterEyeColor == null) &&
            (filterHairColor != null && t.HairColor.Contains(filterHairColor) || filterHairColor == null)
            ).ToList();
    }

    string disply = "none";
    
    private void changeColor()
    {
        if (disply == "none")
        {
            disply = "flex";
        }
        else
        {
            disply = "none";
        }
    }


#line default
#line hidden
#nullable disable
        [global::Microsoft.AspNetCore.Components.InjectAttribute] private IAdultService AdultService { get; set; }
    }
}
#pragma warning restore 1591
