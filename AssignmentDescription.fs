module AssignmentDescription

//Link til .PDF med opgavebeskrivelsen
//https://moodle.easv.dk/pluginfile.php/39427/mod_resource/content/1/Word%20Guesser%20Game.pdf
//The point of this exercise is to complete a F# program for the word guesser game.
//The concrete outcome should be a working F# console program fulfilling the
//requirements.
//When started, the program picks a random word from a list of words. The point of the
//game is to guess the word, by entering a single character where after the program
//shows the secret word using a ‘*’ for the characters that is not guessed yet. To
//illustrate the exact behavior of the game, an example of a dialog is shown below (user
//input is underlined):

//It is important you divide your program into modules that can be described individual.
//Your program must contain a configuration module defining the actual value for the
//following parameters:
//• HIDDEN = ‘*’ – this will be the character printed for those characters not
//guessed yet.
//• CASE_SENSITIVE = false – if this is false, the comparison must be non casesensitive.
//• ALLOW_BLANKS = false – if this is true, then the words may contain spaces, and
//they should be shown.
//• HELP = false – if this is true, the program will make a correct guess, when the
//user can type Crtl-H
//• MULTIPLE = false – if this is true, the user might enter more than one character;
//it will count as one guess. For instance; if the user enters “ab”, all substrings
//with “ab” will be visible.
//• WORDS – at list of strings. It is from this collection the program must get the
//random words to be guessed.