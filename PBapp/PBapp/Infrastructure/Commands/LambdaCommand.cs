using PBapp.Core;
using System;

namespace PBapp.Infrastructure.Commands
{
    internal class LambdaCommand : RelayCommand
    {
        private Action<object>? _Execute;

        private Func<object, bool>? _CanExecute;

        public LambdaCommand(Action<object> Execute, Func<object, bool> CanExecute)
        {
            _Execute = Execute ?? throw new ArgumentNullException(nameof(Execute));
            _CanExecute = CanExecute;
        }

        public override bool CanExecute(object? parameter) => _CanExecute?.Invoke(parameter) ?? true;

        public override void Execute(object? parameter) => _Execute(parameter);
    }
}