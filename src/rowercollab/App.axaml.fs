namespace rowercollab

open Avalonia
open Avalonia.Controls.ApplicationLifetimes
open Avalonia.Markup.Xaml
open rowercollab.Views
open rowercollab.ViewModels

type App() =
    inherit Application()

    override this.Initialize() =
        // Initialize Avalonia controls from NuGet packages:
        let _ = typeof<Avalonia.Controls.DataGrid>
        AvaloniaXamlLoader.Load(this)

    override this.OnFrameworkInitializationCompleted() =
        match this.ApplicationLifetime with
        | :? IClassicDesktopStyleApplicationLifetime as desktop ->
            let mainWindow = MainWindow()
            let appRoot = AppCompositionRoot()
            mainWindow.Content <- appRoot.GetView<MainViewModel>()
            desktop.MainWindow <- mainWindow
        | :? ISingleViewApplicationLifetime as singleViewLifetime ->
            printfn "OnFrameworkInitializationCompleted - ISingleViewApplicationLifetime"
            try
                let appRoot = AppCompositionRoot()
                singleViewLifetime.MainView <- appRoot.GetView<MainViewModel>()
            with x ->
                printfn $"Exception: {x.Message} \n {x.StackTrace}"
        | _ -> ()

        base.OnFrameworkInitializationCompleted()