Module Module1
    '6) Sestavte subrutinu SudaCislaZpole, která má jediný parametr: pole celých čísel. 
    'Výsledkem subrutiny je jednorozměrné celočíselné pole, ve kterém jsou jen sudá čísla obsažená v poli parametru. 
    'Subrutinu ověřte na zadání: sestavte program, který načte pole celých čísel ukončených nulou, která už k číslům nepatří, 
    'a pak zobrazí všechna ze zadaných čísel, která jsou sudá. 
    'peno - trochu jsem to zkratil, nic nezadavam a primo deklaruju "pole celych cilel"
    'peno2 - puvodne je to program pro funkci, zde chceme ukazat, jak by se stejny problem resi pomoci subrutiny


    Sub Main()
        Dim poleCelychCisel() As Integer = {12, 8, 29, 1, 9, 7, 45, 40, 3, 100}
        Dim poleSudych() As Integer
        Dim l As Integer
        Dim ret As String

        SudaCislaZPole(poleCelychCisel, poleSudych)


        ret = ""
        For l = 0 To UBound(poleSudych)
            If poleSudych(l) <> 0 Then
                ret += Str(poleSudych(l)) + Chr(10)
            End If
        Next
        MsgBox(ret)

    End Sub

    Sub SudaCislaZPole(poleCelychCiselF() As Integer, ByRef vystupS() As Integer)
        Dim i As Integer
        Dim k As Integer
        Dim poleSudychF(10) As Integer

        k = 0
        For i = 0 To UBound(poleCelychCiselF)
            If poleCelychCiselF(i) Mod 2 = 0 Then
                poleSudychF(k) = poleCelychCiselF(i)
                k += 1
            End If
        Next

        vystupS = poleSudychF

    End Sub

End Module

'for comparison down there is the same task but using function instead of subrutine

'Module Module1
'    '6) Sestavte funkci SudaCislaZpole, která má jediný parametr: pole celých čísel. 
'    'Výsledkem funkce je jednorozměrné celočíselné pole, ve kterém jsou jen sudá čísla obsažená v poli parametru. 
'    'Funkci ověřte na zadání: sestavte program, který načte pole celých čísel ukončených nulou, která už k číslům nepatří, 
'    'a pak zobrazí všechna ze zadaných čísel, která jsou sudá.
'    'peno - trochu jsem to zkratil, nic nezadavam a primo deklaruju "pole celych cilel"
'    Sub Main()
'        Dim poleCelychCisel() As Integer = {12, 8, 29, 1, 9, 7, 45, 40, 3}
'        Dim poleSudych() As Integer
'        Dim l As Integer
'        Dim ret As String

'        poleSudych = SudaCislaZPole(poleCelychCisel)

'        ret = ""
'        For l = 0 To UBound(poleSudych)
'            If poleSudych(l) <> 0 Then
'                ret += Str(poleSudych(l)) + Chr(10)
'            End If
'        Next
'        MsgBox(ret)
'    End Sub
'    Function SudaCislaZPole(poleCelychCiselF() As Integer) As Integer()
'        Dim i As Integer
'        Dim k As Integer
'        Dim poleSudychF(10) As Integer

'        k = 0
'        For i = 0 To UBound(poleCelychCiselF)
'            If poleCelychCiselF(i) Mod 2 = 0 Then
'                poleSudychF(k) = poleCelychCiselF(i)
'                k += 1
'            End If
'        Next

'        SudaCislaZPole = poleSudychF

'    End Function
'End Module
