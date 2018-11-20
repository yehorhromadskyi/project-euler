module Problem12

open Mathematics.Attributes

let getTriangleNumber n =
    n * (n + 1) / 2

let findTriangleNumberWithOver divisors =
    let rec find nthNumber =
        if (nthNumber |> getTriangleNumber |> getFactors).Length > divisors
            then getTriangleNumber nthNumber
        else find (nthNumber + 1)
    find 1 