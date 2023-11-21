namespace Task3
{
    public class SmartphoneFactory : TechProductFactory
    {
        public override Screen CreateScreen()
        {
            return new AMOLED();
        }

        public override Processor CreateProcessor()
        {
            return new Snapdragon();
        }

        public override Camera CreateCamera()
        {
            return new DualLensCamera();
        }
    }

}