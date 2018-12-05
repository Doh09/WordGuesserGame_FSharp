module SettingsMenu

open System

let mutable index = 0
let mutable showOptions = false

let SelectNextHidden() =
    match Config.HIDDEN with
        | "*" -> Config.HIDDEN <- "!"
        | "!" -> Config.HIDDEN <- "?"
        | "?" -> Config.HIDDEN <- "*"
        | _ -> printfn "Error when selecting new HIDDEN value..."

let ShowMenu() =
    index <- 0
    showOptions <- true

    while showOptions do
        Console.Clear()
        printfn ""
        printfn "Options"
        printfn "0. Back to main menu"
        printfn "1. HIDDEN: %s" Config.HIDDEN
        printfn "2. CASE_SENSITIVE: %b" Config.CASE_SENSITIVE
        printfn "3. ALLOW_BLANKS: %b" Config.ALLOW_BLANKS
        printfn "4. HELP: %b" Config.HELP
        printfn "5. MULTIPLE: %b" Config.MULTIPLE

        let input = System.Console.ReadLine()
        match input with
        | "0" -> showOptions <- false
        | "1" -> SelectNextHidden()
        | "2" -> Config.CASE_SENSITIVE <- not Config.CASE_SENSITIVE
        | "3" -> Config.ALLOW_BLANKS <- not Config.ALLOW_BLANKS
        | "4" -> Config.HELP <- not Config.HELP
        | "5" -> Config.MULTIPLE <- not Config.MULTIPLE
        | _ -> printfn "ERROR - Invalid command"
    Console.Clear()

    
 
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
