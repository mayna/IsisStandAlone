//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated from a template.
//
//     Manual changes to this file may cause unexpected behavior in your application.
//     Manual changes to this file will be overwritten if the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace ISIS
{
    using System;
    using System.Collections.Generic;
    
    using System.ComponentModel;
    public partial class Ophaling : INotifyPropertyChanged
    {
    	public event PropertyChangedEventHandler PropertyChanged;
    	protected virtual void OnPropertyChanged(string propertyName)
    	{
    			PropertyChangedEventHandler handler = PropertyChanged;
    			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
    	}
    private string _naam;
        public string Naam { get { return _naam; } set { _naam = value; OnPropertyChanged("Naam");} }
    private decimal _snelheidscoëfficiënt;
        public decimal SnelheidsCoëfficiënt { get { return _snelheidscoëfficiënt; } set { _snelheidscoëfficiënt = value; OnPropertyChanged("SnelheidsCoëfficiënt");} }
    private decimal _euro;
        public decimal Euro { get { return _euro; } set { _euro = value; OnPropertyChanged("Euro");} }
    private bool _stuktarief;
        public bool StukTarief { get { return _stuktarief; } set { _stuktarief = value; OnPropertyChanged("StukTarief");} }
    }
}
