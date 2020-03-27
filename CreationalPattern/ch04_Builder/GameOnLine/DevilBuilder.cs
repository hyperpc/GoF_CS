namespace ch04_Builder.GameOnLine
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
    }
}