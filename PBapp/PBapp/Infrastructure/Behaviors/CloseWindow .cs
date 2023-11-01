using System.Windows;
using System.Windows.Controls;
using Microsoft.Xaml.Behaviors;

namespace PBapp.Infrastructure.Behaviors
{
    internal class CloseWindow : Behavior<Button>
    {
        protected override void OnAttached() => AssociatedObject.Click += OnButtonClick;

        protected override void OnDetaching() => AssociatedObject.Click -= OnButtonClick;

        private void OnButtonClick(object sender, RoutedEventArgs e) => (AssociatedObject.FindVisualRoot() as Window)?.Close();
    }
}
