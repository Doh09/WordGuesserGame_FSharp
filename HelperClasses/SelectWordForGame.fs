module SelectWordForGame //Used at the start to pick a random word.
open System
open Config

//Check if spaces and multi true or false.
//Then pick a word fitting those requirements.

//let filterSpaces(words : List<string>) flst = List.except(fun (x) -> String.exists(x) " ")
//let getSpaces(words : List<string>) flst = List.filter(fun (x) -> String.exists(x) " ")

let GetWord() : string =
    let word = Config.WORDS.[Random().Next(WORDS.Length)]
    word