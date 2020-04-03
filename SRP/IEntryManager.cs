namespace SRP
{
    public interface IEntryManager<T>
    {
        void AddEntry(T entry);

        void RemoveEntryAt(int index);
    }
}