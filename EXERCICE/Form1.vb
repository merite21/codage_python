Public Class Form1
    Private Sub Form1_Load(sender As Object, e As EventArgs) Handles MyBase.Load

    End Sub
End Class
Module Module1

    Sub Main()

        ' Tableau des élèves
        Dim eleves() As String = {"Adam", "Alex", "Brice", "Bénédicte", "Carine", "Cassiopée", "David", "Dona"}

        Console.Write("Entrez une lettre : ")
        Dim lettre As String = Console.ReadLine().ToUpper()

        ' Filtrer les noms qui commencent par la lettre
        Dim resultat = eleves.Where(Function(n) n.ToUpper().StartsWith(lettre)).ToList()

        If resultat.Count = 0 Then
            Console.WriteLine("Aucun nom ne commence par cette lettre.")
        Else
            ' Trier en ordre croissant
            resultat.Sort()

            Console.WriteLine("Noms trouvés : ")
            For Each nom In resultat
                Console.WriteLine(nom)
            Next
        End If

        Console.WriteLine()
        Console.WriteLine("Appuyez sur Entrée pour quitter...")
        Console.ReadLine()

    End Sub

End Module
