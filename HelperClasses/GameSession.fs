module GameSession
open System

//open Config
//A single game session, not sure if this class should be used.

let WordToGuess = "Bear"
let GuessSoFar = "Be_r"
let mutable GameRunning = true;


let Game() =
    while GameRunning do
        if (Config.HELP && Console.ReadKey().Modifiers = ConsoleModifiers.Control) then 
            printfn "1"
            if Console.ReadKey(true).KeyChar |> Char.ToUpper = 'H' then 
            printf "HELP"
            GameRunning <- false
            printfn "2"
            else
            printfn "3"


let GameSetUp () =
    WordToGuess = SelectWordForGame.GetWord()
    printfn "%s" WordToGuess
    // Prevent example from ending if CTL+C is pressed.
    Console.TreatControlCAsInput = true
    Game()

//s i see this as a test
///Method used for testing word selection..
let PrintThreeRandomWords() =
    printf "Three words: "
    let word1 = SelectWordForGame.GetWord()
    let word2 = SelectWordForGame.GetWord()
    let word3 = SelectWordForGame.GetWord()
    let word4 = CheckIfWordFullyGuessed.MakeGuess("Be**", "Bear", 'a')
    let word5 = CheckIfWordFullyGuessed.MakeGuess("Be**", "Bear", 'r')
    let word6 = CheckIfWordFullyGuessed.MakeGuess("Be**", "Bear", 'x')
    printfn ""
    printfn "Word1: %s" word1
    printfn "Word2: %s" word2
    printfn "Word3: %s" word3
    printfn "Word4: %s" word4
    printfn "Word5: %s" word5
    printfn "Word6: %s" word6
    