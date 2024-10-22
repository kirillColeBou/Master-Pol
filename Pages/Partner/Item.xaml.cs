using Master_Pol.Classes.Context;
using Master_Pol.Classes.Model;
using Microsoft.Data.SqlClient;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
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

namespace Master_Pol.Pages.Partner
{
    /// <summary>
    /// Логика взаимодействия для Item.xaml
    /// </summary>
    public partial class Item : UserControl
    {
        Contexts Contexts = new Contexts();
        public Item(Partners _partners)
        {
            InitializeComponent();
            typeAndName.Content = Contexts.Type_Partner.ToList().Find(x => x.id == _partners.typePartner).name + " | " + _partners.nameCompany;
            discount.Content = GetDiscount(_partners.id) + "%";
            director.Content = _partners.fioDirector;
            telephone.Content = "+7 " + _partners.telephone.ToString().Insert(3, " ").Insert(7, " ").Insert(10, " ");
            rating.Content = "Рейтинг: " + _partners.rating;
        }

        public Int64 GetDiscount(Int64 id)
        {
            var discount = Contexts.GetChanges.FromSqlRaw("EXEC GetChanges @p0", id).ToList();
            double totalProducts = discount.Sum(x => x.countProduct);
            if (totalProducts < 10000) return 0;
            else if (totalProducts >= 10000 && totalProducts < 50000) return 5;
            else if (totalProducts >= 50000 && totalProducts < 300000) return 10;
            else return 15;
        }
    }
}
