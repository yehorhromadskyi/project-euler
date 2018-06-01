module Problem2

open Ranges

let sumOfEvenNumbers till = 
    fibonacci
    |> Seq.takeWhile (fun i -> i < till)
    |> Seq.filter (fun n -> n % 2. = 0.) 
    |> Seq.sum

//sumOfEvenNumbers (4. * 1000. * 1000.)
