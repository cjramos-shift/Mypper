namespace Mapper;

public class Mapping
{
    public void Map<T>(object source)
    {
        var typeReturn = typeof(T);
        var returnObj = Activator.CreateInstance(typeReturn);
        
        var type = source.GetType();
        var propertiesSource = type.GetProperties();
        
        foreach (var prop in propertiesSource)
        {
            var teste = typeReturn.GetProperty(prop.Name).GetValue(source);
            prop.SetValue(returnObj, "", null);
        }
        
        // return returnObj;
    } 
}