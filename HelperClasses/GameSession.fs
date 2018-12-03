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
    printfn "Word1: %s" word1
    printfn "Word2: %s" word2
    printfn "Word3: %s" word3