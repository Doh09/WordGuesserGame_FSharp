module CheckIfWordFullyGuessed
open System


//Check if word guessed depending on if config says case sensitive or not.
let MakeGuess (wordguessed : string) (wordToGuss : string) : bool =
    
    let mutable wordToGuss2 = wordToGuss
    let mutable wordguessed2 = wordguessed

    if Config.CASE_SENSITIVE = false then
        wordToGuss2 <- wordToGuss.ToLower()
        wordguessed2 <- wordguessed.ToLower()

    printfn "wordToGuss : %s" wordToGuss 
    printfn "wordguessed : %s" wordguessed
    printfn "lower WordToGuss : %s" wordToGuss2  
    printfn "lower Wordguessed : %s" wordguessed2

    wordToGuss2 = wordguessed2

let makeACharGuss (wordguessed : string) (wordToGuss : string) =
    printfn "one Letter"