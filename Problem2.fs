
let fib = Seq.unfold (fun state ->
    if snd state > 4000000 then None
    else Some(fst state + snd state, (snd state, fst state + snd state))) (1,1)

let sumOfEvenFib = fib |> Seq.filter (fun n -> n % 2 = 0) |> Seq.sum