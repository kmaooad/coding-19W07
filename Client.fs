namespace OOAD19.Coding.W07

open FSharp.Json
open System


module Client =
 
    type Logger404 = private {
         mutable count: int
    }
    with member this.Count() = this.count
         member this.Trace (message:string) = if message="{}" then this.count <- this.count + 1
         static member Instance() = { count = 0 }
    
    let balance (customerId:int) (from:DateTime) (till:DateTime) (logger: Logger404) : decimal = failwith "not implemented"
        
