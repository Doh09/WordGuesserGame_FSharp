module Config

let mutable HIDDEN = "*" //this will be the character printed for those characters not guessed yet.

let mutable CASE_SENSITIVE = false //if this is false, the comparison must be non casesensitive.

let mutable ALLOW_BLANKS = false //if this is true, then the words may contain spaces, and they should be shown.

let mutable HELP = false //if this is true, the program will make a correct guess, when the user can type ctrl-H

let mutable MULTIPLE = false //if this is true, the user might enter more than one character; 
//it will count as one guess. For instance; if the user enters “ab”, all substrings with “ab” will be visible.

let mutable WORDS = ["Juletræsfod";"Advent";"Julekalender";"Kanel";"Julemandsskæg";"Juleaften";"Julemand"; "Nisse Hue" ;"Tændstikker" ;"Jule Kager" ;"Juletræ" ; "Desert"; "Nøddeknækker"; "Pebernødder" ;"Kræmmerhus" ; "JuleBryg" ; "Kagedåse" ] //at list of strings.
//It is from this collection the program must get the random words to be guessed.

let ResetToDefaultConfigs() =
    HIDDEN <- "*"
    CASE_SENSITIVE <- false
    ALLOW_BLANKS <- false
    HELP <- false
    MULTIPLE <- false
   
let ResetWordList() =
    WORDS <- ["Word cake"; "Sandwich cake"; "Desert"; "House" ]