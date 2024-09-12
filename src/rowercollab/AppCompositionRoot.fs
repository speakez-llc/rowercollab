namespace rowercollab

open ReactiveElmish.Avalonia
open Microsoft.Extensions.DependencyInjection
open rowercollab.ViewModels
open rowercollab.Views

type AppCompositionRoot() =
    inherit CompositionRoot()

    let mainView = MainView()

    override this.RegisterServices services = 
        base.RegisterServices(services)                        // Auto-registers view models

    override this.RegisterViews() = 
        Map [
            VM.Key<MainViewModel>(), View.Singleton(mainView)
            VM.Key<SignUpViewModel>(), View.Singleton<SignUpView>()
            VM.Key<AboutRowerViewModel>(), View.Singleton<AboutRowerView>()
            VM.Key<AboutSpeakEZViewModel>(), View.Singleton<AboutSpeakEZView>()
        ]