using System;
namespace Classes
{  //PROPERTYS
  class Customer   
	{
        // Field (Alan) tanımlamak. public string FirstName;
		public int Id { get; set; }  // Bir müşterinin özelliklerini tutmak için kullandığımız nesnedir. Genellikle veri tabanlarında ki kolonların karşılığı olarak biz burda bir class için tutabiliriz.
        // Mesela biz first namede bir değişiklik yapmak isteyelim. başına mr yazmak gibi kişi set edebilir fakat get ederken olay değişkenlik gösterir bu yüzden bloğu daha açık yazmamız gerekir.
        private string _firstName;
        public string FirstName
        {
            get { return "Mr." + _firstName; }
            set { _firstName = value; }
        }   //bazı programcılar bunu böyle tanımlamak yerine yukarıdaki gibi tanımlarlar ama biz eğer classın özelliklerini anlatacaksak field değilde property olarak tanımlamamız gerekir
        public string LastName { get; set; }
        public string City { get; set; }
    }
    // niye property olarak tanımlıyoruz get ve set ne işe yarıyor ? ENCAPSULATION adı altında konuşulacak.

}

