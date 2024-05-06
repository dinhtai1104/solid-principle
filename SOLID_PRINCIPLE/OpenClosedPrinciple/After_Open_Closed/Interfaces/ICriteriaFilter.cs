namespace OpenClosedPrinciple.After_Open_Closed.Interfaces
{
    public interface ICriteriaFilter<T>
    {
        bool IsMatchCriteria(T targetItem);
    }
}
