let isEvenlyDivisible n =  
    let rec calculate i =
        if i > 20
            then true
        elif n % i = 0
            then calculate (i + 1)
        else false
    calculate 2

let findSmallestDivisible =
    let rec find n = 
        if isEvenlyDivisible n
            then n
        else find (n + 1)
    find 2

findSmallestDivisible