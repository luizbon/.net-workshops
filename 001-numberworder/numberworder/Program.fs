// Learn more about F# at http://fsharp.org

open System

let words = [| "ZERO"; "ONE"; "TWO"; "THREE"; "FOUR"; "FIVE"; "SIX"; "SEVEN"; "EIGHT"; "NINE" |]

let number (argv:string[]) =
    argv.[0]

let loop action input =
    for i in input do
        action i

let charToInt c =
    int c - int '0'

let word (index:int) =
    words.[index]

let print word =
    printf "%s" word

let action c =
    c |> charToInt |> word |> print

[<EntryPoint>]
let main argv =
    argv |> number |> loop action
    0 // return an integer exit code
