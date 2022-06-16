int[] fillArrey(int[] arrey){

    for(int i = 0; i < arrey.Length; i++){
        arrey[i] = Convert.ToInt32(Console.ReadLine());
    }

return arrey;
}

void showArrey(int[] arrey){
    for(int i = 0; i < arrey.Length; i++){
        Console.Write($"{arrey[i]} {" "}");
    }
}

int[] arr = new int [8];

fillArrey(arr);
showArrey(arr);