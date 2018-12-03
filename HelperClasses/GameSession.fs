module GameSession
open System
//open Config
//A single game session, not sure if this class should be used.

let WordToGuess = "Bear"

let GuessSoFar = "Be_r"

///Method used for testing word selection..
let PrintThreeRandomWords() =
    printf "Three words: "
    let word1 = SelectWordForGame.GetWord()
    let word2 = SelectWordForGame.GetWord()
    let word3 = SelectWordForGame.GetWord()
    let word4 = GetHelp.MakeGuess("Be**", "Bear", 'a')
    let word5 = GetHelp.MakeGuess("Be**", "Bear", 'r')
    let word6 = GetHelp.MakeGuess("Be**", "Bear", 'x')
    printfn ""
    printfn "Word1: %s" word1
    printfn "Word2: %s" word2
    printfn "Word3: %s" word3
    printfn "Word4: %s" word4
    printfn "Word5: %s" word5
    printfn "Word6: %s" word6
    