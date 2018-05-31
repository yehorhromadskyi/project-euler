let sqrt' = float >> sqrt >> int64

let isPrime (n:int64) = 
    let rec check i =
        if n = i
            then 1
        else 
            if n % i = 0L
                then 1 + check (i + 1L)
            else check (i + 1L)
    (check 1L) <= 2

let largestPrimeFactor (n:int64) =
    let rec find (i:int64) =
        if (n % i = 0L) && (isPrime i)
            then i
        else find (i - 1L)
    find (sqrt' n)

largestPrimeFactor 600851475143L