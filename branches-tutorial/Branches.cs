ExploreIf();
ExploreWhile();
ExploreFor();

void ExploreIf(){
    int a = 5;
    int b = 3;
    int c = 4;
    if ((a + b +c > 10) || (a == b)){
        Console.WriteLine("The answer is greater than 10");
        Console.WriteLine("And the first number is equal to the second");    
    }
    else{
        Console.WriteLine("The answer is not greater than 10");
        Console.WriteLine("Or the first number is not equal to the second");
    }
}

void ExploreWhile(){
    Console.WriteLine("\n Explore while: \n");
    Console.WriteLine("\n Diference between while and do{}while \n");
    int counter = 0;
    while (counter < 0){
        Console.WriteLine($"Hello World! The counter is {counter}");
        counter++;
    }

    
    counter = 0;
    do{
        Console.WriteLine($"Hello World! The counter is {counter}");
        counter++;
    } while (counter < 0);
}

void ExploreFor(){

    Console.WriteLine("\n Explore for: \n");
    for (int index = 0; index < 10; index++){
        Console.WriteLine($"Hello World! The index is {index}");
    }

    Console.WriteLine("\n Nested loops: \n");

    for (int row = 1; row < 11; row++){
        for (char column = 'a'; column < 'k'; column++){
        Console.WriteLine($"The cell is ({row}, {column})");
    }
    }
    
}