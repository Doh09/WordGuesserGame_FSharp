// Learn more about F# at http://fsharp.org
open System

[<EntryPoint>]
let main argv =
    printfn "Hello World from F#!"
    let x = 10
    let y = 20
    let z = x + y

    //printfn "x: %i" x
    //printfn "y: %i" y
    //printfn "z: %i" z
    WordGuesserGame.StartProgram()
    
    printfn "Hit >ENTER< to exit the program..."
    System.Console.ReadLine();
    0 // return an integer exit code