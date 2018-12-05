module Test_SelectWordForGame

open System
open Xunit
open WordGuesserGame

[<Fact>]
let ``Select word without blanks`` () =
    Config.ALLOW_BLANKS <- false
    let selectedWord = SelectWordForGame.GetWord()
    Assert.False(selectedWord.Contains(" "))

[<Fact>]
let ``Select word with blanks`` () =
    Config.ALLOW_BLANKS <- true
    let selectedWord = SelectWordForGame.GetWord()
    Assert.True(selectedWord.Contains(" "))
