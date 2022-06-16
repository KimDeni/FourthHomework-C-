int summ(int num){

    int value = 0;
    int sum = 0;

    while(num > 0){
        value = num % 10;
        sum = sum + value;
        num =  num / 10;
    
    }

    return(sum);
}

int number = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(summ(number));

