using Odev9_Record.Models;

namespace Odev9_Record;

class Program
{
    public static void ApplyDiscount(MutableMember member, decimal amount)
    {
        member.Price += amount;
        Console.WriteLine(
            $"Üye: {member.Name} - {member.Price}"
        );
    }

    public static MemberDto ApplyDiscount(MemberDto member, decimal amount)
    {
        return member with
        {
            Price = member.Price + amount
        };
    }
    static void Main(string[] args)
    {
        MutableMember member = new()
        {
            Id = 1,
            Name = "Doğukan",
            Plan = "Premium",
            Price = 70m
        };
        MutableMember member1 = new()
        {
            Id = 1,
            Name = "Doğukan",
            Plan = "Premium",
            Price = 70m
        };
        Console.WriteLine(member);//sonuç-> Odev9_Record.Models.MutableMember

        Console.WriteLine(member == member1);//sonuç-> False

        Console.WriteLine(
            $"Üye: {member.Name} - {member.Price}"
        );
        ApplyDiscount(member, 150m);

        Console.WriteLine("=== Record ===");
        MemberDto memberDto1 = new MemberDto(2, "Kübra", "Premium", 150m);
        MemberDto memberDto2 = new MemberDto(2, "Kübra", "Premium", 150m);
        Console.WriteLine(memberDto1);//MemberDto { Id = 2, Name = Kübra, Plan = Premium, Price = 150 }
        Console.WriteLine(memberDto1 == memberDto2);

        MemberDto discountPriceDto = memberDto2 with { Price = memberDto2.Price + 150 };
        Console.WriteLine(memberDto2.Price);
        Console.WriteLine(discountPriceDto);


        MemberDto firstDiscount = ApplyDiscount(memberDto1, 100m);
        Console.WriteLine($"fiyat: {firstDiscount.Price} TL");


        MemberDto secondDiscount = ApplyDiscount(firstDiscount, 50m);
        Console.WriteLine($"İkinci fiyat: {secondDiscount.Price} TL");
        Console.WriteLine(memberDto1);

        /*Init-only property or indexer 'MemberDto.Price' can 
        only be assigned in an object initializer, 
        or on 'this' or 'base' in an instance constructor or 
        an 'init' accessor.*/

        // 1) Class varsayılan olarak referans eşitliği kullanır;
        //    record ise değer odaklı eşitlik sağlar.
        //
        // 2) Record, değer karşılaştırmasını kolaylaştırır.
        //    ToString() ile özellikleri yazdırır ve with ile
        //    orijinali değiştirmeden yeni bir kopya oluşturur.
        //
        // 3) Order bir entity olduğu için genellikle class seçerim.
        //    Çünkü siparişin kimliği ve yaşam döngüsü önemlidir.
        //    OrderDto için record seçebilirim; çünkü istemciye
        //    veri taşır ve değer odaklı eşitlik yararlıdır.


    }
}
