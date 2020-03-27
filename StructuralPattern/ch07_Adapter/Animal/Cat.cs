namespace ch07_Adapter.Animal
{
    public class Cat: IEatFish
    {
        public void EatFish(){
            System.Console.WriteLine("Eating Fish!");
        }
    }
}