namespace Mathematics

module Operations =

    let squareRoot (n:uint64) = n |> float |> sqrt |> uint64


module Attributes =

    let getFactors (n:uint64) = 
        let rec check i =
            if n = i
                then [|n|]
            else 
                if n % i = 0UL
                    then Array.append [|i|] (check (i + 1UL))
                else check (i + 1UL)
        check 1UL

    let isPrime (n:uint64) = 
        getFactors n |> Array.length = 2

