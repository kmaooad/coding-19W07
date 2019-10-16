namespace OOAD19.Coding.W07

open System
open Xunit
open FSharp.Json
open Client
open FsUnit.Xunit
open FsCheck.Xunit
open FsCheck


module Spec =
    [<Fact>]
    let ``Can calculate zero balance``() =
        let b = balance 960 (DateTime(2019,10,1)) (DateTime(2019,10,31)) (Logger404.Instance())
        b |> should equal 0m

    [<Fact>]
    let ``Can calculate non-zero balance``() = 
        let b = balance 920 (DateTime(2019,10,1)) (DateTime(2019,10,31)) (Logger404.Instance())
        b |> should lessThan 0m

    [<Property>]
    let ``Balance calculation is transitive``() = 
        Gen.elements [920;930;940;950;960] 
        |> Arb.fromGen
        |> Prop.forAll <| fun x ->
            let b1 = balance x (DateTime(2019,10,1)) (DateTime(2019,10,10)) (Logger404.Instance())
            let b2 = balance x (DateTime(2019,10,11)) (DateTime(2019,10,20)) (Logger404.Instance())
            let b3 = balance x (DateTime(2019,10,21)) (DateTime(2019,10,31)) (Logger404.Instance())
            let b = balance x (DateTime(2019,10,1)) (DateTime(2019,10,31)) (Logger404.Instance())
            b |> should equal (b1 + b2 + b3)
            
    