namespace ch04_Builder.GameOnLineAdv
{
    public class DevilBuilder : ABuilder
    {        
        public override void BuildType(){
            actor.Type = "Devil";
        }
        public override void BuildGender(){
            actor.Gender = "Demon";
        }
        public override void BuildFace(){
            actor.Face = "Ugly";
        }
        public override void BuildCostume(){
            actor.Costume = "Black clothes";
        }
        public override void BuildHairStyle(){
            actor.HairStyle = "Bald";
        }

        public override bool IsBareHeaded(){
            return true;
        }
    }
}