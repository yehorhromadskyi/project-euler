namespace ``Problems tests``

open FsCheck.Xunit
open Xunit
open Mathematics.Attributes

module ``Problem 1 tests`` =
    open Problem1
    
    [<Fact>]
    let ``Sum of all the multiples of 3 or 5 below 10`` () =
        Assert.Equal(23, multiplesOf3And5 10)

module ``Problem 3 tests`` =
    open Problem3
    
    [<Fact>]
    let ``The largest prime factor of 13195`` () =
        Assert.Equal(29, largestPrimeFactor 13195UL)

module ``Problem 4 tests`` =
    open Problem4
    
    [<Fact>]
    let ``The largest palindrome made from the product of two 2-digit numbers`` () =
        Assert.Equal(9009, largestPalindromeBetween 9 99)

module ``Problem 5 tests`` =
    open Problem5
    
    [<Fact>]
    let ``Smallest number that can be divided by each of the numbers from 1 to 10`` () =
        Assert.Equal(2520, findSmallestDivisible 10)

module ``Problem 6 tests`` =
    open Problem6
    
    [<Fact>]
    let ``Sum square difference`` () =
        Assert.Equal(2640, difBetweenSum 10)

module ``Problem 7 tests`` =
    open Problem7

    [<Fact>]
    let ``6-th prime number`` () =
        let actual = primeAt 6
        Assert.Equal(13, actual)

module ``Problem 8 tests`` =
    open Problem8

    [<Fact>]
    let ``Largest product in a series of 4 digits`` () =
        let actual = greatestMultiplication 4
        Assert.Equal(5832., actual)

module ``Problem 9 tests`` =
    open Problem9

    [<Fact>]
    let ``Triplet with arguments (3, 4, 5)`` () =
        let actual = findTriplet (3 + 4 + 5)
        Assert.Equal((3, 4, 5), actual)

module ``Problem 10 tests`` =
    open Problem10

    [<Fact>]
    let ``Sum of primes below 10`` () =
        let actual = sumOfPrimes 10
        Assert.Equal(17L, actual)

