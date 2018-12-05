module GameSession
open System
open System

//open Config
//A single game session, not sure if this class should be used.

let mutable WordToGuess = "Bears12"
let mutable GuessSoFar = GetHiddenWord.HideWord(WordToGuess)
let mutable gameRunning = false; //Make bool for keeping Game loop running.
    //so the player can keep playing until he wants to stop or he wins

let Game() =
    let mutable Tries = 0
    WordToGuess <- SelectWordForGame.GetWord()
    GuessSoFar <- GetHiddenWord.HideWord(WordToGuess)
    gameRunning <- true

    while gameRunning do
        Console.Clear()
        printfn "you have tryed %i times" Tries
        printfn "%s" GuessSoFar
        let cki = GetKeyboardInput.GetKeyAndModifierTest();
        let mutable char = cki.KeyChar // this is so GetHelp can be used
            //HELP
        if (cki.Key.ToString().Equals("H") && cki.Modifiers.Equals(ConsoleModifiers.Control)) then
            printfn "Call GetHelp()"
            char <- GetHelp.HelpLetter(GuessSoFar)(WordToGuess)
            printfn "the letter from GetHelp is = %c" char
            //Exit
        if (cki.Key.Equals(ConsoleKey.Escape)) then
            Console.Clear()
            gameRunning <- false //exit Game.
            //GUSS
        if (cki.Key.ToString() <> null) then
            Tries <- Tries + 1
            GuessSoFar <- CheckIfWordFullyGuessed.MakeGuess(GuessSoFar)(WordToGuess)(char)
            printfn ""
            printfn "-|%s|-" GuessSoFar
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
    