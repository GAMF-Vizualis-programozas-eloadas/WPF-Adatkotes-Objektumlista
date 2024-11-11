using System.ComponentModel;
using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace WPF_Adatkotes_Objektumlista
{
	/// <summary>
	/// Interaction logic for MainWindow.xaml
	/// </summary>
	public partial class MainWindow : Window
	{
		List<Hallgató> Hallgatók = new List<Hallgató>();
		public MainWindow()
		{
			InitializeComponent();
			// Lista létrehozása.
			Hallgatók.Add(new Hallgató("Szerény", "Vilmos", "XXXXXY", "szv@freemail.hu", 4.55));
			Hallgatók.Add(new Hallgató("Szerény", "Alexandra", "SZAXXX", "sza@freemail.hu", 4.65));
			Hallgatók.Add(new Hallgató("Szigorú", "Kép", "SZKXXY", "szk@freemail.hu", 4.55));
			Hallgatók.Add(new Hallgató("Okoska", "Eduárd", "OEXXXY", "oe@freemail.hu", 3.25));
			// Adatforrás megnevezése - a listaobjektum - a rács minden gyermekének ez lesz az 
			// alapértelmezett adatforrása.
			grRács.DataContext = Hallgatók;

		}

		private void btLe_Click(object sender, RoutedEventArgs e)
		{
			ICollectionView cv =
				CollectionViewSource.GetDefaultView(Hallgatók);
			// Ha van hova visszalépni.
			if (cv.CurrentPosition > 0)
				cv.MoveCurrentToPrevious();
			else
				// Ha nem (azaz az aktuális az első), akkor ugrás az utolsóra.
				cv.MoveCurrentToLast();
		}

		private void btFel_Click(object sender, RoutedEventArgs e)
		{
			ICollectionView cv = CollectionViewSource.GetDefaultView(Hallgatók);
			// Ha még van elem a listában akkor előre lépünk
			if (cv.CurrentPosition < Hallgatók.Count - 1)
				cv.MoveCurrentToNext();
			else
				// Ha nem (azaz az aktuális az utolsó), akkor ugrás az elsőre
				cv.MoveCurrentToFirst();
		}

		private void btLegkisebbÁtlag_Click(object sender, RoutedEventArgs e)
		{
			// Átlag alapján növekvő sorrendbe rendezi a listaelemeket
			Hallgatók.Sort((a, b) =>
				a.GöngyölítettÁtlag == b.GöngyölítettÁtlag ?
				0 :
				(a.GöngyölítettÁtlag > b.GöngyölítettÁtlag ? 1 : -1));
			ICollectionView cv = CollectionViewSource.GetDefaultView(Hallgatók);
			// Ugrás a lista első elemére
			cv.MoveCurrentToFirst();
		}

		private void btLegnagyobbÁtlag_Click(object sender, RoutedEventArgs e)
		{
			// Átlag alapján növekvő sorrendbe rendezi a listaelemeket
			Hallgatók.Sort((a, b) =>
				a.GöngyölítettÁtlag == b.GöngyölítettÁtlag ?
				0 :
				(a.GöngyölítettÁtlag > b.GöngyölítettÁtlag ? 1 : -1));
			ICollectionView cv = CollectionViewSource.GetDefaultView(Hallgatók);
			// Ugrás a lista utolsó elemére
			cv.MoveCurrentToLast();
		}
	}

}