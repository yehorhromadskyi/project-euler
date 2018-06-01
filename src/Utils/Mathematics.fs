namespace Mathematics

module Operations =

    let squareRoot (n:int64) = n |> float |> sqrt |> int64


module Attributes =

    let isPrime (n:int64) = 
        let rec check i =
            if n = i
                then 1
            else 
                if n % i = 0L
                    then 1 + check (i + 1L)
                else check (i + 1L)
        (check 1L) <= 2

