namespace Ming.CorrelationIdProvider
{
    public interface ICorrelationIdProvider
    {
        string CorrelationIdKey { get; }
        void AddCorrelationId();
        string GetCorrelationId();
    }

}
