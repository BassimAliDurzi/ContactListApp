using System.CodeDom.Compiler;

namespace Business.Helper;

public static class IdGenerator
{
    public static string Generate() => Guid.NewGuid().ToString();
 
}
