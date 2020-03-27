using System.Runtime.CompilerServices;
namespace ch04_Builder.GameOnLineAdv
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

        // 1. with parameter
        /*
         protected static Actor actor = new Actor();
         public static Actor Construct(ABuilder ab){
             ab.BuildType();
             ab.BuildGender();
             ab.BuildFace();
             ab.BuildCostume();
             ab.BuildHairStyle();
             return actor;
         }
         */

        // 2. without parameter
         public Actor Construct()
         {
             this.BuildType();
             this.BuildGender();
             this.BuildFace();
             this.BuildCostume();
             this.BuildHairStyle();
             return actor;
         }

         // hook method
         public virtual bool IsBareHeaded(){
             return false;
         }

    }
}