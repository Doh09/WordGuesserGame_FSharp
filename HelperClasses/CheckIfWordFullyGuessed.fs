module CheckIfWordFullyGuessed
open System

//Check if word guessed depending on if config says case sensitive or not.

//Checks if a string contains a char.
//let checkIfContains(word : string, g : char) : bool = String.exists (fun c -> c = g) word

//Get a helping character based on which parts of the words have or haven't been guessed.
let MakeGuess(wordGuessedSoFar : string, fullWord : string, guess : char) : string =
    printfn "Getting helping character..."
    let mutable index = 0
    let wordGuessedSoFarChars = wordGuessedSoFar.ToCharArray()
    
    //match Config.CASE_SENSITIVE with
    //| true -> if (c.Equals(guess)) then wordGuessedSoFarChars.[index] <- c; index <- index + 1
    //| false -> if (c.Equals(guess)) then wordGuessedSoFarChars.[index] <- c; index <- index + 1

    for c in fullWord do //For each char that is equal to guess, reveal this char in the wordGuessedSoFar.
        printf "char: %c" c
        if (c.Equals(guess)) then
            wordGuessedSoFarChars.[index] <- c
        index <- index + 1
    let s = System.String.Concat(wordGuessedSoFarChars) //Print the new wordGuessedSoFar.
    
    //printfn ""
    //let bo1 = checkIfContains("bear", 'B')
    //printfn "Test1: %b" bo1
    //let bo2 = checkIfContains("bear", 'x')
    //printfn "Test2: %b" bo2
    //printfn "wordGuessedSoFarChars: %s" s
    s

        //if (c.Equals(guess))
            //c

//Check if word guessed depending on if config says case sensitive or not.
let MakeGuessForWholeWord (wordguessed : string) (wordToGuss : string) : bool =
    
    let wordToGuss2 = wordToGuss.ToLower()
    let wordguessed2 = wordguessed.ToLower()
    
    printfn "wordToGuss : %s" wordToGuss 
    printfn "wordguessed : %s" wordguessed
    printfn "lower WordToGuss : %s" wordToGuss2  
    printfn "lower Wordguessed : %s" wordguessed2

    wordToGuss2 = wordguessed2

let makeACharGuss (wordguessed : string) (wordToGuss : string) =
    printfn "one Letter"