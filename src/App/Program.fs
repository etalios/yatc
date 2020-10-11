// Learn more about F# at http://fsharp.org

open System
open Library

[<EntryPoint>]
let main argv =
    printf "%s" (Say.hello "F#")
    0 // return an integer exit code
