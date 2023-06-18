using Dapper;
using Dapper_relationship.Entity;
using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Data.SqlTypes;
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

namespace Dapper_relationship
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            var cs = "Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=Dapper_relationship;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=True;ApplicationIntent=ReadWrite;MultiSubnetFailover=False";
            #region One to One  

            //using (var conn = new SqlConnection(cs))
            //{

            //    var sql = @"SELECT * FROM Capitals
            //              INNER JOIN Countries
            //              ON Countries.Id= Capitals.CountrId";
            //    var result = conn.Query<Capital, Country, Capital>(sql,
            //        (capital, country) =>
            //        {
            //            capital.contry = country;
            //            return capital;
            //        });
            //    dataGrid.ItemsSource = result;
            //}
            #endregion

            #region One to Many

            //var categories = new List<Category>();
            //using (var conn = new SqlConnection(cs))
            //{
            //    var sql = @"SELECT C.[Id], C.[Name],P.[Id], P.[Name],P.CategoryId
            //       FROM Categories AS C INNER JOIN Products AS P
            //       ON C.Id=P.CategoryId";

            //    conn.Query<Category, Product, Category>(sql,
            //    (category, product) =>
            //    {
            //        if (!categories.Exists((c) => c.Id == category.Id))
            //        {
            //            category.Products.Add(product);
            //            categories.Add(category);  
                       
                    
            //        }
            //        else
            //        {
            //            categories
            //            .FirstOrDefault(c => c.Id == category.Id)!
            //            .Products.Add(product);
                        
            //        }
            //        return category;
            //    });
            //    dataGrid.ItemsSource = categories;

            //}


            //using(var conn= new SqlConnection(cs))
            //{
            //    var sql = @"SELECT C.[Id], C.[Name],P.[Id], P.[Name],P.CategoryId
            //           FROM Categories AS C INNER JOIN Products AS P
            //           ON C.Id=P.CategoryId";
            //    var result= conn.Query<Category, Product, Product>(sql,
            //        (category,product) =>
            //        {
            //            product.Category = category;
            //            return product;
            //        }
            //        );
            //    dataGrid.ItemsSource = result;


            //}
            #endregion

        }
    }
}
