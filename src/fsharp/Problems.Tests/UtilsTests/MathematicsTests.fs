namespace ``Mathematics tests``

open Xunit
open Mathematics.Attributes
open Mathematics.Operations

module ``Operations tests`` =
    
    [<Fact>]
    let ``Square root of 635*635 equals 635`` () =
        Assert.Equal(635UL, squareRoot (635UL * 635UL))

    [<Fact>]
    let ``Product of numbers in array`` () =
        let expected = 6 * 7 * 88 * 99
        let numbers = [|6; 7; 88; 99|]
        Assert.Equal(expected, product numbers)


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

