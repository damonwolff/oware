﻿module Oware

type StartingPosition =
    | South
    | North

type Board = {
    houses: int*int*int*int*int*int*int*int*int*int*int*int //(A,B,C,D,E,F,a,b,c,d,e,f) [cf charOf function]
    scores: int*int //(South Score, North Score)
    currentTurn: StartingPosition //South or North
    }

let getSeeds n board:Board = 
    let (a,b,c,d,e,f,a',b',c',d',e',f') = board.houses
    failwith "Not finished yet"

let useHouse n board = failwith "Not implemented b"

let start position =    
    let h = (4,4,4,4,4,4,4,4,4,4,4,4)
    let s = (0,0) 
    {houses = h; scores = s; currentTurn = position}
    
let score board = failwith "Not implemented c"


let gameState board = 
   let (a,b,c,d,e,f,a',b',c',d',e',f') = board.houses
   let x,y = board.scores 
   match x > (y + (a + b + c + d + e + f + a' + b' + c' + d' + e' + f'))  with 
   |true -> "South wins"
   |false -> 
        match x > (y + (a + b + c + d + e + f + a' + b' + c' + d' + e' + f'))  with 
        |true -> "South wins"
        |false -> 
            match x = y && (a + b + c + d + e + f + a' + b' + c' + d' + e' + f') = 0  with 
            |true ->  "Game ended in a draw"
            |false ->  match board.currentTurn with
                       |South -> "South's turn"
                       |North -> "North's turn"
   
  

[<EntryPoint>]
let main _ =
    printfn "Hello from F#!"
    0 // return an integer exit code