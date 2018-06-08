// Learn more about F# at http://fsharp.org

open System
open BenchmarkDotNet.Running
open Problem7Benchmark

let defaultSwitch () = BenchmarkRunner.Run typeof<PrimesGenerator>

[<EntryPoint>]
let main argv =
    let summary = BenchmarkRunner.Run typeof<PrimesGenerator>
    Console.ReadLine()
    0 // return an integer exit code


