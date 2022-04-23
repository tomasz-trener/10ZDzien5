using System;
using System.Collections.Generic;
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

namespace P06AplikacjaTypuWPF
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void btnWczytaj_Click(object sender, RoutedEventArgs e)
        {
            Odswiez();
        }

        private void Odswiez()
        {
           
            ZawodnicyRepository zr = new ZawodnicyRepository();
            Zawodnik[] zawodnicy = zr.WczytajZawodnikow();
           
            lbDane.ItemsSource = zawodnicy;
            lbDane.DisplayMemberPath = "Wiersz"; // to musi być właściwość (a nie pole)
        }

        //MVVM - Model-View-View-Model 


        // To co zrobilismy w aplikacji windows forms  VM 

        // w podjesciu MV   VM 

        // otrzymujemy 2 modele:  Zawodnik (zawodnik bazdodanowy)
                                //ZawodnikVM (zawodnik widoku)


    }
}
