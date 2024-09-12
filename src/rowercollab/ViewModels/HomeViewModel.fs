namespace rowercollab.ViewModels

open Avalonia
open Avalonia.Styling
open Avalonia.Media
open Avalonia.Layout
open Elmish
open ReactiveElmish
open ReactiveElmish.Avalonia

type HomeViewModel() =
    inherit ReactiveElmishViewModel()

    member this.Greeting = "Welcome to The Home View!"
