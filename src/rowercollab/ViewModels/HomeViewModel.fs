﻿namespace rowercollab.ViewModels


open ReactiveElmish
open ReactiveElmish.Avalonia
open App

type HomeViewModel() =
    inherit ReactiveElmishViewModel()

    member this.Greeting = "Welcome to The Home View!"
    
    static member DesignVM = new HomeViewModel()