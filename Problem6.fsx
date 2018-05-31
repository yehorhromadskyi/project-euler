let findSquaresSum n =
    let rec find i =
        if i > n
            then 0
        else (i * i) + find (i + 1)
    find 1

let findSum n = [|1..n|] |> Array.sum

let number = 100

let result = (findSum number) * (findSum number) - findSquaresSum number
