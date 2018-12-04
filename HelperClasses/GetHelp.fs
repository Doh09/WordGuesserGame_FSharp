module GetHelp
open System

let genRandomNumbers high =
    let rnd = System.Random()
    rnd.Next (high)

//Get a helping character based on which parts of the words have or haven't been guessed.
let HelpLetter(wordguessed : string) (wordToGuss : string) =

    //let cl = wordToGuss.ToCharArray()
    let mutable helpChar = []
    //helpChar  <- ['1'] |> List.append helpChar
    //helpChar  <- ['2'] |> List.append helpChar
    //helpChar  <- ['2'] |> List.append helpChar
    //helpChar  <- ['5'] |> List.append helpChar
    //printfn "Seasons Average: %A" helpChar

    for c in wordToGuss do
        if not (wordguessed.Contains(c)) then 
            helpChar  <- [c] |> List.append helpChar
        //if not (wordguessed |> Seq.forall Char.IsLetter(c)) then

        //
    //fun (combos : string list) -> List.nth combos (5)

    let l = genRandomNumbers (helpChar.Length)
    printfn""
    printfn "%A" l
    printfn "letter is : %c" (helpChar.Item(l))
    printfn""