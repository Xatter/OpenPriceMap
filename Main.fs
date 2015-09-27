open Microsoft.Owin.Hosting
open System
open System.Collections.Generic
open OpenPriceMap

[<EntryPoint>]
let main argv =
  printfn "%A" argv
  let baseUrl = "http://localhost:3000"
  use app = WebApp.Start<Startup>(baseUrl)
  printfn "Server started localhost:3000"
  printfn "Press any key to quit"
  Console.ReadKey() |> ignore
  0
