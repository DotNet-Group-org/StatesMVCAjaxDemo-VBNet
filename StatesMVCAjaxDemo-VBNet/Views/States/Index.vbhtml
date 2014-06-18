@Imports StatesMVCAjaxDemo_VBNet
@ModelType List(Of StatesMVCAjaxDemo_VBNet.StateNameEntryModel)

@Code
    ViewData("Title") = "States"
End Code

<table class="stateTable">
    <tr class="stateTableRow">
        <td class="stateTableCellName">
            @Html.Partial("StateNameList", Model)
        </td>

        <td  id="stateTableCellData" class="stateTableCellData">
        </td>
    </tr>
</table>

