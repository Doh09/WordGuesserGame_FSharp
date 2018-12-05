module GetKeyboardInput
open System

let GetKeyAndModifierTest() : ConsoleKeyInfo =
//Source: https://docs.microsoft.com/en-us/dotnet/api/system.consolekeyinfo.modifiers?view=netframework-4.7.2
      Console.TreatControlCAsInput <- true
      Console.WriteLine("Press any combination of CTRL, ALT, and SHIFT, and a console key.")
      Console.WriteLine("Press the Escape (Esc) key to quit: \n")
      
      let cki = Console.ReadKey()
      printfn " --- You pressed "
      printfn "the letter is : %c" cki.KeyChar
      match cki.Modifiers with
         | ConsoleModifiers.Alt -> printfn "ALT+"
         | ConsoleModifiers.Shift -> printfn "SHIFT+" 
         | ConsoleModifiers.Control  -> printfn "CTRL+"
         | _ -> printfn "not recognized modifier"//Do nothing
      //Exit
      if (cki.Key.Equals(ConsoleKey.Escape)) then
         printfn "After ConsoleKey.Escape"
         Config.gameRunning <- false //exit Game.
      //GetHelp | S: i move this to game session
//      if (cki.Key.ToString().Equals("H") && cki.Modifiers.Equals(ConsoleModifiers.Control)) then
//            printfn "Call GetHelp()"
//            let char = GetHelp.HelpLetter("L_m__")("Lamas")
//            printfn "the letter from GetHelp is = %c" char
      cki
        


//let stuffToDoWhenKeyPressed s (e : KeyEventArgs) = 
//        match e with
//        | e when e.KeyCode = Keys.D0 -> gameButtons.[0].Text <- "0"
//        | e when e.KeyCode = Keys.D1 -> gameButtons.[0].Text <- "1" 
//        | _  -> GUI.Play.gameButtons.[0].Text <- "?" 

//gameButtons.[0].KeyDown.AddHandler(new System.Windows.Forms.KeyEventHandler (fun s e -> stuffToDoWhenKeyPressed s e ))