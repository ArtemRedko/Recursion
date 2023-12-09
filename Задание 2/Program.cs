int Ackermann(int m, int n){
    if(m == 0) {
        return n + 1;
    }
    else{
        if(n == 0){
            return Ackermann(m - 1, 1);
        }    
        else{
            return Ackermann(m - 1, Ackermann(m, n - 1));
        }
    }   
}
Console.WriteLine("Введите число m: ");
int M = Convert.ToInt32(Console.ReadLine());
Console.WriteLine("Введите число n: ");
int N = Convert.ToInt32(Console.ReadLine());
if(M < 0 || N < 0){
    Console.WriteLine("Числа должны быть больше, либо равны 0!!");
}
int result = Ackermann(M, N);
Console.WriteLine($"A(m,n) = {result}");