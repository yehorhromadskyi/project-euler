namespace ``Ranges tests``

open NUnit.Framework

module ``Fibonacci`` =
    open Ranges

    [<Test>]
    let ``8-th item equals sum of 7th and 6th`` ()=
        let n_th = Seq.item 8 fibonacci
        let n_thMinus1 = Seq.item 7 fibonacci
        let n_thMinus2 = Seq.item 6 fibonacci
        Assert.AreEqual(n_th, n_thMinus1 + n_thMinus2)

