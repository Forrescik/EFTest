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
using MyEntityFrameworkClass;

namespace Narzedziownia
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		private readonly NarzedziowniaEntities1 narzedziownia;
		public MainWindow()
		{
			InitializeComponent();
			narzedziownia = new NarzedziowniaEntities1();
		}

		private void Button_Click(object sender, RoutedEventArgs e)
		{
			var q = (from c in narzedziownia.Tools
					 select c).ToList();
		}
	}
}
