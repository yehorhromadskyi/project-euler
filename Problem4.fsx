let reverse (s:string) = System.String(s.ToCharArray() |> Array.rev)

let isPalindrome (n:int) =
    let s = string n
    let firstHalf = s.Substring(0, s.Length / 2)
    let secondHalf = s.Substring((if s.Length % 2 = 0 then s.Length else s.Length + 1) / 2)
    firstHalf = (reverse secondHalf)

let getSeq = Seq.unfold (fun state -> 
    if fst state < 100
        then None 
    elif snd state <= 100
        then Some(fst state * snd state, (fst state - 1, 999))
    else Some(fst state * snd state, (fst state, snd state - 1)))

getSeq (999, 999) |> Seq.filter(fun x -> isPalindrome x) |> Seq.max
