namespace ch04_Builder.GameOnLineAdv
{
    public class AngelBuilder : ABuilder
    {
        public override void BuildType(){
            actor.Type = "Angel";
        }
        public override void BuildGender(){
            actor.Gender = "Female";
        }
        public override void BuildFace(){
            actor.Face = "Pretty";
        }
        public override void BuildCostume(){
            actor.Costume = "White skirt";
        }
        public override void BuildHairStyle(){
            actor.HairStyle = "Shawl long hair";
        }
    }
}