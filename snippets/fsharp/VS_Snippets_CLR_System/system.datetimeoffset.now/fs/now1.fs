﻿// <Snippet1>
open System

let fmtStrings = 
    [ "d"; "D"; "f"; "F"; "g"; "G"; "M"
      "R"; "s"; "t"; "T"; "u"; "y" ]

let value = DateTimeOffset.Now
// Display date in default format.
printfn $"{value}\n"

// Display date using each of the specified formats.
for fmtString in fmtStrings do
    printfn $"{fmtString} --> {value.ToString fmtString}"

// The example displays output similar to the following:
//    11/19/2012 10:57:11 AM -08:00
//
//    d --> 11/19/2012
//    D --> Monday, November 19, 2012
//    f --> Monday, November 19, 2012 10:57 AM
//    F --> Monday, November 19, 2012 10:57:11 AM
//    g --> 11/19/2012 10:57 AM
//    G --> 11/19/2012 10:57:11 AM
//    M --> November 19
//    R --> Mon, 19 Nov 2012 18:57:11 GMT
//    s --> 2012-11-19T10:57:11
//    t --> 10:57 AM
//    T --> 10:57:11 AM
//    u --> 2012-11-19 18:57:11Z
//    y --> November, 2012
// </Snippet1>