namespace host;

internal interface IDataSync<TData> : IUtils
{
    internal Task<int> Insert<T>(in T Table);

    internal Task<int> Remove<T>(in T Table);

    internal Task<int> Update<T>(in T Table);

    internal Task<List<object>> GetWithPk<T>(in string? tableName,
                                             params string?[] primaryKeys);

    internal Task<List<object>> GetFieldWithPk<T>(in string? tableName, int collumn,
                                                  params string?[] primaryKeys);

    internal Task<List<List<object>>> GetTable<T>(in string? tableName);
}
