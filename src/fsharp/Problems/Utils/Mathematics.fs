namespace Mathematics

module Attributes =

    let countFactors n = 
        let root = n |> float |> sqrt |> int
        let rec check i =
            if i = root
                then 0
            else 
                if n % i = 0
                    then 2 + (check (i + 1))
                else check (i + 1)
        check 1

    let getFactors n = 
        let half = n / 2 |> int
        let rec check i =
            if i > half
                then [|n|]
            else 
                if n % i = 0
                    then Array.append [|i|] (check (i + 1))
                else check (i + 1)
        check 1

    let isPrime (n:int) =
        let n' = n |> float |> sqrt |> int
        let rec check i =
            if n' < i
                then 1
            else 
                if n % i = 0
                    then 1 + check (i + 1)
                else check (i + 1)
        (check 1) <= 2

    let isPalindrome (n:int) =
        let s = string n
        let firstHalf = s.Substring(0, s.Length / 2)
        let secondHalf = s.Substring((if s.Length % 2 = 0 then s.Length else s.Length + 1) / 2)
        firstHalf = System.String(secondHalf.ToCharArray() |> Array.rev)

module Operations =

    let squareRoot (n:uint64) = n |> float |> sqrt |> uint64

    let rec nextPrime n =
        let nNext = n+1
        if Attributes.isPrime nNext
            then nNext
        else nextPrime nNext

    let product (numbers:int[]) =
        match numbers with
        | [||] -> 0
        | _ -> numbers |> Array.fold (fun multiplication element -> (multiplication * element)) 1