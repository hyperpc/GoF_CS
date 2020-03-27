namespace ch04_Builder.GameOnLineAdv
{
    public class ActorController
    {
        public Actor Construct(ABuilder builder){
            builder.BuildType();
            builder.BuildGender();
            builder.BuildFace();
            builder.BuildCostume();
            if(!builder.IsBareHeaded()){
                builder.BuildHairStyle();
            }
            Actor actor = builder.CreateActor();

            return actor;
        }
    }
}