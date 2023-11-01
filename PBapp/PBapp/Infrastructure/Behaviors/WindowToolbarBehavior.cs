using Microsoft.Xaml.Behaviors;
using System.Windows.Input;
using System.Windows;

namespace PBapp.Infrastructure.Behaviors
{
    internal class WindowToolbarBehavior : Behavior<UIElement>
    {
        private Window? _Window;

        protected override void OnAttached()
        {
            _Window = AssociatedObject as Window ?? AssociatedObject.FindVisualParant<Window>();
            AssociatedObject.MouseLeftButtonDown += OnMouseDown;
        }
        protected override void OnDetaching()
        {
            AssociatedObject.MouseLeftButtonDown -= OnMouseDown;
            _Window = null;
        }

        private void OnMouseDown(object sender, MouseButtonEventArgs e)
        {
            if (!(AssociatedObject.FindVisualRoot() is Window window)) return;

            switch (e.ClickCount)
            {
                case 1:
                    DragMove(window);
                    break;

                case 2:
                    MaximizeWindow(window);
                    break;
            }
        }

        private void DragMove(Window window)
        {
            window.DragMove();
        }

        private void MaximizeWindow(Window window)
        {
            window.WindowState = window.WindowState switch
            {
                WindowState.Normal => WindowState.Maximized,
                WindowState.Maximized => WindowState.Normal,
                _ => window.WindowState
            };
        }
    }
}
