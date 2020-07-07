using System.Collections.Generic;
namespace ch17_Iterator.Sales
{
    public class ProductList : AbstractObjList
    {
        public ProductList(List<object> products) : base(products){            
        }
        public override AbstractorIterator CreateIterator(){
            return new ProductIterator(this);
        }
    }
}