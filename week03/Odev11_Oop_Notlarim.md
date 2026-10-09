1-> Sınıf aynı özelliğe sahip varlıklar için tekrar tekrar aynı kodu yazmamak için yazdığımız geliştirilebilir kodlar Nesne ise bu sınıftan türettiğimiz ve buradaki özelliklere sahip olan değişkendir.Örneğin Member sıfımız var diyelim Ayşe adında biri Member sınıfına ait olabilir

2->Parametreli constructor yazmak parametresiz olanı ezer.Default olarak kalmışsa yani el ile parametresiz bir constructor yazılammışsa hata almamak için parametreli constructor'a gerekli parametreler nesne ile tanımlandığı yerde verilmeli.

3->Book : LibraryItem Book sınıfının LibraryItem sınıfından miras alması ve burada olan özellikleri istediğinde kullanabilmesidir. Member : IIdentifiable ise bir sözleşme imzalamaktır ve kabiliyet gibi düşünülebilir. Bu yüzden implement edildiği interface'de ki özellikleri barındırmak zorundadır.

4->string[20] sabit uzunluklu bir dizidir ve eleman sayısını takip etmek için sayaç kullanılır. List<Member> ise dinamik olarak büyüyüp küçülebilen bir koleksiyondur.

5->List, elemanları sıralı şekilde listelemek ve üzerinde gezinmek için kullanılır. Dictionary, anahtar-değer mantığıyla çalışır. ID ile tek bir üyeyi bulmak için Dictionary<int, Member> kullanmak uygundur. Böylece ilgili üyeye ID üzerinden erişilebilir.

6->_members alanının private olması, bu alana sınıf dışından doğrudan erişilmesini engeller. Böylece üye ekleme, silme ve listeleme işlemleri servis metotları üzerinden kontrol edilir. 

7->BudgetService ve LibraryService, uygulamadaki verileri yönetmek için kullanılan servis sınıflarıdır. Her ikisi de verileri koleksiyonlarda tutabilir ve ekleme, listeleme veya arama gibi işlemleri gerçekleştirebilir.

8->void Display() bir işlem gerçekleştirir ve herhangi bir değer döndürmez. Örneğin bilgileri doğrudan ekrana yazdırabilir. string GetSummary() ise bir metin döndürür. Döndürülen metin bir değişkende saklanabilir, ekrana yazdırılabilir veya başka işlemlerde kullanılabilir.