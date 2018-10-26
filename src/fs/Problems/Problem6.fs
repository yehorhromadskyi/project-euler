module Problem6

    let difBetweenSum n = 
        let findSquaresSum =
            let rec find i =
                if i > n
                    then 0
                else (i * i) + find (i + 1)
            find 1
        
        let sum = [|1..n|] |> Array.sum
        sum * sum - findSquaresSum

    //difBetweenSum 100

