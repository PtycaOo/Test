Console.WriteLine("Введите слова для заполнения массива через запятую:\n Например: Мама,Папа,Сын");







String[] GetMassiv(){
String? s = Console.ReadLine();
        String[] OriginMassiv = s.Split(',');
    return OriginMassiv;
}

String[] Origin = GetMassiv();