using System.Collections.Generic;
namespace ch17_Iterator.Sales
{
    public class ProductIterator:AbstractorIterator
    {
        private ProductList productList;
        private List<object> products;
        private int cursor1;
        private int cursor2;
        public ProductIterator(ProductList list){
            productList = list;
            products=list.GetObjects();
            cursor1=0;
            cursor2=products.Count-1;
        }
        public void Next(){
            if(cursor1<products.Count){
                cursor1++;
            }
        }
        public bool IsLast(){
            return cursor1==products.Count;
        }
        public void Previous(){
            if(cursor2>-1){
                cursor2--;
            }            
        }
        public bool IsFirst(){
            return cursor2==-1;
        }
        public object GetNextItem(){
            return products[cursor1];
        }
        public object GetPreviousItem(){
            return products[cursor2];
        }
    }
}