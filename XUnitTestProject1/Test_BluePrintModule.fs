module Test_BluePrintModule

open System
open Xunit
open WordGuesserGame

//This class is used as blueprint for our test classes.
[<Fact>]
let ``Blueprint test method`` () =
    //Blueprint test method. If this doesn't run as intended then something is wrong with the unit test setup.
    Assert.True(true)
