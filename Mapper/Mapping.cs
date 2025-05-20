namespace Mapper;

public class Mapping
{
    public object Map<T>(object source)
    {
        var typeReturn = typeof(T);
        var returnObj = Activator.CreateInstance(typeReturn);

        var type = source.GetType();
        var propertiesSource = type.GetProperties();

        foreach (var prop in propertiesSource)
        {
            var value = prop.GetValue(source) ?? "Not found";
            var propInfo = typeReturn.GetProperty(prop.Name);
            propInfo.SetValue(returnObj, value, null);
        }

        return returnObj;
    }
}