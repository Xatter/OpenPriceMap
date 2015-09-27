open Microsoft.Owin.Hosting
open System
open System.Collections.Generic
open OpenPriceMap

[<EntryPoint>]
let main argv =
  printfn "%A" argv
  let baseUrl = "http://localhost:999"
  use app = WebApp.Start<Startup>(baseUrl)
  Console.WriteLine("Press any key to quit")
  Console.ReadKey() |> ignore
  0
