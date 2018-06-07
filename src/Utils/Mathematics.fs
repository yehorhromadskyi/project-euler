namespace Mathematics

module Operations =

    let squareRoot (n:uint64) = n |> float |> sqrt |> uint64

    let rec nextPrime n =
        let nNext = n+1
        match nNext with
        | 1 -> 1
        | 2 -> 2
        | 3 -> 3
        | 5 -> 5
        | n' when n'%2 <> 0 
               && n'%3 <> 0 
               && n'%5 <> 0
               && n'%7 <> 0 -> n'
        | n' -> nextPrime n'


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

