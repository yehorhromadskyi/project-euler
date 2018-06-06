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


module ``Problem 5 tests`` =
    open Problem5
    
    [<Fact>]
    let ``Smallest number that can be divided by each of the numbers from 1 to 10`` ()=
        Assert.Equal(2520, findSmallestDivisible 10)

module ``Problem 6 tests`` =
    open Problem6
    
    [<Fact>]
    let ``Sum square difference`` ()=
        Assert.Equal(2640, difBetweenSum 10)

