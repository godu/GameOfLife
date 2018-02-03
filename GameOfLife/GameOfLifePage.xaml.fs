namespace GameOfLife

open Xamarin.Forms
open Xamarin.Forms.Xaml

type GameOfLifePage() =
    inherit ContentPage()
    let _ = base.LoadFromXaml(typeof<GameOfLifePage>)
