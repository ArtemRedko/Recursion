void NewArray(int[] mass, int j){
    int[] array = new int[j + 1];
    if(j < 0) return;
    Console.Write($"{mass[j]} ");
    NewArray(mass, j - 1);
}
int[] Array(int a){
    int[] mass = new int[a];
    Random num = new Random();
    for(int i = 0; i < mass.Length; i++){
        mass[i] = num.Next(1, 100);
    }
    return mass;
}
void PrintArray(int[] mass){
    for(int i = 0; i < mass.Length; i++){
        Console.Write($"{mass[i]} ");
    }
}
int[] array = Array(11);
PrintArray(array);
Console.WriteLine();
NewArray(array, array.Length - 1);