using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Черновик.ViewModels
{
    public class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        public void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this,new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Функция установки значения свойства с уведомлением
        /// </summary>
        /// <typeparam name="T">тип устанавливаемого свойства</typeparam>
        /// <param name="field">поле</param>
        /// <param name="value">значение</param>
        /// <param name="propertyName">название свойства вызывающего метод объекта</param>
        /// <returns>возвращает результат операции установки свойства</returns>
        public bool Set<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field, value)) {
                return false;
            }
            else
            {
                field = value;
                OnPropertyChanged(propertyName);
                return true;
            }
        }

    }
}
