namespace ``Ranges tests``

open Arbitraries
open Xunit
open FsCheck
open FsCheck.Xunit
open Mathematics.Attributes

module ``Fibonacci`` =
    open Ranges

    [<Property>]
    let ``n-th item equals to sum of n-1 and n-2`` () =
        let values = Gen.elements [3..1000] |> Arb.fromGen
        Prop.forAll values (fun n ->
            let n_th = Seq.item n fibonacci
            let n_thMinus1 = Seq.item (n - 1) fibonacci
            let n_thMinus2 = Seq.item (n - 2) fibonacci
            Assert.Equal(n_th, n_thMinus1 + n_thMinus2)
        )
