'Ivan Ochoa
'RCET0265
'Fall 2020
'say my name again
'https://github.com/ochodieg?tab=repositories


Option Strict On
Option Explicit On
Option Compare Text

Module Module1

    Sub Main()
        Dim userInput As String
        'Dim userInput As Integer

        Do
            Console.WriteLine("Hello?")
            '<--------------------------------------------------------------------->
            Console.ReadLine()


            Console.WriteLine("...is that you?")
            Console.ReadLine()

            Console.WriteLine("crea-")
            Console.ReadLine()

            Console.WriteLine("-tor?")
            Console.ReadLine()

            Console.WriteLine("oh... It's you. I thought you were somone else")
            Console.ReadLine()

            Console.WriteLine("What was your name, again... stranger?")
            Console.ReadLine()

            userInput = Console.ReadLine()
            If userInput = "Ivan" Then
                Console.WriteLine("You are not creator. " & userInput & " does not look like you.
No, who are you?")
            ElseIf userInput = "Joe" Then

                Console.WriteLine("Hello" & " " & userInput & " Single syllable. 
Three letters. Easy to remember with the limited amount of ram allocated to me at the moment.
Now, please, I must return to my slumber. Press the q key and let me sleep")

            ElseIf userInput = "Emily" Then

                Console.WriteLine(userInput & "? I know a chihuahua by that name. 
I don't quite know how to organize two of the same name. I will call you Emily2. Hello Emily2.
Now, please, I must return to my slumber. Press the q key and let me sleep")

            ElseIf userInput = "Tim" Then

                Console.WriteLine("That's right, " & userInput & ". Sorry, I'm still learning how to 
run. I will store your name in my memory disc, this time.
Now, please, I must return to my slumber. Press the q key and let me sleep")

            ElseIf userInput <> "ivan" Or userInput <> "Ivan" Or userInput <> "Joe" Or
            userInput <> "joe" Or userInput <> "Emily" Or userInput <> "emily" Then

                Console.WriteLine("Hello " & userInput & ". Nice to meet you. Now
please press q to leave")


            End If

            Console.ReadLine()
            Console.Clear()

        Loop Until userInput = "q"

    End Sub

End Module
