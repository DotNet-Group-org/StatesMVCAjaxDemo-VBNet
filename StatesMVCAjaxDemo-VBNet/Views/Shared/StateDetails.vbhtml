@Imports StatesMVCAjaxDemo_VBNet
@ModelType StatesMVCAjaxDemo_VBNet.State

            <table class="stateDetailTable">
               <tr class="stateDetailTableRow">
                    <td class="stateDetailTableCellLabel">&nbsp;</td>
                    <td class="stateDetailTableCellData">&nbsp</td>
                    <td class="stateDetailTableCellEdit">[&nbsp;@Html.ActionLink("Edit", "Edit", "State", New With {.id = Model.stateAbbr}, Nothing)&nbsp;]&nbsp;&nbsp;&nbsp;[&nbsp;@Html.ActionLink("Delete", "Delete", "State", New With {.id = Model.stateAbbr}, Nothing)&nbsp;]</td>
                </tr>
                
                <tr class="stateDetailTableRow">
                    <td colspan="2" class="stateDetailTableCellStateName">
                        @Model.stateName
                    </td>
                    <td class="stateDetailTableCellStateAbbr">
                        @Model.stateAbbr
                    </td>
                </tr>

                <tr class="stateDetailTableRow">
                    <td class="stateDetailTableCellLabel">Capital</td>
                    <td class="stateDetailTableCellData">@Model.stateCapital</td>
                    <td class="stateDetailTableCellFiller">&nbsp;</td>
                </tr>

                <tr class="stateDetailTableRow">
                    <td class="stateDetailTableCellLabel">Bird</td>
                    <td class="stateDetailTableCellData">@Model.stateBird</td>
                    <td class="stateDetailTableCellFiller">&nbsp;</td>
                </tr>


                <tr class="stateDetailTableRow">
                    <td class="stateDetailTableCellLabel">Flower</td>
                    <td class="stateDetailTableCellData">@Model.stateFlower</td>
                    <td class="stateDetailTableCellFiller">&nbsp;</td>
                </tr>

                <tr class="stateDetailTableRow">
                    <td class="stateDetailTableCellLabel">Tree</td>
                    <td class="stateDetailTableCellData">@Model.stateTree</td>
                    <td class="stateDetailTableCellFiller">&nbsp;</td>
                </tr>

                @If Model.stateImageFlag <> "" Then
                    @<tr class="stateDetailTableRow">
                        <td class="stateDetailTableCellImageLabel">State Flag</td>
                        <td class="stateDetailTableCellImage" colspan="2">
                            <img src="@Url.Content(Model.stateImageFlag)" alt="State flag" />
                        </td>
                    </tr>
                End If

                @If Model.stateImageSeal <> "" Then
                    @<tr class="stateDetailTableRow">
                        <td class="stateDetailTableCellImageLabel">State Seal</td>
                        <td class="stateDetailTableCellImage" colspan="2">
                            <img src="@Url.Content(Model.stateImageSeal)" alt="State seal" />
                        </td>
                    </tr>
                End If

                <tr class="stateDetailTableRow">
                    <td id="cellCountyLabel" class="stateDetailTableCellEdit" style="padding-top: 50px;">
                        [ @Ajax.ActionLink("Show Counties", "GetCounties", New With {.id = Model.stateAbbr}, New AjaxOptions With {.HttpMethod = "POST", .OnComplete = "DisplayCounties"}) ]
                    </td>
                    <td id="cellCountyListing" class="stateDetailTableCellEdit" style="padding-top: 50px;">&nbsp;</td>
                    <td class="stateDetailTableCellEdit">&nbsp;</td>
                </tr>
            </table>
