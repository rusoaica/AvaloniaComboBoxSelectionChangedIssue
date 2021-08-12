using System.Collections.Generic;
using System.ComponentModel;
using System.Runtime.CompilerServices;

namespace ComboboxSelectionChangedIssue
{
    public class StartupVM : INotifyPropertyChanged
    {
        public event PropertyChangedEventHandler? PropertyChanged;
        public Command SelectedItemChanged_Command { get; set; }

        private HashSet<SomeEntity> someItemSource = new HashSet<SomeEntity>();
        public HashSet<SomeEntity> SomeItemSource
        {
            get { return someItemSource; }
            set { someItemSource = value; Notify(); }
        }

        private SomeEntity selectedEntity;
        public SomeEntity SelectedEntity
        {
            get { return selectedEntity; }
            set { selectedEntity = value; Notify(); }
        }

        public void Notify([CallerMemberName] string propertyName = null)
        {
            PropertyChanged?.Invoke(this, new PropertyChangedEventArgs(propertyName));
        }

        public StartupVM()
        {
            SomeItemSource = new HashSet<SomeEntity>() 
            {
                new SomeEntity() { Text = "a", Value = "1" },
                new SomeEntity() { Text = "b", Value = "2" },
                new SomeEntity() { Text = "c", Value = "3" },
            };
            SelectedItemChanged_Command = new Command(SelectedItemChanged);
        }

        private void SelectedItemChanged()
        {

        }
    }
}
