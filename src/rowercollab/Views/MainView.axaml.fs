namespace rowercollab.Views

open Avalonia.Controls
open Avalonia.Markup.Xaml

type MainView () as this =
    inherit UserControl ()

    do this.InitializeComponent()

    member private this.InitializeComponent() =
//#if DEBUG
//        this.AttachDevTools()
//#endif
        AvaloniaXamlLoader.Load(this)