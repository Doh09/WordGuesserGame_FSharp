module SettingsMenu

open System

let ShowMenu() =
    printfn ""
    printfn "Options"
    //printfn "0. Back to main menu"
    printfn "1. HIDDEN: %s" Config.HIDDEN
    printfn "2. CASE_SENSITIVE: %b" Config.CASE_SENSITIVE
    printfn "3. ALLOW_BLANKS: %b" Config.ALLOW_BLANKS
    printfn "4. HELP: %b" Config.HELP
    printfn "5. MULTIPLE: %b" Config.MULTIPLE

//let HandleMenuInput(inp : string) =
//    printfn "You selected option: %s" inp
//    match inp with //it is more a "if else" than "switch"
//    | "1" -> ShowMenu()
//    | "2" -> ShowCredits()
//    | "3" -> ExitGame()
//    | "T" -> Test()
//    | _ -> printfn "ERROR - not a menu option, please select again..."

//let AskForMenuInput() =
//    printfn "To select an option, please write a number (1-3) and press >ENTER<..."
//    let input = Console.ReadLine()
//    HandleMenuInput(input)
