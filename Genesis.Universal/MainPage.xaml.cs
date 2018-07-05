using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using Windows.Foundation;
using Windows.Foundation.Collections;
using Windows.UI.Xaml;
using Windows.UI.Xaml.Controls;
using Windows.UI.Xaml.Controls.Primitives;
using Windows.UI.Xaml.Data;
using Windows.UI.Xaml.Input;
using Windows.UI.Xaml.Media;
using Windows.UI.Xaml.Navigation;
using Genesis.Commons;
using System.Collections.ObjectModel;

// The Blank Page item template is documented at https://go.microsoft.com/fwlink/?LinkId=402352&clcid=0x409

namespace Genesis.Universal
{
    /// <summary>
    /// An empty page that can be used on its own or navigated to within a Frame.
    /// </summary>
    public sealed partial class MainPage : Page
    {
        public NoteViewModelPopulation ViewModel { get; set; }

        public MainPage()
        {
            this.InitializeComponent();
            this.ViewModel = new NoteViewModelPopulation();
            //ListView listView = Populate();
            //ListDisplay.Children.Add(listView);
        }
        ListView Populate()
        {
            ListView listView = new ListView();
            ObservableCollection<string> listItems = new ObservableCollection<string>();
            Note tmp = new Note("Franek", "Jestem Super");
            listItems.Add(tmp.Title);

            listView.ItemsSource = listItems;
            return listView;
        }
    }
}
