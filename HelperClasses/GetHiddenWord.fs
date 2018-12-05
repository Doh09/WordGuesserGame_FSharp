module GetHiddenWord

//Get the hidden word to display based on which characters have and haven't been guessed. cw (gu*ss*d.)
let HideWord(wordToHide : string) : string =
    let mutable hiddenWord = ""
    for c in wordToHide do //For each char in word, create a * to represent it.
        hiddenWord <- hiddenWord + Config.HIDDEN
    printfn "HiddenWord: %s" hiddenWord
    //printfn "HiddenWord2: %s" hiddenWord
    hiddenWord