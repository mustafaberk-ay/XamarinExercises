using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace DersProva
{
    public partial class MainPage : ContentPage
    {
        //Xamarin Forms 3 tane projeyle geliyor. Bunlardan bir tanesi portable(.NET Standard class library), digerleri de ios ve Android
        //Portable olanda yazdigimiz kodlar hem ios'u hem de android'i etkiler.
        //Spesifik ozellikler eklemek istersek, android veya ios tarafinda yapmamiz gerekir.
        //Son kullanicinin ekranda gorduklerine kontrol veya UI denir.
        //UI'lari C# ile olustabilecegimiz gibi xaml'ta da olusturabiliriz.
        //Xaml bir isaretleme dili, butun kodlari bir metin dosyasina cevirir. Bu metinler araciligiyla butun UI elementlerine kontrol edebiliriz.
        //Xaml bize hizli ve esnek bir calisma imkani sunar.
        //Simdilik, cok fazla detaya girmiyorum UI'larin hiyersasinden sonra bahsedecegim.
       
        public MainPage()
        {
            InitializeComponent();
            //StackLayout stackLayout = new StackLayout();
            //Label label = new Label();
            //Button button = new Button();
            //Entry entry = new Entry();
            //stackLayout.Children.Add(entry);
            //stackLayout.Children.Add(button);
            //stackLayout.Children.Add(label);
            //button.Clicked += Button_Clicked;
            //button.Text = "Karsila";
            //this.Content = stackLayout;

            //void Button_Clicked(object sender, EventArgs e)
            //{
            //    label.Text = "Merhaba " + entry.Text;
            //}
            //this.BindingContext = new Person();
        }

        //private void Button_Clicked(object sender, EventArgs e)
        //{
        //    lblName.Text = "Merhaba " + entryName.Text;
        //}

        //C# ile yazinca gordugunuz gibi uzun suruyor.
        //xaml kullanarak cok daha az kodla ayni isi yaptik. Daha az kod yazdigimiz icin de hata yapma olasaligimiz azaldi.
        //Xaml'da degisiklik yaptigimizda ctrl + s ile hot reload yaparak ekrana yaptigimiz degisiklikleri gosterebiliriz.
        //Xaml ile c# in arasindaki farkla ilgili sorular gelirse cevapla, baska tur sorular gelirse cavaplama
        //Xaml'in anatomisini anlatacagim.
        //UI birimlerini gelisiguzel yerlestiremeyiz. Bunlari UI container'larinin icinde kullanmamiz gerekir, UI container'lar pageler ve layoutlardir.

        //Mesela MainPage'imiz ContentPage'den inherit oluyor. ContentPage en basic page yapimizdir.
        //Namespace'ler bir websitesi url'i gibi gorunuyor ama path yapisi boyle oldugundandir. Bunlarin calismasi icin internete gerek yok.
        //using'lerin yaptigi isi xaml'da yapar.
        //x: prefix bu namespace'in icerisindeki  bir property'e ulasirken prefix'in adi ve iki nokta operatoru kullanilir (x:) Bu sekilde property'lere ulasmamizi saglar.
        //Eger bir prefix yoksa, dogrudan property'e ulasiriz.
        //Ilerleyen zamanlarda kendi namespace'imizi olusturmayi gosterecegim.
        //Ozellikle de MVVM mimarisinde cok kullanacagiz.
        //Normalde page'in icerisine en fazla bir tane kontrol yeslestirebiliriz. Ama bizim birden fazla kontrol yerlestirmemiz gerekecek, bunu yapmak icin de Layout kullanacagiz.
        //Simdilik StackLayout'tan bahsedecegim. StackLayout kontrolleri alt alta ya da yan yana dizer.

        //Az onceki ornegimizde alt alta dizdik, yan yana dizmek icin stackLayout orientation attribute'unu horizontal olarak degistirmemiz gerekir.
        //xaml.cs'te ContentPage'in Content property'sini tanimlamazsak calismaz ancak xaml tarafinda bu default olarak tanimlanmistir.
        //ContentPage'in bir ozelligi oldugu icin xaml.cs ve xaml taraflarinda bu sekilde gosterebiliriz.
        //BindingContext ile class'i contentPage'e baglariz. xaml.cs tarafinda this.Bindingcontext ile yapilir ama parametresiz bir constructor varsa xaml.cs'i tercih etmiyoruz.
        //Bunun sebebi kod okunurlugunu arttirmaktir.
        //Kod okunurlugu yazilim mimarisi ve test yapabilmek icin mumkun oldugunca xaml.cs'e kod getirmiyoruz.


    }
}
