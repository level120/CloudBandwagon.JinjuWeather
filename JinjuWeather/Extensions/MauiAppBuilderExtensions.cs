using System;
using System.Reflection;
using JinjuWeather.ViewModels;

namespace JinjuWeather.Extensions;

public static class MauiAppBuilderExtensions
{
    /// <summary>
    /// Register Pages.
    /// </summary>
    /// <param name="builder">App builder.</param>
    /// <returns>App builder.</returns>
    public static MauiAppBuilder ConfigurePages(this MauiAppBuilder builder)
    {
        var pageEnumerable = Assembly.GetExecutingAssembly()
                                     .GetTypes()
                                     .Where(type => type.IsAssignableInstanceTo<Page>())
                                     .ToArray();

        foreach (var page in pageEnumerable)
        {
            builder.Services.AddTransient(page);
        }

        return builder;
    }

    /// <summary>
    /// Register ViewModels.
    /// </summary>
    /// <param name="builder">App builder.</param>
    /// <returns>App builder.</returns>
    public static MauiAppBuilder ConfigureViewModels(this MauiAppBuilder builder)
    {
        var pageEnumerable = Assembly.GetExecutingAssembly()
                                     .GetTypes()
                                     .Where(type => type.IsAssignableInstanceTo<ViewModelBase>())
                                     .ToArray();

        foreach (var page in pageEnumerable)
        {
            builder.Services.AddTransient(page);
        }

        return builder;
    }

    private static bool IsAssignableInstanceTo<TAssign>(this Type type)
    {
        return type.IsAssignableTo(typeof(TAssign)) && !type.IsAbstract && !type.IsInterface;
    }
}

