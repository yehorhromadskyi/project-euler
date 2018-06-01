module Problem3

open Mathematics.Operations
open Mathematics.Attributes

let largestPrimeFactor (n:int64) =
    let rec find (i:int64) =
        if (n % i = 0L) && (isPrime i)
            then i
        else find (i - 1L)
    find (squareRoot n)

//largestPrimeFactor 600851475143L
