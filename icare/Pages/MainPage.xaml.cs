using icare.DTOs;
using System.Collections.ObjectModel;

namespace icare;

public partial class MainPage : ContentPage
{
    public ObservableCollection<RentTableDto> DataList { get; set; }

    public MainPage()
    {
        InitializeComponent();
        DataList = new ObservableCollection<RentTableDto>
            {
                new() { Number = "1", Date = "01/09/2024", InvoiceNumber = "QA123", Customer = "Müştəri 1", Address = "Bakı", Executor = "İcraçı 1", Amount = "100₼", Payment = "Ödənildi", Note = "Qeyd yoxdur" },
                new() { Number = "2", Date = "02/09/2024", InvoiceNumber = "QA124", Customer = "Müştəri 2", Address = "Sumqayıt", Executor = "İcraçı 2", Amount = "200₼", Payment = "Gözləyir", Note = "Ödəniş gözləyir" }
            };
        BindingContext = this;
    }

}