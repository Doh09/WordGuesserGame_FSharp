module Config

let mutable HIDDEN = "*" //this will be the character printed for those characters not guessed yet.

let mutable CASE_SENSITIVE = false //if this is false, the comparison must be non casesensitive.

let mutable ALLOW_BLANKS = false //if this is true, then the words may contain spaces, and they should be shown.

let mutable HELP = false //if this is true, the program will make a correct guess, when the user can type ctrl-H

let mutable MULTIPLE = false //if this is true, the user might enter more than one character; 
//it will count as one guess. For instance; if the user enters “ab”, all substrings with “ab” will be visible.

let mutable WORDS = ["Word cake"; "Sandwich cake"; "Desert"; "House" ] //at list of strings.
//It is from this collection the program must get the random words to be guessed.

let mutable programRunning = true; //Make bool for keeping Program loop running.
    //so the play returns to the menu after each game

let mutable gameRunning = false; //Make bool for keeping Game loop running.
    //so the player can keep playing until he wants to stop or he wins

let ResetToDefaultConfigs() =
    HIDDEN <- "*"
    CASE_SENSITIVE <- false
    ALLOW_BLANKS <- false
    HELP <- false
    MULTIPLE <- false
   
let ResetWordList() =
    WORDS <- ["Word cake"; "Sandwich cake"; "Desert"; "House" ]