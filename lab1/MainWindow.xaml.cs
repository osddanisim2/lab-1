﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
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

namespace lab1
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

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            //Оголошення зміних
            int floors, apartmentsperfloor, entrances;
            double price;
            //Зчитування даних з форми
            floors = Convert.ToInt32(this.textBox1.Text);
            apartmentsperfloor = Convert.ToInt32(this.textBox2.Text);
            price = Convert.ToDouble(this.textBox3.Text);
            entrances = Convert.ToInt32(this.textBox4.Text);

            Building building = new(entrances, floors, apartmentsperfloor, price: price);
            string calculations = $"Кількість квартир у під'їзді: {building.CalculateApartmentsInEntrance()}\n" +
                                  $"Загальна кількість квартир: {building.CalculateTotalApartments()}\n" +
                                  $"Загальна вартість будівлі: {building.CalculateTotalCost():C}\n";

            MessageBox.Show(calculations, "Розрахунки", MessageBoxButton.OK, MessageBoxImage.Information);
        }
    }
}
