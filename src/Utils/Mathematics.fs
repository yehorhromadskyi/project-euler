﻿namespace Mathematics

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

    let isPalindrome (n:int) =
        let s = string n
        let firstHalf = s.Substring(0, s.Length / 2)
        let secondHalf = s.Substring((if s.Length % 2 = 0 then s.Length else s.Length + 1) / 2)
        firstHalf = System.String(secondHalf.ToCharArray() |> Array.rev)

