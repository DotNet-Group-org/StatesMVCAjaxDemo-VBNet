﻿<!DOCTYPE html>
<html>
<head>
    <title>@ViewData("Title")</title>
    <link href="@Url.Content("~/Content/Site.css")" rel="stylesheet" type="text/css" />

    <!-- For making AJAX calls via Ajax@ActionLink, you need to include these scripts:
            jquery.unobtrusive-ajax.js
            MicrosoftAjax.js
            MicrosoftMvcAjax.js
    -->
    <script src="@Url.Content("~/Scripts/jquery-1.4.4.min.js")" type="text/javascript"></script>
    <script src="@Url.Content("~/Scripts/jquery.unobtrusive-ajax.js")" type="text/javascript"></script>
    <script src="@Url.Content("~/Scripts/jquery.validate.min.js")" type="text/javascript"></script>
    <script src="@Url.Content("~/Scripts/jquery.validate.unobtrusive.min.js")" type="text/javascript"></script>
    <script src="@Url.Content("~/Scripts/MicrosoftAjax.js")" type="text/javascript"></script>
    <script src="@Url.Content("~/Scripts/MicrosoftMvcAjax.js")" type="text/javascript"></script>
</head>

<body>
    <div class="page">

        <div id="header">
            <div id="title">
                <h1>States ASP.NET MVC 3 Demo</h1>
            </div>

            <div id="logindisplay">
                @Html.Partial("_LogOnPartial")
            </div>

            <br />
            <div id="menucontainer">

                <ul id="menu">
                    <li>@Html.ActionLink("Home", "Index", "Home")</li>
                    <li>@Html.ActionLink("States", "Index", "States")</li>
                    <li>@Html.ActionLink("About", "About", "Home")</li>
                </ul>

            </div>
        </div>

        <div id="main">
            @RenderBody()
            <div id="footer">
            </div>
        </div>
    </div>
</body>
</html>
