using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace labsheet1
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        ObservableCollection<Band> bandinfo;

        public MainWindow()
        {
            InitializeComponent();
        }

        private void Window_Loaded(object sender, RoutedEventArgs e)
        {

            ComboBox.ItemsSource = new string[] {"All" ,"Rap", "Pop", "Dance" };


            Band e1 = new Band.Rap()
            {
                Year = new DateTime(2019, 6, 30),
                BandName = "Travis scott",
                Members = "Travis scott"
               
                

            };
            var e2 = new Band.Rap()
            {
                Year = new DateTime(2019, 6, 30),
                BandName = "Post Malone",
                Members = "Post Malone"
             

            };
            var e3 = new Band.Dance()
            {
                Year = new DateTime(2019, 6, 30),
                BandName = "Meduza",
                Members = "Meduza"

            };
            var e4 = new Band.Dance()
            {
                Year = new DateTime(2019, 6, 30),
                BandName = "Blonde",
                Members = "Blonde"

            };
            var e5 = new Band.Rap()
            {
                Year = new DateTime(2019, 6, 30),
                BandName = "Roddy Ricch",
                Members = "Roddy Ricch"

            };
            var e6 = new Band.Rap()
            {
                Year = new DateTime(2019, 6, 30),
                BandName = "No vanity",
                Members = "No vanity"

            };

            bandinfo = new ObservableCollection<Band>();
            bandinfo.Add(e1);
            bandinfo.Add(e2);
            bandinfo.Add(e3);
            bandinfo.Add(e4);
            bandinfo.Add(e5);
            bandinfo.Add(e6);


            Album a1 = new Album()
            {   Name = "Highest in the room",
                ReleaseDate = new DateTime(2019, 6, 30),
                Sales = 10000
            };
            Album a2 = new Album()
            {   Name = "Sicko mode",
                ReleaseDate = new DateTime(2019, 6, 30),
                Sales = 13000
            };

            Album a3 = new Album()
            {   Name = "Goodbyes",
                ReleaseDate = new DateTime(2019, 6, 30),
                Sales = 18000
            };

            Album a4 = new Album()
            {   Name = "Sunflower",
                ReleaseDate = new DateTime(2019, 6, 30),
                Sales = 40000
            };
            Album a5 = new Album()
            {
                Name = "Piece of your heart",
                ReleaseDate = new DateTime(2019, 6, 30),
                Sales = 80000
            };
            Album a6 = new Album()
            {
                Name = "I loved you",
                ReleaseDate = new DateTime(2019, 6, 30),
                Sales = 19000
            };
            Album a7 = new Album()
            {
                Name = "The box",
                ReleaseDate = new DateTime(2019, 6, 30),
                Sales = 40000
            };
            Album a8 = new Album()
            {
                Name = "Kill me",
                ReleaseDate = new DateTime(2019, 6, 30),
                Sales = 30400
            };
            Album a9 = new Album()
            {
                Name = "Cold",
                ReleaseDate = new DateTime(2019, 6, 30),
                Sales = 10000
            };
            Album a10 = new Album()
            {
                Name = "Happening",
                ReleaseDate = new DateTime(2019, 6, 30),
                Sales = 70000
            };




            e1.Albums.Add(a1);
            e1.Albums.Add(a2);
            e2.Albums.Add(a3);
            e2.Albums.Add(a4);
            e3.Albums.Add(a5);
            e4.Albums.Add(a6);
            e5.Albums.Add(a7);
            e6.Albums.Add(a8);
            e6.Albums.Add(a9);
            e6.Albums.Add(a10);



            // Display list in listbox
            Left_textBox.ItemsSource = bandinfo;
        }

        // Singers - left list box
        private void Left_textBox_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            Band selectedActivity = Left_textBox.SelectedItem as Band;

            //make sure it's not null
            if (selectedActivity != null)
            {
                label_year.Content = selectedActivity.GetDetails1();
                label_members.Content = selectedActivity.GetDetails2();
                Right_TextBox.ItemsSource = selectedActivity.Albums;

            }
        }


      
       

        

    }
}
