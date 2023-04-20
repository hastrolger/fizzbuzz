void fizzbuzz () {
    for (var n = 1; n < 101; n++){
        if (n % 3 == 0 && n % 5 == 0) 
        {
            Console.WriteLine($"Number {n} is a FIZZBUZZ");
        }
        else if (n % 3 == 0) 
        {
            Console.WriteLine($"Number {n} is a FIZZ");
        }
        else if (n % 5 == 0) 
        {
            Console.WriteLine($"Number {n} is a BUZZ");
        } 
        else 
        {
            Console.WriteLine($"Number {n} is not FIZZ nor BUZZ");
        }
        
    }
}

fizzbuzz();
