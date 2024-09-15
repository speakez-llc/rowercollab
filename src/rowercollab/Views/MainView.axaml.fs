namespace rowercollab.Views

open System
open Avalonia
open Avalonia.Controls
open Avalonia.Input
open Avalonia.Interactivity
open Avalonia.Markup.Xaml
open Elmish

type MainView () as this =
    inherit UserControl ()

    do this.InitializeComponent()

    member private this.InitializeComponent() =
//#if DEBUG
//        this.AttachDevTools()
//#endif
        AvaloniaXamlLoader.Load(this)