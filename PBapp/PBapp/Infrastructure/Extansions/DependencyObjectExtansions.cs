using System.Windows.Media;
using System.Windows;

namespace System.Windows
{
    static class DependencyObjectExtansions
    {
        public static DependencyObject FindVisualRoot(this DependencyObject obj)
        {
            do
            {
                var parent = VisualTreeHelper.GetParent(obj);
                if (parent is null) return obj;
                obj = parent;
            }
            while (true);
        }

        public static DependencyObject FindLogicalRoot(this DependencyObject obj)
        {
            do
            {
                var parent = LogicalTreeHelper.GetParent(obj);
                if (parent is null) return obj;
                obj = parent;
            }
            while (true);
        }

        public static T FindVisualParant<T>(this DependencyObject obj) where T : DependencyObject
        {
            if (obj is null) return null;

            var target = obj;
            do
            {
                target = VisualTreeHelper.GetParent(target);
            }
            while (target != null && !(target is T));

            return target as T;
        }

        public static T FindLogicalParant<T>(this DependencyObject obj) where T : DependencyObject
        {
            if (obj is null) return null;

            var target = obj;
            do
            {
                target = LogicalTreeHelper.GetParent(target);
            }
            while (target != null && !(target is T));

            return target as T;
        }
    }
}
