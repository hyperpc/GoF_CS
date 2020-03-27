namespace ch04_Builder.GameOnLineAdv
{
    public class HeroBuilder : ABuilder
    {
        public override void BuildType(){
            actor.Type = "Hero";
        }
        public override void BuildGender(){
            actor.Gender = "Male";
        }
        public override void BuildFace(){
            actor.Face = "Handsome";
        }
        public override void BuildCostume(){
            actor.Costume = "Armor";
        }
        public override void BuildHairStyle(){
            actor.HairStyle = "Elegant";
        }
    }
}