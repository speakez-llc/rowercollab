module rowercollab.ViewModels.App

open Elmish
open ReactiveElmish.Avalonia

type Model =
    {
        View: View
    }

and View =
    | HomeView
    | ProjectView
    | SignUpView
    | AboutRowerView
    | AboutSpeakEZView
    | ContactView

type Msg =
    | SetView of View
    | GoHome
    | SetMainViewActive of bool

let init () =
    {
        View = HomeView
    }

let logModel (model: Model) =
    printfn "Current Model: %A" model

let update (msg: Msg) (model: Model) =
    match msg with
    | SetView view -> { View = view }
    | GoHome -> { View = HomeView }


let app = 
    Program.mkAvaloniaSimple init update
    |> Program.withErrorHandler (fun (_, ex) -> printfn $"Error: {ex.Message}")
    |> Program.withConsoleTrace
    |> Program.mkStore