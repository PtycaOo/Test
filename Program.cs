Console.WriteLine("Введите слова для заполнения массива через запятую:\nНапример: Мама,Папа,Сын");

String[] GetMassiv(){
String? s = Console.ReadLine();
    String[] OriginMassiv = s!.Split(',');
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

String[] New_massiv(int size,String[]Origin_massive ){
String[] arr = new String[size];
int j = 0;
for(int i = 0; i < Origin_massive.Length; i++){
    if(Origin_massive[i].Length <= 3){
        arr[j] = Origin_massive[i];
        j++;
    }
}
return arr;
}

String[] Origin = GetMassiv();
int size = number_new_massive(Origin);
String[] Finish_massive = New_massiv(size, Origin);
Console.WriteLine(string.Join(" | ",Finish_massive));
