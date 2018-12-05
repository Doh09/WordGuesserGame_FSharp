module GetHelp
open System

let genRandomNumbers high =
    let rnd = System.Random()
    rnd.Next (high)

//Get a helping character based on which parts of the words have or haven't been guessed.
let HelpLetter(wordguessed : string) (wordToGuss : string) : char =
    let mutable helpChar = []
    for c in wordToGuss do
        if not (wordguessed.Contains(c)) then 
            helpChar  <- [c] |> List.append helpChar
    let l = genRandomNumbers (helpChar.Length)
    helpChar.Item(l)