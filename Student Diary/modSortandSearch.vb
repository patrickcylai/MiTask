Module modSortandSearch

    Sub QuickSort(ByRef vArray As Object, ByRef inLow As Long, ByRef inHi As Long)

        '=============
        'Quicksort
        '=============
        Dim pivot As Object
        Dim tmpSwap As Object
        Dim tmpLow As Long
        Dim tmpHi As Long

        tmpLow = inLow
        tmpHi = inHi

        pivot = vArray((inLow + inHi) \ 2)

        While (tmpLow <= tmpHi)

            While (vArray(tmpLow) < pivot And tmpLow < inHi)
                tmpLow = tmpLow + 1
            End While

            While (pivot < vArray(tmpHi) And tmpHi > inLow)
                tmpHi = tmpHi - 1
            End While

            If (tmpLow <= tmpHi) Then
                tmpSwap = vArray(tmpLow)
                vArray(tmpLow) = vArray(tmpHi)
                vArray(tmpHi) = tmpSwap
                tmpLow = tmpLow + 1
                tmpHi = tmpHi - 1
            End If

        End While

        If (inLow < tmpHi) Then
            QuickSort(vArray, inLow, tmpHi)
        End If

        If (tmpLow < inHi) Then
            QuickSort(vArray, tmpLow, inHi)
        End If
    End Sub

    Function BinarySearch(ByVal search As String, ByVal array As Object, ByVal upperIndex As Integer)

        '===============
        'Binary Search
        '===============
        Dim middle, lower, upper As Integer
        Dim find As String = search

        lower = 0
        upper = upperIndex

        While upper >= lower
            middle = (upper + lower) / 2

            If find = array(middle) Then
                Return True
                Exit Function
            End If

            If find > array(middle) Then
                lower = middle + 1
            Else
                upper = middle - 1
            End If

        End While

        Return False
    End Function

End Module
