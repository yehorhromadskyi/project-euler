namespace ``Problems tests``

open Xunit

module ``Problem 1 tests`` =
    open Problem1
    
    [<Fact>]
    let ``Sum of all the multiples of 3 or 5 below 10`` () =
        Assert.Equal(23, multiplesOf3And5 10)


module ``Problem 3 tests`` =
    open Problem3
    
    [<Fact>]
    let ``The largest prime factor of 13195`` () =
        Assert.Equal(29UL, largestPrimeFactor 13195UL)

module ``Problem 4 tests`` =
    open Problem4
    
    [<Fact>]
    let ``The largest palindrome made from the product of two 2-digit numbers`` ()=
        Assert.Equal(9009, largestPalindromeBetween 9 99)

