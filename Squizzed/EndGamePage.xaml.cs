﻿using System;
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

namespace Squizzed
{
    /// <summary>
    /// Logika interakcji dla klasy EndGamePage.xaml
    /// </summary>
    public partial class EndGamePage : Page
    {
        public EndGamePage()
        {
            InitializeComponent();
            finalScore.Text = MainWindow.score.GetScore().ToString();
            MainWindow.score.ZeroPoints();
            MainWindow.gameNumber = 0;
        }

        public void endQuiz(object sender, RoutedEventArgs e)
        {

            this.NavigationService.Navigate(new Menu());
        }
    }
}
