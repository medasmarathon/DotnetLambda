namespace RandomProductFunction
{
    public class RandomProductStore
    {
        private Dictionary<int, RandomProduct> productOfId = new();
        public RandomProduct? GetRandomProduct(int id)
        {
            if (!productOfId.ContainsKey(id))
            {
                return null;
            }
            return productOfId[id];
        }

        public RandomProduct UpsertRandomProduct(RandomProduct product)
        {
            if (productOfId.ContainsKey(product.Id))
            {
                productOfId[product.Id] = product;
            }
            else
            {
                productOfId.Add(product.Id, product);
            }
            return productOfId[product.Id];
        }
    }
}
