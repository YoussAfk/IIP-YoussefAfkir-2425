﻿using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WpfChat
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

        private void btn(object sender, RoutedEventArgs e)
        {

        }

        private void btnVerzenden_click(object sender, RoutedEventArgs e)
        {
            string voornaam = txtNaam.Text; 
            string bericht = tekstbox;
            string chat = chatVenster.Text;
            chat = $"voornaam says:{Environment.NewLine}"; 

        }

        private void text_block_naam__TextChanged(object sender, TextChangedEventArgs e)
        {

        }
    }
}