class Program {
    public static void Main(string[] args) {
        double CX = double.Parse(Console.ReadLine());
        double CY = double.Parse(Console.ReadLine());
        double PX = double.Parse(Console.ReadLine());
        double PY = double.Parse(Console.ReadLine());
        double Round = double.Parse(Console.ReadLine());
        double FirstRadius = Math.Sqrt(Math.Pow(CX-PX,2)+Math.Pow(CY-PY,2));
        double FirstSeta = (180/Math.PI)*(Math.Atan((CY-PY)/(CX-PX)));

        while(Round > 0) {
            FirstSeta = FirstSeta + 90;
            PX = ((FirstRadius)*Math.Cos(FirstSeta/(180/Math.PI)))+CX;
            PY = ((FirstRadius)*Math.Sin(FirstSeta/(180/Math.PI)))+CY;
            FirstRadius = FirstRadius/2;
            CX = ((FirstRadius)*Math.Cos(FirstSeta/(180/Math.PI)))+CX;
            CY = ((FirstRadius)*Math.Sin(FirstSeta/(180/Math.PI)))+CY;
            Round--;
        }
        Console.WriteLine(CX);
        Console.WriteLine(CY);
        Console.WriteLine(PX);
        Console.WriteLine(PY);
    }
}