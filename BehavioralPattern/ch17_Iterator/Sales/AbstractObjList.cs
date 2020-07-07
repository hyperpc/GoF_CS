using System.Collections.Generic;
namespace ch17_Iterator.Sales
{
    public abstract class AbstractObjList
    {
        protected List<object> objects = new List<object>();
        public AbstractObjList(List<object> objs)
        {
            objects=objs;
        }
        public void AddObject(object o){
            objects.Add(o);
        }
        public void RemoveObject(object o){
            objects.Remove(o);
        }
        public List<object> GetObjects(){
            return objects;
        }
        public abstract AbstractorIterator CreateIterator();
    }
}