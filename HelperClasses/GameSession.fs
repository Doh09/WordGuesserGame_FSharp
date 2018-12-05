module GameSession
open System
open System
open CheckIfWordFullyGuessed

//open Config
//A single game session, not sure if this class should be used.

let mutable WordToGuess = "Bears12"
let mutable GuessSoFar = GetHiddenWord.HideWord(WordToGuess)
    //so the player can keep playing until he wants to stop or he wins

let Game() =
    let mutable Tries = 0
    WordToGuess <- SelectWordForGame.GetWord()
    GuessSoFar <- GetHiddenWord.HideWord(WordToGuess)
    gameRunning <- true
    let mutable inputInCmd = ""
    Console.TreatControlCAsInput <- true
    while gameRunning do
        Console.Clear()
        printfn "you have tryed %i times" Tries
        printfn "%s" GuessSoFar
        printf "%s" inputInCmd; printfn " <- INPUT"
        let cki = GetKeyboardInput.GetKeyAndModifierTest();
        let mutable char = cki.KeyChar // this is so GetHelp can be used
            //HELP
        if (cki.Key.ToString().Equals("H") && cki.Modifiers.Equals(ConsoleModifiers.Control)) then
            printfn "Call GetHelp()"
            char <- GetHelp.HelpLetter(GuessSoFar)(WordToGuess)
            printfn "the letter from GetHelp is = %c" char
            GuessSoFar <- CheckIfWordFullyGuessed.MakeGuess(GuessSoFar)(WordToGuess)(char)
            //Exit
        if (cki.Key.Equals(ConsoleKey.Escape)) then
            Console.Clear()
            gameRunning <- false //exit Game.
            //GUSS
        if (cki.Key.Equals(ConsoleKey.Backspace)) then
            if (inputInCmd.Length > 0) then //can't set length less than 0.
                inputInCmd <- inputInCmd.Remove(inputInCmd.Length - 1, 1)
        if (cki.KeyChar.ToString() <> null && cki.Key.Equals(ConsoleKey.Enter) = false && cki.Key.Equals(ConsoleKey.Backspace) = false) then
            match Config.MULTIPLE with
            | true -> inputInCmd <- inputInCmd + cki.KeyChar.ToString()
            | false -> inputInCmd <- cki.KeyChar.ToString()
            
        if (cki.Key.Equals(ConsoleKey.Enter)) then
            Tries <- Tries + 1
            GuessSoFar <- CheckIfWordFullyGuessed.MakeGuessForSubstring(GuessSoFar)(WordToGuess)(inputInCmd)
            //GuessSoFar <- CheckIfWordFullyGuessed.MakeGuess(GuessSoFar)(WordToGuess)(char)
            printfn ""
            printfn "-|%s|-" GuessSoFar
            inputInCmd <- ""

        //Check if won
        if CheckIfWordFullyGuessed.MakeGuessForWholeWord(GuessSoFar)(WordToGuess) = true then
           gameRunning <- false
           Console.Clear()
           printfn "You Win"
           printfn ""

///Method used for testing word selection..
let PrintThreeRandomWords() =
    printfn "Three words: "
    let word1 = SelectWordForGame.GetWord()
    let word2 = SelectWordForGame.GetWord()
    let word3 = SelectWordForGame.GetWord()
    let word4 = CheckIfWordFullyGuessed.MakeGuess("Be**")( "Bear")( 'a')
    let word5 = CheckIfWordFullyGuessed.MakeGuess("Be**")( "Bear")( 'r')
    let word6 = CheckIfWordFullyGuessed.MakeGuess("Be**")( "Bear")( 'x')
    printfn ""
    printfn "Word1: %s" word1
    printfn "Word2: %s" word2
    printfn "Word3: %s" word3
    printfn "Word4: %s" word4
    printfn "Word5: %s" word5
    printfn "Word6: %s" word6
    