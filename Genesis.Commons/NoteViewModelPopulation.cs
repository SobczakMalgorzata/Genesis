using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Genesis.Commons
{
    public class NoteViewModelPopulation
    {
        private ObservableCollection<Note> notes = new ObservableCollection<Note>();
        public ObservableCollection<Note> Notes { get { return this.notes; } }
        public NoteViewModelPopulation()
        {
            this.notes.Add(new Note("Ale Numer", "Jane Doe"));
            this.notes.Add(new Note("", "Jane Doe"));
            this.notes.Add(new Note("Kicia była słodka, a jej futerko było pokryte błotem. Wyamgała mycia, co jak to z kotami bywa, raczej łatwe nie będzie. \n Ale historia."));
        }
    }
}
