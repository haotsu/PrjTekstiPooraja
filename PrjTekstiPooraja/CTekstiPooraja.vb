﻿Public Class CTekstiPooraja
    Implements ITeisendused

    'Klassi CTekstiPooraja atribuudid (muutujad)
    Private intAlgusSymbol As Integer
    Private intLoppSymbol As Integer
    Private strPooratavTekst As String

    Private Property intAlgus As Integer Implements ITeisendused.intAlgus
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Integer)
            Throw New NotImplementedException()
        End Set
    End Property

    Private Property intLopp As Integer Implements ITeisendused.intLopp
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As Integer)
            Throw New NotImplementedException()
        End Set
    End Property

    Private Property strTekst As String Implements ITeisendused.strTekst
        Get
            Throw New NotImplementedException()
        End Get
        Set(value As String)
            Throw New NotImplementedException()
        End Set
    End Property

    Private Sub teisendaTekst(ByRef strSisendTekst As String) Implements ITeisendused.teisendaTekst
        Throw New NotImplementedException()
    End Sub

    Private Function pooraTekst() As String Implements ITeisendused.pooraTekst
        Throw New NotImplementedException()
    End Function
End Class
