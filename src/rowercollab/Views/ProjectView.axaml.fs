namespace rowercollab.Views

open Avalonia.Controls
open Avalonia.Markup.Xaml
open Material.Avalonia

type ProjectView () as this = 
    inherit UserControl ()

    do this.InitializeComponent()

    member private this.InitializeComponent() =
        AvaloniaXamlLoader.Load(this)

