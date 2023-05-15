Imports VBGame.VBGame

Public Module Program
    Sub Main()
        Using game As New Game1()
            game.Run()
        End Using
        ' Console.WriteLine("Hello!")
    End Sub
End Module