Namespace StatesMVCAjaxDemo
    Public Class StatesController
        Inherits System.Web.Mvc.Controller

        Dim stateRepository As IRepository

        Public Sub New()
            stateRepository = New Repository
        End Sub

        Public Sub New(ByRef repository As IRepository)
            stateRepository = repository
        End Sub

        '
        ' GET: /States

        Function Index() As ActionResult
            Dim model As List(Of StateNameEntryModel)
            model = stateRepository.GetAllStateNames()

            Return View(model)
        End Function


        Function GetStateDetails(ByVal id As String) As PartialViewResult
            Dim model As StateDetailModel
            model = stateRepository.GetStateDetails(id)

            Return PartialView("StateDetails", model.stateDetails)
        End Function

        ' jsonresult actions must be invoked via POST
        <HttpPost()>
        Function GetCounties(ByVal id As String) As JsonResult
            Return Json(stateRepository.GetCounties(id))
        End Function
    End Class

End Namespace