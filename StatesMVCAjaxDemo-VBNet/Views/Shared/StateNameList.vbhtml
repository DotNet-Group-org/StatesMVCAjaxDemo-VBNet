@Imports StatesMVCAjaxDemo_VBNet
@ModelType List(Of StatesMVCAjaxDemo_VBNet.StateNameEntryModel)

@Code
    Dim className As String = String.Empty
    Dim id As String = String.Empty
End Code

<!-- just to demostrate that the entire page is not being refreshed -->
<div>
    Last Page Refresh: @Now.ToString("hh:mm:ss")
</div>
@For Each entry As StateNameEntryModel In Model
    If entry.isSelected Then
        className = "stateNameBlockSelected"
    Else
        className = "stateNameBlockUnselected"
    End If

    id = "stateNameEntry_" & entry.stateAbbr

    @<div id="@id" class="@classname">
        @If entry.isSelected Then
            @entry.stateName
        Else
            @Ajax.ActionLink(entry.stateName, "GetStateDetails", New With {.id = entry.stateAbbr}, New AjaxOptions With {.UpdateTargetId = "stateTableCellData", .HttpMethod = "GET", .OnComplete = "RefreshNameListStyle('" + id + "');"})
        End If
    </div>
    Next

<div class="stateNameCreateLabel">
    [&nbsp;@Html.ActionLink("Create New State", "Create", "State")&nbsp;]
</div>

<script type="text/javascript">

    function RefreshNameListStyle(id) {
        // get div that has the class "stateNameBlockSelected", and change
        // the class from "stateNameBlockSelected" to "stateNameBlockUnselected"
        $('div.stateNameBlockSelected').removeClass("stateNameBlockSelected").addClass("stateNameBlockUnselected");
        // set the current state div class to "stateNameBlockSelected"
        $("#" + id).removeClass("stateNameBlockUnselected").addClass("stateNameBlockSelected");
    }

    function DisplayCounties(context) {
        var s = ""

        // first need to convert the json string to a javascript object
        var j = JSON.parse(context.responseText);

        // now can enumerate through the list
        for (var i = 0; i < j.length; i++) {
            s = s + "<div>" + j[i] + "</div>"
        }

        // update the cell containing the label
        $("#cellCountyLabel").html("Counties").removeClass("stateDetailTableCellEdit").addClass("stateDetailTableCellLabel");
        // update the cell containing the list of the counties
        $("#cellCountyListing").html(s).removeClass("stateDetailTableCellEdit").addClass("stateDetailTableCellData");
    }

</script>
