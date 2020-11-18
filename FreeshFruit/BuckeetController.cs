namespace FreeshFruit
{
    internal class BuckeetController : BucketController
    {
        private object keranjangBuah;
        private MainWindow mainWindow;

        public BuckeetController(object keranjangBuah, MainWindow mainWindow)
        {
            this.keranjangBuah = keranjangBuah;
            this.mainWindow = mainWindow;
        }
    }
}