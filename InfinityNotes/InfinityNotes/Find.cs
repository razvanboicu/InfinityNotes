using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.IO.Packaging;
using System.IO;
using System.Windows.Documents;

namespace InfinityNotes
{
    internal partial class Find
    {
        static public int GetIndexForSearchedText(TabItem source, string text)
        {
            TextBox tBoxResponse = source.Content as TextBox;
            return tBoxResponse.Text.IndexOf(text);
        }
        static public Tuple<TabItem, bool, string> SearchLastWindowSelected(TabItem source, string textForSearch)
        {
            TextBox tBoxResponse = source.Content as TextBox;
            if (tBoxResponse.Text.Contains(textForSearch))
            {
                int startIndex = GetIndexForSearchedText(source, textForSearch);
                ((TextBox)source.Content).Focus();
                ((TextBox)source.Content).SelectionStart = startIndex;
                ((TextBox)source.Content).SelectionLength = textForSearch.Length;

                Tuple<TabItem, bool, string> response = new Tuple<TabItem, bool, string>(source, true, textForSearch);
                return response;
            }
            else return new Tuple<TabItem, bool, string>(source, false, textForSearch);
        }

        static public Tuple<List<TabItem>, bool, string> SearchThroughOpenedTabs(List<TabItem> source, string textForSearch)
        {
            bool found = false;
            for (int i = 0; i < source.Count; i++)
            {
                TextBox tBoxResponse = source[i].Content as TextBox;
                if (tBoxResponse.Text.Contains(textForSearch))
                {
                    found = true;
                    int startIndex = GetIndexForSearchedText(source[i], textForSearch);
                    ((TextBox)source[i].Content).Focus();
                    ((TextBox)source[i].Content).SelectionStart = startIndex;
                    ((TextBox)source[i].Content).SelectionLength = textForSearch.Length;
                }
            }
            if (found)
                return new Tuple<List<TabItem>, bool, string>(source, true, textForSearch);
            else return new Tuple<List<TabItem>, bool, string>(source, false, textForSearch);
        }
    }
}
