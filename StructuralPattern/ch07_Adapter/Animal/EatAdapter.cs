namespace ch07_Adapter.Animal
{
    public class EatAdapter: IEatFish,IEatBone
    {
        private IEatFish eatFishObj;
        private IEatBone eatBoneObj;

        public EatAdapter(IEatFish obj1,IEatBone obj2){
            this.eatFishObj=obj1;
            this.eatBoneObj=obj2;
        }

        // convert eat fish to eat bone
        public void EatFish(){
            this.eatBoneObj.EatBone();
        }

        // convert eat bone to eat fish
        public void EatBone(){
            this.eatFishObj.EatFish();
        }
    }
}