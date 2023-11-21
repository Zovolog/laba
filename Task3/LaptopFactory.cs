namespace Task3
{
    public class LaptopFactory : TechProductFactory
    {
        public override Screen CreateScreen()
        {
            return new LCD();
        }

        public override Processor CreateProcessor()
        {
            return new Exynos();
        }

        public override Camera CreateCamera()
        {
            return new SingleLensCamera();
        }
    }

}