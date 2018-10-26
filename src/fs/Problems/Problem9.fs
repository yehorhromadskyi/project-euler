module Problem9

let isPythagoreanTriplet a b c = (a*a + b*b = c*c) && (a < b) && (b < c)

let isInt (n:float) = n % 1. = 0.

let findTriplet withSum =
    let rec findRec a b =
        match a, b, (sqrt (float (a*a + b*b))) with
        | a', _, _  when a' > 1000 -> [||]
        | _, b', _  when b' > 1000 -> findRec (a+1) (a+2)
        | _, _, c  when isInt c -> Array.append [|(a, b, (int c))|] (findRec a (b+1))
        | _ -> findRec a (b+1)
    let triplets = findRec 1 2
    triplets |> Array.find (fun (a, b, c) -> a + b + c = withSum)