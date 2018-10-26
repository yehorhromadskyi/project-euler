module Problem5

    let isEvenlyDivisible number till =  
        let rec calculate i =
            if i > till
                then true
            elif number % i = 0
                then calculate (i + 1)
            else false
        calculate 2
    
    let findSmallestDivisible till =
        let rec find n = 
            if isEvenlyDivisible n till
                then n
            else find (n + 1)
        find 2
    
    //findSmallestDivisible 20

