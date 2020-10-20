using System;
using System.Windows;
using System.Windows.Controls;

namespace Ejercicio_7
{
    /// <summary>
    /// Lógica de interacción para MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }
        private void RadioButton_Click(object sender, RoutedEventArgs e)
        {
            RadioButton boton = (RadioButton)sender;
            DINTTextBlock.FontSize = Convert.ToDouble(boton.Tag);
            
        }
    }
}
