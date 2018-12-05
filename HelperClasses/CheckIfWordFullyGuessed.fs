module CheckIfWordFullyGuessed
open System

//Check if word guessed depending on if config says case sensitive or not.

//Checks if a string contains a char.
//let checkIfContains(word : string, g : char) : bool = String.exists (fun c -> c = g) word

//Get a helping character based on which parts of the words have or haven't been guessed.
let MakeGuess(wordGuessedSoFar : string)( fullWord : string)( guess : char) : string =
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
    let s = System.String.Concat(wordGuessedSoFarChars) //Make char array into string.
    s

//Check if word is guessed depending on if config says case sensitive or not.
let MakeGuessForWholeWord (wordguessed : string) (wordToGuss : string) : bool =
    
    let mutable wordToGuss2 = wordToGuss
    let mutable wordguessed2 = wordguessed

    if Config.CASE_SENSITIVE = false then
        wordToGuss2 <- wordToGuss.ToLower()
        wordguessed2 <- wordguessed.ToLower()

    wordToGuss2 = wordguessed2

let MakeGuessForSubstring(wordGuessedSoFar : string)( fullWord : string)( guess : string) : string =
    //Case sensitivity settings
    let mutable caseSense_wgsf = wordGuessedSoFar
    let mutable caseSense_fullword = fullWord
    let mutable caseSense_guess = guess
    if Config.CASE_SENSITIVE = false then
        caseSense_wgsf <- caseSense_wgsf.ToLower()
        caseSense_fullword <- caseSense_fullword.ToLower()
        caseSense_guess <- caseSense_guess.ToLower()
    //Char array + progress setup
    let wordGuessedSoFarChars = caseSense_wgsf.ToCharArray()
    let fullwordCharArray = caseSense_fullword.ToCharArray()
    let mutable fullwordMut = caseSense_fullword
    let mutable index = 0
    let mutable substringIndex = 0
    //Action
    while index <> -1 do //While substring can be found
        index <- fullwordMut.IndexOf(caseSense_guess) //Find index of matching substring, if not found (0) then leave loop.
        substringIndex <- 0
        if (index <> -1) then
            for c in caseSense_guess do //Go through substring.
                wordGuessedSoFarChars.[index + substringIndex] <- fullWord.[index + substringIndex]
                fullwordCharArray.[index + substringIndex] <- '*' //Change inspected substring so doesn't hit that value again.
                substringIndex <- substringIndex + 1
        fullwordMut <- String.Concat(fullwordCharArray) //Change word being expected so can jump to next valid substring if any.
    
    let s = System.String.Concat(wordGuessedSoFarChars) //Make char array into string.
    printfn "%s" s
    s
    
    