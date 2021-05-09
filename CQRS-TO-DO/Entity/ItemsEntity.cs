using System.Collections.Generic;

namespace CQRS_TO_DO.Entity
{
    public class ItemsEntity
    {
        List<Items> itensList = new List<Items>();

        public ItemsEntity()
        {
            itensList.Add(new Items("Arderson", 20));
            itensList.Add(new Items("Arderson", 20));
            itensList.Add(new Items("Arderson", 20));
        }

        public void Add(Items i) => itensList.Add(i);
        public List<Items> GetAll(){
            return itensList;
        }
    }
}