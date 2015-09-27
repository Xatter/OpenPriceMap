namespace OpenPriceMap
  open Microsoft.Owin
  open Owin

  type Startup() =
    member x.Configuration (app:IAppBuilder) =
      app.UseWelcomePage() |> ignore

  [<assembly:OwinStartup(typeof<Startup>)>]
  do ()
