class Program {
    public static void Main(string[] args) {
        double InputX = double.Parse(Console.ReadLine());
        InputX = InputX % 2;
        Console.WriteLine(Calculate(InputX));
    }
    public static double Calculate(double x) {
        if(x <= -1) {
            return Calculate(x+2);
        }
        else if(x > 1) {
            return Calculate(x-2);
        }
        else if(x > 0 && x <= 1) {
            return -Math.Sqrt(1-Math.Pow(x,2));
        }
        else if(x <= 0 && x >-1) {
            return Math.Sqrt(1-Math.Pow(x,2));
        }
        else { 
            return x;
        }
    }
}