﻿namespace rowercollab.ViewModels

open Avalonia.Interactivity
open Material.Styles.Themes
open Material.Styles.Themes.Base
open Avalonia
open Avalonia.Threading
open ReactiveElmish
open ReactiveElmish.Avalonia
open Elmish
open rowercollab.ViewModels
open App

type MainViewModel(root: CompositionRoot) =
    inherit ReactiveElmishViewModel()
    
    let local =
        Program.mkAvaloniaSimple init update
        |> Program.withErrorHandler (fun (_, ex) -> printfn $"Error: %s{ex.Message}")
        |> Program.mkStore
        
    let switchTheme() =
        Dispatcher.UIThread.InvokeAsync(fun () ->
            let materialTheme = Application.Current.LocateMaterialTheme<MaterialTheme>()
            materialTheme.BaseTheme <-
                if materialTheme.BaseTheme = BaseThemeMode.Light then
                    BaseThemeMode.Dark
                else
                    BaseThemeMode.Light
        ) |> ignore

    member this.SelectedIndex
        with get () =
            this.Bind(app, fun m ->
                match m.View with
                | HomeView -> 0
                | ProjectView -> 1
                | SignUpView -> 2
                | AboutRowerView -> 3
                | AboutSpeakEZView -> 4
                | ContactView -> 5
            )
        and set value =
            match value with
            | 0 -> app.Dispatch (SetView HomeView)
            | 1 -> app.Dispatch (SetView ProjectView)
            | 2 -> app.Dispatch (SetView SignUpView)
            | 3 -> app.Dispatch (SetView AboutRowerView)
            | 4 -> app.Dispatch (SetView AboutSpeakEZView)
            | 5 -> app.Dispatch (SetView ContactView)
            | _ -> ()

    member this.HomeView = root.GetView<HomeViewModel>()
    member this.ProjectView = root.GetView<ProjectViewModel>()
    member this.SignUpView = root.GetView<SignUpViewModel>()
    member this.AboutRowerView = root.GetView<AboutRowerViewModel>()
    member this.AboutSpeakEZView = root.GetView<AboutSpeakEZViewModel>()
    member this.ContactView = root.GetView<ContactViewModel>()
    
    member this.SwitchTheme() = switchTheme()
    
    static member DesignVM = new MainViewModel(Design.stub)