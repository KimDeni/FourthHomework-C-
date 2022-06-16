int degree(int num, int deg){

    int result = 1 ;
     for(int i = 1; i <= deg; i++){
        result = result * num;
     }

    return(result);
}

int number = Convert.ToInt32(Console.ReadLine());
int degr = Convert.ToInt32(Console.ReadLine());

Console.WriteLine(degree(number, degr));

