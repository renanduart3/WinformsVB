Imports System.Text
Imports Microsoft.VisualStudio.TestTools.UnitTesting

<TestClass()> Public Class TesteServiceForm

    Private _formService As FormService = New FormService()
    <TestMethod()>
    Sub IsPrime_InputIs1_ReturnFalse()
        Dim result As Boolean = _formService.IsPrime(1)

        Assert.IsFalse(result, "1 should not be prime")
    End Sub

End Class