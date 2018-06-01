module Problem2

open Ranges

let sumOfEvenNumbers = 
    fibonacci
    |> Seq.takeWhile (fun i -> i < 4. * 1000. * 1000.)
    |> Seq.filter (fun n -> n % 2. = 0.) 
    |> Seq.sum
