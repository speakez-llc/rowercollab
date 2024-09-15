namespace rowercollab.Views

open Avalonia.Controls
open Avalonia.Markup.Xaml
open Material.Avalonia

type ContactView () as this = 
    inherit UserControl ()

    do this.InitializeComponent()

    member private this.InitializeComponent() =
        AvaloniaXamlLoader.Load(this)

