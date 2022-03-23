using Microsoft.Win32;
using System;
using System.Collections.ObjectModel;
using System.IO;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Input;
using System.Windows.Media;
using System.Linq;
using System.Windows.Media.Imaging;
using Font = System.Windows.Media.FontFamily;

namespace InfinityNotes
{
    public partial class FindReplace : Window
    {
        static public bool findAllChecked = false;
        static private bool found = false;
        static private TabItem modifiedTabItem = null;
        static private ObservableCollection<TabItem> modifiedTabItems = null;
        static private bool foundAllTabs = false;

        static public bool replaceAllChecked = false;
        static private TabItem modifiedTabItemWithReplacedText = null;
        static private ObservableCollection<TabItem> modifiedTabItemsWithReplacedText = null;

        public FindReplace()
        {
            InitializeComponent();
        }
        static public ObservableCollection<TabItem> GetResponseReplaceThroughTabs()
        {
            return modifiedTabItemsWithReplacedText;
        }
        static public TabItem GetResponseReplaceSpecificTab()
        {
            return modifiedTabItemWithReplacedText;
        }
        private void PressedReplaceButton(object sender, RoutedEventArgs e)
        {
            if(textBoxOld.Text.ToString().Length > 0 && textBoxNew.Text.ToString().Length > 0)
            {
                ObservableCollection<TabItem> responseTabsOpened = MainWindow.GetOpenedTabs();
                if (!replaceAllCheckBox.IsChecked == true)
                {
                    modifiedTabItemWithReplacedText = Replace.ReplaceSpecificTab(responseTabsOpened[MainWindow.GetLastTabItemIndex()], textBoxOld.Text.ToString(), textBoxNew.Text.ToString()); ;
                }
                else
                {
                    replaceAllChecked = true;
                    var response = Replace.ReplaceThroughTabs(responseTabsOpened.ToList(), textBoxOld.Text.ToString(), textBoxNew.Text.ToString());
                    modifiedTabItemsWithReplacedText = new ObservableCollection<TabItem>(response);
                }
            }
        }
        static public ObservableCollection<TabItem> GetResponseFindThroughTabs()
        {
            if (foundAllTabs == true)
            {
                return modifiedTabItems;
            }
            return null;
        }
        static public TabItem GetResponseFindSpecificTab()
        {
            if (found == true)
            {
                return modifiedTabItem;
            }
            return null;
        }
        private void PressedFindButton(object sender, RoutedEventArgs e)
        {
            if (textBoxFind.Text.ToString().Length > 0)
            {
                ObservableCollection<TabItem> responseTabsOpened = MainWindow.GetOpenedTabs();
                if (!searchEverywhereCheckBox.IsChecked == true)
                {
                    var response = Find.SearchLastWindowSelected(responseTabsOpened[MainWindow.GetLastTabItemIndex()], textBoxFind.Text.ToString());
                    if (response.Item2 == true)
                    {
                        modifiedTabItem = response.Item1;
                        found = true;
                    }
                    else
                    {
                        found = false;
                    }
                }
                else
                {
                    findAllChecked = true;
                    var response = Find.SearchThroughOpenedTabs(responseTabsOpened.ToList(), textBoxFind.Text.ToString());
                    if (response.Item2 == true)
                    {
                        modifiedTabItems = new ObservableCollection<TabItem>(response.Item1);
                        foundAllTabs = true;
                    }
                    else
                    {
                        foundAllTabs = false;
                    }
                }
            }
        }
        private void ProcessOpenedTabs()
        {
            ObservableCollection<TabItem> response = MainWindow.GetOpenedTabs();
            for (int i = 0; i < response.Count; i++)
            {
                if (response.Count > 0)
                {
                    Console.WriteLine(i);
                }

            }
            if (MainWindow.GetLastTabItemIndex() != -1)
                Console.WriteLine("Last indexLastTab: " + MainWindow.GetLastTabItemIndex() + " \n");

        }
    }
}
