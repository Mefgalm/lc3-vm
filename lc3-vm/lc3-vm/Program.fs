﻿open lc3vm

[<EntryPoint>]
let main argv =
    try
        LC3VirtualMachine.Instance.ProgramCounter <- 0x3000us

        LC3VirtualMachine.load LC3VirtualMachine.Instance "C:\\Users\\Yuris Liepins\\Projects\\lc3-vm\\images\\2048.obj" |> ignore
        LC3VirtualMachine.eval LC3VirtualMachine.Instance
    with
        | ex -> printfn "%A" (ex.ToString())
    0