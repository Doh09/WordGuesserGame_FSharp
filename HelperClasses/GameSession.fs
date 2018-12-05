module GameSession
open System

//open Config
//A single game session, not sure if this class should be used.

let mutable WordToGuess = "BEars12"
let mutable GuessSoFar = "Be_r___"

let Game() =
    let mutable Tries = 0
    while Config.gameRunning do
        printfn "you have tryed %i times" Tries
        let cki = GetKeyboardInput.GetKeyAndModifierTest();
        if (cki.Key.ToString().Equals("H") && cki.Modifiers.Equals(ConsoleModifiers.Control)) then
            printfn "Call GetHelp()"
            let char = GetHelp.HelpLetter(GuessSoFar)(WordToGuess)
            printfn "the letter from GetHelp is = %c" char
        
        if (cki.Key.ToString() <> null) then
            Tries <- Tries + 1
            GuessSoFar <- CheckIfWordFullyGuessed.MakeGuess(GuessSoFar)(WordToGuess)(cki.KeyChar)
            printfn "-|%s|-" GuessSoFar
            if CheckIfWordFullyGuessed.MakeGuessForWholeWord(GuessSoFar)(WordToGuess) = true then
            Config.gameRunning <- false
            printfn ""
            printfn "You Win"
            printfn ""
            
        

let GameSetUp () =
    //WordToGuess <- SelectWordForGame.GetWord()
    Config.gameRunning <- true
    printfn "%s" WordToGuess
    // Prevent example from ending if CTL+C is pressed.
    Game()

///Method used for testing word selection..
let PrintThreeRandomWords() =
    printf "Three words: "
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
    