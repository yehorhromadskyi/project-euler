let multiplesOf3And5 = 
    seq {1..999}
        |> Seq.filter (fun n -> n % 3 = 0 || n % 5 = 0)
        |> Seq.sum