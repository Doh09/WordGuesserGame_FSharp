module GetHiddenWord

//Get the hidden word to display based on which characters have and haven't been guessed. cw (gu*ss*d.)

let PrintWord typed input : string =
    printfn(typed);
    printfn(input);
    "that was a word"

let cylinderVolume radius length : float =
   // Define a local value pi.
   printfn ""
   let pi = 3.14159
   length * pi * radius * radius