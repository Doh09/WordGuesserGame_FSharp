module GetKeyboardInput
open System

let GetKeyAndModifierTest() =
//Source: https://docs.microsoft.com/en-us/dotnet/api/system.consolekeyinfo.modifiers?view=netframework-4.7.2
      Console.TreatControlCAsInput <- true
      Console.WriteLine("Press any combination of CTRL, ALT, and SHIFT, and a console key.")
      Console.WriteLine("Press the Escape (Esc) key to quit: \n")
      
      let mutable KeepGettingInput = true
      while KeepGettingInput do
         let cki = Console.ReadKey()
         Console.Write(" --- You pressed ")
         match cki.Modifiers with
         | ConsoleModifiers.Alt -> printfn "ALT+"
         | ConsoleModifiers.Shift -> printfn "SHIFT+" 
         | ConsoleModifiers.Control  -> printfn "CTRL+"
         | _ -> printf "not recognized modifier"//Do nothing

         if (cki.Equals(ConsoleKey.Escape)) then
            KeepGettingInput <- false //exit loop.
         let keyPressed = cki.Key.ToString()
         printfn "%s" keyPressed //Keys er tal, bogstaver, muligvis alle characters.

         if (cki.Key.ToString().Equals("H") && cki.Modifiers.Equals(ConsoleModifiers.Control)) then
            printfn "Call GetHelp()"
      //Return ConsoleKeyInfo
        


//let stuffToDoWhenKeyPressed s (e : KeyEventArgs) = 
//        match e with
//        | e when e.KeyCode = Keys.D0 -> gameButtons.[0].Text <- "0"
//        | e when e.KeyCode = Keys.D1 -> gameButtons.[0].Text <- "1" 
//        | _  -> GUI.Play.gameButtons.[0].Text <- "?" 

//gameButtons.[0].KeyDown.AddHandler(new System.Windows.Forms.KeyEventHandler (fun s e -> stuffToDoWhenKeyPressed s e ))