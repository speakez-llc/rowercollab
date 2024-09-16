module rowercollab.ViewModels.App

open Elmish
open ReactiveUI
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


let update (msg: Msg) (model: Model) =
    match msg with
    | SetView view -> { model with View = view }
    | NavigationItemSelected index ->
        match index with
        | 0 -> { model with View = HomeView }
        | 1 -> { model with View = ProjectView }
        | 2 -> { model with View = SignUpView }
        | 3 -> { model with View = AboutRowerView }
        | 4 -> { model with View = AboutSpeakEZView }
        | 5 -> { model with View = ContactView }
        | _ -> model
    | GoHome -> { model with View = HomeView }
    

let app = 
    Program.mkAvaloniaSimple init update
    |> Program.withErrorHandler (fun (_, ex) -> printfn $"Error: {ex.Message}")
    //|> Program.withConsoleTrace
    |> Program.mkStore

