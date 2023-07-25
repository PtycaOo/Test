Console.WriteLine("Введите слова для заполнения массива через запятую:\n Например: Мама,Папа,Сын");

String[] GetMassiv(){
String? s = Console.ReadLine();
        String[] OriginMassiv = s.Split(',');
    return OriginMassiv;
}

int number_new_massive(String[] arr){
    int Count = 0;
for(int i = 0; i < arr.Length; i++){
    if(arr[i].Length <= 3){
        Count++;
    }  
}
return Count;
}

String[] Origin = GetMassiv();
