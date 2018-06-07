namespace ``Mathematics tests``

open Arbitraries
open Xunit
open FsCheck
open FsCheck.Xunit
open Mathematics.Attributes
open Mathematics.Operations

module ``Operations tests`` =
    
    [<Property>]
    let ``Square root of n*n equals n`` (n:uint64) =
        n = squareRoot (n * n)

    [<Property(Arbitrary = [|typeof<PositiveIntArbitrary>|])>]
    let ``Next prime number is really prime`` (n:int32) =
        let next = nextPrime n
        isPrime next && next > n


module ``Attributes tests`` =

    [<Fact>]
    let ``Number 12 has 6 factors`` () =
        Assert.Equal(6, 12 |> getFactors |> Array.length)

    [<Fact>]
    let ``7 is a prime number`` () =
        Assert.True(isPrime 7)

    [<Fact>]
    let ``8 is not a prime number`` () =
        Assert.False(isPrime 8)

    [<Fact>]
    let ``9009 is a palindrome`` () =
        Assert.True(isPalindrome 9009)

    [<Fact>]
    let ``90091 is not a palindrome`` () =
        Assert.False(isPalindrome 90091)

