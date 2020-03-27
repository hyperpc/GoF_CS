namespace ch04_Builder.GameOnLine
{
    public abstract class ABuilder
    {
         protected Actor actor = new Actor();

         public abstract void BuildType();
         public abstract void BuildGender();
         public abstract void BuildFace();
         public abstract void BuildCostume();
         public abstract void BuildHairStyle();

         public Actor CreateActor(){
             return actor;
         }
    }
}