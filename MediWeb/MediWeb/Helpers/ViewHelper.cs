using Microsoft.AspNetCore.Mvc.Rendering;
using System.ComponentModel;
using System.Reflection;
using Common;

namespace Helpers;
public static class ViewHelper
{
    public static SelectList GetSelectListWithDescriptions<TEnum>() where TEnum : struct, Enum
    {
        var values = from TEnum e in Enum.GetValues(typeof(TEnum))
                     select new
                     {
                         Value = e,
                         Text = GetEnumDescription(e)
                     };

        return new SelectList(values, "Value", "Text");
    }

    private static string GetEnumDescription<TEnum>(TEnum value)
    {
        value.AssertIsNotNull();

        FieldInfo field = value.GetType().GetField(value.ToString());

        DescriptionAttribute attribute = field.GetCustomAttribute<DescriptionAttribute>();

        return attribute == null ? value.ToString() : attribute.Description;
    }
}
