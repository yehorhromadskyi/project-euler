namespace ``Ranges tests``

open Xunit
open FsCheck
open FsCheck.Xunit

module ``Fibonacci`` =
    open Ranges

    [<Property>]
    let ``8-th item equals sum of 7th and 6th`` (i:int32) =
        let n_th = Seq.item (i+2) fibonacci
        let n_thMinus1 = Seq.item (i+1) fibonacci
        let n_thMinus2 = Seq.item i fibonacci
        Assert.Equal(n_th, n_thMinus1 + n_thMinus2)

