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
    public partial class Prestatie : INotifyPropertyChanged
    {
    	public event PropertyChangedEventHandler PropertyChanged;
    	protected virtual void OnPropertyChanged(string propertyName)
    	{
    			PropertyChangedEventHandler handler = PropertyChanged;
    			if (handler != null) handler(this, new PropertyChangedEventArgs(propertyName));
    	}
    private int _id;
        public int Id { get { return _id; } set { _id = value; OnPropertyChanged("Id");} }
    private System.DateTime _datum;
        public System.DateTime Datum { get { return _datum; } set { _datum = value; OnPropertyChanged("Datum");} }
    private int _klantennummer;
        public int KlantenNummer { get { return _klantennummer; } set { _klantennummer = value; OnPropertyChanged("KlantenNummer");} }
    private byte _aantalhemden;
        public byte AantalHemden { get { return _aantalhemden; } set { _aantalhemden = value; OnPropertyChanged("AantalHemden");} }
    private byte _parameterhemden;
        public byte ParameterHemden { get { return _parameterhemden; } set { _parameterhemden = value; OnPropertyChanged("ParameterHemden");} }
    private byte _aantallakens1;
        public byte AantalLakens1 { get { return _aantallakens1; } set { _aantallakens1 = value; OnPropertyChanged("AantalLakens1");} }
    private byte _parameterlakens1;
        public byte ParameterLakens1 { get { return _parameterlakens1; } set { _parameterlakens1 = value; OnPropertyChanged("ParameterLakens1");} }
    private byte _aantallakens2;
        public byte AantalLakens2 { get { return _aantallakens2; } set { _aantallakens2 = value; OnPropertyChanged("AantalLakens2");} }
    private byte _parameterlakens2;
        public byte ParameterLakens2 { get { return _parameterlakens2; } set { _parameterlakens2 = value; OnPropertyChanged("ParameterLakens2");} }
    private byte _aantalanderestrijk;
        public byte AantalAndereStrijk { get { return _aantalanderestrijk; } set { _aantalanderestrijk = value; OnPropertyChanged("AantalAndereStrijk");} }
    private byte _tijdanderestrijk;
        public byte TijdAndereStrijk { get { return _tijdanderestrijk; } set { _tijdanderestrijk = value; OnPropertyChanged("TijdAndereStrijk");} }
    private byte _parameteranderestrijk;
        public byte ParameterAndereStrijk { get { return _parameteranderestrijk; } set { _parameteranderestrijk = value; OnPropertyChanged("ParameterAndereStrijk");} }
    private byte _tijdadministratie;
        public byte TijdAdministratie { get { return _tijdadministratie; } set { _tijdadministratie = value; OnPropertyChanged("TijdAdministratie");} }
    
        public virtual Klant Klanten { get; set; }
    }
}