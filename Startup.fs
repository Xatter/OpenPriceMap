namespace OpenPriceMap
  open Owin
  open Microsoft.Owin
  open System.Web.Http

  type Config = {
    id : RouteParameter
  }

  type Startup() =
    member x.Configuration (app:IAppBuilder) =
      let config =
        let config = new HttpConfiguration()
        config.Routes.MapHttpRoute("DefaultApi", "api/{controller}/{id}", { id = RouteParameter.Optional }) |> ignore
        config

      app.UseWebApi config |> ignore

  [<assembly:OwinStartup(typeof<Startup>)>]
  do ()
