module SelectWordForGame //Used at the start to pick a random word.
open System
open Config
open System.Linq
//Check if spaces and multi true or false.
//Then pick a word fitting those requirements.

//let getWithoutSpaces(words : List<string>) : string = words |> Seq.filter (fun x ->  (x.Contains(" "))) |> seq.fst
let getWithoutSpaces(words : List<string>) : List<string> = words |> List.filter (fun x ->  not (x.Contains(" ")))
let getWithSpaces(words : List<string>) : List<string> = words |> List.filter (fun x ->  (x.Contains(" "))) 
//let filterSpaces(words : List<string>) flst = List.except(fun (x) -> String.exists(x) " ") 

let GetWord() : string =
    let mutable wordList = WORDS
    wordList <- getWithoutSpaces(wordList)
    let word = wordList.[Random().Next(wordList.Length)]
    word