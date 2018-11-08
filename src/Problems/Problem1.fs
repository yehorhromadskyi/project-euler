module Problem1

let multiplesOf3And5 till = 
    seq {1..till - 1}
        |> Seq.filter (fun n -> n % 3 = 0 || n % 5 = 0)
        |> Seq.sum

//multiplesOf3And5 1000