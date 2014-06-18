@Imports StatesMVCAjaxDemo_VBNet
@ModelType StatesMVCAjaxDemo_VBNet.StateDetailModel

@Code
    ViewData("Title") = "Details"
End Code

<table class="stateTable">
    <tr class="stateTableRow">
        <td class="stateTableCellName">
            @Html.Partial("StateNameList", Model.stateNames )
        </td>

        <td id="stateTableCellData" class="stateTableCellData">
            @Html.Partial("StateDetails", Model.stateDetails)
        </td>
    </tr>
</table>

