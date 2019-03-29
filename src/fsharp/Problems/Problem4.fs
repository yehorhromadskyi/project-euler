module Problem4

    open Mathematics.Attributes

    let largestPalindromeBetween lowest highest = 
        Seq.unfold (fun state -> 
            if fst state = lowest
                then None 
            elif snd state = lowest
                then Some(fst state * snd state, (fst state - 1, highest))
            else Some(fst state * snd state, (fst state, snd state - 1))) (highest, highest)
        |> Seq.filter(isPalindrome)
        |> Seq.max

    //largestPalindromeBetween 99 999
