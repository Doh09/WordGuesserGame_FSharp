﻿module Test_CheckIfWordFullyGuessed

open System
open Xunit
open WordGuesserGame

[<Fact>]
let ``Make single character guess`` () =
    let FullWord = "Big Mountain"
    let WordGuessedSoFar = "B*g ***nta*n"
    let Guess1 = 'i' //2 'i's in "Big Mountain"
    let Guess2 = 'o' //1 'o' in "Big Mountain"
    let Guess3 = 'x' //0 'x' in "Big Mountain"
    let wordAfterNewGuess1 = CheckIfWordFullyGuessed.MakeGuess(WordGuessedSoFar)(FullWord)(Guess1)
    let wordAfterNewGuess2 = CheckIfWordFullyGuessed.MakeGuess(WordGuessedSoFar)(FullWord)(Guess2)
    let wordAfterNewGuess3 = CheckIfWordFullyGuessed.MakeGuess(WordGuessedSoFar)(FullWord)(Guess3)
    Assert.Equal("Big ***ntain", wordAfterNewGuess1)
    Assert.Equal("B*g *o*nta*n", wordAfterNewGuess2)
    Assert.Equal(WordGuessedSoFar, wordAfterNewGuess3)

[<Fact>]
let ``Make full word guess`` () =
    let FullWord1 = "Big Mountain"
    let FullWord2 = "Jeremiah"
    let FullWord3 = "Jebediah"
    let Guess1 = "Big Mountain" //Right guess
    let Guess2 = "Jebedyeah" //Wrong guess
    let Guess3 = "Jebediah" //Right guess
    let result1 = CheckIfWordFullyGuessed.MakeGuessForWholeWord (Guess1) (FullWord1)
    let result2 = CheckIfWordFullyGuessed.MakeGuessForWholeWord (Guess2) (FullWord2)
    let result3 = CheckIfWordFullyGuessed.MakeGuessForWholeWord (Guess3) (FullWord3)
    Assert.True(result1)
    Assert.False(result2)
    Assert.True(result3)