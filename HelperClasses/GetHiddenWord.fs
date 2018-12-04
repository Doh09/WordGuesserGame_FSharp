module GetHiddenWord

//Get the hidden word to display based on which characters have and haven't been guessed. cw (gu*ss*d.)

//let rec HideWord2(wordToHide : string) : string = Seq.toList  |> List.collect '*' |> list

//String.exists (fun c -> c = g)
//let checkIfContains(word : string, g : char) : bool = String.exists (fun c -> c = g)
let HideWord(wordToHide : string) : string =
    let mutable hiddenWord = ""
    for c in wordToHide do //For each char in word, create a * to represent it.
        hiddenWord <- hiddenWord + Config.HIDDEN
    printfn "HiddenWord: %s" hiddenWord
    //Seq.toList "Hello"

    //hiddenWord <- wordToHide.Replace(wordToHide, "birds")
    //printfn "HiddenWord2: %s" hiddenWord
    hiddenWord

let PrintWord gussedSofare WordToGuss : string =

    //(**e**e*.)
    //(gu****d.)
    //(guessed.)

    printfn(gussedSofare);
    printfn(WordToGuss);
  //  if(gussedSofare == WordToGuss)
  //  {won}
  //  else {nope}
 //   "that was a word"