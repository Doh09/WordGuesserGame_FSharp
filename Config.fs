module Config

let HIDDEN = "*" //this will be the character printed for those characters not guessed yet.

let CASE_SENSITIVE = false //if this is false, the comparison must be non casesensitive.

let ALLOW_BLANKS = false //if this is true, then the words may contain spaces, and they should be shown.

let HELP = false //if this is true, the program will make a correct guess, when the user can type ctrl-H

let MULTIPLE = false //if this is true, the user might enter more than one character; 
//it will count as one guess. For instance; if the user enters “ab”, all substrings with “ab” will be visible.

let WORDS = [ "Word cake", "Sandwich cake", "Desert", "House" ] //at list of strings.
//It is from this collection the program must get the random words to be guessed.