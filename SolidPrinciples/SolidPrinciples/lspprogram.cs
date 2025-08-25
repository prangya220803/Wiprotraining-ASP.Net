//// WITHOUT LSP

//using System;
//public class Bird
//{
//    public virtual void Fly()
//    {
//        Console.WriteLine("Bird is flying.");
//    }
//}
//public class Sparrow : Bird
//{
//    public override void Fly()
//    {
//        Console.WriteLine("Sparrow is flying.");
//    }
//}
//public class Penguin : Bird
//{

//    public override void Fly()
//    {
//        throw new NotImplementedException("Penguin can't fly!");
//    }
//}
//public class BirdWatcher
//{
//    public void Observe(Bird bird)
//    {
//        bird.Fly();  
//    }
//}
//class Program
//{
//    static void Main()
//    {
//        BirdWatcher watcher = new BirdWatcher();
//        Bird sparrow = new Sparrow();
//        Bird penguin = new Penguin();

//        watcher.Observe(sparrow);  
//        watcher.Observe(penguin);  
//    }
//}

//---------------------------------------------------------------------------------------------------------------------

//WITH LSP

using System;
public abstract class Bird
{
    public abstract void Move();
}

public class Sparrow : Bird
{
    public override void Move()
    {
        Console.WriteLine("Sparrow is flying.");
    }
}
public class Penguin : Bird
{
    public override void Move()
    {
        Console.WriteLine("Penguin is swimming.");
    }
}
public class BirdWatcher
{
    public void Observe(Bird bird)
    {
        bird.Move(); 
    }
}
class Program
{
    static void Main()
    {
        BirdWatcher watcher = new BirdWatcher();
        Bird sparrow = new Sparrow();
        Bird penguin = new Penguin();

        watcher.Observe(sparrow);
        watcher.Observe(penguin);
    }
}