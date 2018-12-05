module Test_GetHiddenWord

open System
open Xunit
open WordGuesserGame

[<Fact>]
let ``Words can be hidden with blanks`` () =
    let testWord1 = "This is a cool bar"
    let testWord2 = "Merciful heavens"
    let testWord3 = "Wonderful life"
    let testResult1 = GetHiddenWord.HideWord(testWord1)
    let testResult2 = GetHiddenWord.HideWord(testWord2)
    let testResult3 = GetHiddenWord.HideWord(testWord3)
    Assert.Equal("******************", testResult1)
    Assert.Equal("****************", testResult2)
    Assert.Equal("**************", testResult3)

[<Fact>]
let ``Words can be hidden without blanks`` () =
    let testWord1 = "Bar"
    let testWord2 = "Merciful"
    let testWord3 = "Wonderful"
    let testResult1 = GetHiddenWord.HideWord(testWord1)
    let testResult2 = GetHiddenWord.HideWord(testWord2)
    let testResult3 = GetHiddenWord.HideWord(testWord3)
    Assert.Equal("***", testResult1)
    Assert.Equal("********", testResult2)
    Assert.Equal("*********", testResult3)

[<Fact>]
let ``My test3`` () =
    Assert.True(true)
