namespace ``Problems tests``

open NUnit.Framework

module ``Problem 1 tests`` =
    open Problem1
    
    [<Test>]
    let ``Sum of all the multiples of 3 or 5 below 10 equals 23`` ()=
        Assert.AreEqual(23, multiplesOf3And5 10)


module ``Problem 3 tests`` =
    open Problem3
    
    [<Test>]
    let ``The largest prime factor of 13195 is 29`` ()=
        Assert.AreEqual(29, largestPrimeFactor 13195L)

