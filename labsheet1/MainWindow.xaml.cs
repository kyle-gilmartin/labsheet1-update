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

            ComboBox.ItemsSource = new string[] { "Rap", "Pop", "Dance" };


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
                Members = "Poat Malone"
             

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
                BandName = "Meduza",
                Members = "Meduza"

            };
            var e5 = new Band.Rap()
            {
                Year = new DateTime(2019, 6, 30),
                BandName = "XxxTentacion",
                Members = "XxxTentacion"

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
            { Name = "Random text1",
              ReleaseDate = new DateTime(2020, 9, 10),
              Sales = 10
            };
            Album a2 = new Album()
            {   Name = "Random text2",
                ReleaseDate = new DateTime(2010, 14, 16),
                Sales = 130
            };

            Album a3 = new Album()
            {   Name = "Random text4",
                ReleaseDate = new DateTime(2019, 7, 19),
                Sales = 180
            };

            Album a4 = new Album()
            {   Name = "Random text6",
                ReleaseDate = new DateTime(2016, 4, 13),
                Sales = 400
            };

            e1.Albums.Add(a1);
            e1.Albums.Add(a2);
            e2.Albums.Add(a3);
            e2.Albums.Add(a1);
            e3.Albums.Add(a1);
            e3.Albums.Add(a1);
            e4.Albums.Add(a2);
            e4.Albums.Add(a1);
            e5.Albums.Add(a4);
            e6.Albums.Add(a3);



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
