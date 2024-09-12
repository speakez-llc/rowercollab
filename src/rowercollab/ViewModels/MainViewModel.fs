namespace rowercollab.ViewModels

open Avalonia
open Avalonia.Styling
open Avalonia.Media
open Avalonia.Layout
open Elmish
open ReactiveElmish
open ReactiveElmish.Avalonia

type MainViewModel() =
    inherit ReactiveElmishViewModel()

    member this.Greeting = "Welcome to The Main View!"
