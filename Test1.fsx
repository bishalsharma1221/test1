(*
F# Assessment: Lists, Map, Filter, Reduce, Tail Recursion
Author: Bishal
*)

open System

// 1. Mapping, Filtering through Lists

let salaries = [75000.0; 48000.0; 120000.0; 190000.0; 300113.0; 92000.0; 36000.0]

// a. Filtering high-income salaries (Above $100,000)
let highIncomeSalaries = List.filter (fun salary -> salary > 100000.0) salaries
printfn "High-Income Salaries: %A" highIncomeSalaries

// b. Calculating Tax Using Map Function
let calculateTax salary =
    match salary with
    | _ when salary <= 49020.0 -> salary * 15.0 / 100.0
    | _ when salary <= 98040.0 -> salary * 20.5 / 100.0
    | _ when salary <= 151978.0 -> salary * 26.0 / 100.0
    | _ when salary <= 216511.0 -> salary * 29.0 / 100.0
    | _ -> salary * 33.0 / 100.0

let taxedSalaries = List.map (fun salary -> (salary, calculateTax salary)) salaries
printfn "Taxed Salaries: %A" taxedSalaries

// c. Adding $20,000 to salaries less than $49,020
let incrementedSalaries = salaries |> List.map (fun salary -> if salary < 49020.0 then salary + 20000.0 else salary)
printfn "Incremented Salaries: %A" incrementedSalaries

// d. Summing Salaries between $50,000 and $100,000 using Reduce
let salarySum =
    salaries
    |> List.filter (fun salary -> salary >= 50000.0 && salary <= 100000.0)
    |> List.reduce (+)

printfn "Sum of Salaries between $50,000 and $100,000: %f" salarySum


// 2. Tail Recursion - Sum of Multiples of 3
let rec sumOfMultiplesOf3 n acc =
    if n <= 0 then acc
    else sumOfMultiplesOf3 (n - 3) (acc + float n)

let result = sumOfMultiplesOf3 27 0.0
printfn "Sum of Multiples of 3 up to 27: %f" result
