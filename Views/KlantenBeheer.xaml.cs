﻿using System;
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
using System.Data.Entity;
using System.ComponentModel;
using System.Collections.Specialized;
using System.Windows.Controls.Primitives;

namespace ISIS.Views
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class KlantenBeheer : System.Windows.Controls.UserControl
    {
        //ISIS_DataEntities _entities;
        //CollectionViewSource _klantenViewSource;
        //Klant _addClient;
        //bool _unsavedChanges;
        //int _oldLengthSearchBox = 0;
        //int _numberofErrors = 0;

        public KlantenBeheer()
        {
            InitializeComponent();
        }

        private void UserControl_Loaded(object sender, RoutedEventArgs e)
        {
        //    _klantenViewSource = ((System.Windows.Data.CollectionViewSource)(this.FindResource("klantenViewSource")));
        //    Refresh();
        //    SwitchToEditMode();
        }

        //private void Refresh()
        //{
        //    _unsavedChanges = false;

        //    if (_entities != null)
        //        _entities.Dispose();

        //    _entities = new ISIS_DataEntities();
        //    _entities.Klanten.Local.CollectionChanged += Local_CollectionChanged;
        //    _entities.Klanten.Load();
        //    _entities.Winkels.Local.CollectionChanged += SoortKlant_CollectionChanged;
        //    _entities.Winkels.Load();
        //    _klantenViewSource.Source = _entities.Klanten.Local;
        //    TextBoxSearch.ItemsSource = _entities.Klanten.Local;
        //    ButtonAdd.Content = "Toevoegen";
        //    GridInformation.DataContext = _klantenViewSource;
        //}

        //private void SoortKlant_CollectionChanged(object sender, NotifyCollectionChangedEventArgs e)
        //{
        //    AddItemmSourceComboBoxSoortKlant();
        //}

        //void Local_CollectionChanged(object sender, System.Collections.Specialized.NotifyCollectionChangedEventArgs e)
        //{
        //    if (e.Action == NotifyCollectionChangedAction.Remove)
        //    {
        //        foreach (Klant item in e.OldItems)
        //        {
        //            //Removed items => Delete event
        //            item.PropertyChanged -= EntityViewModelPropertyChanged;
        //        }
        //    }
        //    else if (e.Action == NotifyCollectionChangedAction.Add)
        //    {
        //        foreach (Klant item in e.NewItems)
        //        {
        //            //Added items => Add event
        //            item.PropertyChanged += EntityViewModelPropertyChanged;
        //        }
        //    }
        //}

        //public void EntityViewModelPropertyChanged(object sender, PropertyChangedEventArgs e)
        //{
        //    //This will get called when the property of an object inside the collection changes
        //    if (e.PropertyName != "CanValidateID")     //There isn't actual data changed in that property
        //        _unsavedChanges = true;
        //}

        //public bool CheckChanges()
        //{
        //    if (ButtonAdd.Content.ToString() == "Annuleren")
        //    {
        //        MessageBoxResult result = MessageBox.Show("U bent nog een nieuwe klant aan het aanmaken! Deze is nog niet opgeslagen!\nWilt u zeker verder gaan?", "Klantenbeheer", MessageBoxButton.YesNo);
        //        if (result == MessageBoxResult.No)
        //        {
        //            return true;
        //        }
        //    }

        //    if (_unsavedChanges == true)
        //    {
        //        MessageBoxResult result = MessageBox.Show("Er zijn nog onopgeslagen wijzigingen.\nWilt u deze wijzingen nog opslaan?", "KlantenBeheer", MessageBoxButton.YesNoCancel);
        //        if (result == MessageBoxResult.Yes)
        //        {
        //            Save();
        //        }
        //        else if (result == MessageBoxResult.No)
        //        {
        //            Refresh();
        //        }
        //        else
        //        {
        //            return true;
        //        }
        //    }

        //    return false;
        //}

        //private void Save()
        //{
        //    try
        //    {
        //        _entities.SaveChanges();
        //        _unsavedChanges = false;
        //    }
        //    catch (Exception e)
        //    {
        //        var error = _entities.GetValidationErrors();
        //        if (error != null)
        //            MessageBox.Show("Opslagen is niet gelukt!\n\nWegens volgende reden:\n" + error.FirstOrDefault().ValidationErrors.FirstOrDefault().ErrorMessage);
        //        else
        //            MessageBox.Show(e.ToString());
        //    }

        //}

        private void ButtonCancel_Click(object sender, RoutedEventArgs e)
        {
        //    CheckChanges();
        }

        //private void SwitchToAddMode()
        //{
        //    TextBoxID.IsReadOnly = false;
        //    (GridInformation.DataContext as Klant).CanValidateID = true;
        //    ButtonAdd.Content = "Annuleren";
        //}

        //private void SwitchToEditMode()
        //{
        //    GridInformation.DataContext = _klantenViewSource;
        //    TextBoxID.IsReadOnly = true;
        //    //Get Klant that is currently bind to GridInformation (this equals to the currentitem of the klantenViewSource)
        //    //Because the ID textbox is now readonly disable data validation!
        //    (_klantenViewSource.View.CurrentItem as Klant).CanValidateID = false;
        //    ButtonAdd.Content = "Toevoegen";
        //}

        private void ComboBoxSoortKlant_Loaded(object sender, RoutedEventArgs e)
        {
        //    List<string> data = new List<string>();
        //    data.Add("Winkel");
        //    data.Add("Ophaling");
        //    data.Add("Bedrijven");
        //    data.Add("Scholen");
        //    ComboBoxSoortKlant.ItemsSource = data;

        }

        private void ComboBoxSoortKlant_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        //    AddItemmSourceComboBoxSoortKlant();
        }

        //private void AddItemmSourceComboBoxSoortKlant()
        //{
        //    if (ComboBoxSoortKlant.SelectedIndex != -1)
        //    {
        //        if (ComboBoxSoortKlant.SelectedValue.ToString() == "Winkel")
        //            ComboBoxSoortKlantPlaats.ItemsSource = _entities.Winkels.Local;
        //        //else if (ComboBoxSoortKlant.SelectedValue.ToString() == "Ophaling")
        //        //    ComboBoxSoortKlantPlaats.ItemsSource = SoortKlant.Ophalingen;
        //        //else if (ComboBoxSoortKlant.SelectedValue.ToString() == "Bedrijven")
        //        //    ComboBoxSoortKlantPlaats.ItemsSource = SoortKlant.Bedrijven;
        //        //else if (ComboBoxSoortKlant.SelectedValue.ToString() == "Scholen")
        //        //    ComboBoxSoortKlantPlaats.ItemsSource = SoortKlant.Scholen;

        //        ComboBoxSoortKlantPlaats.IsEnabled = true;
        //    }
        //    else
        //        ComboBoxSoortKlantPlaats.IsEnabled = false;
        //}

        private void ComboBoxBetalingswijze_Loaded(object sender, RoutedEventArgs e)
        {
        //    List<string> data = new List<string>();
        //    data.Add("Papier");
        //    data.Add("Elektronisch");
        //    ComboBoxBetalingswijze.ItemsSource = data;
        }

        private void ComboBoxBericht_Loaded(object sender, RoutedEventArgs e)
        {
        //    List<string> data = new List<string>();
        //    data.Add("Neen");
        //    data.Add("SMS");
        //    data.Add("E-mail");
        //    ComboBoxBericht.ItemsSource = data;
        }

        private void TextBoxSearch_TextChanged(object sender, TextChangedEventArgs e)
        {
        //    int tempID;
        //    var tempSearchList = new List<Klant>();

        //    //If text is getting longer search in items from the combobox self
        //    //If not search in the list with all the items (in this situation you're deleting chars)
        //    //Result: If you're adding chars, it will go faster because you need to search in a smaller list!
        //    if (_oldLengthSearchBox < TextBoxSearch.Text.Length)
        //    {
        //        tempSearchList = TextBoxSearch.Items.OfType<Klant>().ToList();
        //    }
        //    else
        //    {
        //        tempSearchList = _entities.Klanten.Local.ToList();
        //    }

        //    if (int.TryParse(TextBoxSearch.Text, out tempID))
        //    {
        //        List<Klant> tempList = tempSearchList.Where(k => k.ID.ToString().Contains(TextBoxSearch.Text)).ToList();
        //        TextBoxSearch.ItemsSource = tempList;
        //    }
        //    else
        //    {
        //        //If the text contains off digits don't search after it in Naam and Voornaam (after all you will not find anything!)
        //        if (!TextBoxSearch.Text.Any(char.IsDigit))
        //        {
        //            List<Klant> tempList = tempSearchList.Where(k => k.Naam.ToString().ToLower().Contains(TextBoxSearch.Text.ToLower()) || k.Voornaam != null && k.Voornaam.ToString().ToLower().Contains(TextBoxSearch.Text.ToLower())).ToList();
        //            TextBoxSearch.ItemsSource = tempList;
        //        }
        //    }

        //    _oldLengthSearchBox = TextBoxSearch.Text.Length;        //Save current textlength, in the future we can compare it to determine if the textlength became bigger or smaller!
        }

        private void TextBoxSearch_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
        //    if (TextBoxSearch.SelectedItem is Klant)
        //    {
        //        Klant temp = (Klant)TextBoxSearch.SelectedItem;
        //        _klantenViewSource.View.MoveCurrentTo(temp);
        //    }
        }

        private void GridInformation_Error(object sender, ValidationErrorEventArgs e)
        {
        //    if (e.Action.ToString() == "Added")
        //    {
        //        ButtonSave.IsEnabled = false;
        //        _numberofErrors++;
        //    }
        //    else
        //    {
        //        _numberofErrors--;
        //        if (_numberofErrors < 1)
        //            ButtonSave.IsEnabled = true;
        //    }
        }
    }

    public class SearchComboBox : ComboBox
    {

        protected override void OnKeyDown(KeyEventArgs e)
        {
            base.OnKeyDown(e);

            //Disables automatic selection when DropDownsOpen!
            if (this.IsEditable &&
                this.IsDropDownOpen == false &&
                this.StaysOpenOnEdit)
            {
                this.IsDropDownOpen = true;
            }
        }

    }
}
