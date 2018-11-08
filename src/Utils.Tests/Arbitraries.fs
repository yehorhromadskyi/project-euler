module Arbitraries

open FsCheck

    type PositiveIntArbitrary =
        static member Get() = //Arb.from<PositiveInt>
            Arb.Default.Int32().Filter(fun n -> n > 0)
        

