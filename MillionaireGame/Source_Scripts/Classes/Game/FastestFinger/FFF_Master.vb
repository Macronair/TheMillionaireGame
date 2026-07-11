Imports Microsoft.AspNetCore.SignalR.Client

Module FFF_Master

    Async Function SendQuestion() As Task
        Dim connection = New HubConnectionBuilder().
            WithUrl("https://localhost:5000/fastestfingerhub").
            Build()

        Await connection.StartAsync()

        Dim question = New With {
            .QuestionId = 1,
            .Question = "Zet deze gebeurtenissen in de juiste volgorde",
            .Answers = New List(Of String) From {
                "Val van de Berlijnse Muur",
                "Eerste maanlanding",
                "Uitvinding van de telefoon",
                "Franse Revolutie"
            }
        }

        Await connection.InvokeAsync("SendQuestion", question)

        Console.WriteLine("Vraag verstuurd!")
        Console.ReadLine()
    End Function

End Module
