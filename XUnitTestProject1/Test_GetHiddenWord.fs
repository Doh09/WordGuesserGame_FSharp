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
    let mutable expectedResult1 = ""
    for c in testWord1 do 
        expectedResult1 <- expectedResult1 + Config.HIDDEN
    let mutable expectedResult2 = ""
    for c in testWord2 do 
        expectedResult2 <- expectedResult2 + Config.HIDDEN
    let mutable expectedResult3 = ""
    for c in testWord3 do 
        expectedResult3 <- expectedResult3 + Config.HIDDEN
    Assert.Equal(expectedResult1, testResult1)
    Assert.Equal(expectedResult2, testResult2)
    Assert.Equal(expectedResult3, testResult3)

[<Fact>]
let ``Words can be hidden without blanks`` () =
    let testWord1 = "Bar"
    let testWord2 = "Merciful"
    let testWord3 = "Wonderful"
    let testResult1 = GetHiddenWord.HideWord(testWord1)
    let testResult2 = GetHiddenWord.HideWord(testWord2)
    let testResult3 = GetHiddenWord.HideWord(testWord3)
    let mutable expectedResult1 = ""
    for c in testWord1 do 
        expectedResult1 <- expectedResult1 + Config.HIDDEN
    let mutable expectedResult2 = ""
    for c in testWord2 do 
        expectedResult2 <- expectedResult2 + Config.HIDDEN
    let mutable expectedResult3 = ""
    for c in testWord3 do 
        expectedResult3 <- expectedResult3 + Config.HIDDEN
    Assert.Equal(expectedResult1, testResult1)
    Assert.Equal(expectedResult2, testResult2)
    Assert.Equal(expectedResult3, testResult3)

[<Fact>]
let ``Words can be hidden with blanks - Changed HIDDEN value`` () =
    Config.HIDDEN <- "!"
    let testWord1 = "This is a cool bar"
    let testWord2 = "Merciful heavens"
    let testWord3 = "Wonderful life"
    let testResult1 = GetHiddenWord.HideWord(testWord1)
    let testResult2 = GetHiddenWord.HideWord(testWord2)
    let testResult3 = GetHiddenWord.HideWord(testWord3)
    let mutable expectedResult1 = ""
    for c in testWord1 do 
        expectedResult1 <- expectedResult1 + Config.HIDDEN
    let mutable expectedResult2 = ""
    for c in testWord2 do 
        expectedResult2 <- expectedResult2 + Config.HIDDEN
    let mutable expectedResult3 = ""
    for c in testWord3 do 
        expectedResult3 <- expectedResult3 + Config.HIDDEN
    Assert.Equal(expectedResult1, testResult1)
    Assert.Equal(expectedResult2, testResult2)
    Assert.Equal(expectedResult3, testResult3)

[<Fact>]
let ``Words can be hidden without blanks - Changed HIDDEN value`` () =
    Config.HIDDEN <- "!"
    let testWord1 = "Bar"
    let testWord2 = "Merciful"
    let testWord3 = "Wonderful"
    let testResult1 = GetHiddenWord.HideWord(testWord1)
    let testResult2 = GetHiddenWord.HideWord(testWord2)
    let testResult3 = GetHiddenWord.HideWord(testWord3)
    let mutable expectedResult1 = ""
    for c in testWord1 do 
        expectedResult1 <- expectedResult1 + Config.HIDDEN
    let mutable expectedResult2 = ""
    for c in testWord2 do 
        expectedResult2 <- expectedResult2 + Config.HIDDEN
    let mutable expectedResult3 = ""
    for c in testWord3 do 
        expectedResult3 <- expectedResult3 + Config.HIDDEN
    Assert.Equal(expectedResult1, testResult1)
    Assert.Equal(expectedResult2, testResult2)
    Assert.Equal(expectedResult3, testResult3)
