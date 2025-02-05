let rec factorial n = 
    if n < 0 then 
        failwith "Factorial is not defined for negative numbers."
    elif n = 0 then 1
    else n * factorial (n - 1)

let result = factorial 5 //This will return 120
let result2 = factorial (-1) //This will throw an exception