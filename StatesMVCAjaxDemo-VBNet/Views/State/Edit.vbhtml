﻿@Imports StatesMVCAjaxDemo_VBNet
@ModelType StatesMVCAjaxDemo_VBNet.State


@Code
    ViewData("Title") = "Edit"
End Code

<table class="stateTable">
    <tr class="stateTableRow">
        <td class="stateTableCellName">
            @Html.Partial("StateNameList", ViewBag.stateNames)
        </td>

        <td class="stateTableCellData">

            @Html.ValidationSummary("Please correct the errors and try again.")

            @Code 
                Html.BeginForm("Edit", "State", FormMethod.Post, Nothing)
            End Code

            <div>
                @Html.HiddenFor(Function(m) m.stateID)

                <table class="stateDetailTable">
                    <tr class="stateDetailTableRow">
                        <td class="stateDetailTableCellLabel">@Html.LabelFor(Function(m) m.stateName)</td>
                        <td class="stateDetailTableCellData">@Html.TextBoxFor(Function(m) m.stateName)</td>
                        <td class="stateDetailTableCellFiller">@Html.ValidationMessageFor(Function(m) m.stateName)</td>
                    </tr>
                        
                    <tr class="stateDetailTableRow">
                        <td class="stateDetailTableCellLabel">@Html.LabelFor(Function(m) m.stateAbbr)</td>
                        <td class="stateDetailTableCellData">@Html.TextBoxFor(Function(m) m.stateAbbr)</td>
                        <td class="stateDetailTableCellFiller">@Html.ValidationMessageFor(Function(m) m.stateAbbr)</td>
                    </tr>
                     
                    <tr class="stateDetailTableRow">
                        <td class="stateDetailTableCellLabel">@Html.LabelFor(Function(m) m.stateCapital)</td>
                        <td class="stateDetailTableCellData">@Html.TextBoxFor(Function(m) m.stateCapital)</td>
                        <td class="stateDetailTableCellFiller">@Html.ValidationMessageFor(Function(m) m.stateCapital)</td>
                    </tr>

                    <tr class="stateDetailTableRow">
                        <td class="stateDetailTableCellLabel">@Html.LabelFor(Function(m) m.stateBird)</td>
                        <td class="stateDetailTableCellData">@Html.TextBoxFor(Function(m) m.stateBird)</td>
                        <td class="stateDetailTableCellFiller">@Html.ValidationMessageFor(Function(m) m.stateBird)</td>
                    </tr>

                    <tr class="stateDetailTableRow">
                        <td class="stateDetailTableCellLabel">@Html.LabelFor(Function(m) m.stateFlower)</td>
                        <td class="stateDetailTableCellData">@Html.TextBoxFor(Function(m) m.stateFlower)</td>
                        <td class="stateDetailTableCellFiller">@Html.ValidationMessageFor(Function(m) m.stateFlower)</td>
                    </tr>

                    <tr class="stateDetailTableRow">
                        <td class="stateDetailTableCellLabel">@Html.LabelFor(Function(m) m.stateTree)</td>
                        <td class="stateDetailTableCellData">@Html.TextBoxFor(Function(m) m.stateTree)</td>
                        <td class="stateDetailTableCellFiller">@Html.ValidationMessageFor(Function(m) m.stateTree)</td>
                    </tr>

                    <tr class="stateDetailTableRow">
                        <td class="stateDetailTableCellLabel">@Html.LabelFor(Function(m) m.stateRegion)</td>
                        <td class="stateDetailTableCellData">@Html.TextBoxFor(Function(m) m.stateRegion)</td>
                        <td class="stateDetailTableCellFiller">@Html.ValidationMessageFor(Function(m) m.stateRegion)</td>
                    </tr>

                    <tr class="stateDetailTableRow">
                        <td class="stateDetailTableCellLabel">@Html.LabelFor(Function(m) m.stateImageFlag)</td>
                        <td class="stateDetailTableCellData">@Html.TextBoxFor(Function(m) m.stateImageFlag)</td>
                        <td class="stateDetailTableCellFiller">@Html.ValidationMessageFor(Function(m) m.stateImageFlag)</td>
                    </tr>

                    <tr class="stateDetailTableRow">
                        <td class="stateDetailTableCellLabel">@Html.LabelFor(Function(m) m.stateImageSeal)</td>
                        <td class="stateDetailTableCellData">@Html.TextBoxFor(Function(m) m.stateImageSeal)</td>
                        <td class="stateDetailTableCellFiller">@Html.ValidationMessageFor(Function(m) m.stateImageSeal)</td>
                    </tr>

                    <tr class="stateDetailTableRow">
                        <td class="stateDetailTableCellSubmit"><input type="submit" value="Update" class="stateDetailSubmitText" /></td>
                        <td class="stateDetailTableCellData">&nbsp;</td>
                        <td class="stateDetailTableCellFiller">&nbsp;</td>
                    </tr>
                </table>
            </div>

            @Code
                Html.EndForm()
            End code
        </td>
    </tr>
</table>

