module Problem3

open Mathematics.Operations
open Mathematics.Attributes

let largestPrimeFactor (n:uint64) =
    let nSqrt = squareRoot n |> int
    let rec find (i:int) =
        if (n % (uint64 i) = 0UL) && (isPrime i)
            then i
        else find (i - 1)
    find nSqrt

//largestPrimeFactor 600851475143UL
