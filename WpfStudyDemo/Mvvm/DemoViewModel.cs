using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WpfStudyDemo.Mvvm
{
    public class DemoViewModel : INotifyPropertyChanged
    {
        #region INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        /// <summary>
        /// 属性值变化时发生
        /// </summary>
        /// <param name="propertyName"></param>
        protected virtual void OnPropertyChanged(string propertyName)
        {
            if (this.PropertyChanged != null)
                this.PropertyChanged(this, new PropertyChangedEventArgs(propertyName));
        }

        #endregion

        private string currentTime;

        /// <summary>
        /// CurrentTime
        /// </summary>
        public string CurrentTime
        {
            get
            {
                return this.currentTime;
            }

            set
            {
                this.currentTime = value;
                this.OnPropertyChanged(nameof(this.CurrentTime));
            }
        }

    }
}
