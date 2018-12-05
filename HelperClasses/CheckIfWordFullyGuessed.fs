module CheckIfWordFullyGuessed
open System

//Check if word guessed depending on if config says case sensitive or not.

//Checks if a string contains a char.
//let checkIfContains(word : string, g : char) : bool = String.exists (fun c -> c = g) word

//Get a helping character based on which parts of the words have or haven't been guessed.
let MakeGuess(wordGuessedSoFar : string)( fullWord : string)( guess : char) : string =
    printfn "Getting helping character..."
    
    let wordGuessedSoFarChars = wordGuessedSoFar.ToCharArray()
    
    let mutable fullWord2 = fullWord
    let mutable guess2 = guess

    if Config.CASE_SENSITIVE = false then
        fullWord2 <- fullWord2.ToLower()
        guess2 <- Char.ToLower(guess2)
    
    let mutable index = 0
    for c in fullWord2 do //For each char that is equal to guess, reveal this char in the wordGuessedSoFar.
//        printfn "char: %c" c
        if (c.Equals(guess2)) then
            wordGuessedSoFarChars.[index] <- fullWord.[index]
        index <- index + 1
    let s = System.String.Concat(wordGuessedSoFarChars) //Print the new wordGuessedSoFar.
    s

//Check if word is guessed depending on if config says case sensitive or not.
let MakeGuessForWholeWord (wordguessed : string) (wordToGuss : string) : bool =
    
    let mutable wordToGuss2 = wordToGuss
    let mutable wordguessed2 = wordguessed

    if Config.CASE_SENSITIVE = false then
        wordToGuss2 <- wordToGuss.ToLower()
        wordguessed2 <- wordguessed.ToLower()

    wordToGuss2 = wordguessed2

//let MakeGuessForSubstring(wordguessed : string) (guess : string) : bool =
    