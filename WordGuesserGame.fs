module WordGuesserGame //The main file for the word guesser game.

open System

//Acts as gathering/central point for the game.

let mutable GameRunning = true; //Make bool for keeping game loop running. 
//Set mutable so can be changed later to exit the game.

let ShowMenu() =
    printfn ""
    printfn "Menu"
    printfn "1. Start game"
    printfn "2. Show credits"
    printfn "3. Exit game"

let StartGame() =
    printfn "Starting new game session..."

let ShowCredits() =
    printfn "Made by Simon Bay Nymand & Alex Andreasen"
    printfn "Hope you enjoy the game!"

let ExitGame() =
    GameRunning <- false //Set bool false to exit the game loop.
    printfn "Exitting game.."

let HandleMenuInput(inp : string) =
    printfn "You selected option: %s" inp
    match inp with 
    | "1" -> StartGame()
    | "2" -> ShowCredits()
    | "3" -> ExitGame()
    | _ -> printfn "ERROR - not a menu option, please select again..."

let AskForMenuInput() =
    printfn "To select an option, please write a number (1-3) and press >ENTER<..."
    let input = Console.ReadLine()
    HandleMenuInput(input)

let StartProgram() =
    printfn "Welcome to the word guesser game!"
    while GameRunning do
        ShowMenu()
        AskForMenuInput()