Module Module1

    Sub Main()

        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''
        'Name: Curtis  Mullett                                                        '
        'Program name: Mr. and Mrs. Game                                              '
        'Date: 21/11/14                                                               '
        'Description: Asks two individuals questions about each other                 '
        '''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''''

        'Variables
        Dim Q(5) As String
        Dim Count As Integer
        Dim QA1(5) As String
        Dim QA2(5) As String
        Dim Read As Integer
        Dim Score As Integer
        Dim P1 As String
        Dim P2 As String

        'Storing Questions
        Q(0) = "What is favourite food?"
        Q(1) = "What is P1's most valued possesion?"
        Q(2) = "What is P1's most annoying habbit?"
        Q(3) = "What is P1's proudest Moment?"
        Q(4) = "How old is P1?"
        Q(5) = "Does P1 Like or hate marmite?"

        Count = 0
        Read = 0


        Console.WriteLine("Hello and welcome to Mr. and Mrs. the Game")
        Console.WriteLine("This game is for two players!")
        Console.WriteLine("WARNING!!! Type awnsers using no capitalisation")
        Console.WriteLine("Press ENTER to continue...")
        Console.ReadLine()
        Console.Clear()

        Console.WriteLine("What is P1's name?...")
        P1 = Console.ReadLine()
        Console.WriteLine("What is P2's name?...")
        P2 = Console.ReadLine()
        Console.WriteLine(P2 & " please look away!")
        Console.WriteLine("Press ENTER when ready....")
        Console.ReadLine()
        Console.Clear()

        Console.WriteLine("The First question is.... ")
        Console.WriteLine(Q(Count))
        QA1(Count) = Console.ReadLine()
        Count = Count + 1

        While Count <> 6
            Console.WriteLine("The next question is.... ")
            Console.WriteLine(Q(Count))
            QA1(Count) = Console.ReadLine()
            Count = Count + 1
        End While

        Console.Clear()

        If Count = 6 Then
            Count = 0
        End If


        Console.WriteLine("The first question is.... ")
        Console.WriteLine(Q(Count))
        QA2(Count) = Console.ReadLine()
        Count = Count + 1

        While Count <> 6
            Console.WriteLine("The next question is....")
            Console.WriteLine(Q(Count))
            QA2(Count) = Console.ReadLine()
            Count = Count + 1
        End While

        Console.Clear()


        Count = 0
        While Count <> 6
            If LCase(QA1(Count)) = LCase(QA2(Count)) Then
                Score = Score + 1
            End If
            Count = Count + 1
        End While

        Console.Clear()

        Console.WriteLine("Your total score is " & Score & " out of 6")
        Console.ReadLine()

    End Sub

End Module
