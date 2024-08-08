using Intellenum;

namespace IntellenumMemberAttribute;

public class IntellenumGeneratedTests
{
    [Fact]
    public void FieldBasedGeneratedEnum()
    {
        // This works...
        var value = FieldBasedEnum.One.ToString();
        Assert.Equal(nameof(FieldBasedEnum.One), value);
    }

    [Fact]
    public void AttributeBasedGeneratedEnum()
    {
        // This will throw in 1.0.3!!!
        var value = AttributeBasedEnum.One.ToString();
        Assert.Equal(nameof(AttributeBasedEnum.One), value);
    }
}

[Intellenum<string>]
[Member("One")]
public partial class AttributeBasedEnum;

[Intellenum<string>]
public partial class FieldBasedEnum
{
    public static readonly FieldBasedEnum One = new();
}
