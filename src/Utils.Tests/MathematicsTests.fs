namespace ``Mathematics tests``

open NUnit.Framework

module ``Operations tests`` =
    open Mathematics.Operations
    
    [<Test>]
    let ``Square root of 1000*1000 equals 1000``()=
        let number = 1000L
        Assert.AreEqual(number, squareRoot (number * number))


module ``Attributes tests`` =
    open Mathematics.Attributes

    [<Test>]
    let ``7 is a prime number`` ()=
        Assert.IsTrue(isPrime 7L)

    [<Test>]
    let ``8 is not a prime number`` ()=
        Assert.IsFalse(isPrime 8L)

