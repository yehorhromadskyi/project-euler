module Problem7

open Mathematics.Operations

let primes = 
    Seq.unfold (fun i' -> 
        let next = nextPrime i'
        Some(next, next)) 1 

let primeAt i =
    Seq.item (i-1) primes
            
    //primeAt 10001

