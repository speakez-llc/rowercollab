namespace rowercollab.Views

open Avalonia.Controls
open Avalonia.Markup.Xaml
open Material.Icons.Avalonia

type SignUpView () as this =
    inherit UserControl ()

    do
        this.InitializeComponent()
        this.Opacity <- 0.0
        this.Loaded.Add(fun _ -> this.Opacity <- 1.0)

    member private this.InitializeComponent() =
        AvaloniaXamlLoader.Load(this)