namespace Solid.Single_Responsibility
{
    public interface IEntryManager<T>
    {
        void AddEntry(T entry);
        void RemoveEntry(int index);
    }
}