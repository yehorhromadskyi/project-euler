// Learn more about F# at http://fsharp.org

open System
open Problem12

[<EntryPoint>]
let main argv =
    printfn "Calculating triangle number with over 100 divisors"
    
    let triangleNumber = findTriangleNumberWithOver 100
    printfn "The number is %i" triangleNumber

    Console.ReadLine()
    
    0 // return an integer exit code
