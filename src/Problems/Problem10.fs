module Problem10

open Ranges

let sumOfPrimes till = primes 
                    |> Seq.takeWhile(fun n -> n < till)
                    |> Seq.fold (fun sum element -> sum + (int64 element)) 0L
