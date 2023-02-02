class Program {
    public static void Main(string[] args) {
        double inputX = double.Parse(Console.ReadLine());
        Console.WriteLine(Calculate(inputX));
    }
    public static double Calculate(double inputX) {
        if(Math.Pow(inputX,2) > 4){
            inputX = 1+ Calculate(inputX - (4*Math.Abs(inputX))/(inputX));
            return inputX;
        }
        else {
            inputX = 2;
            return inputX;
        }s
    }
}