' MIT License

' Copyright (c) 2020 Jean-Jacques François Reibel

' Permission is hereby granted, free of charge, to any person obtaining a copy
' of this software and associated documentation files (the "Software"), to deal
' in the Software without restriction, including without limitation the rights
' to use, copy, modify, merge, publish, distribute, sublicense, and/or sell
' copies of the Software, and to permit persons to whom the Software is
' furnished to do so, subject to the following conditions:

' The above copyright notice and this permission notice shall be included in all
' copies or substantial portions of the Software.

' THE SOFTWARE IS PROVIDED "AS IS", WITHOUT WARRANTY OF ANY KIND, EXPRESS OR
' IMPLIED, INCLUDING BUT NOT LIMITED TO THE WARRANTIES OF MERCHANTABILITY,
' FITNESS FOR A PARTICULAR PURPOSE AND NONINFRINGEMENT. IN NO EVENT SHALL THE
' AUTHORS OR COPYRIGHT HOLDERS BE LIABLE FOR ANY CLAIM, DAMAGES OR OTHER
' LIABILITY, WHETHER IN AN ACTION OF CONTRACT, TORT OR OTHERWISE, ARISING FROM,
' OUT OF OR IN CONNECTION WITH THE SOFTWARE OR THE USE OR OTHER DEALINGS IN THE
' SOFTWARE.

Imports System

Public Class MainClass
    
    Shared Sub Main()
        Console.WriteLine("Creating car.")
        Dim subaru As New Car(4, 4, 4)
        Console.WriteLine("Wheels check: " & subaru.wheels)
        Console.WriteLine("Doors check: " & subaru.doors)
        Console.WriteLine("Cylinders check: " & subaru.cylinders & vbCrLf)
        Console.WriteLine("Adding wheels directly to car object.")
        subaru.wheels = 5
        Console.WriteLine("Wheels check: " & subaru.wheels)
        Console.WriteLine("Doors check: " & subaru.doors)
        Console.WriteLine("Cylinders check: " & subaru.cylinders & vbCrLf)
        Console.WriteLine("Removing wheels using object method.")
        subaru.deleteWheels(1)
        Console.WriteLine("Wheels check: " & subaru.wheels)
        Console.WriteLine("Doors check: " & subaru.doors)
        Console.WriteLine("Cylinders check: " & subaru.cylinders & vbCrLf)

    End Sub
End Class

Public Class Car

    Public wheels As Integer
    Public doors As Integer
    Public cylinders As Integer

    Public Sub addWheels(wheelsIn As Integer)
        wheels +=  wheelsIn
    End Sub 
    
    Public Sub addDoors(doorsIn As Integer)
        doors +=  doorsIn
    End Sub 
    
    Public Sub addCylinders(cylindersIn As Integer)
        cylinders +=  cylindersIn
    End Sub 
    
    Public Sub deleteWheels(wheelsIn As Integer)
        wheels -=  wheelsIn
    End Sub 
    
    Public Sub deleteDoors(doorsIn As Integer)
        doors -=  doorsIn
    End Sub 
    
    Public Sub deleteCylinders(cylindersIn As Integer)
        cylinders -=  cylindersIn
    End Sub 

    Public Sub New( _
        ByVal wheelsIn As Integer, _
        ByVal doorsIn As Integer, _
        ByVal cylindersIn As Integer)
        Me.wheels = wheelsIn
        Me.doors = doorsIn
        Me.cylinders = cylindersIn
    End Sub
    
 End Class
