module client

open System
open System.Net

let IP =
    Console.ForegroundColor <- ConsoleColor.Gray
    printfn "Getting hostname....."
    let localHost = Dns.GetHostName()
    Console.WriteLine localHost

    printfn "Searching for local IP:"
    Console.ForegroundColor <- ConsoleColor.DarkCyan
    let ip = Dns.GetHostEntry(localHost).AddressList
             |> Array.find (fun x -> x.AddressFamily.ToString() = "InterNetwork")
             |> printfn "Local IP: %A"
    0

Console.ForegroundColor <- ConsoleColor.Gray
Console.ReadKey(true) |> ignore