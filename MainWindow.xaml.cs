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

namespace Kachalka_clicker
{
    /// <summary>
    /// Логика взаимодействия для MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        private int chet = 0;
        private int level = 0;

        private int countPris = 0;
        private int countGantel = 0;

        public MainWindow()
        {
            InitializeComponent();
            gantel1.Visibility = Visibility.Hidden;
            gantel2.Visibility = Visibility.Hidden;
            BGantel.Visibility = Visibility.Hidden;
            pris2.Visibility = Visibility.Hidden;
            gim1.Visibility = Visibility.Hidden;
            gim2.Visibility = Visibility.Hidden;
            BGim.Visibility = Visibility.Hidden;
        }

        private void Level_Check()
        {
            if (chet == 10)
            {
                MessageBox.Show("Поздравляю, новый левел");
                level += 1;
            }
            else if (chet == 50)
            {
                MessageBox.Show("Поздравляю, новый левел\n теперь вам доступны гантели");
                gantel1.Visibility = Visibility.Visible;
                gantel2.Visibility = Visibility.Visible;
                BGantel.Visibility = Visibility.Visible;
                level += 1;
                //ааа
            }
            else if (chet == 100)
            {
                MessageBox.Show("Поздравляю, новый левел\n теперь вам доступен жим лежа");
                gim1.Visibility = Visibility.Visible;
                gim2.Visibility = Visibility.Visible;
                BGim.Visibility = Visibility.Visible;
                level += 1;
            }
            levelTB.Text = "УРОВЕНЬ " + level;
        }


        private void Gantel_Click(object sender, RoutedEventArgs e)
        {
            int schetchik = countGantel % 2;
            chet += 2;
            switch (schetchik)
            {
                case 0:
                    gantel2.Visibility = Visibility.Hidden;
                    gantel1.Visibility = Visibility.Visible;
                    break;
                case 1:
                    gantel2.Visibility = Visibility.Visible;
                    gantel1.Visibility = Visibility.Hidden;
                    break;

            }
            countGantel++;

            TBlevel.Text = chet.ToString();
            Level_Check();
        }


        private void BPris_Click(object sender, RoutedEventArgs e)
        {
            int schetchik = countPris % 2;
            chet += 1;
            switch (schetchik)
            {
                case 0:
                    pris2.Visibility = Visibility.Hidden;
                    pris1.Visibility = Visibility.Visible;
                    break;
                case 1:
                    pris2.Visibility = Visibility.Visible;
                    pris1.Visibility = Visibility.Hidden;
                    break;

            }
            countPris++;

            TBlevel.Text = chet.ToString();
            Level_Check();
        }

        private void BGim_Click(object sender, RoutedEventArgs e)
        {
            int schetchik = countPris % 2;
            chet += 3;
            switch (schetchik)
            {
                case 0:
                    gim2.Visibility = Visibility.Hidden;
                    gim1.Visibility = Visibility.Visible;
                    break;
                case 1:
                    gim2.Visibility = Visibility.Visible;
                    gim1.Visibility = Visibility.Hidden;
                    break;

            }
            countPris++;

            TBlevel.Text = chet.ToString();
            Level_Check();
        }
    }
}
