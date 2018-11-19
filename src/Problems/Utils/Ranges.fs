module Ranges

open Mathematics.Operations

let fibonacci = Seq.unfold (fun (a, b) -> 
    Some(a, (b, a + b))) (0., 1.)

let primes = Seq.unfold (fun i' -> 
    let next = nextPrime i'
    Some(next, next)) 1

