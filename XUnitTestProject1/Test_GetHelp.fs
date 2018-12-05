module Test_GetHelp

open System
open Xunit
open WordGuesserGame

let checkIfContains(word : string, g : char) : bool = String.exists (fun c -> c = g) word

[<Fact>]
let ``Get help for word with blanks`` () =
    let wordToGuess1 = "Big mountain"
    let wordGuessedSoFar1 = "Big ***ntain"
    let helpingLetter1 = GetHelp.HelpLetter(wordGuessedSoFar1)(wordToGuess1)
    let wordToGuess2 = "Full of bears"
    let wordGuessedSoFar1 = "**** of **ars"
    let helpingLetter2 = GetHelp.HelpLetter(wordGuessedSoFar1)(wordToGuess2)
    Assert.True(wordToGuess1.Contains(helpingLetter1))
    Assert.True(wordToGuess2.Contains(helpingLetter2))

[<Fact>]
let ``Get help for word without blanks`` () =
    let wordToGuess1 = "Mountain"
    let wordGuessedSoFar1 = "***ntain"
    let helpingLetter1 = GetHelp.HelpLetter(wordGuessedSoFar1)(wordToGuess1)
    let wordToGuess2 = "Full"
    let wordGuessedSoFar1 = "**ll"
    let helpingLetter2 = GetHelp.HelpLetter(wordGuessedSoFar1)(wordToGuess2)
    Assert.True(wordToGuess1.Contains(helpingLetter1))
    Assert.True(wordToGuess2.Contains(helpingLetter2))