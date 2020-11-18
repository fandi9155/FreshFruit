namespace FreeshFruit
{
    internal class Seller
    {
        private string v;
        private BucketController bucketController;

        public Seller(string v, BucketController bucketController)
        {
            this.v = v;
            this.bucketController = bucketController;
        }
    }
}