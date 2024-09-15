namespace rowercollab

open Avalonia.Controls
open ReactiveElmish.Avalonia
open rowercollab.ViewModels
open rowercollab.Views

type AppCompositionRoot(?mainWindow: MainWindow) =
    inherit CompositionRoot()
    
    override this.RegisterServices services =
        base.RegisterServices services 
    

    override this.RegisterViews() =
        Map [
            VM.Key<MainViewModel>(), View.Singleton<MainView>()
            VM.Key<HomeViewModel>(), View.Transient<HomeView>()
            VM.Key<ProjectViewModel>(), View.Transient<ProjectView>()
            VM.Key<SignUpViewModel>(), View.Transient<SignUpView>()
            VM.Key<AboutRowerViewModel>(), View.Transient<AboutRowerView>()
            VM.Key<AboutSpeakEZViewModel>(), View.Transient<AboutSpeakEZView>()
            VM.Key<ContactViewModel>(), View.Transient<ContactView>()
        ]