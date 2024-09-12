namespace rowercollab

open Avalonia.Controls
open ReactiveElmish.Avalonia
open rowercollab.ViewModels
open rowercollab.Views
open Microsoft.Extensions.DependencyInjection

type AppCompositionRoot(?mainWindow: MainWindow) =
    inherit CompositionRoot()


    override this.RegisterServices services =
        base.RegisterServices services
        


    override this.RegisterViews() = 
        Map [
            VM.Key<MainViewModel>(), View.Singleton<MainView>()
            VM.Key<HomeViewModel>(), View.Singleton<HomeView>()
            VM.Key<SignUpViewModel>(), View.Singleton<SignUpView>()
            VM.Key<AboutRowerViewModel>(), View.Singleton<AboutRowerView>()
            VM.Key<AboutSpeakEZViewModel>(), View.Singleton<AboutSpeakEZView>()
        ]