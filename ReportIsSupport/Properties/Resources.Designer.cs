﻿namespace ReportIsSupport.Properties {
    
    
    /// <summary>
    ///   Строго типизированный класс ресурсов для поиска локализованных строк и т. п.
    /// </summary>
    // Этот класс был автоматически создан классом StronglyTypedResourceBuilder
    // с помощью программы ResGen или в среде Visual Studio.
    // Чтобы добавить или удалить элемент, измените файл .ResX, а затем вновь запустите программу ResGen
    // с параметром /str или перестройте проект в среде VS.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "4.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    internal class Resources {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Resources() {
        }
        
        /// <summary>
        ///   Возвращает из кэша экземпляр ResourceManager, используемый этим классом.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Resources.ResourceManager ResourceManager {
            get {
                if ((resourceMan == null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("ReportIsSupport.Properties.Resources", typeof(Resources).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Переопределяет свойство CurrentUICulture текущего потока для всех
        ///   операций поиска ресурсов, использующих этот строго типизированный класс ресурсов.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        internal static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
    }
}
