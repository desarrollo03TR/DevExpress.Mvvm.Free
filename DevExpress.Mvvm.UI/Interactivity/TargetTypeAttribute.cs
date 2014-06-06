using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace DevExpress.Mvvm.UI.Interactivity {
    [AttributeUsage(AttributeTargets.Class, AllowMultiple = true, Inherited = true)]
    public sealed class TargetTypeAttribute : Attribute {
        public TargetTypeAttribute(Type targetType) {
            TargetType = targetType;
        }
        public Type TargetType { get; private set; }
    }
}