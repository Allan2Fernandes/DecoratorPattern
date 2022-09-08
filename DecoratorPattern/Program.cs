using DecoratorPattern;

public class Program
{
    static void Main(string[] args)
    {
        
        BaseBread burgerPiece = new BurgerBun();
        burgerPiece = new Ketchup(burgerPiece);
        burgerPiece = new Meat(burgerPiece);
        burgerPiece = new BottomBread(burgerPiece);
        Console.WriteLine(burgerPiece.Description());
        Console.WriteLine(burgerPiece.Cost());
        

    }
}