namespace ch04_Builder.GameOnLine
{
    public class ActorController
    {
        public Actor Construct(ABuilder builder){
            builder.BuildType();
            builder.BuildGender();
            builder.BuildFace();
            builder.BuildCostume();
            builder.BuildHairStyle();
            Actor actor = builder.CreateActor();

            return actor;
        }
    }
}