namespace rowercollab.ViewModels

open Avalonia
open Avalonia.Styling
open Avalonia.Media
open Avalonia.Layout
open Elmish
open ReactiveElmish
open ReactiveElmish.Avalonia
open App

type AboutSpeakEZViewModel() =
    inherit ReactiveElmishViewModel()

    member this.Greeting = "This is the Sign Up View!"
    static member DesignVM = new AboutSpeakEZViewModel()

