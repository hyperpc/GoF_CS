namespace ch08_Bridge.Plane
{
    public abstract class APlane
    {
        protected IPlaneBuilder builder;
        public void SetBuilder(IPlaneBuilder b){
            this.builder = b;
        }

        public abstract void Fly();
    }
}