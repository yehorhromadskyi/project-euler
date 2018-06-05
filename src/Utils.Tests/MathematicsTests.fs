namespace ``Mathematics tests``

open Xunit
open FsCheck.Xunit

module ``Operations tests`` =
    open Mathematics.Operations
    
    [<Property>]
    let ``Square root of n*n equals n`` (n:uint64) =
        n = squareRoot (n * n)


module ``Attributes tests`` =
    open Mathematics.Attributes

    [<Fact>]
    let ``Number 12 has 6 factors`` ()=
        Assert.Equal(6, 12UL |> getFactors |> Array.length)

    [<Fact>]
    let ``7 is a prime number`` ()=
        Assert.True(isPrime 7UL)

    [<Fact>]
    let ``8 is not a prime number`` ()=
        Assert.False(isPrime 8UL)

