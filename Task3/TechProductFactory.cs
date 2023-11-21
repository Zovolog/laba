namespace Task3
{
    public abstract class TechProductFactory
    {
        public abstract Screen CreateScreen();
        public abstract Processor CreateProcessor();
        public abstract Camera CreateCamera();
    }

}