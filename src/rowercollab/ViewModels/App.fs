module rowercollab.ViewModels.App

open Elmish
open ReactiveElmish.Avalonia
open Avalonia.Data.Converters

type Model =  
    { 
        View: View
        IsHomeViewActive: bool
    }

and View = 
    | SignUpView
    | AboutRower
    | AboutSpeakEZ
    | HomeView

type Msg = 
    | SetView of View
    | GoHome
    | SetMainViewActive of bool

let init () = 
    { 
        View = HomeView
        IsHomeViewActive = true 
    }

let update (msg: Msg) (model: Model) =
    match msg with
    | SetView view -> 
        let isHomeViewActive = (view = HomeView)
        { model with View = view; IsHomeViewActive = isHomeViewActive }
    | GoHome -> { model with View = HomeView; IsHomeViewActive = true }
    | SetMainViewActive isActive -> { model with IsHomeViewActive = isActive }


let app = 
    Program.mkAvaloniaSimple init update
    |> Program.withErrorHandler (fun (_, ex) -> printfn $"Error: {ex.Message}")
    //|> Program.withConsoleTrace
    |> Program.mkStore
