module Ranges

let fibonacci = Seq.unfold (fun (a, b) -> 
    Some(a, (b, a + b))) (0., 1.)

