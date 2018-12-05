module WordGuesserGame //The main file for the word guesser game.

open System
open GetKeyboardInput

//Acts as gathering/central point for the game.

let mutable programRunning = true; //Make bool for keeping Program loop running.
    //so the play returns to the menu after each game

let ShowMenu() =
    printfn "Menu"
    printfn "1. Start game"
    printfn "2. Show credits"
    printfn "3. Exit program"
    //printfn "4. Show options"
    printfn "To select an option, please write a number (1-4) and press >ENTER<..."

let StartGame() =
    printfn "Starting new game session..."
    //GetKeyboardInput.GetKeyAndModifierTest()
    GameSession.Game()

let ShowCredits() =
    printfn "Made by Simon Bay Nymand & Alex Andreasen"
    printfn "Hope you enjoy the game!"

let ExitProgram() =
    programRunning <- false //Set bool false to exit the game loop.
    printfn "Exitting Program.."
    
let HandleMenuInput(inp : string) =
    printfn "You selected option: %s" inp
    match inp with //it is more a "if else" than "switch"
    | "1" -> StartGame()
    | "2" -> ShowCredits()
    | "3" -> ExitProgram()
    | "4" -> SettingsMenu.ShowMenu()
    | _ -> printfn "ERROR - not a menu option, please select again..."

let AskForMenuInput() =
    
    let input = Console.ReadLine()
    HandleMenuInput(input)

let StartProgram() =
    printfn "Welcome to the word guesser game!"
    
    while programRunning do
        ShowMenu()
        AskForMenuInput()
        printfn "Welcome back to the menu"