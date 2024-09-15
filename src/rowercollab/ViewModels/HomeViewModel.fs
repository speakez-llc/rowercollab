namespace rowercollab.ViewModels

open ReactiveElmish

type HomeViewModel() =
    inherit ReactiveElmishViewModel()

    member this.Greeting = "Welcome to The Home View!"
    
    static member DesignVM = new HomeViewModel()