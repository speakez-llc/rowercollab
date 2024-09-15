namespace rowercollab

open Avalonia
open Avalonia.Controls
open Avalonia.Controls.ApplicationLifetimes
open Avalonia.Markup.Xaml
open rowercollab.Views
open rowercollab.ViewModels

type App() =
    inherit Application()

    override this.Initialize() =
        // Initialize Avalonia controls from NuGet packages:
        printfn "Initializing Avalonia"
        let _ = typeof<Avalonia.Controls.DataGrid>
        printfn "loading Avalonia"

        AvaloniaXamlLoader.Load(this)
        printfn "loaded - end of initialize"

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
                printfn "get appRoot"
                let appRoot = AppCompositionRoot()
                printfn "set mainview"
                singleViewLifetime.MainView <- appRoot.GetView<ViewModels.MainViewModel>()
                printfn "call base"
            with x ->
                printfn $"Exception: {x.Message} \n {x.StackTrace}"
        | _ -> ()

        base.OnFrameworkInitializationCompleted()