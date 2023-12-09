void Numbers(int m, int n){
    if(m > n) return;                          
    Console.Write(m + " ");
    Numbers(m + 1, n);
}
Console.WriteLine("Введите первое число: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите второе число: ");
int N = Convert.ToInt32(Console.ReadLine());
if(M >= N){
    Console.WriteLine("Первое чиcло должно быть больше второго!!");
}
else{
    Numbers(M, N);
}