using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace DemoEx.ViewModels
{
   public abstract  class BaseViewModel : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler PropertyChanged;

        protected virtual void OnPropertyChanged([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        /// <summary>
        /// Установка значения свойства
        /// </summary>
        /// <typeparam name="T">Обобщенный тип устанавливаемого свойства</typeparam>
        /// <param name="field">Свойство для установки значение</param>
        /// <param name="value">Значение передаваемое в свойство</param>
        /// <param name="propertyName">Имя свойства</param>
        /// <returns>Результат установки нового значение свойства</returns>
        protected virtual bool Set<T>(ref T field, T value, [CallerMemberName] string propertyName = null)
        {
            if (Equals(field , value)) return false;
            field = value;
            OnPropertyChanged(propertyName);
            return true;
        }
    }
}
