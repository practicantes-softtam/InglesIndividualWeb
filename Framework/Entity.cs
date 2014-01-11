using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace Framework
{
    public class Entity //: INotifyPropertyChanged
    {
        //private ModifiedState _state = ModifiedState.None;
        private bool _fromDataSource;

        public bool FromDataSource
        {
            get { return this._fromDataSource; }
        }
        /*
        public ModifiedState State
        {
            get { return this._state; }
        }
        #region Miembros de INotifyPropertyChanged

        public event PropertyChangedEventHandler PropertyChanged;

        #endregion

        protected void NotifyPropertyChanged(string info)
        {
            if (PropertyChanged != null)
            {
                this._state = ModifiedState.Modified;
                PropertyChanged(this, new PropertyChangedEventArgs(info));
            }
        }
        */
        public Entity() : this(false)
        {
        }

        public Entity(bool fromDataSource)
        {
            this._fromDataSource = fromDataSource;
        }

        public void SetFromDataSource(bool fromDataSource)
        {
            this._fromDataSource = fromDataSource;
        }
    }
}
