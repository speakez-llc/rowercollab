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
    | NavigationItemSelected of int
    | GoHome

let init () =
    {
        View = HomeView
    }

let logModel (model: Model) =
    printfn "Current Model: %A" model

let update (msg: Msg) (model: Model) =
    match msg with
    | SetView view -> 
        let newModel = { View = view }
        printfn $"View changed to: %A{view}"
        logModel newModel
        newModel
    | NavigationItemSelected index ->
        printfn $"Menu item selected: %d{index}"
        match index with
        | 0 -> { model with View = HomeView }
        | 1 -> { model with View = ProjectView }
        | 2 -> { model with View = SignUpView }
        | 3 -> { model with View = AboutRowerView }
        | 4 -> { model with View = AboutSpeakEZView }
        | 5 -> { model with View = ContactView }
        | _ -> model
    | GoHome -> 
        let newModel = { View = HomeView }
        printfn "Navigating to HomeView"
        logModel newModel
        newModel

let app = 
    Program.mkAvaloniaSimple init update
    |> Program.withErrorHandler (fun (_, ex) -> printfn $"Error: {ex.Message}")
    |> Program.withConsoleTrace
    |> Program.mkStore