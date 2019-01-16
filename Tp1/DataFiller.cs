namespace Tp1
{
    public abstract class DataFiller
    {
        DataContext dataContext;
        internal abstract void fill(DataContext dataContext);
    }
}
