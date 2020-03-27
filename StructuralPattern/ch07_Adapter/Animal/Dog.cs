namespace ch07_Adapter.Animal
{
    public class Dog: IEatBone
    {
        public void EatBone(){
            System.Console.WriteLine("Eating Bone!");
        }
    }
}