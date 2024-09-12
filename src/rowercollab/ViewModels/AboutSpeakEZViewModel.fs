namespace rowercollab.ViewModels

open Avalonia
open Avalonia.Styling
open Avalonia.Media
open Avalonia.Layout
open Elmish
open ReactiveElmish
open ReactiveElmish.Avalonia


type AboutSpeakEZViewModel() =
    inherit ReactiveElmishViewModel()

    member this.Greeting = "This is the About SpeakEZ View!"
    static member DesignVM = new AboutSpeakEZViewModel()

