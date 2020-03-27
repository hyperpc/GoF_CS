namespace ch08_Bridge.PlaneB
{
    public abstract class APlaneBuilder
    {
        protected IPlane plane;

        public void SetPlane(IPlane plane){
            this.plane = plane;
        }

        public abstract void Build();
        
    }
}