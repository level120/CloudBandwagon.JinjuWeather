using System;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace JinjuWeather.ViewModels;

/// <summary>
/// Base ViewModel.
/// </summary>
public abstract class ViewModelBase : INotifyPropertyChanged
{
    /// <inheritdoc />
    public event PropertyChangedEventHandler PropertyChanged;

    /// <summary>
    /// Raise property changed event.
    /// </summary>
    /// <param name="propertyName">property name.</param>
    protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
    {
        PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
    }

    /// <summary>
    /// Set field and notify property changed.
    /// </summary>
    /// <typeparam name="T">Item type.</typeparam>
    /// <param name="field">field.</param>
    /// <param name="value">value.</param>
    /// <param name="propertyName">property name.</param>
    /// <returns>Is set succeed.</returns>
    protected bool SetProperty<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
    {
        if (EqualityComparer<T>.Default.Equals(field, value))
        {
            return false;
        }

        field = value;

        OnPropertyChanged(propertyName);

        return true;
    }
}