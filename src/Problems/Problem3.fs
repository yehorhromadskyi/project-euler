module Problem3

open Mathematics.Operations
open Mathematics.Attributes

let largestPrimeFactor (n:uint64) =
    let nSqrt = squareRoot n
    let rec find (i:uint64) =
        if (n % i = 0UL) && (isPrime i)
            then i
        else find (i - 1UL)
    find nSqrt

//largestPrimeFactor 600851475143UL
