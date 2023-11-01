using Microsoft.Xaml.Behaviors;
using System;
using System.Windows.Controls;

namespace PBapp.Infrastructure.Behaviors
{
    internal class ScrollToLastAfterLoaded : Behavior<ListBox>
    {
        protected override void OnAttached() => AssociatedObject.Loaded += AssociatedObject_Loaded;


        protected override void OnDetaching() => AssociatedObject.Loaded -= AssociatedObject_Loaded;

        private void AssociatedObject_Loaded(object sender, System.Windows.RoutedEventArgs e)
        {
            if (!(sender is ListBox listBox)) throw new TypeAccessException($"{sender} is not ListBox.");

            listBox.SelectedItem = listBox.Items[listBox.Items.Count - 1];
            listBox.ScrollIntoView(listBox.SelectedItem);
        }
    }

    internal class ScrollToLastAfterUpdated : Behavior<ListBox>
    {
        protected override void OnAttached() => AssociatedObject.SourceUpdated += AssociatedObject_SourceUpdated;

        protected override void OnDetaching() => AssociatedObject.SourceUpdated -= AssociatedObject_SourceUpdated;

        private void AssociatedObject_SourceUpdated(object? sender, System.Windows.Data.DataTransferEventArgs e)
        {
            if (!(sender is ListBox listBox)) throw new TypeAccessException($"{sender} is not ListBox.");

            listBox.SelectedItem = listBox.Items[listBox.Items.Count - 1];
            listBox.ScrollIntoView(listBox.SelectedItem);
        }
    }
}
