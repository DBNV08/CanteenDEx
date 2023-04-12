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

namespace CanteenDEx.Pages
{
    /// <summary>
    /// Логика взаимодействия для ViewPage.xaml
    /// </summary>
    public partial class ViewPage : Page
    {
        CanteenDExEntities db;
        Products ProductsTable;
        public List<Products> ProductList;
        int CurrentPage = 1;
        int End = 14;
        int Start = 0;
        public ViewPage()
        {
            InitializeComponent();
            db = CanteenDExEntities.GetContext();
            ProductsTable = new Products();
            ProductList = db.Products.ToList();
            for (int i = 1; i < 15; i++)
                Lb.Items.Add(ProductList[i]);
            NumOfPage.Content = CurrentPage.ToString();


        }

        private void PrevPage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (CurrentPage == 1) return;
            CurrentPage--; Start -= 15; End = Start + 15;
            Lb.Items.Clear();
            for (int i = Start; i < End; i++)
                Lb.Items.Add(ProductList[i]);
            NumOfPage.Content = CurrentPage.ToString();
        }

        private void NextPage_MouseDown(object sender, MouseButtonEventArgs e)
        {
            if (Start + 15 > ProductList.Count) return;
            CurrentPage++; Start += 15; End = Start + 15;
            Lb.Items.Clear();
            if (ProductList.Count - 15 < End) End = ProductList.Count;
            for (int i = Start; i < End; i++)
                Lb.Items.Add(ProductList[i]);
            NumOfPage.Content = CurrentPage.ToString();
        }
    }
}
