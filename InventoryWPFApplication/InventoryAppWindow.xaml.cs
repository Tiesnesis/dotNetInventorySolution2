﻿using InventoryWPFApplication.UserServiceReference;
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

namespace InventoryWPFApplication
{
    /// <summary>
    /// Interaction logic for InventoryAppWindow.xaml
    /// </summary>
    public partial class InventoryAppWindow : Window
    {
        private UserServiceClient proxy = null;

        public InventoryAppWindow()
        {
            InitializeComponent();
            proxy = new UserServiceClient();
            EnableDisableVisualControls(false);
        }

        private void EnableDisableVisualControls(bool mode)
        {
            btnLogIn.IsEnabled = !mode;
            btnLogOut.IsEnabled = mode;
            btnSearch.IsEnabled = mode;
            textBoxSearchByDescr.IsEnabled = mode;
            btnReserve.IsEnabled = mode;
            txtBoxResCount.IsEnabled = mode;
            txtBoxIdRes.IsEnabled = mode;
            btnCreateAdd.IsEnabled = mode;
            txtBoxCount.IsEnabled = mode;
            txtBoxPrice.IsEnabled = mode;
            txtBoxDescr.IsEnabled = mode;
            txtBoxIDCreate.IsEnabled = mode;
            btnGetAllParts.IsEnabled = mode;
            btnGetTotal.IsEnabled = mode;
            btnGetBalance.IsEnabled = mode;
            btnGetReserved.IsEnabled = mode;
            listViewInventoryData.IsEnabled = mode;
        }

        private void btnGetAllParts_Click(object sender, RoutedEventArgs e)
        {
            List<Inventory> results = proxy.getAllParts();
            listViewInventoryData.ItemsSource = results;
        }

        private void btnGetTotal_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" " + proxy.calculateTotal(), "Total");
        }

        private void btnGetBalance_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" " + proxy.calculateBalance(), "Balance");
        }

        private void btnGetReserved_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show(" " + proxy.calculateReserved(), "Reserved");
        }

        private void btnSearch_Click(object sender, RoutedEventArgs e)
        {
            List<Inventory> results = proxy.searchPartByDescription(textBoxSearchByDescr.Text);
            listViewInventoryData.ItemsSource = results;
        }

        private void btnReserve_Click(object sender, RoutedEventArgs e)
        {
            int tmpInt;
            try
            {
                tmpInt = System.Convert.ToInt32(txtBoxResCount.Text);
            }
            catch (Exception)
            {
                tmpInt = 0;
            }

            proxy.reservePart(txtBoxIdRes.Text, tmpInt);

            List<Inventory> results = proxy.getAllParts();
            listViewInventoryData.ItemsSource = results;
        }

        private void btnCreateAdd_Click(object sender, RoutedEventArgs e)
        {
            int tmpInt;
            double tmpDbl;

            try
            {
                tmpDbl = System.Convert.ToDouble(txtBoxPrice.Text);
            }
            catch (Exception)
            {
                tmpDbl = 0;
            }
            try
            {
                tmpInt = System.Convert.ToInt32(txtBoxCount.Text);
            }
            catch (Exception)
            {
                tmpInt = 0;
            }

            proxy.addPart(txtBoxIDCreate.Text, txtBoxDescr.Text, tmpDbl, tmpInt);

            List<Inventory> results = proxy.getAllParts();
            listViewInventoryData.ItemsSource = results;
        }

        private void btnLogOut_Click(object sender, RoutedEventArgs e)
        {
            EnableDisableVisualControls(false);
        }

        private void btnLogIn_Click(object sender, RoutedEventArgs e)
        {
            bool tmpBool = proxy.logIn(txtBoxFN.Text, txtBoxLN.Text);
            if (tmpBool)
                EnableDisableVisualControls(true);
            else
            {
                EnableDisableVisualControls(false);
            }
        }

        private void listViewInventoryData_Copy_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btnAllUsers_Click(object sender, RoutedEventArgs e)
        {
            List<User> results = proxy.getAllUsers();
            listViewUserData.ItemsSource = results;
        }

        private void btnCreateAddUser_Click(object sender, RoutedEventArgs e)
        {
            proxy.addUser(txtCreateUserFirstName.Text, txtCreateUserLastName.Text);

            List<User> results = proxy.getAllUsers();
            listViewUserData.ItemsSource = results;
        }

        private void btnDeleteUser_Click(object sender, RoutedEventArgs e)
        {
            int tmpInt;
            {
                tmpInt = System.Convert.ToInt32(txtDeleteUserID.Text);
            }
            proxy.deleteUser(tmpInt);

            List<User> results = proxy.getAllUsers();
            listViewUserData.ItemsSource = results;
        }

        private void btnInvDelete_Click(object sender, RoutedEventArgs e)
        {
            proxy.deleteInventory(txtBoxInvDeleteID.Text);

            List<Inventory> results = proxy.getAllParts();
            listViewInventoryData.ItemsSource = results;
        }

        private void btnSearchUserByFirstName_Click(object sender, RoutedEventArgs e)
        {
            List<User> results = proxy.searchUserByFirstName(textSearchUserFirstName.Text);
            listViewUserData.ItemsSource = results;
        }

        private void btnSearchUserByFirstName(object sender, RoutedEventArgs e)
        {
            List<User> results = proxy.searchUserByLastName(textSearchUserLastName.Text);
            listViewUserData.ItemsSource = results;
        }

        private void btnCreateAddCart_Click(object sender, RoutedEventArgs e)
        {
            proxy.addCart(txtCreateCartUserID.Text, txtCreateCartInvID.Text, txtCreateCartCount.Text);

            List<CART_TABLE> results = proxy.getAllCarts();
            listViewCartData.ItemsSource = results;
        }

        private void btnGetAllCarts_Click(object sender, RoutedEventArgs e)
        {
            List<CART_TABLE> results = proxy.getAllCarts();
            listViewCartData.ItemsSource = results;
        }

        private void btnSearchCartUserID_Click(object sender, RoutedEventArgs e)
        {
            List<CART_TABLE> results = proxy.searchCartByUsrID(textBoxSearchCartUserID.Text);
            listViewCartData.ItemsSource = results;
        }

        private void btnSearchCartInvID_Click(object sender, RoutedEventArgs e)
        {
            List<CART_TABLE> results = proxy.searchCartByInvID(textBoxSearchCartInvID.Text);
            listViewCartData.ItemsSource = results;
        }

        private void btnDeleteCart_Click(object sender, RoutedEventArgs e)
        {

            int tmpInt;
            {
                tmpInt = System.Convert.ToInt32(txtDeleteCartID.Text);
            }

            proxy.deleteCart(tmpInt);

            List<CART_TABLE> results = proxy.getAllCarts();
            listViewCartData.ItemsSource = results;
        }

        private void btnBuy_Click(object sender, RoutedEventArgs e)
        {
            proxy.deleteCartByUserID(txtBuyUserID.Text);

            List<CART_TABLE> results = proxy.getAllCarts();
            listViewCartData.ItemsSource = results;
        }
    }
}
